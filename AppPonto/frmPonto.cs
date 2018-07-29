//DESENVOLVIDO POR: GUILHERME ABDON CALDEIRA
//E-MAIL: GUILHERME.CALDEIRA@HOTMAIL.COM.BR

using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using AppPonto_ENT;
using AppPonto_BLL;

namespace AppPonto
{
    public partial class frmPonto : Form
    {
        #region "Propriedades"

        public int IndexLinhaSelecionar { get; set; }

        private string NomeArquivo
        {
            get 
            {
                string Retorno = null;

                if (cboAno.SelectedValue != null && cboMes.SelectedValue != null)
                {
                    Retorno = (cboAno.SelectedValue.ToString() + "_" + Convert.ToInt32(cboMes.SelectedValue).ToString("00")).ToUpper() + ".xml";
                }

                return Retorno;
            }
        }

        #endregion

        #region "Construtor"

        public frmPonto()
        {
            InitializeComponent();
        }

        #endregion

        #region "Eventos Form"

        private void frmPonto_Load(object sender, EventArgs e)
        {
            IndexLinhaSelecionar = -1;

            CarregarArquivosDiretorio(null);

            grvPonto.Focus();
        }

        private void frmPonto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    CarregaDados();
                    CarregaTotais();
                    break;
                case Keys.Enter:
                    MarcarPonto();
                    break;
                case Keys.F12:
                    ExecutaRelatorio();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void frmPonto_Activated(object sender, EventArgs e)
        {
            grvPonto.Select();
            grvPonto.Focus();

            if (ValidaIndexExists())
            {
                grvPonto.CurrentCell = grvPonto.Rows[IndexLinhaSelecionar].Cells[0];
                grvPonto.Rows[IndexLinhaSelecionar].Selected = true;
            }
        }

        #endregion

        #region "Eventos KeyDown"

        private void grvPonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #region "Eventos CellFormatting"

        private void grvPonto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            #region "Busca registro existente na linha"

            object objItem = grvPonto.Rows[e.RowIndex].DataBoundItem;

            #endregion

