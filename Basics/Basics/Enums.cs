using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    //declare the enum
    public enum ShippingMethod
    {
        Regular = 1,
        Registered = 2,
        Express = 3,
    }
    internal class enumClass
    {
        static public void getShippingMethod()
        {
            var method1 = ShippingMethod.Registered;
            Console.WriteLine(method1);
            var method2 = 3;
            //casting number equivalent into a ShippingMethod
            Console.WriteLine((ShippingMethod)method2);

            //parsing string that matches a enum type
            var method3 = "Regular";
            var newMethod3 = Enum.Parse(typeof(ShippingMethod), method3);

            Console.WriteLine(newMethod3);
        }
    }
}
