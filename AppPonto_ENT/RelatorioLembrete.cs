using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace AppPonto_ENT
{
    public class ColecaoRelatorioLembrete : Collection<RelatorioLembrete> { };

    [Serializable]
    public class RelatorioLembrete
    {
        private DateTime _DataLembrete;
        private string _DiaSemanaLembrete;
        private TimeSpan? _Hora;
        private string _Lembrete;

        public DateTime DataLembrete
        {
            get { return _DataLembrete; }
            set { _DataLembrete = value; }
        }
        public string DiaSemanaLembrete
        {
            get { return _DiaSemanaLembrete; }
            set { _DiaSemanaLembrete = value; }
        }
        public TimeSpan? Hora
        {
            get { return _Hora; }
            set { _Hora = value; }
        }
        public string Lembrete
        {
            get { return _Lembrete; }
            set { _Lembrete = value; }
        }
    }
}
