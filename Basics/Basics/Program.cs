using System;


namespace Basics 
{
    class Program
    {
        static void Main(string[] args)
        {
            //casting

            //if convertions won't lose data, and types are compatible, you CAN convert.
            byte b = 1; //byte datatype has 1 byte
            int c = b; //int datatype has 4 bytes

            //if might lose data, it won't convert implicitly, you have to CAST.
            int d = 1;
            byte e = (byte)d;

            //converting uncompatible data types
            string s = "1";
            int x = int.Parse(s);
            //or
            int y = Convert.ToInt32(s);

            //joining array items
            var arrayOfInt = new int[5] { 1,2,3,4,5 };
            string list = string.Join(", ", arrayOfInt);

            //Console.WriteLine(list);

            //Verbatim strings
            string msg = "Check this url: /n /t http:///path//path//file";
            string verbatimMsg = @"Check this url:
    http://path/path/file";

            //Console.WriteLine($"msg: {msg}, verbatimMsg: {verbatimMsg}");

            //Enums
            //enumClass.getShippingMethod();
        }

      
    }
}