using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214062
{
    public class LeftBack_1214062 : Product_1214062
    {
        protected string leftBack;

        public LeftBack_1214062(string title, string leftBack)
        {
            this.MyTitle = title;
            this.MyType = "Left Back";
            this.leftBack = leftBack;

            //Console.WriteLine("Ini dari class LeftBack");
        }

        public string LeftBack
        {
            get
            {
                return leftBack;
            }

            set
            {
                leftBack = value;
            }
        }
    }
}
