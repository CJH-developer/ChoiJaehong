using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : MetroForm
    {

        public Form2()
        {
            InitializeComponent();
        }
        
        private void btn_input_Click(object sender, EventArgs e)//입고창으로 이동
        {
            string strselect = Ma_input.Text;

            switch (strselect)
            {
                case "재료"://재료 입고창으로 이동
                    {
                        Form3 form3 = new Form3();
                        form3.FormSendEvent += new Form3.FormSendDataHandler(DieaseUpdateEventMethod);
                        form3.Show();
                        
                    }
                    break;
                case "안료"://안료 입고창으로 이동
                    {
                        Form4 form4 = new Form4();
                        form4.FormSendEvent += new Form4.FormSendDataHandler(DieaseUpdateEventMethod);
                        form4.Show();
                    }
                    break;
                case "향료"://향료 입고창으로 이동
                    {
                        Form5 form5 = new Form5();
                        form5.FormSendEvent += new Form5.FormSendDataHandler(DieaseUpdateEventMethod);
                        form5.Show();
                    }
                    break;
                case "색소"://색소 입고창으로 이동
                    {
                        Form6 form6 = new Form6();
                        form6.FormSendEvent += new Form6.FormSendDataHandler(DieaseUpdateEventMethod);
                        form6.Show();
                    }
                    break;
            }
           

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            TB_Mat.Visible = false;
            TB_Pig.Visible = false;
            TB_Perf.Visible = false;
            TB_Col.Visible = false;
        }

        private void DieaseUpdateEventMethod(object sender)//입고창에서 데이터 불러오기
        {
            string strSelect = Ma_input.Text;

            switch (strSelect)
            {
                case "재료":
                    TB_Mat.Text = sender.ToString();
                    break;
                case "안료":
                    TB_Pig.Text = sender.ToString();
                    break;
                case "향료":
                    TB_Mat.Text = sender.ToString();
                    break;
                case "색소":
                    TB_Pig.Text = sender.ToString();
                    break;
            }

            
            
        }




        private void TB_Mat_TextChanged(object sender, EventArgs e)//재료 이동
        {

            int w, h;

            w = pb1.Location.X.GetHashCode();
            h = pb1.Location.Y.GetHashCode();

            int i, j;
            i = 80;
            j = 88;
            
            pb1.Location = new Point(i, j);
            while (j < 180)

            {
                j += 10;
                Thread.Sleep(10);
                pb1.Location = new Point(i, j);
            }
            while (i < 300)
            {
                i += 10;
                Thread.Sleep(7);
                pb1.Location = new Point(i, j);
            }

            i = 70;
            j = 70;
            
            pb1.Location = new Point(i, j);

            
        }

        private void TB_Pig_TextChanged(object sender, EventArgs e)//안료 이동
        {
            int w1, h1;

            w1 = pb2.Location.X.GetHashCode();
            h1 = pb2.Location.Y.GetHashCode();

            int i1, j1;

            i1 = 210;
            j1 = 70;

            pb2.Location = new Point(i1, j1);

            while (j1 < 180)

            {
                j1 += 10;
                Thread.Sleep(10);
                pb2.Location = new Point(i1, j1);
            }
            while (i1 < 300)
            {
                i1 += 10;
                Thread.Sleep(7);
                pb2.Location = new Point(i1, j1);
            }

            i1 = 210;
            j1 = 70;

            pb2.Location = new Point(i1, j1);
        }
        
        private void TB_Col_TextChanged(object sender, EventArgs e)//색소 이동
        {

        }

        private void TB_Perf_TextChanged(object sender, EventArgs e)//향료 이동
        {

        }
    }
}

