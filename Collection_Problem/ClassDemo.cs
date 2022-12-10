using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Problem
{
    public class ClassDemo
    {
        public void Demo()
        {
            Dictionary<int,string> list = new Dictionary<int,string>();
            list.Add(1,"Ramchandra");
            list.Add(2,"Mahesh");
            list.Add(3,"Sachin");
            list.Add(4,"Sanjeev");
            Console.WriteLine("\nAccess Value Using Key (key=1) :" + list[1]);

            foreach (var element in list)
            {
                Console.WriteLine($"key ={element.Key} & Value = {element.Value}");
            }
        }
    }
}
