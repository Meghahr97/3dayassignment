using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PizzaOrder> po = new List<PizzaOrder>
            {
                new PizzaOrder
                {OrderID=101, OrderDate=DateTime.Now, PizzaType="veg", PizzaSize='s', toppings="sweetcorn",qty=4,price=100 },
                new PizzaOrder
                { OrderID=102, OrderDate=DateTime.Now, PizzaType="nonveg", PizzaSize='m', toppings="egg",qty=3,price=300},
                new PizzaOrder
                 {OrderID=103, OrderDate=DateTime.Now, PizzaType="veg", PizzaSize='l', toppings="sweetcorn",qty=4,price=50 },

            };
            //to display all
            var data = from t in po
                       select t;

            foreach (var d in data)
                Console.WriteLine(d.OrderID + " " + d.OrderDate + " " + d.PizzaSize + " " + d.PizzaSize +" " +d.toppings +" " +d.qty +" " +d.price);
            Console.WriteLine("********");


            //display all pizza based on size and type

            var data6 = from t in po
                        select new { ptype = t.PizzaType, psize = t.PizzaSize };
            foreach (var d in data6)
                Console.WriteLine(d.ptype + " " + d.ptype);
            Console.WriteLine("**********");


            //for maxprice
            var data1 = from t in po
                        where t.price == po.Max(x => x.price)
                        select t;

            foreach (var d in data1)
                Console.WriteLine(d.OrderID + " " + d.OrderDate + " " + d.PizzaSize + " " + d.PizzaType + " " + d.toppings + " " + d.qty + " " + d.price);

            //for min price

            var data2 = from t in po
                        where t.price == po.Min(y => y.price)
                        select t;

            foreach (var d in data2)
                Console.WriteLine(d.OrderID + " " + d.OrderDate + " " + d.PizzaSize + " " + d.PizzaType + " " + d.toppings + " " + d.qty + " " + d.price);


            //to display pizza type and topings where pizza size = m

            var data3 = from t in po
                        where t.PizzaSize=='m'
                        select new { pizzaType = t.PizzaType, toppings = t.toppings };
                        


            foreach (var d in data3)
                Console.WriteLine(d.pizzaType + " " + d.toppings);
            Console.WriteLine("***********");

            //display count of pizza sold, amount collected group by pizza size

            var data5 = from t in po
                        group t by t.PizzaType into grp
                        select new { ptype = grp.Key, sumQty = grp.Sum(x => x.qty), amount = grp.Sum(y => y.price) };
            foreach (var d in data5)
                Console.WriteLine(d.sumQty + " " + d.ptype + " " + d.amount);

            Console.WriteLine("***********");

            //

            var data8 = from t in po
                        group t by t.PizzaSize into grp
                        select new { ptype = grp.Key, sumQty = grp.Sum(x => x.qty), amount = grp.Sum(y => y.price) };
            foreach(var d in data8)
                Console.WriteLine(d.sumQty + " " + d.ptype + " " + d.amount);
            Console.WriteLine("***********");





        }
    }
}
