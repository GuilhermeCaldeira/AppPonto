using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppPonto
{
    public partial class frmError : Form
    {
        #region "Construtor"

        public frmError()
        {
            InitializeComponent();
        }

        #endregion

        #region "Eventos Form"

        private void frmError_Load(object sender, EventArgs e)
        {
            Random randNum = new Random();
            int Index = randNum.Next(1, 76);

            if (Index >= 1 && Index <= 25)
            {
                lblMsgError.Text = @"Ooxi!" + Environment.NewLine + @"Esqueci de algum ponto e vírgula...";

                imgError.Image = AppPonto.Properties.Resources.imgERRO_01;
                lblMsgError.ForeColor = ColorTranslator.FromHtml("#3B464F");
            }
            else if (Index > 25 && Index <= 50)
            {
                lblMsgError.Text = @"Buaaaa!" + Environment.NewLine + @"O bug derrubou meu sorvete...";

                imgError.Image = AppPonto.Properties.Resources.imgERRO_02;
                lblMsgError.ForeColor = ColorTranslator.FromHtml("#FF5579");
            }
            else if (Index > 50 && Index <= 75)
            {
                lblMsgError.Text = @"Oops!" + Environment.NewLine + @"Alguma coisa comeu os fios...";

                imgError.Image = AppPonto.Properties.Resources.imgERRO_03;
                lblMsgError.ForeColor = ColorTranslator.FromHtml("#58718B");
            }
        }

        private void frmError_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        #endregion
    }
}
