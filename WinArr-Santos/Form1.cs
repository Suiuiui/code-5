using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinArr_Santos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int[] setA = SetAtextBox.Text.Split(' ').Select(int.Parse).ToArray();
            int[] setB = SetBtextBox.Text.Split(' ').Select(int.Parse).ToArray();
            int[] intersection = setA.Intersect(setB).ToArray();
            Intersectionlbl.Text = String.Join(" ", intersection);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int[] setA = SetAtextBox.Text.Split(' ').Select(int.Parse).ToArray();
            int[] setB = SetBtextBox.Text.Split(' ').Select(int.Parse).ToArray();
            int[] Difference = setA.Except(setB).Concat(setB.Except(setA)).ToArray();
            Differencelbl.Text = String.Join(" ", Difference);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int[] setA = SetAtextBox.Text.Split(' ').Select(int.Parse).ToArray();
            int[] setB = SetBtextBox.Text.Split(' ').Select(int.Parse).ToArray();
            int[] SymmetricalDifference = setA.Except(setB).ToArray();
            SymmetricalDifferencelbl.Text = String.Join(" ", SymmetricalDifference);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int[] setA = SetAtextBox.Text.Split(' ').Select(int.Parse).ToArray();
            int[] setB = SetBtextBox.Text.Split(' ').Select(int.Parse).ToArray();
            int[] Union = setA.Union(setB).ToArray();
            Unionlbl.Text = String.Join(" ", Union);
        }
    }
}
