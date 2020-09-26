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


    public partial class Form3 : MetroForm
    {
        public delegate void FormSendDataHandler(string sendstring);
        public event FormSendDataHandler FormSendEvent;

        public Form3()
        {
            InitializeComponent();
        }
        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=scott;Password=TIGER;";

        private void Form3_Load(object sender, EventArgs e)
        {
           
           
        }

        private void CB_Kind_SelectedIndexChanged(object sender, EventArgs e)
        {

           

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string s = CB_Kind.Text;
            string material_count = tb_Orcnt.Text;

            cmd.CommandText = $"select material_count from material_tb where material_name='{s}'";


            cmd.ExecuteNonQuery();
            OracleDataReader rdr = cmd.ExecuteReader();

            StringBuilder sb = new StringBuilder();

            while (rdr.Read())

            {

                string jnum = rdr["material_count"].ToString();

                sb.Append(jnum);



                TB_stock.Text = sb.ToString();

            }

            conn.Close();


        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            try
            {

                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                string s = CB_Kind.Text;
                string material_count = tb_Orcnt.Text;

                cmd.CommandText = $"update material_tb set material_count = ({material_count})+(select material_count from(select material_count from material_tb where material_name='{s}')a)where material_name='{s}'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"select material_count from material_tb where material_name='{s}'";


                cmd.ExecuteNonQuery();
                OracleDataReader rdr = cmd.ExecuteReader();

                StringBuilder sb = new StringBuilder();

                while (rdr.Read())

                {

                    string jnum = rdr["material_count"].ToString();

                    sb.Append(jnum);



                    TB_stock.Text = sb.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("입고에 실패하였습니다.");
            }

            this.FormSendEvent(CB_Kind.Text);

            this.Close();
        }
        public void EventMethod(string str)
        {

        }

    }
}