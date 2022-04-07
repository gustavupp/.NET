using System;


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

            Lists.AboutLists();


        }
    }
}