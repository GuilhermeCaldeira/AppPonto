using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.RdlExpressions;
using AppPonto_BLL;
using AppPonto_ENT;

namespace AppPonto
{
    public partial class frmRelatorio : Form
    {
        #region "Construtor"

        public frmRelatorio()
        {
            InitializeComponent();
        }

        #endregion

        #region "Eventos Form"

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            BindReport();
        }

        private void frmRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void frmRelatorio_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(0, 0);
        }

        #endregion

        #region "Métodos Gerais"

        public TimeSpan TotalDiferencaInicial(List<Ponto> ListPonto)
        {
            long ValorTotal = 0;

            foreach (Ponto Item in ListPonto.Where(p => (((Ponto)p).DiaSemana != DiaSemanda.DOMINGO && ((Ponto)p).Feriado == 'N' && ((Ponto)p).Ferias == 'N' && ((Ponto)p).Folga == 'N')))
            {
                if (Item.TotalHora != null)
                {
                    ValorTotal += TimeSpan.Parse((Item.HoraEntrada != null && Item.HoraEntrada != string.Empty && Item.HoraEntrada != "  ::00") ? (Item.HoraEntrada != "00:00:00" ? Util_BLL.FormatHoras(TimeSpan.Parse("08:00:00") - TimeSpan.Parse(Item.HoraEntrada)) : "00:00:00") : "00:00:00").Ticks;
                }
            }

            return (new TimeSpan(ValorTotal));
        }

        private void BindReport()
        {
            ColecaoRelatorioPonto Colecao = new ColecaoRelatorioPonto();
            ColecaoRelatorioLembrete Lembrete = new ColecaoRelatorioLembrete();

            TimeSpan TotalHorasTrabalhadas = (new Ponto_BLL()).HorasTrabalhadas(Util_BLL.ListPonto);

            string DifInicial = Util_BLL.FormatHoras(TotalDiferencaInicial(Util_BLL.ListPonto));

            foreach (Ponto Item in Util_BLL.ListPonto)
            {
                #region "Histórico de Ponto"

                Colecao.Add(new RelatorioPonto()
                {
                    Data = Item.Data,
                    DiaSemana = Util_BLL.strRetornaDiaSemana(Item.DiaSemana),
                    DiferencaInicial = (Item.HoraEntrada != null && Item.HoraEntrada != string.Empty && Item.HoraEntrada != "  ::00") ? (Item.HoraEntrada != "00:00:00" ? (TimeSpan.Parse("08:00:00") - TimeSpan.Parse(Item.HoraEntrada)) : TimeSpan.Parse("00:00:00")) : (TimeSpan?)null,
                    HoraEntrada = (Item.HoraEntrada != null && Item.HoraEntrada != string.Empty && Item.HoraEntrada != "  ::00") ? TimeSpan.Parse(Item.HoraEntrada) : (TimeSpan?)null,
                    HoraSaidaAlmoco = (Item.HoraSaidaAlmoco != null && Item.HoraSaidaAlmoco != string.Empty && Item.HoraSaidaAlmoco != "  ::00") ? TimeSpan.Parse(Item.HoraSaidaAlmoco) : (TimeSpan?)null,
                    HoraRetornoAlmoco = (Item.HoraRetornoAlmoco != null && Item.HoraRetornoAlmoco != string.Empty && Item.HoraRetornoAlmoco != "  ::00") ? TimeSpan.Parse(Item.HoraRetornoAlmoco) : (TimeSpan?)null,
                    HoraSaida = (Item.HoraSaida != null && Item.HoraSaida != string.Empty && Item.HoraSaida != "  ::00") ? TimeSpan.Parse(Item.HoraSaida) : (TimeSpan?)null,
                    TotalHora = Item.TotalHora,
                    DiferencaTotalHora = Item.DiferencaTotalHora,

                    TotalHorasDia = Util_BLL.FormatHoras(Util_BLL._TotalHorasDia),
                    TotalHorasSabado = Util_BLL.FormatHoras(Util_BLL._TotalHorasSabado),
                    TotalHorasSemanais = Util_BLL.FormatHoras(Util_BLL._TotalHorasSemana),
                    TotalHorasMes= Util_BLL.FormatHoras(Util_BLL._TotalHorasMes),
                    TotalHorasTrabalhadas = Util_BLL.FormatHoras(TotalHorasTrabalhadas),
                    TotalDiferencaHoras = Util_BLL.FormatHoras(new TimeSpan(TotalHorasTrabalhadas.Ticks - Util_BLL._TotalHorasMes.Ticks)),
                    TotalDiferencaInicial = DifInicial
                });

                #endregion

                #region "Lembretes"

                if (!string.IsNullOrEmpty(Item.LembreteHoraEntrada))
                {
                    Lembrete.Add(new RelatorioLembrete() 
                    { 
                        DataLembrete = Item.Data,
                        DiaSemanaLembrete = Util_BLL.strRetornaDiaSemana(Item.DiaSemana),
                        Hora = (Item.HoraEntrada != null && Item.HoraEntrada != string.Empty && Item.HoraEntrada != "  ::00") ? TimeSpan.Parse(Item.HoraEntrada) : (TimeSpan?)null,
                        Lembrete = Item.LembreteHoraEntrada,
                    });
                }

                if (!string.IsNullOrEmpty(Item.LembreteHoraSaidaAlmoco))
                {
                    Lembrete.Add(new RelatorioLembrete()
                    {
                        DataLembrete = Item.Data,
                        DiaSemanaLembrete = Util_BLL.strRetornaDiaSemana(Item.DiaSemana),
                        Hora = (Item.HoraSaidaAlmoco != null && Item.HoraSaidaAlmoco != string.Empty && Item.HoraSaidaAlmoco != "  ::00") ? TimeSpan.Parse(Item.HoraSaidaAlmoco) : (TimeSpan?)null,
                        Lembrete = Item.LembreteHoraSaidaAlmoco,
                    });
                }

                if (!string.IsNullOrEmpty(Item.LembreteHoraRetornoAlmoco))
                {
                    Lembrete.Add(new RelatorioLembrete()
                    {
                        DataLembrete = Item.Data,
                        DiaSemanaLembrete = Util_BLL.strRetornaDiaSemana(Item.DiaSemana),
                        Hora = (Item.HoraRetornoAlmoco != null && Item.HoraRetornoAlmoco != string.Empty && Item.HoraRetornoAlmoco != "  ::00") ? TimeSpan.Parse(Item.HoraRetornoAlmoco) : (TimeSpan?)null,
                        Lembrete = Item.LembreteHoraRetornoAlmoco,
                    });
                }

                if (!string.IsNullOrEmpty(Item.LembreteHoraSaida))
                {
                    Lembrete.Add(new RelatorioLembrete()
                    {
                        DataLembrete = Item.Data,
                        DiaSemanaLembrete = Util_BLL.strRetornaDiaSemana(Item.DiaSemana),
                        Hora = (Item.HoraSaida != null && Item.HoraSaida != string.Empty && Item.HoraSaida != "  ::00") ? TimeSpan.Parse(Item.HoraSaida) : (TimeSpan?)null,
                        Lembrete = Item.LembreteHoraSaida,
                    });
                }

                #endregion
            }

            rtvRelatorio.LocalReport.DataSources.Clear();
            rtvRelatorio.LocalReport.DataSources.Add(new ReportDataSource("MarcacaoPonto", Colecao));
            rtvRelatorio.LocalReport.DataSources.Add(new ReportDataSource("LembretePonto", Lembrete));
            rtvRelatorio.SetDisplayMode(DisplayMode.PrintLayout);
            rtvRelatorio.ZoomMode = ZoomMode.PageWidth;
            rtvRelatorio.RefreshReport();
        }

        #endregion
    }
}
