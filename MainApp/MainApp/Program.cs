﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userModule = new UserManagementModule();
            userModule.ManageUser("Rohit Kokare");
            Console.ReadKey();
        }
    }
}