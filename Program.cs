using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPConcepts1;
using ClassLibrary2;
using System.Collections;
using ApplicationDataManager;

namespace OOPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Application For demonstrating OOP Concepts****************" + "\n\n");

            #region Abstraction
            //An abstarct class cannot be instansiated
            //It is necessary to implement abstract methods in the derived class
            //to make a class abstratct use abstarct keyword same applies for method
            //An abstract method is implicitly virtual
            DerivedClass1 dvC = new DerivedClass1();
            dvC.Draw();

            AbstractClass1 absC = new DerivedClass1();
            absC.Draw();
            
            AbstractClass1.DispAbs();
            
            #endregion

            #region Interface
            Console.WriteLine("\n \n");
            DerivedClass1 objDev = new DerivedClass1();

           
                objDev.InterfaceCommMethod();
           
            //to access explicitly implemented method of interface we need to cast the derived class object
            // to Interface1.
            Interface1 interface1obj = new DerivedClass1();

            interface1obj.InterfaceCommMethod();

            #endregion

            ImplementClassnStructs();

           // int res = Class1.MessageBox();
          // Console.WriteLine("Extern Implementation result: " + res);

           

             Console.WriteLine("Constants are static by default:  " + ClassnStructs.x.ToString());

             ClassnStructs objclass = new ClassnStructs();

             Console.WriteLine("Readonly are assigned value at runtime:  " +
             ClassnStructs.y.ToString());

             Hashtable hashT = new Hashtable();

             hashT.Add("1", "Axis1");
             hashT.Add(2, "Axis2");

             Dictionary<Int32, String> dict1 = new Dictionary<int, string>();

             dict1.Add(1, "VAlue1");
             dict1.Add(2, "Value2");
            
             Console.WriteLine("Print Dictionary value for 1st element: " + dict1[1]);
             Console.WriteLine("Print Hashtable value for 1st element: " + hashT["1"].ToString());

             Tuple<Int32, String, Int64, Boolean> tup1 = GetAxisInfo();

             Console.WriteLine(tup1.Item1 + "\n" + tup1.Item2 + "\n" + tup1.Item3 + "\n" + tup1.Item4);

            //implementing multidimensional arrays
             int[,] multi = new int[3, 2] { { 1, 2}, { 44, 55} ,{7,8}};

            Console.WriteLine("\n \n" + "Press any key to exit");

            AppManager1.Display();
            AppManager1.DisplayMessage();

            AppManager1 appobj = new AppManager1();
            appobj.PrintPartialMethod();
            appobj.PrintPartialMethod1();

            ArrayList a1 = new ArrayList();

            a1.Add("dsfsd");
            a1.Add(9);

            Int32[] intarr = new Int32[] {12,10,2,3,5,2,4,5,6};

            Console.WriteLine(intarr[1]+"\n" + a1[1].ToString());

            


            List<Int32> intlist = new List<int>();
            intlist.Add(1);
            intlist.Add(89);
            intlist.Add(0);
            intlist.Add(9);

            intlist.Sort();

         

            Console.ReadLine();
        }

        static void ImplementClassnStructs()
        {
            try
            {
                //Implementing Structs
                Structure1 objS = new Structure1();
                objS.SName = "Init Struct Name";

                //Implementing Class
                ClassnStructs objC = new ClassnStructs();

                Type type = objC.GetType();

                Type t1 = typeof(ClassnStructs);


               // objS = null;
               // objC = null;

                MEthodToCNS(objC, objS);

                if (objC == null)
                {
                    throw new ArgumentNullException();
                }

                Console.WriteLine("\n\n" + objC.SName + "\n" + objS.SName);
            }

            catch (DivideByZeroException)
            {

               //Exception ex =new Exception("error");
                // throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
 
            }
           
        }

       static  void MEthodToCNS(ClassnStructs c1, Structure1 s1)
        {
            c1.SName = "Changing class property";

            s1.SName = "Changing struct property";
        }

       static Tuple<Int32, String, Int64, Boolean> GetAxisInfo()
       {
           Tuple<Int32, String, Int64, Boolean> tup = new Tuple<int,string,long,bool>(1,"Axis1",123456789,true) ;

           return tup;

          
       }

    }

    static class teststatic
    {
       // public int i;

        public static int r;
        
        //teststatic()
        //{
 
        //}

        //public void getname()
        //{
 
        //}

        public static void m1()
        {
 
        }
    }
}
