using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214062
{
    public class Football_1214062 : Product_1214062
    {
        protected string skill;

        public Football_1214062(string title, string skill)
        {
            this.MyTitle = title;
            this.MyType = "Football";
            this.skill = skill;

            //Console.WriteLine("Ini dari class Football");
        }

        public string Skill
        {
            get
            {
                return skill;
            }

            set
            {
                skill = value;
            }
        }
    }
}
