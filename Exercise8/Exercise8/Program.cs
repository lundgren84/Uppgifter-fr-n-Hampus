﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Logg("Logg 1----First post");
            logger.Logg("Logg 2.....second .... post");
            logger.ReadLog();
            Console.ReadKey();
        }
    }
}
