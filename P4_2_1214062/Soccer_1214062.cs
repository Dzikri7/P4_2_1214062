using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214062
{
    public class Soccer_1214062 : Product_1214062
    {
        protected string duration;

        public Soccer_1214062(string title, string duration)
        {
            this.MyTitle = title;
            this.MyType = "Soccer";
            this.duration = duration;

            //Console.WriteLine("Ini dari class Soccer");
        }

        public string Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }
    }
}
