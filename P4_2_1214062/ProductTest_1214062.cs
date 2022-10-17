using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214062
{
    class ProductTest_1214062
    {
        static void Main(string[] args)
        {
            FIFA_1214062 product1 = new FIFA_1214062("FIFA", "Cristiano Ronaldo", "817");
            Soccer_1214062 product2 = new Soccer_1214062("Lionel Messi", "7");
            Football_1214062 product3 = new Football_1214062("Neymar Jr", "dazzling skill");
            LeftBack_1214062 product4 = new LeftBack_1214062("Roberto Carlos", "Real Madrid FC");
            GOAT_1214062 product5 = new GOAT_1214062("Cristiano Ronaldo and Lionel Messi", "12");

            Console.WriteLine("A Football Star {0}, \"{1}\" has {2} goals throughout his career", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("A {0} Star, \"{1}\" has {2} Ballon d'Ors throughout his career", product2.MyType, product2.MyTitle, product2.Duration);
            Console.WriteLine("A {0} Star, \"{1}\" has a very {2} in playing football", product3.MyType, product3.MyTitle, product3.Skill);
            Console.WriteLine("\"{1}\" is the best {0} in {2} of all time ", product4.MyType, product4.MyTitle, product4.LeftBack);
            Console.WriteLine("\"{1}\" is the best duo {0} of all time, who have a total of {2} Ballon d'Ors in their careers ", product5.MyType, product5.MyTitle, product5.GOAT);
        }
    }
}
