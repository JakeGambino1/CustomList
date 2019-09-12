using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> listTest = new CustomList<int>();
            listTest.Add(1);
            listTest.Add(2);
            listTest.Add(3);

            string str = listTest[2].ToString();
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
