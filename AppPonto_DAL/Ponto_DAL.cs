using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using AppPonto_ENT;

namespace AppPonto_DAL
{
    public class Ponto_DAL
    {
        #region "Modificações de Dados"

        public void CriarOuAlterarTabela(List<Ponto> ListPonto, string NomeArquivo)
        {
            XmlSerializer parse = new XmlSerializer(typeof(Ponto[]));

            using (var writer = new StreamWriter(Caminho.CaminhoXML(NomeArquivo)))
            {
                parse.Serialize(writer, ListPonto.ToArray());
                writer.Close();
            }
        }

        public List<Ponto> CarregaRegistro(string NomeArquivo)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Ponto[]));
            List<Ponto> ListPontos = new List<Ponto>();

            if (File.Exists(Caminho.CaminhoXML(NomeArquivo)))
            {
                using (XmlReader reader = XmlReader.Create(Caminho.CaminhoXML(NomeArquivo)))
                {
                    foreach (Ponto Item in (Ponto[])ser.Deserialize(reader))
                    {
                        Item.Ferias = Item.Ferias != 0 ? Item.Ferias : 'N';
                        Item.Folga = Item.Folga != 0 ? Item.Folga : 'N';

                        ListPontos.Add(Item);
                    }
                }
            }

            return ListPontos;
        }

        #endregion
    }
}
