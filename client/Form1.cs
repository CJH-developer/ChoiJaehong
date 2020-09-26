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

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data = { "레드", "핑크" };
            comboBox1.Items.AddRange(data);
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
                string[] data3 = { "캔디크러시(매트)", "캔디크러시(글로우)","과즙톡톡(매트)","과즙톡톡(글로우)",
                "크레용팝(매트)","크레용팝(글로우)" };

                comboBox2.Items.AddRange(data3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   int selectLip = comboBox1.SelectedIndex;
            //   string s = textBox1.Text;
            string strselect = comboBox2.Text;

            switch(strselect)
            {
                case "레드벨벳(매트)":
                    string packet1 = "BUYLIPSTIK_CNT1" + "\a";
                    packet1 += textBox1.Text;
                    client.SendDataOne(packet1);
                    break;

                case "레드벨벳(글로우)":
                    string packet2 = "BUYLIPSTIK_CNT2" + "\a";
                    packet2 += textBox1.Text;
                    client.SendDataOne(packet2);
                    break;


                case "딸기가좋아(매트)":
                    string packet3 = "BUYLIPSTIK_CNT3" + "\a";
                    packet3 += textBox1.Text;
                    client.SendDataOne(packet3);
                    break;


                case "딸기가 좋아(글로우)":
                    string packet4 = "BUYLIPSTIK_CNT4" + "\a";
                    packet4 += textBox1.Text;
                    client.SendDataOne(packet4);
                    break;


                case "체리필터(매트)":
                    string packet5 = "BUYLIPSTIK_CNT5" + "\a";
                    packet5 += textBox1.Text;
                    client.SendDataOne(packet5);
                    break;


                case "체리필터(글로우)":
                    string packet6 = "BUYLIPSTIK_CNT6" + "\a";
                    packet6 += textBox1.Text;
                    client.SendDataOne(packet6);
                    break;

                case "캔디크러시(매트)":
                    string packet7 = "BUYLIPSTIK_CNT7" + "\a";
                    packet7 += textBox1.Text;
                    client.SendDataOne(packet7);
                    break;

                case "캔디크러시(글로우)":
                    string packet8 = "BUYLIPSTIK_CNT8" + "\a";
                    packet8 += textBox1.Text;
                    client.SendDataOne(packet8);
                    break;
                case "과즙톡톡(매트)":
                    string packet9 = "BUYLIPSTIK_CNT9" + "\a";
                    packet9 += textBox1.Text;
                    client.SendDataOne(packet9);
                    break;

                case "과즙톡톡(글로우)":
                    string packet10 = "BUYLIPSTIK_CNT10" + "\a";
                    packet10 += textBox1.Text;
                    client.SendDataOne(packet10);
                    break;
                case "크레용팝(매트)":
                    string packet11 = "BUYLIPSTIK_CNT11" + "\a";
                    packet11 += textBox1.Text;
                    client.SendDataOne(packet11);
                    break;

                case "크레용팝(글로우)":
                    string packet12 = "BUYLIPSTIK_CNT12" + "\a";
                    packet12 += textBox1.Text;
                    client.SendDataOne(packet12);
                    break;
            }
            
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

    }
}
