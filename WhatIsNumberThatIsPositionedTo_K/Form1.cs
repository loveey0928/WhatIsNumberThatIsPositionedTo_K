using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatIsNumberThatIsPositionedTo_K
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class MainSolution
        {
            public int[] Solution(int[] array, int[,] commands)
            {
                int[] answer = new int[commands.Length];
                for (int i = 0; i < commands.Length; i++)
                {
                    int first = commands[i, 0];
                    int end = commands[i, 1];
                    int k = commands[i, 2];
                }
                return answer;
            }
        }
    }
}
