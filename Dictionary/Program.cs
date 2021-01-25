using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> student = new MyDictionary<string , int>();
            student.Add("Mehmet Uslu" ,154);
            student.Add("Ahmet Çalışkan",452);
            student.Add("Hakan Ünsal" ,753);

            student.List();

            student.Add("Arda Kurt", 545);
            student.List();

            


            


        }
    }
}
