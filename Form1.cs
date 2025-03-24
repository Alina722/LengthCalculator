using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strInput;
        double douOutput;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textCm.Text = "";
            textM.Text = "";
            textKm.Text = "";
            textIn.Text = "";
            textFt.Text = "";
            textYard.Text = "";
        }

        private void textCm_KeyUp(object sender, KeyEventArgs e)
        {

            strInput = textCm.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                CaculateAnswer(0, douOutput);
            }
            else
            {
                textInfo.Text = "請輸入數字";
                textCm.Text = "";
            }
        }

        private void textM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                CaculateAnswer(1, douOutput * 100);
            }
            else
            {
                textInfo.Text = "請輸入數字";
                textM.Text = "";
            }
        }

        private void textKm_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textKm.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                CaculateAnswer(2, douOutput * 100000);
            }
            else
            {
                textInfo.Text = "請輸入數字";
                textKm.Text = "";
            }
        }

        private void textIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textIn.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                CaculateAnswer(3, douOutput * 2.54);
            }
            else
            {
                textInfo.Text = "請輸入數字";
                textIn.Text = "";
            }
        }

        private void textFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textFt.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                CaculateAnswer(4, douOutput * 30.48);
            }
            else
            {
                textInfo.Text = "請輸入數字";
                textFt.Text = "";
            }
        }

        private void textYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textYard.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                CaculateAnswer(4, douOutput * 91.44);
            }
            else
            {
                textInfo.Text = "請輸入數字";
                textYard.Text = "";
            }
        }
        private void CaculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                textCm.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                textM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != 2)
                textKm.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                textIn.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != 4)
                textFt.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != 5)
                textYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }
    }
}
