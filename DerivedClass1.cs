using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPConcepts1;

namespace OOPConcepts
{
    public class DerivedClass1:AbstractClass1,Interface1,Interface2
    {

        //it is necessary to use "override keyword else abstarct method impemention is not considered and compiler throws an error"
        public override void Draw()
        {
            Console.WriteLine("Implementing Draw in derived class ");

            MethodAdd1();
        }

        public override void CHeckAbs()
        {

        }

        public void InterfaceCommMethod()
        {
            Console.WriteLine("Interface2 comm method called");
        }

         string Interface1.Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void Interface1.InterfaceCommMethod()
        {
            Console.WriteLine("Interface1 comm method called");
        }

        string Interface1.GetName()
        {
            return "Hello Manjushree";
        }
    }

    public class DerivedClass2 : AbstractClass1
    {
        public override void CHeckAbs()
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Implementing Draw in derived class ");

            MethodAdd1();
        }
    }
}
