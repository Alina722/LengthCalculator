using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void textCm_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM

            douCM = Convert.ToDouble(textCm.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            textM.Text = string.Format("{0:0.##########}", douCM / 100);
            textKm.Text = string.Format("{0:0.##########}", douCM / 10000);
            textIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
            textFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
            textYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
            //將douCM的數值除以100，也就是從公分轉換成公尺
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtM顯示結果
        }

        private void textM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM; 

            douM = Convert.ToDouble(textM.Text); 

            textCm.Text = string.Format("{0:0.##########}", douM / 0.01);
            textKm.Text = string.Format("{0:0.##########}", douM / 1000);
            textIn.Text = string.Format("{0:0.##########}", douM / 0.0254);
            textFt.Text = string.Format("{0:0.##########}", douM / 0.3048);
            textYard.Text = string.Format("{0:0.##########}", douM / 0.9144);
        }

        private void textKm_KeyUp(object sender, KeyEventArgs e)
        {
            double douKm; 
            douKm = Convert.ToDouble(textKm.Text); 

            textCm.Text = string.Format("{0:0.##########}", douKm / 0.00001);
            textM.Text = string.Format("{0:0.##########}", douKm / 0.001);
            textIn.Text = string.Format("{0:0.##########}", douKm / 0.0000254);
            textFt.Text = string.Format("{0:0.##########}", douKm / 0.0003048);
            textYard.Text = string.Format("{0:0.##########}", douKm / 0.0009144);
        }

        private void textIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn;
            douIn = Convert.ToDouble(textIn.Text);

            textCm.Text = string.Format("{0:0.##########}", douIn * 2.54);
            textM.Text = string.Format("{0:0.##########}", douIn * 0.0254);
            textKm.Text = string.Format("{0:0.##########}", douIn * 0.0000254);
            textFt.Text = string.Format("{0:0.##########}", douIn * 0.0833);
            textYard.Text = string.Format("{0:0.##########}", douIn * 0.0278);
        }

        private void textFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt;
            douFt = Convert.ToDouble(textFt.Text);

            textCm.Text = string.Format("{0:0.##########}", douFt * 30.48);
            textM.Text = string.Format("{0:0.##########}", douFt * 0.3048);
            textKm.Text = string.Format("{0:0.##########}", douFt * 0.0003048);
            textIn.Text = string.Format("{0:0.##########}", douFt * 12);
            textYard.Text = string.Format("{0:0.##########}", douFt * 0.3333);
        }

        private void textYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;
            douYard = Convert.ToDouble(textYard.Text);

            textCm.Text = string.Format("{0:0.##########}", douYard * 91.44);
            textM.Text = string.Format("{0:0.##########}", douYard * 0.9144);
            textKm.Text = string.Format("{0:0.##########}", douYard * 0.0009144);
            textIn.Text = string.Format("{0:0.##########}", douYard * 36);
            textFt.Text = string.Format("{0:0.##########}", douYard * 3);
        }
    }
}
