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
    public partial class frmLembrete : Form
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
            get;
            set;
        }
        public string NameColumn
        {
            get;
            set;
        }

        #endregion

        #region "Eventos Form"

        public frmLembrete()
        {
            InitializeComponent();
        }

        private void frmLembrete_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        #endregion

        #region "Eventos KeyDown"

        private void frmLembrete_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    FecharTela();
                    break;
                case Keys.F7:
                    Confirmar();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region "Eventos Click"

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        #endregion

        #region "Métodos Gerais"

        private void FecharTela()
        {
            this.Close();
        }

        private void Confirmar()
        {
            string Lembrete = !(string.IsNullOrEmpty(txtLembrete.Text)) ? txtLembrete.Text : null;

            if (NameColumn == "colHrEntrada")
            {
                _ItemPonto.LembreteHoraEntrada = Lembrete;
            }
            else if (NameColumn == "colHrSaidaAlmoco")
            {
                _ItemPonto.LembreteHoraSaidaAlmoco = Lembrete;
            }
            else if (NameColumn == "colHrRetornoAlmoco")
            {
                _ItemPonto.LembreteHoraRetornoAlmoco = Lembrete;
            }
            else if (NameColumn == "colHrSaida")
            {
                _ItemPonto.LembreteHoraSaida = Lembrete;
            }

            (new Ponto_BLL()).AtualizaCampo(_ItemPonto, NomeArquivo);

            FecharTela();
        }

        private void CarregaDados()
        {
            if (NameColumn == "colHrEntrada")
            {
                txtLembrete.Text = _ItemPonto.LembreteHoraEntrada;
                lblTitulo.Text = Util_BLL.strRetornaDiaSemana(_ItemPonto.DiaSemana) + " " + _ItemPonto.Data.ToString("dd/MM/yyyy") + " " + _ItemPonto.HoraEntrada;
            }
            else if (NameColumn == "colHrSaidaAlmoco")
            {
                txtLembrete.Text = _ItemPonto.LembreteHoraSaidaAlmoco;
                lblTitulo.Text = Util_BLL.strRetornaDiaSemana(_ItemPonto.DiaSemana) + " " + _ItemPonto.Data.ToString("dd/MM/yyyy") + " " + _ItemPonto.HoraSaidaAlmoco;
            }
            else if (NameColumn == "colHrRetornoAlmoco")
            {
                lblTitulo.Text = Util_BLL.strRetornaDiaSemana(_ItemPonto.DiaSemana) + " " + _ItemPonto.Data.ToString("dd/MM/yyyy") + " " + _ItemPonto.HoraRetornoAlmoco;
                txtLembrete.Text = _ItemPonto.LembreteHoraRetornoAlmoco;
            }
            else if (NameColumn == "colHrSaida")
            {
                lblTitulo.Text = Util_BLL.strRetornaDiaSemana(_ItemPonto.DiaSemana) + " " + _ItemPonto.Data.ToString("dd/MM/yyyy") + " " + _ItemPonto.HoraSaida;
                txtLembrete.Text = _ItemPonto.LembreteHoraSaida;
            }

            txtLembrete.Focus();
        }

        #endregion
    }
}
