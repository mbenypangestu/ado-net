using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabungan
{
    class User
    {
        private string name;
        private string passwd;
        private Tabungan tabungan;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Passwd
        {
            get
            {
                return passwd;
            }

            set
            {
                passwd = value;
            }
        }

        internal Tabungan Tabungan
        {
            get
            {
                return tabungan;
            }

            set
            {
                tabungan = value;
            }
        }
    }
}
