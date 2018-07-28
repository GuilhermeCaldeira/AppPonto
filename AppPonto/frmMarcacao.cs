using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppPonto_BLL;
using AppPonto_ENT;

namespace AppPonto
{
    public partial class frmMarcacao : Form
    {
        #region "Propriedades"

        public Ponto ItemPonto
        {
            get { return _ItemPonto; }
            set { _ItemPonto = value; }
        }
        private Ponto _ItemPonto;

        public string NomeArquivo
        {
            get; set;
        }

        #endregion

        #region "Eventos Form"

        public frmMarcacao()
        {
            InitializeComponent();
        }

        private void frmMarcacao_Load(object sender, EventArgs e)
        {
            CarregaDados();

            txtHrEntrada.GotFocus += RecebeFoco_GotFocus;
            txtHrSaidaAlmoco.GotFocus += RecebeFoco_GotFocus;
            txtHrRetornoAlmoco.GotFocus += RecebeFoco_GotFocus;
            txtHrSaida.GotFocus += RecebeFoco_GotFocus;

            if(_ItemPonto.DiaSemana == DiaSemanda.SABADO)
            {
                txtHrSaidaAlmoco.KeyDown += txtSaida_KeyDown;
            }
            else 
            {
                txtHrSaida.KeyDown += txtSaida_KeyDown;
            }
        }

        #endregion

        #region "Eventos KeyDown"

        private void frmMarcacao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    FecharTela();
                    break;
                case Keys.F7:
                    Confirmar();
                    break;
                case Keys.Enter:
                    SendKeys.Send("{TAB}");
                    break;
                default:
                    break;
            }
        }

        private void txtSaida_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Confirmar();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region "Eventos GotFocus"

        void RecebeFoco_GotFocus(object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).SelectAll();
        }

        #endregion

        #region "Eventos Click"

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        #endregion

        #region "Métodos Gerais"

        private void FecharTela()
        {
            this.Close();
        }

        private void CarregaDados()
        {
            lblTitulo.Text = Util_BLL.strRetornaDiaSemana(_ItemPonto.DiaSemana) + " " + _ItemPonto.Data.ToString("dd/MM/yyyy");
            txtHrEntrada.Text = _ItemPonto.HoraEntrada;
            txtHrSaidaAlmoco.Text = _ItemPonto.HoraSaidaAlmoco;

            if (_ItemPonto.DiaSemana != DiaSemanda.SABADO)
            {
                txtHrRetornoAlmoco.Text = _ItemPonto.HoraRetornoAlmoco;
                txtHrSaida.Text = _ItemPonto.HoraSaida;
            }

            txtHrRetornoAlmoco.Enabled = _ItemPonto.DiaSemana != DiaSemanda.SABADO;
            txtHrSaida.Enabled = _ItemPonto.DiaSemana != DiaSemanda.SABADO;
            lblTitHrRetornoAlmoco.Enabled = _ItemPonto.DiaSemana != DiaSemanda.SABADO;
            lblTitHrSaida.Enabled = _ItemPonto.DiaSemana != DiaSemanda.SABADO;
        }

        private void Confirmar()
        {
            string HrEntrada = txtHrEntrada.Text + ":00";
            string HrSaidaAlmoco = txtHrSaidaAlmoco.Text + ":00";
            string HrRetornoAlmoco = txtHrRetornoAlmoco.Text + ":00";
            string HrSaida = txtHrSaida.Text + ":00";

            if (ValidaHora(HrEntrada))
            {
                if (ValidaHora(HrSaidaAlmoco))
                {
                    if (_ItemPonto.DiaSemana == DiaSemanda.SABADO || ValidaHora(HrRetornoAlmoco))
                    {
                        if (_ItemPonto.DiaSemana == DiaSemanda.SABADO || ValidaHora(HrSaida))
                        {
                            _ItemPonto.HoraEntrada = HrEntrada;
                            _ItemPonto.HoraSaidaAlmoco = HrSaidaAlmoco;
                            _ItemPonto.HoraRetornoAlmoco = HrRetornoAlmoco;
                            _ItemPonto.HoraSaida = HrSaida;

                            if (_ItemPonto.DiaSemana != DiaSemanda.SABADO)
                            {
                                #region "Verifica se o retorno do almoço é menor que 01:01:00"

                                TimeSpan HoraSaidaAlmoco = TimeSpan.Parse(_ItemPonto.HoraSaidaAlmoco);
                                TimeSpan HoraRetornoAlmoco = TimeSpan.Parse(_ItemPonto.HoraRetornoAlmoco);

                                TimeSpan Diferenca = new TimeSpan(HoraRetornoAlmoco.Ticks - HoraSaidaAlmoco.Ticks);

                                #endregion

                                if (Diferenca.Ticks < TimeSpan.Parse("01:01:00").Ticks && HoraRetornoAlmoco.Ticks != TimeSpan.Parse("00:00:00").Ticks)
                                {
                                    if (MessageBox.Show(this, "Intervalo de retorno de almoço é menor que 01:01 hrs." + Environment.NewLine + "Deseja Continuar?", "Marcação de Ponto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        FinalizaAlteracao();
                                    }
                                }
                                else
                                {
                                    FinalizaAlteracao();
                                }
                            }
                            else
                            {
                                FinalizaAlteracao();
                            }
                        }
                        else
                        {
                            Util_BLL.MensagemAlerta("Horário de saída inválido!");
                            txtHrSaida.Focus();
                        }
                    }
                    else
                    {
                        Util_BLL.MensagemAlerta("Horário de retorno almoço inválido!");
                        txtHrRetornoAlmoco.Focus();
                    }
                }
                else
                {
                    Util_BLL.MensagemAlerta("Horário de saída almoço inválido!");
                    txtHrSaidaAlmoco.Focus();
                }
            }
            else
            {
                Util_BLL.MensagemAlerta("Horário de entrada inválido!");
                txtHrEntrada.Focus();
            }
        }

        private bool ValidaHora(string Horario) 
        {
            bool Retorno = false;

            try
            {
                TimeSpan HoraInicio = TimeSpan.Parse("00:00:00");
                TimeSpan HoraFim = TimeSpan.Parse("23:59:59");
                TimeSpan Hora = TimeSpan.Parse(Horario);

                if (Hora.Ticks >= HoraInicio.Ticks && Hora.Ticks <= HoraFim.Ticks)
                {
                    Retorno = true;
                }
                else
                {
                    Retorno = false;
                }
            }
            catch (Exception ex)
            {
                Retorno = false;   
            }

            return Retorno;
        }

        private void FinalizaAlteracao()
        {
            (new Ponto_BLL()).AtualizaCampo(_ItemPonto, NomeArquivo);

            FecharTela();
        }

        #endregion
    }
}
