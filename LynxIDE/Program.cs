﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LynxIDE
{
    static class Program
    {
        static void Main()
        {
            new Thread(() => { Application.Run(new Form1()); }).Start(); // UI Application
        }
    }
}
