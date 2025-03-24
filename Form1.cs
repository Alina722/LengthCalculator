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
                textM.Text = string.Format("{0:0.##########}", douOutput / 100);
                textKm.Text = string.Format("{0:0.##########}", douOutput / 100000);
                textIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                textFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                textYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                textInfo.Text = "請輸入數字";
                textCm.Text = "";
            }
        }

        private void textM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                textCm.Text = string.Format("{0:0.##########}", douOutput / 0.01);
                textKm.Text = string.Format("{0:0.##########}", douOutput / 1000);
                textIn.Text = string.Format("{0:0.##########}", douOutput / 0.0254);
                textFt.Text = string.Format("{0:0.##########}", douOutput / 0.3048);
                textYard.Text = string.Format("{0:0.##########}", douOutput / 0.9144);
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
                textCm.Text = string.Format("{0:0.##########}", douOutput / 0.00001);
                textM.Text = string.Format("{0:0.##########}", douOutput / 0.001);
                textIn.Text = string.Format("{0:0.##########}", douOutput / 0.0000254);
                textFt.Text = string.Format("{0:0.##########}", douOutput / 0.0003048);
                textYard.Text = string.Format("{0:0.##########}", douOutput / 0.0009144);
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
                textCm.Text = string.Format("{0:0.##########}", douOutput * 2.54);
                textM.Text = string.Format("{0:0.##########}", douOutput * 0.0254);
                textKm.Text = string.Format("{0:0.##########}", douOutput * 0.0000254);
                textFt.Text = string.Format("{0:0.##########}", douOutput * 0.0833);
                textYard.Text = string.Format("{0:0.##########}", douOutput * 0.0278);
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
                textCm.Text = string.Format("{0:0.##########}", douOutput * 30.48);
                textM.Text = string.Format("{0:0.##########}", douOutput * 0.3048);
                textKm.Text = string.Format("{0:0.##########}", douOutput * 0.0003048);
                textIn.Text = string.Format("{0:0.##########}", douOutput * 12);
                textYard.Text = string.Format("{0:0.##########}", douOutput * 0.3333);
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
                textCm.Text = string.Format("{0:0.##########}", douOutput * 91.44);
                textM.Text = string.Format("{0:0.##########}", douOutput * 0.9144);
                textKm.Text = string.Format("{0:0.##########}", douOutput * 0.0009144);
                textIn.Text = string.Format("{0:0.##########}", douOutput * 36);
                textFt.Text = string.Format("{0:0.##########}", douOutput * 3);
            }
            else
            {
                textInfo.Text = "請輸入數字";
                textYard.Text = "";
            }
        }
    }
}
