using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppPonto_BLL;
using AppPonto_ENT;

namespace AppPonto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. ok
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(Caminho.PastaXML))
            {
                Directory.CreateDirectory(Caminho.PastaXML);
            }

            if (!File.Exists(Caminho.CaminhoXML()))
            {
                (new Ponto_BLL()).CriarTabela();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.Run(new frmPonto());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string ArquivoLog = Caminho.PastaLOG + @"\\LOG_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".err";

            if (!Directory.Exists(Caminho.PastaLOG))
            {
                Directory.CreateDirectory(Caminho.PastaLOG);
            }

            if (!File.Exists(ArquivoLog))
            {
                File.Create(ArquivoLog).Dispose();
            }

            using (StreamWriter swError = new StreamWriter(ArquivoLog))
            {
                swError.WriteLine("[ERROR] " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                swError.WriteLine("[MESSAGE] " + e.Exception.Message);
                swError.WriteLine("[SOURCE] " + e.Exception.Source);
                swError.WriteLine("[TARGET SITE] " + e.Exception.TargetSite);
                swError.WriteLine(string.Empty);
                swError.WriteLine(e.Exception.ToString());

                swError.Close();
                swError.Dispose();
            }

            frmError FrmError = new frmError();
            FrmError.ShowDialog();

        }

    }
}
