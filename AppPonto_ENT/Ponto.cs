using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace AppPonto_ENT
{
    public enum DiaSemanda
    {
        DOMINGO = 01,
        SEGUNDA_FEIRA = 02,
        TERÇA_FEIRA = 03,
        QUARTA_FEIRA = 04,
        QUINTA_FEIRA = 05,
        SEXTA_FEIRA = 06,
        SABADO = 07
    }

    public class ColecaoPonto : Collection<Ponto> { };

    [Serializable]
    public class Ponto
    {
        private DateTime _Data;
        private DiaSemanda _DiaSemana;
        private string _HoraEntrada;
        private string _HoraSaidaAlmoco;
        private string _HoraRetornoAlmoco;
        private string _HoraSaida;
        private string _TotalHora;
        private string _DiferencaTotalHora;
        private char _Feriado;
        private char _Ferias;
        private char _Folga;
        private string _LembreteHoraEntrada;
        private string _LembreteHoraSaidaAlmoco;
        private string _LembreteHoraRetornoAlmoco;
        private string _LembreteHoraSaida;

        public DateTime Data
        {
            get { return _Data; }
            set { _Data = value; }
        }
        public DiaSemanda DiaSemana
        {
            get { return _DiaSemana; }
            set { _DiaSemana = value; }
        }
        public string HoraEntrada
        {
            get { return _HoraEntrada; }
            set { _HoraEntrada = value; }
        }
        public string HoraSaidaAlmoco
        {
            get { return _HoraSaidaAlmoco; }
            set { _HoraSaidaAlmoco = value; }
        }
        public string HoraRetornoAlmoco
        {
            get { return _HoraRetornoAlmoco; }
            set { _HoraRetornoAlmoco = value; }
        }
        public string HoraSaida
        {
            get { return _HoraSaida; }
            set { _HoraSaida = value; }
        }
        public string TotalHora
        {
            get { return _TotalHora; }
            set { _TotalHora = value; }
        }
        public string DiferencaTotalHora
        {
            get { return _DiferencaTotalHora; }
            set { _DiferencaTotalHora = value; }
        }
        public char Feriado
        {
            get { return _Feriado; }
            set { _Feriado = value; }
        }
        public char Ferias
        {
            get { return _Ferias; }
            set { _Ferias = value; }
        }
        public char Folga
        {
            get { return _Folga; }
            set { _Folga = value; }
        }
        public string LembreteHoraEntrada
        {
            get { return _LembreteHoraEntrada; }
            set { _LembreteHoraEntrada = value; }
        }
        public string LembreteHoraSaidaAlmoco
        {
            get { return _LembreteHoraSaidaAlmoco; }
            set { _LembreteHoraSaidaAlmoco = value; }
        }
        public string LembreteHoraRetornoAlmoco
        {
            get { return _LembreteHoraRetornoAlmoco; }
            set { _LembreteHoraRetornoAlmoco = value; }
        }
        public string LembreteHoraSaida
        {
            get { return _LembreteHoraSaida; }
            set { _LembreteHoraSaida = value; }
        }
    }
}
