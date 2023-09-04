using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;
using AssemblyA;

[assembly: InternalsVisibleTo("AssemblyB")]

namespace AssemblyA
{
    public class MyClass
    {
        internal MyClass()
        {
            Console.WriteLine("Internal constructor called from Assembly A");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Public method called from Assembly A");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        myObject.PublicMethod();
    }
}
