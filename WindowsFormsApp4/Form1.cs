﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
  public partial class Form1 : Form
  {
    int[] Mas = new int[15];
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      textBox1.Text = "";
      for (int i = 0; i < 15; i++)
      {
        Mas[i] = rand.Next(-50, 50);
        textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
        + Convert.ToString(Mas[i]) + Environment.NewLine;

      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox2.Text = "";
      for (int i = 0; i < 15; i++)
      {
        if (i % 2 == 0) Mas[i] = Mas[i] + 1;
        else Mas[i] = Mas[i] + 2;
        textBox2.Text += "Mas[" + Convert.ToString(i) + "] = "
        + Convert.ToString(Mas[i]) + Environment.NewLine;
      }
    }
  }
}
