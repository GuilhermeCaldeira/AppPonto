using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace AppPonto_ENT
{
    public class ColecaoRelatorioPonto : Collection<RelatorioPonto> { };

    [Serializable]
    public class RelatorioPonto
    {
        private DateTime _Data;
        private string _DiaSemana;
        private TimeSpan? _DiferencaInicial;
        private TimeSpan? _HoraEntrada;
        private TimeSpan? _HoraSaidaAlmoco;
        private TimeSpan? _HoraRetornoAlmoco;
        private TimeSpan? _HoraSaida;
        private string _TotalHora;
        private string _DiferencaTotalHora;

        private string _TotalHorasDia;
        private string _TotalHorasSabado;
        private string _TotalHorasSemanais;
        private string _TotalHorasMes;
        private string _TotalHorasTrabalhadas;
        private string _TotalDiferencaHoras;
        private string _TotalDiferencaInicial;

        public DateTime Data
        {
            get { return _Data; }
            set { _Data = value; }
        }
        public string DiaSemana
        {
            get { return _DiaSemana; }
            set { _DiaSemana = value; }
        }
        public TimeSpan? DiferencaInicial
        {
            get { return _DiferencaInicial; }
            set { _DiferencaInicial = value; }
        }
        public TimeSpan? HoraEntrada
        {
            get { return _HoraEntrada; }
            set { _HoraEntrada = value; }
        }
        public TimeSpan? HoraSaidaAlmoco
        {
            get { return _HoraSaidaAlmoco; }
            set { _HoraSaidaAlmoco = value; }
        }
        public TimeSpan? HoraRetornoAlmoco
        {
            get { return _HoraRetornoAlmoco; }
            set { _HoraRetornoAlmoco = value; }
        }
        public TimeSpan? HoraSaida
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

        public string TotalHorasDia
        {
            get { return _TotalHorasDia; }
            set { _TotalHorasDia = value; }
        }
        public string TotalHorasSabado
        {
            get { return _TotalHorasSabado; }
            set { _TotalHorasSabado = value; }
        }
        public string TotalHorasSemanais
        {
            get { return _TotalHorasSemanais; }
            set { _TotalHorasSemanais = value; }
        }
        public string TotalHorasMes
        {
            get { return _TotalHorasMes; }
            set { _TotalHorasMes = value; }
        }
        public string TotalHorasTrabalhadas
        {
            get { return _TotalHorasTrabalhadas; }
            set { _TotalHorasTrabalhadas = value; }
        }
        public string TotalDiferencaHoras
        {
            get { return _TotalDiferencaHoras; }
            set { _TotalDiferencaHoras = value; }
        }
        public string TotalDiferencaInicial
        {
            get { return _TotalDiferencaInicial; }
            set { _TotalDiferencaInicial = value; }
        }
    }
}
