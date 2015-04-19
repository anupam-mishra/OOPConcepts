using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPConcepts
{
    //an abstract class cannot be sealed or static
    public abstract class AbstractClass1
    {
        public static string _name;
        public AbstractClass1()//by default class members are private hence to make it instantiable we need to make it public
        {
 
        }

        public  abstract void Draw();
                
        //Using a static method as abstratc class cannot be instantiated
        public static void DispAbs()
        {
            Console.WriteLine("I am in Abstract class but not abstract");
        }

        protected void MethodAdd1()
        {
 
        }

        public abstract void CHeckAbs();


    }
}
