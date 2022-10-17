using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214062
{
    public class FIFA_1214062: Product_1214062
    {
        protected string pageCount;

        public FIFA_1214062(string type, string title, string pageCount) : base(type, title)
        {
            this.pageCount = pageCount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }

            set
            {
                pageCount = value;
            }
        }
    }
}
