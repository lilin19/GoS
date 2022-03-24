using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace GoS
{
    public partial class Form1 : Form
    {
        Game go = new Game("A", "B", 19, 0);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string input = Input.Text;

            Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
            Match result = re.Match(input);

            string xstring = result.Groups[1].Value;
            string ystring = result.Groups[2].Value;
            int y = int.Parse(ystring);
            int x = xaxis(xstring);
            go.Play(x, y);
            string test = "";
            foreach (Sck sck in go.Situation)
            {
                test += (sck.color.ToString() + sck.position[0].ToString() + "," + sck.position[1].ToString() + " ");
            }
            Status.Text = test;

        }
        int xaxis(string x)
        {
            switch (x)
            {
                case "a":
                    return 1;
                case "b":
                    return 2;
                case "c":
                    return 3;
                case "d":
                    return 4;
                case "e":
                    return 5;
                case "f":
                    return 6;
                case "g":
                    return 7;
                case "h":
                    return 8;
                case "i":
                    return 9;
                case "j":
                    return 10;
                case "k":
                    return 11;
                case "l":
                    return 12;
                case "m":
                    return 13;
                case "n":
                    return 14;
                case "o":
                    return 15;
                case "p":
                    return 16;
                case "q":
                    return 17;
                case "r":
                    return 18;
                case "s":
                    return 19;
            
            }
            return 0;
        }
    }
}
