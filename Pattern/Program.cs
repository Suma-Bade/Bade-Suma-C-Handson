﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee= Singleton.GetInstance();
            fromEmployee.printDetails("employee");
            Singleton fromStudent =Singleton.GetInstance();
            fromStudent.printDetails("student");
            Console.ReadLine();
        }
    }
}
