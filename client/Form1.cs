using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;

namespace client
{
    public partial class Form1 : MetroForm
    {
        Client client;

        public Form1()
        {
            InitializeComponent();
            client = new Client(this, "127.0.0.1", 7000);

            string msg = "";
            String[] packet = msg.Split('\a');
            /*
            string packet = "MEMBERADD" + "\a";
            packet += "test#";
            packet += "test#";
            client.SendDataOne(packet);
            */
        }

        public void RecvData(String msg)
        {
            //Console.WriteLine(msg);
            String[] packet = msg.Split('\a');
            String[] packet1 = null;
            if (packet.Length > 1)
            {
                packet1 = packet[1].Split('#');
            }
            
            if (packet[0] == "BUYLIPSTIK_1")
            {
                //MessageBox.Show(packet1[1].ToString());

                //if (packet1[1] == id)
                //    Console.WriteLine(packet1[1] + "회원가입 성공");
            }
            else if (packet[0] == "ACK_MEMBERADD_F")
            {
                MessageBox.Show(packet1[1].ToString());
                //if (packet1[1] == id)
                //    Console.WriteLine(packet1[1] + "회원가입 실패");
            }
            //추가할 부분
        }
        void Db(string o)
        {
            string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                             "(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))" +
                             ";User Id=scott;Password=TIGER;";



            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = o;

            cmd.ExecuteNonQuery();


            conn.Close();
        }

        Point p;
        Bitmap b;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] data = { "레드", "핑크" };
            comboBox1.Items.AddRange(data);


            b = (Bitmap)Bitmap.FromFile(@"C:\temp_two\1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = b;

            b = (Bitmap)Bitmap.FromFile(@"C:\temp_two\2.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = b;

            b = (Bitmap)Bitmap.FromFile(@"C:\temp_two\3.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = b;

            b = (Bitmap)Bitmap.FromFile(@"C:\temp_two\4.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = b;


            b = (Bitmap)Bitmap.FromFile(@"C:\temp_two\5.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = b;

            b = (Bitmap)Bitmap.FromFile(@"C:\temp_two\6.jpg");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = b;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                string[] data2 = { "레드벨벳(매트)", "레드벨벳(글로우)", "딸기가좋아(매트)",
                "딸기가 좋아(글로우)","체리필터(매트)","체리필터(글로우)" };

                comboBox2.Items.AddRange(data2);
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                string[] data3 = { "캔디크러시(매트)", "캔디크러시(글로우)","과즙톡톡(글로우)","과접톡톡(글로우)",
                "크레용팝(매트)","크레용팝(글로우)" };

                comboBox2.Items.AddRange(data3);
            }
        }


        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
  

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   int selectLip = comboBox1.SelectedIndex;
         //   string s = textBox1.Text;


            string packet = "BUYLIPSTIK_CNT" + "\a";
            packet += textBox1.Text;
            client.SendDataOne(packet);

            
            string packet1 = "BUYLIPSTIK_NOTICE" + "\a";
            packet1 += "주문이 들어왔습니다.";
            client.SendDataOne(packet1);

            /*
            if (selectLip == 0)
            {   

                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(체리)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(빨강)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '레드벨벳(메트)'");
            }

            else if (selectLip == 1)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(체리)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(빨강)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '레드벨벳(글로우)'");
            }
            else if (selectLip == 2)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(딸기)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(빨강)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '딸기가 좋아(메트)'");
            }
            else if (selectLip == 3)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(딸기)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(빨강)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '딸기가 좋아(글로우)'");
            }

            else if (selectLip == 4)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(체리)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(빨강)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '체리필터(메트)'");
            }


            else if (selectLip == 5)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(체리)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(빨강)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '체리필터(글로우)'");
            }

            int selectLip2 = comboBox2.SelectedIndex;

            if (selectLip2 == 0)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(사과)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(핑크)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '캔디크러시(메트)'");
            }
            else if (selectLip2 == 1)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(사과)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(핑크)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '캔디크러시(글로우)'");
            }
            else if (selectLip2 == 2)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(사과)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(핑크)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '과즙톡톡(메트)'");
            }
            else if (selectLip2 == 3)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(사과)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(핑크)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '과즙톡톡(글로우)'");
            }
            else if (selectLip2 == 4)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(딸기)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(핑크)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '크레용팝(메트)'");
            }
            else if (selectLip2 == 5)
            {
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '켄텔릴라왁스'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '유동 파라핀'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '안료'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '향료(딸기)'");
                Db($"update material_tb set material_count =material_count-({s})*20 where material_name = '색소(핑크)'");
                Db($"update lipstik_tb set lipstik_cnt =lipstik_cnt - ({s}) where lipstik_name = '크레용팝(글로우)'");
            }*/




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
