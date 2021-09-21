using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LynxIDE
{
    public partial class Form1 : Form
    {
        string[] words = {
                "INC1",
                "PUSH",
                "POP",
                "PRINTCHAR",
                "READ",
                "PRINTNUM",
                "RANDPOP",
                "DEC1",
                "MOVPOP",
                "NUL1",
                "NUL2",
                "INC10",
                "INC20",
                "DEC2",
                "START?",
                "LOOP?"
            };
        Color[] Colors =
        {
                    Color.Red,
                    Color.Blue,
                    Color.Purple,
                    Color.Green,
                    Color.Yellow,
                    Color.Cyan,
                    Color.Black,
                    Color.White,
                    Color.Brown,
                    Color.Lime,
                    Color.Pink,
                    Color.Orange,
                    Color.Gray,
                    Color.YellowGreen,
                    Color.DarkMagenta,
                    Color.PeachPuff,
                    Color.PeachPuff
            };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] file = richTextBox1.Text.Split('\n');
            BuildTools.RunScript(file);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("./saved.lynxlang", richTextBox1.Text.Split('\n'));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(File.Exists("./saved.lynxlang"))
            {
                richTextBox1.Text = File.ReadAllText("saved.lynxlang");
            }
            runSyntaxHighlighting();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HelpForm helpform = new HelpForm();
            helpform.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            runSyntaxHighlighting();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //runSyntaxHighlighting();
            }
        }
        private void runSyntaxHighlighting()
        {
            if (!checkBox1.Checked)
                return;
            int i = 0;
            foreach (string word in words)
            {
                int startindex = 0;
                while (startindex < richTextBox1.TextLength)
                {
                    int wordstartIndex = richTextBox1.Find(word, startindex, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        richTextBox1.SelectionStart = wordstartIndex;
                        richTextBox1.SelectionLength = word.Length;
                        richTextBox1.SelectionColor = Colors[i];
                    }
                    else
                        break;
                    startindex += wordstartIndex + word.Length;
                }
                i++;
            }
            richTextBox1.Select(richTextBox1.Text.Length, 0);
            richTextBox1.SelectionColor = richTextBox1.ForeColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
