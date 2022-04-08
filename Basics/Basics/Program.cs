using System;
using System.Collections.Generic;


namespace Basics 
{
    class Program
    {

        static void Main(string[] args)
        {

            //Enums
            //enumClass.getShippingMethod();

            //reference vs value types

            //value type
            var myAge = 10;
            ReferenceVsValueTypes.Increment(myAge);
            //Console.WriteLine(myAge); //doest change the value of MyAge within this scope

            //reference type
            Person gus = new Person("Gus", 31);
            ReferenceVsValueTypes.MakeOlder(gus);
            //Console.WriteLine(gus.age); //changes the value since both here and inside the method they point to the same object in memory

            //Arrays.AboutArrays();

            //Lists.AboutLists();

            //Constructors
            var myCustomer = new Costumer("Gustavo", 31);

            //Object initializer
            var otherCostumer = new Costumer { Name = "Gus", Id = 31 };

            //Params Modifier
            //Console.WriteLine( Calculator.AddNums(1,2,3,4));
            //Console.WriteLine(Calculator.AddNums(new int[] {1,2,3,4}));

            //Indexers
            var cookie = new  HttpCookie();
            cookie["name"] = "GusCookie";
            Console.WriteLine(cookie["name"]);

            //Dictionary
            var myDictionary = new Dictionary<string, string>()
            {
                {"Fname","Gussoo" },
                { "Lname", "Pereira" }
            };
            myDictionary["Fname"] = "Gustavo";

            Console.WriteLine($"Full Name: {myDictionary["Fname"]} {myDictionary["Lname"]}");


            }

    }
}