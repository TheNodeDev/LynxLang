using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LynxIDE
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text =
                "LynxLang is a programming language similar to assembly in syntax, it uses different commands to access memory and output to the console, currently, it is only available as an interpreted language through this IDE, but i am working on allowing these scripts to be compiled through porting them to c++ on runtime and compiling to windows or any platform, however for now you can save and load files by sharing the 'saved.lynxlang' file in the IDE's Directory and load the script in the IDE via the 'LOAD' Button.\n\n\nLynxLang uses Seperate commands on seperate lines to edit, increse, decrese, and access the stack, (all of these commands are detailed in the rightmost text box) these commands are all in caps, and the loop commands ending in ? to show they aren't operator commands\n\nLynxlang uses the idea of a Stack and 2 accumulators, with commands allowing the user to increase, decrease, set to 0 and to push these 2 accumulators (accumulators work like a number, having a single value), a stack is a stack of numbers, you can add numbers to it, and you can take the first number off, however you cannot take or see any numbers that are below the top one";

            richTextBox2.Text =
                "This section details the commands you can use so far:\n\nINC1:\nIncrease accumulator by 1\n\nPUSH:\nPush the value of accumulator 1 into the stack\n\nPOP:\nDelete the topmost value in the stack\n\nPRINTCHAR:\nTake the top value of the stack and print out the char value of that number\n\nREAD:\nTake single character input from the user and puts it to the top of the stack\n\nPRINTNUM:\nPrints the value of the top of the stack to the console without it becoming an ascii character\n\nDEC1:\nDecrease the value of accumulator 1\n\nMOVPOP:\nmove the top value of the stack into accumulator 1\n\nNUL1/NUL2:\nSet the value of accumulator 1/2 respectively to 0\n\nINC10:\nIncrement accumulator 1 value by 10\n\nINC20:\nIncrement accumulator 2 value by 10\n\nDEC2:\nDecrease the value in accumulator 2 by 1\n\nSTART?:\nStart a loop, sets the loop back point to there\n\nLOOP?:\nIf the value at the top of the stack isn't equal to accumulator 2, it will loop back to the previous START? command";
        }
    }
}
