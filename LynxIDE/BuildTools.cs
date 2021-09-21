using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynxIDE
{
    class BuildTools
    {
        public static void RunScript(String[] lines)
        {
            Stack<int> stack = new Stack<int>();
            int accum1 = 0;
            int accum2 = 0;

            int loopline = -1;

            int i = 0;
            while(i < lines.Count())
            {
                String line = lines[i].Split(' ')[0];
                //Console.WriteLine(line);
                switch(line)
                {
                    case "INC1":
                        accum1++;
                        break;
                    case "PUSH":
                        stack.Push(accum1);
                        break;
                    case "POP":
                        try
                        {
                            stack.Pop();
                        }
                        catch { }
                        break;
                    case "PRINTCHAR":
                        try
                        {
                            Console.WriteLine((char)stack.Pop());
                        }
                        catch { }
                        break;
                    case "READ":
                        stack.Push(Console.ReadKey().KeyChar);
                        break;
                    case "PRINTNUM":
                        
                        Console.WriteLine(stack.Pop());
                        break;
                    case "DEC1":
                        accum1--;
                        break;
                    case "MOVPOP":
                        try
                        {
                            accum1 = stack.Pop();
                        }
                        catch { }
                        break;
                    case "NUL1":
                        accum1 = 0;
                        break;
                    case "INC10":
                        accum1 += 10;
                        break;
                    case "INC20":
                        accum2 += 10;
                        break;
                    case "DEC2":
                        accum2--;
                        break;
                    case "NUL2":
                        accum2 = 0;
                        break;
                    case "START?":
                        loopline = i;
                        break;
                    case "LOOP?":
                        try
                        {
                            if (stack.Peek() != accum2)
                            {
                                i = loopline;
                            }
                        }
                        catch { i = loopline; }
                        break;
                }
                i++;
            }
        }
    }
}
