using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppPonto_DAL;
using AppPonto_ENT;

namespace AppPonto_BLL
{
    //DESENVOLVIDO POR: GUILHERME ABDON CALDEIRA
    //E-MAIL: GUILHERME.CALDEIRA@HOTMAIL.COM.BR

    public class Ponto_BLL
    {
        #region "Utilizado para criar a tabela de armazenamento de ponto, regra utilizada somente na inicialização so software"

        public void CriarTabela()
        {
            List<Ponto> ListPonto = new List<Ponto>();

            DateTime MesInicio = Convert.ToDateTime("01/" + DateTime.Now.ToString("MM/yyyy"));
            DateTime MesFim = Convert.ToDateTime(MesInicio.AddMonths(1).AddSeconds(-1).ToString("dd/MM/yyyy"));

            for (int i = 1; i <= MesFim.Day; i++)
            {
                DateTime Dia = Convert.ToDateTime(i.ToString("00") + "/" + DateTime.Now.ToString("MM/yyyy"));
                
                Ponto ItemPonto = new Ponto();
                ItemPonto.Data = Dia;
                ItemPonto.DiaSemana = Util_BLL.RetornaDiaSemana(Dia.DayOfWeek);
                ItemPonto.Feriado = 'N';
                ItemPonto.Ferias = 'N';
                ItemPonto.Folga = 'N';

                if (ItemPonto.DiaSemana != DiaSemanda.DOMINGO)
                {
                    ItemPonto.HoraEntrada = "08:00:00";
                    ItemPonto.HoraSaidaAlmoco = "12:00:00";

                    if (ItemPonto.DiaSemana != DiaSemanda.SABADO)
                    {
                        ItemPonto.HoraRetornoAlmoco = "14:00:00";
                        ItemPonto.HoraSaida = "18:00:00";
                    }
                }

                ListPonto.Add(ItemPonto);
            }

            ListPonto = CalcularValorTotal(ListPonto);

            (new Ponto_DAL()).CriarOuAlterarTabela(ListPonto, null);
        }

        #endregion

        #region "Atualiza tabela de dados"

        public void AtualizaCampo(Ponto ItemAtualiza, string NomeArquivo)
        {
            List<Ponto> ListPonto = Util_BLL.ListPonto;

            foreach (Ponto Item in ListPonto)
            {
                if (Item.Data.Date == ItemAtualiza.Data.Date)
                {
                    Item.Data = ItemAtualiza.Data;
                    Item.DiaSemana = ItemAtualiza.DiaSemana;
                    Item.HoraEntrada = ItemAtualiza.HoraEntrada;
                    Item.HoraSaidaAlmoco = ItemAtualiza.HoraSaidaAlmoco;
                    Item.HoraRetornoAlmoco = ItemAtualiza.HoraRetornoAlmoco;
                    Item.HoraSaida = ItemAtualiza.HoraSaida;
                    Item.TotalHora = ItemAtualiza.TotalHora;
                    Item.DiferencaTotalHora = ItemAtualiza.DiferencaTotalHora;
                    Item.Feriado = ItemAtualiza.Feriado;
                    Item.LembreteHoraEntrada = ItemAtualiza.LembreteHoraEntrada;
                    Item.LembreteHoraSaidaAlmoco = ItemAtualiza.LembreteHoraSaidaAlmoco;
                    Item.LembreteHoraRetornoAlmoco = ItemAtualiza.LembreteHoraRetornoAlmoco;
                    Item.LembreteHoraSaida = ItemAtualiza.LembreteHoraSaida;

                    break;
                }
            }

            ListPonto = CalcularValorTotal(ListPonto);
            Util_BLL.ListPonto = ListPonto;

            (new Ponto_DAL()).CriarOuAlterarTabela(ListPonto, NomeArquivo);
        }

        #endregion

        #region "Carregamento de registros"

