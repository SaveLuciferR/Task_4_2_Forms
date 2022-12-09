using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4_2_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void res(int n, int index = 1)
		{
			if (index > n)
			{
				return;
			}

			for (int i = index; i >= 1; i--)
			{
				textBox2.Text += i + "\t";
			}

			index++;
			textBox2.Text += "\r\n";

			res(n, index);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				textBox2.Text = "";

				int n = Convert.ToInt32(textBox1.Text);

				res(n);
			}
			catch
			{
				textBox2.Text = "Введите корректное значение";
			}
		}
	}
}
