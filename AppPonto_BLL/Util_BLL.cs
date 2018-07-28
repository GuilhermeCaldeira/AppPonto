using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppPonto_ENT;

namespace AppPonto_BLL
{
    public class Util_BLL
    {
        #region "Propriedades"

        public static List<Ponto> ListPonto
        {
            get { return _ListPonto; }
            set { _ListPonto = value; }
        }
        private static List<Ponto> _ListPonto;

        #endregion

        #region "Constantes"

        public static TimeSpan _TotalHorasDia
        {
            get { return TimeSpan.FromHours(8); }
        }

        public static TimeSpan _TotalHorasSemana
        {
            get { return TimeSpan.FromHours(44); }
        }

        public static TimeSpan _TotalHorasSabado
        {
            get { return TimeSpan.FromHours(4); }
        }

        public static TimeSpan _TotalHorasMes 
        {
            get 
            {
                int QtdeDiasUteis = _ListPonto.Count(p => (((Ponto)p).DiaSemana != DiaSemanda.DOMINGO && ((Ponto)p).DiaSemana != DiaSemanda.SABADO && ((Ponto)p).Feriado == 'N' && ((Ponto)p).Ferias == 'N' && ((Ponto)p).Folga == 'N'));
                int QtdeSabados = _ListPonto.Count(p => (((Ponto)p).DiaSemana == DiaSemanda.SABADO && ((Ponto)p).Feriado == 'N' && ((Ponto)p).Ferias == 'N' && ((Ponto)p).Folga == 'N'));

                TimeSpan TotalHorasMes = TimeSpan.FromHours((QtdeDiasUteis * Util_BLL._TotalHorasDia.TotalHours) + (QtdeSabados * Util_BLL._TotalHorasSabado.TotalHours));

                return TotalHorasMes;
            }
        }

        #endregion

        #region "Métodos Gerais"

        public static DiaSemanda RetornaDiaSemana(DayOfWeek Dia)
        {
            DiaSemanda DiaRetorno = DiaSemanda.DOMINGO;

            switch(Dia)
            {
                case DayOfWeek.Sunday:
                    DiaRetorno = DiaSemanda.DOMINGO;
                    break;
                case DayOfWeek.Monday:
                    DiaRetorno = DiaSemanda.SEGUNDA_FEIRA;
                    break;
                case DayOfWeek.Tuesday:
                    DiaRetorno = DiaSemanda.TERÇA_FEIRA;
                    break;
                case DayOfWeek.Wednesday:
                    DiaRetorno = DiaSemanda.QUARTA_FEIRA;
                    break;
                case DayOfWeek.Thursday:
                    DiaRetorno = DiaSemanda.QUINTA_FEIRA;
                    break;
                case DayOfWeek.Friday:
                    DiaRetorno = DiaSemanda.SEXTA_FEIRA;
                    break;
                case DayOfWeek.Saturday:
                    DiaRetorno = DiaSemanda.SABADO;
                    break;                                                                
                default:
                    break;
            }

            return DiaRetorno;
        }

        public static string strRetornaDiaSemana(DiaSemanda Dia)
        {
            string DiaRetorno = string.Empty;

            switch (Dia)
            {
                case DiaSemanda.DOMINGO:
                    DiaRetorno = "Domingo";
                    break;
                case DiaSemanda.SEGUNDA_FEIRA:
                    DiaRetorno = "Segunda-Feira";
                    break;
                case DiaSemanda.TERÇA_FEIRA:
                    DiaRetorno = "Terça-Feira";
                    break;
                case DiaSemanda.QUARTA_FEIRA:
                    DiaRetorno = "Quarta-Feira";
                    break;
                case DiaSemanda.QUINTA_FEIRA:
                    DiaRetorno = "Quinta-Feira";
                    break;
                case DiaSemanda.SEXTA_FEIRA:
                    DiaRetorno = "Sexta-Feira";
                    break;
                case DiaSemanda.SABADO:
                    DiaRetorno = "Sábado";
                    break;
                default:
                    break;
            }

            return DiaRetorno;
        }

        public static string FormatHoras(TimeSpan Horario)
        {
            string Retorno = string.Empty;

            if (Horario.Ticks < 0)
            {
                Horario = new TimeSpan(Horario.Ticks * -1);

                Retorno = "-" + ((int)Horario.TotalHours).ToString("00") + ":" + Horario.Minutes.ToString("00") + ":" + Horario.Seconds.ToString("00");
            }
            else
            {
                Retorno = ((int)Horario.TotalHours).ToString("00") + ":" + Horario.Minutes.ToString("00") + ":" + Horario.Seconds.ToString("00");
            }

            return Retorno;
        }

        public static void MensagemAlerta(string Msg)
        {
            MessageBox.Show(Msg, "Marcação de Ponto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static string RetornaMes(int NumMes)
        {
            string Retorno = string.Empty;

            switch(NumMes)
            {
                case 1:
                    Retorno = "Janeiro";
                    break;
                case 2:
                    Retorno = "Fevereiro";
                    break;
                case 3:
                    Retorno = "Março";
                    break;
                case 4:
                    Retorno = "Abril";
                    break;
                case 5:
                    Retorno = "Maio";
                    break;
                case 6:
                    Retorno = "Junho";
                    break;
                case 7:
                    Retorno = "Julho";
                    break;
                case 8:
                    Retorno = "Agosto";
                    break;
                case 9:
                    Retorno = "Setembro";
                    break;
                case 10:
                    Retorno = "Outubro";
                    break;
                case 11:
                    Retorno = "Novembro";
                    break;
                case 12:
                    Retorno = "Dezembro";
                    break;
                default:
                    break;
            }

            return Retorno;
        }

        #endregion
    }
}
