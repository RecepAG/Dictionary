using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T1,T2>
    {

        T1[] studentName;
        T2[] studentNumber;

        public MyDictionary()
        {
            studentName = new T1[0];
            studentNumber = new T2[0];
        }

        public void Add(T1 studentNames, T2 studentNumbers)
        {
            T1[] tempStudentName = studentName;
            T2[] tempStudentNumber = studentNumber;

            studentName = new T1[studentName.Length + 1];
            studentNumber = new T2[studentNumber.Length + 1];

            for (int i = 0; i < tempStudentName.Length; i++)
            {
                studentName[i] = tempStudentName[i];
                studentNumber[i] = tempStudentNumber[i];
            }

            studentName[studentName.Length - 1] = studentNames;
            studentNumber[studentNumber.Length - 1] = studentNumbers;

            

        }
        public void List()
        {
            Console.WriteLine("List of Students");

            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine("Öğrenci No : " + studentNumber[i] + " Ad Soyad : "+studentName[i]);

            }
        }



    }
}
