using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Lists
    {
        static public void AboutLists()
        {
            var list = new List<string>() { "Gus","Aline","Lisa"};
            var newList = new string[list.Count];
            list.CopyTo(newList);

            for(int i = 0; i < newList.Length; i++) 
            {
                if (newList[i].StartsWith("G"))
                    newList[i] = newList[i].Replace("G", "D");
                Console.WriteLine(newList[i]);
            }

            list.ForEach(x =>
            {
                if (x.StartsWith("G"))
                   x =  x.Replace("G", "D");
                Console.WriteLine(x);
            });

        }
    }
}
