using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) //메인화면이 시작되었을 때 첫 화면
        {
            string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=scott;Password=TIGER;";

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = ($"select * from lipstik_tb");

            OracleDataReader rdr = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();


            while (rdr.Read())

            {

                string Code = rdr["lipstik_code"] as string;

                string Name = rdr["lipstik_name"] as string;

                string Cnt = rdr["lipstik_cnt"].ToString();

                string Price = rdr["lipstik_price"].ToString();

                string[] rw = new string[] { Code, Name, Cnt, Price };

                dataGridView1.Rows.Add(rw);

            }

        }

       

        private void btn_FSitu_Click(object sender, EventArgs e) //공정상황 폼으로 이동
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

      

        private void btn_Sel_Click(object sender, EventArgs e) //검색버튼을 눌렀을 시, 조회
        {
            string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=scott;Password=TIGER;";

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
           
            if (Mat_tb.Text.Equals(""))
            {
                
                cmd.CommandText = ($"select * from lipstik_tb where lipstik_name like '{Lib_tb.Text}%'");
              
                OracleDataReader rdr = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                

                while (rdr.Read())

                {
                   
                    string Code = rdr["lipstik_code"] as string;
                    
                    string Name = rdr["lipstik_name"] as string;
                    
                    string Cnt = rdr["lipstik_cnt"].ToString();
                    
                    string Price = rdr["lipstik_price"].ToString();
                   
                    string[] rw = new string[] { Code, Name, Cnt, Price };
                  
                    dataGridView1.Rows.Add(rw);
                  
                }
            }
          
            else if (Lib_tb.Text.Equals("")) 
            {
               
                cmd.CommandText = ($"select * from material_tb where material_name like '{Mat_tb.Text}%'");

                OracleDataReader rfr = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (rfr.Read())
                {
                    string Code = rfr["material_code"] as string;

                    string Name = rfr["material_name"] as string;

                    string Count = rfr["material_count"] as string;

                    string Sel = rfr["self_life"] as string;

                    string[] rs = new string[] { Code, Name, Count, Sel };
                    dataGridView1.Rows.Add(rs);
                }
            }

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_DSitu_Click(object sender, EventArgs e) //입출고현황 폼으로 이동
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }
    }
}