            if (objItem != null)
            {
                #region "Cast para objeto Ponto"

                Ponto Item = (Ponto)objItem;

                #endregion

                #region "Verifica se é feriado"

                if (Item.Feriado == 'S')
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#FCDC6F");
                }
                else if (Item.Ferias == 'S')
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#B8E3EF");   
                }
                else if (Item.Folga == 'S')
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#CFED70");
                }

                #endregion

                #region "Verifica se esta sendo preenchido a coluna colDiaSemana"

                if (grvPonto.Columns[e.ColumnIndex].Name == "colDiaSemana")
                {
                    e.Value = Util_BLL.strRetornaDiaSemana(Item.DiaSemana);
                }

                #endregion

                #region "Verifica Lembrete"

                if (!string.IsNullOrEmpty(Item.LembreteHoraEntrada) && grvPonto.Columns[e.ColumnIndex].Name == "colHrEntrada")
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#F59A92");
                }
                else if (!string.IsNullOrEmpty(Item.LembreteHoraSaidaAlmoco) && grvPonto.Columns[e.ColumnIndex].Name == "colHrSaidaAlmoco")
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#F59A92");
                }
                else if (!string.IsNullOrEmpty(Item.LembreteHoraRetornoAlmoco) && grvPonto.Columns[e.ColumnIndex].Name == "colHrRetornoAlmoco")
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#F59A92");
                }
                else if (!string.IsNullOrEmpty(Item.LembreteHoraSaida) && grvPonto.Columns[e.ColumnIndex].Name == "colHrSaida")
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#F59A92");
                }

                #endregion

                #region "Valida colunas para formatar grid"

                if (Item.DiaSemana == DiaSemanda.SABADO)
                {
                    if (grvPonto.Columns[e.ColumnIndex].Name == "colHrRetornoAlmoco" || grvPonto.Columns[e.ColumnIndex].Name == "colHrSaida")
                    {
                        e.CellStyle.BackColor = Color.Silver;
                        e.Value = string.Empty;
                    }
                    else if (grvPonto.Columns[e.ColumnIndex].Name == "colTotalHora" && e.Value != null)
                    {
                        e.CellStyle.ForeColor = ValidaTotalHoras(e.Value.ToString(), Util_BLL._TotalHorasSabado);
                    }
                }
                else if (Item.DiaSemana == DiaSemanda.DOMINGO)
                {
                    e.CellStyle.BackColor = Color.Silver;

                    if (grvPonto.Columns[e.ColumnIndex].Name != "colDia" && grvPonto.Columns[e.ColumnIndex].Name != "colDiaSemana" &&
                        grvPonto.Columns[e.ColumnIndex].Name != "colTotalHora" && grvPonto.Columns[e.ColumnIndex].Name != "colDiferenca")
                    {
                        e.Value = string.Empty;
                    }
                    else if(grvPonto.Columns[e.ColumnIndex].Name == "colTotalHora" || grvPonto.Columns[e.ColumnIndex].Name == "colDiferenca")
                    {
                        e.CellStyle.Font = new Font(grvPonto.DefaultCellStyle.Font, FontStyle.Bold);
                    }
                }
                else
                {
                    if (grvPonto.Columns[e.ColumnIndex].Name == "colTotalHora" && e.Value != null)
                    {
                        e.CellStyle.ForeColor = ValidaTotalHoras(e.Value.ToString(), Util_BLL._TotalHorasDia);
                    }
                    else if ((grvPonto.Columns[e.ColumnIndex].Name == "colHrSaidaAlmoco" || grvPonto.Columns[e.ColumnIndex].Name == "colHrRetornoAlmoco") && e.Value != null)
                    {
                        #region "Verifica se o retorno do almoço é menor que 01:01:00"

                        TimeSpan HoraSaidaAlmoco = TimeSpan.Parse(Item.HoraSaidaAlmoco);
                        TimeSpan HoraRetornoAlmoco = TimeSpan.Parse(Item.HoraRetornoAlmoco);

                        TimeSpan Diferenca = new TimeSpan(HoraRetornoAlmoco.Ticks - HoraSaidaAlmoco.Ticks);

                        if (Diferenca.Ticks < TimeSpan.Parse("01:01:00").Ticks && HoraRetornoAlmoco.Ticks != TimeSpan.Parse("00:00:00").Ticks)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                        }

                        #endregion
                    }
                }

                #endregion
            }
        }

        #endregion

        #region "Eventos CellClick"

        private void grvPonto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexLinhaSelecionar = grvPonto.CurrentRow.Index;
        }

        #endregion

        #region "Eventos CellDoubleClick"

        private void grvPonto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MarcarPonto();
        }

        #endregion

        #region "Eventos MouseDown"

        private void grvPonto_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = ((DataGridView)sender).HitTest(e.X, e.Y);

                if (hit.Type != DataGridViewHitTestType.Cell)
                {
                    popMarcacao.AutoSize = false;
                    popMarcacao.Enabled = false;
                    popMarcacao.Width = 0;
                    popMarcacao.Height = 0;
                }
                else
                {
                    popMarcacao.AutoSize = true;
                    popMarcacao.Enabled = true;
                }
            }
        }

        #endregion

        #region "Eventos CellContextMenuStripNeeded"

        private void grvPonto_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            grvPonto.CurrentCell = grvPonto.Rows[e.RowIndex].Cells[e.ColumnIndex];
            grvPonto.Rows[e.RowIndex].Selected = true;

            IndexLinhaSelecionar = e.RowIndex;

            object objItem = grvPonto.Rows[grvPonto.CurrentRow.Index].DataBoundItem;

            if (objItem != null)
            {
                Ponto Item = (Ponto)objItem;
                btnFeriado.Text = Item.Feriado == 'N' ? "Definir Feriado" : "Remover Feriado";
                btnFerias.Text = Item.Ferias == 'N' ? "Definir Férias" : "Remover Férias";
                btnFolga.Text = Item.Folga == 'N' ? "Definir Folga" : "Remover Folga";

                #region "Valida Menus"

                btnLembrete.Enabled = (grvPonto.Columns[e.ColumnIndex].Name == "colHrEntrada" || grvPonto.Columns[e.ColumnIndex].Name == "colHrSaidaAlmoco" ||
                                       grvPonto.Columns[e.ColumnIndex].Name == "colHrRetornoAlmoco" || grvPonto.Columns[e.ColumnIndex].Name == "colHrSaida") && 
                                       Item.DiaSemana != DiaSemanda.DOMINGO;

                if (((grvPonto.Columns[e.ColumnIndex].Name == "colHrRetornoAlmoco" || grvPonto.Columns[e.ColumnIndex].Name == "colHrSaida") &&
                      Item.DiaSemana == DiaSemanda.SABADO))
                {
                    btnLembrete.Enabled = false;
                }

                btnFeriado.Enabled = Item.DiaSemana != DiaSemanda.DOMINGO;
                btnFerias.Enabled = Item.DiaSemana != DiaSemanda.DOMINGO;
                btnFolga.Enabled = Item.DiaSemana != DiaSemanda.DOMINGO;
                btnFalta.Enabled = Item.DiaSemana != DiaSemanda.DOMINGO && Item.Feriado != 'S' && Item.Ferias != 'S' && Item.Folga != 'S';

                #endregion
            }
        }

        #endregion

        #region "Eventos Click"

        private void btnMarcarPonto_Click(object sender, EventArgs e)
        {
            MarcarPonto();    
        }

        private void btnFeriado_Click(object sender, EventArgs e)
        {
            object objItem = grvPonto.Rows[grvPonto.CurrentRow.Index].DataBoundItem;

            DefineLicencas(objItem, true, false, false);
        }

        private void btnFerias_Click(object sender, EventArgs e)
        {
            object objItem = grvPonto.Rows[grvPonto.CurrentRow.Index].DataBoundItem;

            DefineLicencas(objItem, false, true, false);
        }

        private void btnFolga_Click(object sender, EventArgs e)
        {
            object objItem = grvPonto.Rows[grvPonto.CurrentRow.Index].DataBoundItem;

            DefineLicencas(objItem, false, false, true);
        }

        private void btnLembrete_Click(object sender, EventArgs e)
        {
            Lembrete();   
        }

        private void btnFalta_Click(object sender, EventArgs e)
        {
            object objItem = grvPonto.Rows[grvPonto.CurrentRow.Index].DataBoundItem;

            if(objItem != null)
            {
                Ponto Item = (Ponto)objItem;

                if (Item.DiaSemana != DiaSemanda.DOMINGO && Item.Feriado == 'N' && Item.Ferias == 'N' && Item.Folga == 'N')
                {
                    Item.HoraEntrada = "00:00:00";
                    Item.HoraSaidaAlmoco = "00:00:00";

                    if (Item.DiaSemana != DiaSemanda.SABADO)
                    {
                        Item.HoraRetornoAlmoco = "00:00:00";
                        Item.HoraSaida = "00:00:00";
                    }

                    (new Ponto_BLL()).AtualizaCampo(Item, NomeArquivo);

                    CarregaDados();
                    CarregaTotais();    
                }
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            ExecutaRelatorio();
        }

        #endregion

        #region "Eventos SelectedIndexChanged"

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaTotais();
        }

        private void cboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarArquivosDiretorio(cboAno.SelectedValue.ToString());
        }

        #endregion

        #region "Eventos FormClosing"

        void FrmMarcacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.pnPrincipal.Enabled = true;

            CarregaDados();
            CarregaTotais();
        }

        void FrmLembrete_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.pnPrincipal.Enabled = true;

            CarregaDados();
            CarregaTotais();
        }

        #endregion

        #region "Métodos Gerais"

        private bool ValidaIndexExists()
        {
            return (IndexLinhaSelecionar > 0 && (grvPonto.Rows.Count - 1) >= IndexLinhaSelecionar);
        }

        private void DefineLicencas(object objItem, bool Feriado, bool Ferias, bool Folga)
        {
            if (objItem != null)
            {
                Ponto Item = (Ponto)objItem;

                if (Item.DiaSemana != DiaSemanda.DOMINGO)
                {
                    #region "Atualiza Dados"

                    if (Feriado)
                    {
                        Item.Feriado = Item.Feriado == 'N' ? 'S':'N';

                        Item.Ferias = 'N';
                        Item.Folga = 'N';
                    }
                    else if (Ferias)
                    {
                        Item.Ferias = Item.Ferias == 'N' ? 'S' : 'N';

                        Item.Feriado = 'N';
                        Item.Folga = 'N';
                    }
                    else if (Folga)
                    {
                        Item.Folga = Item.Folga == 'N' ? 'S' : 'N';

                        Item.Feriado = 'N';
                        Item.Ferias = 'N';
                    }

                    #endregion

                    Item.HoraEntrada = "08:00:00";
                    Item.HoraSaidaAlmoco = "12:00:00";

                    if (Item.DiaSemana != DiaSemanda.SABADO)
                    {
                        Item.HoraRetornoAlmoco = "14:00:00";
                        Item.HoraSaida = "18:00:00";
                    }

                    (new Ponto_BLL()).AtualizaCampo(Item, NomeArquivo);

                    CarregaDados();
                    CarregaTotais();
                }
            }
        }

        /// <summary>
        /// Chama a função para abertura da tela de
        /// cadastro de lembrete
        /// </summary>
        private void Lembrete()
        {
            object objItem = grvPonto.Rows[grvPonto.CurrentRow.Index].DataBoundItem;

            if (objItem != null)
            {
                Ponto Item = (Ponto)objItem;

                if (Item.DiaSemana != DiaSemanda.DOMINGO)
                {
                    this.pnPrincipal.Enabled = false;

                    frmLembrete FrmLembrete = new frmLembrete();
                    FrmLembrete.FormClosing += FrmLembrete_FormClosing;

                    FrmLembrete.NomeArquivo = NomeArquivo;
                    FrmLembrete.ItemPonto = Item;
                    FrmLembrete.NameColumn = grvPonto.Columns[grvPonto.CurrentCell.ColumnIndex].Name;
                    FrmLembrete.ShowDialog();
                }
                else
                {
                    Util_BLL.MensagemAlerta("Não é possível marcar definir um lembrete para este dia!");
                }
            }
        }

        private void MarcarPonto()
        {
            object objItem = grvPonto.Rows[grvPonto.CurrentRow.Index].DataBoundItem;
            IndexLinhaSelecionar = grvPonto.CurrentRow.Index;

            if (objItem != null)
            {
                Ponto Item = (Ponto)objItem;

                if (Item.DiaSemana != DiaSemanda.DOMINGO && Item.Feriado == 'N' && Item.Ferias == 'N' && Item.Folga == 'N')
                {
                    this.pnPrincipal.Enabled = false;

                    frmMarcacao FrmMarcacao = new frmMarcacao();
                    FrmMarcacao.FormClosing += FrmMarcacao_FormClosing;

                    FrmMarcacao.NomeArquivo = NomeArquivo;
                    FrmMarcacao.ItemPonto = Item;
                    FrmMarcacao.ShowDialog();
                }
                else
                {
                    Util_BLL.MensagemAlerta("Não é possível marcar ponto neste dia!");
                }
            }
        }

        private void CarregaDados()
        {
            Util_BLL.ListPonto = (new Ponto_BLL()).CarregaRegistro(NomeArquivo);

            grvPonto.AutoGenerateColumns = false;
            grvPonto.DataSource = Util_BLL.ListPonto;
            grvPonto.ContextMenuStrip = popMarcacao;

            ///Caso não exista linha selecionada o sistema
            ///busca o dia atual para selecionar a linha do
            ///mesmo.
            if (IndexLinhaSelecionar == -1)
            {
                IndexLinhaSelecionar = DateTime.Now.Day - 1;
            }
            
            ///O index sendo diferente de -1 é selecionada a linha
            ///referênte ao index.
            if (ValidaIndexExists())
            {
                grvPonto.CurrentCell = grvPonto.Rows[IndexLinhaSelecionar].Cells[0];
                grvPonto.Rows[IndexLinhaSelecionar].Selected = true;
            }
        }

        private void CarregaTotais()
        {
            TimeSpan TotalHorasTrabalhadas = (new Ponto_BLL()).HorasTrabalhadas(Util_BLL.ListPonto);

            lblHrsDia.Text = Util_BLL.FormatHoras(Util_BLL._TotalHorasDia);
            lblHrsSemana.Text = Util_BLL.FormatHoras(Util_BLL._TotalHorasSemana);
            lblHrsSabado.Text = Util_BLL.FormatHoras(Util_BLL._TotalHorasSabado);
            lblHrsMes.Text = Util_BLL.FormatHoras(Util_BLL._TotalHorasMes);
            lblHrsTrabalhadas.Text = Util_BLL.FormatHoras(TotalHorasTrabalhadas);
            lblDiferenca.Text = Util_BLL.FormatHoras(new TimeSpan(TotalHorasTrabalhadas.Ticks - Util_BLL._TotalHorasMes.Ticks));

            lblDiferenca.ForeColor = ValidaTotalHoras(lblDiferenca.Text, TimeSpan.Parse("0"));
        }

        private void CarregarArquivosDiretorio(string FindAno)
        {
            #region "Buscar Arquivos"

            DirectoryInfo Dir = new DirectoryInfo(Caminho.PastaXML);
            List<ListItem> ListMes = new List<ListItem>();
            List<ListItem> ListAno = new List<ListItem>();

            FileInfo[] Files = Dir.GetFiles("*.xml", SearchOption.AllDirectories);

            foreach (FileInfo File in Files)
            {
                string[] strMes = File.Name.Replace(".xml", string.Empty).Split('_');

                #region "Valida Mês"

                ListItem ItemMes = new ListItem();
                ItemMes.Value = strMes[1];
                ItemMes.ValueAux = strMes[0];
                ItemMes.Text = Util_BLL.RetornaMes(Convert.ToInt32(ItemMes.Value));

                ListMes.Add(ItemMes);

                //if (ListMes.Count(p => ((ListItem)p).Value == ItemMes.Value) <= 0)
                //{
                //    ListMes.Add(ItemMes);
                //}

                #endregion

                if (string.IsNullOrEmpty(FindAno))
                {
                    #region "Valida Ano"

                    ListItem ItemAno = new ListItem();
                    ItemAno.Value = strMes[0];
                    ItemAno.Text = strMes[0];

                    if (ListAno.Count(p => ((ListItem)p).Value == ItemAno.Value) <= 0)
                    {
                        ListAno.Add(ItemAno);
                    }

                    #endregion
                }
            }

            #endregion

            #region "Ano"

            if (string.IsNullOrEmpty(FindAno))
            {
                cboAno.DisplayMember = "Text";
                cboAno.ValueMember = "Value";
                cboAno.DataSource = ListAno;

                cboAno.SelectedIndexChanged += cboAno_SelectedIndexChanged;

                cboAno.SelectedIndex = cboAno.Items.Count - 1;

                FindAno = cboAno.SelectedValue.ToString();
            }

            #endregion

            #region "Mês"

            cboMes.DisplayMember = "Text";
            cboMes.ValueMember = "Value";
            cboMes.DataSource = ListMes.Where(p => ((ListItem)p).ValueAux == FindAno).ToList();

            cboMes.SelectedIndex = cboMes.Items.Count - 1;

            #endregion
        }

        /// <summary>
        /// Chama o form frmrelatorio para gerar o 
        /// relatório do selecionado pelo usuário.
        /// </summary>
        private void ExecutaRelatorio()
        {
            frmRelatorio FrmRelatorio = new frmRelatorio();
            FrmRelatorio.WindowState = FormWindowState.Maximized;
            FrmRelatorio.StartPosition = FormStartPosition.CenterScreen;

            FrmRelatorio.BringToFront();
            FrmRelatorio.ShowDialog(this);
        }

        /// <summary>
        /// Verifica se o total de horas esta acima ou abaixo do desejado,
        /// caso esteja acima ou igual será retornado azul, caso contrário
        /// será retornado vermelho.
        /// </summary>
        /// <param name="Hora"></param>
        /// <param name="HoraValidacao"></param>
        /// <returns></returns>
        private Color ValidaTotalHoras(string Hora, TimeSpan HoraValidacao)
        {
            Color CorRetorno = new Color();
            TimeSpan tsHora = TimeSpan.Parse(Hora);

            CorRetorno = tsHora.Ticks < HoraValidacao.Ticks ? Color.Red : Color.Blue;

            return CorRetorno;
        }

        #endregion
    }
}