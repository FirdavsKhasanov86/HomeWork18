using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace HomeWork18
{
    class Program
    {

        static void Main(string[] args)
        {

        //Задание 2
        //    List<string> myList= new List<string>() { "Notebook", "Phone", "TV", "IPad" };
        //    myList.Add("MacBooK");
        //    string electronics = myList[0];
        //    int count = myList.Count();
        //    Console.WriteLine("Length:" + count);
        //    foreach (var x in myList)
        //    {
        //          Console.WriteLine(myList.IndexOf(x) + "." + x);
        //    }

        //Задание 3
         Dictionary<int, string>  car = new Dictionary<int, string>() { { 2018, "Camry" }, { 2015, "BMW" }, {2019, "Lexus"} };
         car.Add(2016,"Prado");
         string model = car.ElementAt(0).Value;
         int count = car.Count();
         Console.WriteLine("Length:" + count);
         foreach (var y in car)
         {
           Console.WriteLine("Key:" + y.Key + "," + "Value:" + y.Value);
         }
          Console.ReadKey();
          
        }

        
    }

}

