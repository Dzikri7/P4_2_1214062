using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214062
{
    public class GOAT_1214062 : Product_1214062
    {
        protected string goat;

        public GOAT_1214062(string title, string goat)
        {
            this.MyTitle = title;
            this.MyType = "GOAT";
            this.goat = goat;

            //Console.WriteLine("Ini dari class GOAT");
        }

        public string GOAT
        {
            get
            {
                return goat;
            }

            set
            {
                goat = value;
            }
        }
    }
}
