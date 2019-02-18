using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreatorRedo
{
    class Pizza
    {
        public string Size
        {
            get { return _size ?? ""; }
            set { _size = value;  }   
        }
        private string _size;

        public string Meats
        {
            get { return _meats ?? ""; }
            set { _meats = value; }
        }
        private string _meats = "";

        public string Vegetables
        {
            get { return _vegetables ?? ""; }
            set { _vegetables = value; }
        }
        private string _vegetables;











    }
}
