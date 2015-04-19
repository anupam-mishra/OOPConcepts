using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPConcepts
{
    class ClassnStructs
    {
        Int32 Student_id;
        String Strudent_Name;

        public  const Int32 x = 90;
        public static readonly Int32 y = 100;

        public ClassnStructs()
        {
           // y = 900;
        }
        static ClassnStructs()
        {
            Console.WriteLine("Static constructor is trigerred for class");
            y = 900;

            
        }

        ~ClassnStructs()
        {
            Console.WriteLine("Destructor is called");
        }

       public String SName
        {
            get { return Strudent_Name; }
            set { Strudent_Name = value; }

        }

       


        void GetStudentName()
        {
            Console.WriteLine("Kishore");

            //y = 80;

        }

        void GetStudentId()
        {
            Console.WriteLine("123");
        }
    }

    struct Structure1
    {
        Int32 Student_id;
        String Strudent_Name;

        static Structure1()
        {
            Console.WriteLine("Structure static Constructor is triggered ");
        }

       public String SName
        {
            get { return Strudent_Name; }
            set { Strudent_Name = value; }

        }

       public void GetStudentName()
        {
            Console.WriteLine("Kishore");
        }

        void GetStudentId()
        {
            Console.WriteLine("123");
        }
    }

    struct Structure2  
    {
        
    }

   enum Days
   {
       Monday,
       TuesDay
   }

   public abstract class c1
   {
 
   }

}
