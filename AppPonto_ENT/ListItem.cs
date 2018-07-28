using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace AppPonto_ENT
{
    [Serializable]
    public class ColecaoFiltroMes : Collection<ListItem> { };

    [Serializable]
    public class ListItem
    {
        private string _Value;
        private string _ValueAux;
        private string _Text;

        public string Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        public string ValueAux
        {
            get { return _ValueAux; }
            set { _ValueAux = value; }
        }
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }        
    }
}