        public List<Ponto> CarregaRegistro(string NomeArquivo)
        {
            List<Ponto> ListRetorno = (new Ponto_DAL()).CarregaRegistro(NomeArquivo);
            ListRetorno = CalcularValorTotal(ListRetorno);

            return ListRetorno;
        }

        #endregion

        #region "Calculo de totais"

        public List<Ponto> CalcularValorTotal(List<Ponto> ListPonto)
        {
            TimeSpan TotalHoraSemana = TimeSpan.Parse("00:00:00");
            TimeSpan TotalDiferencaSemana = TimeSpan.Parse("00:00:00");

            foreach (Ponto Item in ListPonto)
            {
                TimeSpan HoraEntrada = TimeSpan.Parse("00:00:00");
                TimeSpan HoraSaidaAlmoco = TimeSpan.Parse("00:00:00");

                if (Item.DiaSemana != DiaSemanda.DOMINGO)
                {
                    HoraEntrada = TimeSpan.Parse(Item.HoraEntrada);
                    HoraSaidaAlmoco = TimeSpan.Parse(Item.HoraSaidaAlmoco);
                }

                if (Item.DiaSemana != DiaSemanda.SABADO && Item.DiaSemana != DiaSemanda.DOMINGO)
                {
                    TimeSpan HoraRetornoAlmoco = TimeSpan.Parse(Item.HoraRetornoAlmoco);
                    TimeSpan HoraSaida = TimeSpan.Parse(Item.HoraSaida);

                    TimeSpan Total = new TimeSpan((HoraSaidaAlmoco.Ticks - HoraEntrada.Ticks) + (HoraSaida.Ticks - HoraRetornoAlmoco.Ticks));
                    TimeSpan Diferenca = new TimeSpan(Total.Ticks - Util_BLL._TotalHorasDia.Ticks);

                    TotalHoraSemana = new TimeSpan(Total.Ticks + TotalHoraSemana.Ticks);
                    TotalDiferencaSemana = new TimeSpan(Diferenca.Ticks + TotalDiferencaSemana.Ticks);

                    Item.TotalHora = Util_BLL.FormatHoras(Total);
                    Item.DiferencaTotalHora = Util_BLL.FormatHoras(Diferenca);
                }
                else if (Item.DiaSemana == DiaSemanda.SABADO)
                {
                    TimeSpan Total = new TimeSpan((HoraSaidaAlmoco.Ticks - HoraEntrada.Ticks));
                    TimeSpan Diferenca = new TimeSpan(Total.Ticks - Util_BLL._TotalHorasSabado.Ticks);

                    TotalHoraSemana = new TimeSpan(Total.Ticks + TotalHoraSemana.Ticks);
                    TotalDiferencaSemana = new TimeSpan(Diferenca.Ticks + TotalDiferencaSemana.Ticks);

                    Item.TotalHora = Util_BLL.FormatHoras(Total);
                    Item.DiferencaTotalHora = Util_BLL.FormatHoras(Diferenca);
                }
                else if (Item.DiaSemana == DiaSemanda.DOMINGO)
                {
                    Item.TotalHora = Util_BLL.FormatHoras(TotalHoraSemana);
                    Item.DiferencaTotalHora = Util_BLL.FormatHoras(TotalDiferencaSemana);

                    TotalHoraSemana = TimeSpan.Parse("00:00:00");
                    TotalDiferencaSemana = TimeSpan.Parse("00:00:00");
                }
            }

            return ListPonto;
        }

        public TimeSpan HorasTrabalhadas(List<Ponto> ListPonto)
        {
            long ValorTotal = 0;

            foreach (Ponto Item in ListPonto.Where(p => (((Ponto)p).DiaSemana != DiaSemanda.DOMINGO && ((Ponto)p).Feriado == 'N' && ((Ponto)p).Ferias == 'N' && ((Ponto)p).Folga == 'N')))
            {
                if (Item.TotalHora != null)
                {
                    ValorTotal += TimeSpan.Parse(Item.TotalHora).Ticks;
                }
            }

            return (new TimeSpan(ValorTotal));
        }

        #endregion
    }
}
