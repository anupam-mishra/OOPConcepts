using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPConcepts1
{
    interface Interface1
    {
        //Interfaces cannot contain fields
       // public string _Name;

       // public int _id;

        String Name { get; set; }

        void InterfaceCommMethod();

        String GetName();

    }
}
