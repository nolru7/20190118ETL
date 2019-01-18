using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += btn_event;
            button2.Click += btn_event;

        }

        private void btn_event(object o,EventArgs a)
        {
            Button btn = (Button)o;
            switch(btn.Name)
            {
                case "button1":
                    dev();
                    break;
                case "button2":
                    manage();
                    break;
                default:
                    break;

            }
            
        }

        private bool dev()
        {
            try
            {
                MessageBox.Show("dev");
                string strConnection =
                    string.Format("server={0};user={1};password={2};database={3}", "192.168.3.122", "root", "1234","test");

                MySqlConnection conn = GetConnection(strConnection);
                if (conn == null)
                {
                    MessageBox.Show("접속 오류");
                    return false;
                }
                MessageBox.Show("접속 성공");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool manage()
        {
            try
            {
                MessageBox.Show("man");
                string strConnection = 
                    string.Format("server={0};user={1};password={2};database={3}", "192.168.3.149", "root", "1234","gudi");

                MySqlConnection conn = GetConnection(strConnection);
                if(conn == null)
                {
                    MessageBox.Show("접속 오류");
                    return false;
                }
                MessageBox.Show("접속 성공");

                return true;
            }
            catch 
            {
                return false;
            }
        }

        private MySqlConnection GetConnection(string strConnection)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = strConnection;
                return conn;
            }
            catch 
            {
                return null;
            }
        }
    }
}
