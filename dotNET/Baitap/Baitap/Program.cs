﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.OutputEncoding = Encoding.Unicode; 
            Console.InputEncoding = Encoding.Unicode;
            Person nv = new Person();
            nv.Input("Nguyễn Lương Hùng", "Thai Nguyen");
            nv.Display();
        }
    }
}
