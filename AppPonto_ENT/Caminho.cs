using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPonto_ENT
{
    public class Caminho
    {
        public static string NomeArquivo
        {
            get
            {
                return DateTime.Now.ToString("yyyy_MM").ToUpper() + ".xml";
            }
        }

        public static string CaminhoXML()
        {
            return CaminhoXML(NomeArquivo);   
        }

        public static string CaminhoXML(string NomeArq)
        {
            string CaminhoXML = PastaXML + "\\" + ((NomeArq != null && NomeArq != string.Empty) ? NomeArq : NomeArquivo);

            return CaminhoXML;
        }

        public static string PastaXML
        {
            get
            {
                string CaminhoXML = Directory.GetCurrentDirectory();
                CaminhoXML = CaminhoXML.Replace("\\bin", string.Empty).Replace("\\Debug", string.Empty).Replace("\\Release", string.Empty);
                CaminhoXML += "\\Dados";

                return CaminhoXML;
            }
        }

        public static string PastaLOG
        {
            get
            {
                string CaminhoXML = Directory.GetCurrentDirectory();
                CaminhoXML = CaminhoXML.Replace("\\bin", string.Empty).Replace("\\Debug", string.Empty).Replace("\\Release", string.Empty);
                CaminhoXML += "\\Log";

                return CaminhoXML;
            }
        }
    }
}
