using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
namespace _240312
{
    public partial class Form1 : Form
    {

        static Random random = new Random();   // 랜덤 수 생성

        //꼭 있어야하는 정보 밑에 4개 위에 한 개는 개체
        //내 서버 127.0.0.1
        //강사님 192.168.31.147
        private MySqlConnection conn;
        private string server = "192.168.31.147"; // 어떤 서버에
        private string database = "team4"; // 어떤 DB에 -> team4 스키마  // 내거 market_db
        //member table 생성 
        //mem_id 열 생성 CHAR(5) 설정

        private string uid = "root"; // 어떤 권한으로
        private string password = "0000";// 비밀번호  // 내 비밀번호는 root0000 // 강사님 0000
        
        public Form1()
        {
            InitializeComponent();
            //string y = textBox2.Text;
        }




        //1번 버튼 : 테이블 생성
        // 2번 버튼 : 위테이블에 1번 텍스트박스 값을 참조하여 테이블에 name필드에 행 추가를 하는 버튼
        // 1번 텍스트박스 : DB의 name필드에 들어갈 텍스트 입력하는 칸
        private void button1_Click(object sender, EventArgs e)
        {

            string table = textBox6.Text;
         //   string table2 = textBox9.Text;
            string connectionString = $"SERVER = {server}; DATABASE = {database}; UID={uid}; PASSWORD={password};";
            conn = new MySqlConnection(connectionString); // MYSQL로 만든 생성자 함수 conn이라 부름.
            string reservation = $"CREATE TABLE IF NOT EXISTS medical ( name VARCHAR(10) ,birth VARCHAR(10), age VARCHAR(5), date VARCHAR(10), pay VARCHAR(10), ok boolean)";  // 넣으려는 SQL문
           // string paydata = $"CREATE TABLE IF NOT EXISTS {table2} ( name VARCHAR(5) ,birth VARCHAR(10) PRIMARY KEY, age VARCHAR(3), date VARCHAR(20), pay VARCHAR(20), pay_data VARCHAR(2))";  // 넣으려는 SQL문

            if (make_connection())
            {
                MySqlCommand cmd = new MySqlCommand(reservation, conn);
              //  MySqlCommand cmd1 = new MySqlCommand(paydata, conn);

                cmd.ExecuteNonQuery();  //SQL문 실행
               // cmd1.ExecuteNonQuery();  //SQL문 실행
               
                conn.Close();//conn이라는 DB연결 객체를 해제
                MessageBox.Show("쿼리 전송 완료");
            }
            else
            {
                MessageBox.Show("쿼리 전송 실패");
            }

        }

        private bool make_connection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string time = textBox1.Text;
            string name = textBox2.Text;
            string birth = textBox3.Text;
            string phone = textBox4.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string city = textBox5.Text;
            string age = textBox7.Text;
            string receipt = textBox8.Text;

            string table = textBox6.Text;
           // string table2 = textBox9.Text;

            int RanNum = random.Next(1000, 200000);
            int RanNum2 = (RanNum / 100) * 100;
            string str = string.Format("{0:#,###}", RanNum2);


            string connectionString = $"SERVER = {server}; DATABASE = {database}; UID={uid}; PASSWORD={password};";
            conn = new MySqlConnection(connectionString); // MYSQL로 만든 생성자 함수 conn이라 부름.
            string rv = $"SELECT * FROM {table}";
            // string pd = $"SELECT * FROM {table2}";

            string reservation = $"INSERT INTO {table} VALUES ('{time}' ,'{name}', '{birth}', '{phone}', '{city}', '{date}')";  // 넣으려는 SQL문
           // string paydata = $"INSERT INTO {table2} VALUES ('{name}' ,'{birth}', '{age}', '{date}', '{str}', '{receipt}')";  // 넣으려는 SQL문
            if (make_connection())
            {
                MySqlCommand cmd = new MySqlCommand(reservation, conn);
              //  MySqlCommand cmd1 = new MySqlCommand(paydata, conn);
                MySqlCommand cmd2 = new MySqlCommand(rv, conn);
              //  MySqlCommand cmd3 = new MySqlCommand(pd, conn);

                cmd.ExecuteNonQuery();  //SQL문 실행
              //  cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
              //  cmd3.ExecuteNonQuery();
                MySqlDataReader reader = cmd2.ExecuteReader();
                string readString = "";
                while (reader.Read())
                {
                    readString += string.Format("{0},{1},{2},{3},{4}, {5}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5] + Environment.NewLine);
                }
                richTextBox1.Text = readString;
                conn.Close();//conn이라는 DB연결 객체를 해제
                MessageBox.Show("쿼리 전송 완료");
            }
            else
            {
                MessageBox.Show("쿼리 전송 실패");
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            string table = textBox6.Text;
           // string table2 = textBox9.Text;

            string connectionString = $"SERVER = {server}; DATABASE = {database}; UID={uid}; PASSWORD={password};";
            conn = new MySqlConnection(connectionString); // MYSQL로 만든 생성자 함수 conn이라 부름.
            string reservation = $"DROP TABLE  medical ";  // 넣으려는 SQL문
          //  string paydata = $"DROP TABLE  {table2} ";  // 넣으려는 SQL문
            if (make_connection())
            {
                MySqlCommand cmd = new MySqlCommand(reservation, conn);
             //   MySqlCommand cmd1 = new MySqlCommand(paydata, conn);
                cmd.ExecuteNonQuery();  //SQL문 실행
             //   cmd1.ExecuteNonQuery();  //SQL문 실행
                conn.Close();//conn이라는 DB연결 객체를 해제
                MessageBox.Show("쿼리 전송 완료");
            }
            else
            {
                MessageBox.Show("쿼리 전송 실패");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            string table = textBox6.Text;
          //  string table2 = textBox9.Text;

            string connectionString = $"SERVER = {server}; DATABASE = {database}; UID={uid}; PASSWORD={password};";
            conn = new MySqlConnection(connectionString); // MYSQL로 만든 생성자 함수 conn이라 부름.
            string reservation = $"SELECT * FROM {table}";
           // string paydata = $"SELECT * FROM {table2}";

   
            if (make_connection())
            {
                MySqlCommand cmd = new MySqlCommand(reservation, conn);
             //   MySqlCommand cmd1 = new MySqlCommand(paydata, conn);
   

                cmd.ExecuteNonQuery();  //SQL문 실행
             //   cmd1.ExecuteNonQuery();  //SQL문 실행
                MySqlDataReader reader = cmd.ExecuteReader();
                string readString = "";
                while (reader.Read())
                {
                    readString += string.Format("{0},{1},{2},{3},{4}, {5}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5] + Environment.NewLine);
                }
                richTextBox1.Text = readString;
                conn.Close();//conn이라는 DB연결 객체를 해제
                MessageBox.Show("쿼리 전송 완료");
            }
            else
            {
                MessageBox.Show("쿼리 전송 실패");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;

            string table = textBox6.Text;
           // string table2 = textBox9.Text;

            string connectionString = $"SERVER = {server}; DATABASE = {database}; UID={uid}; PASSWORD={password};";
            conn = new MySqlConnection(connectionString); // MYSQL로 만든 생성자 함수 conn이라 부름.
            string reservation = $"SELECT * FROM {table}";
           // string paydata = $"SELECT * FROM {table2}";

            string reservation22 = $"DELETE FROM {table} where (name='{a}')";  // 넣으려는 SQL문
            //string paydata22 = $"DELETE FROM {table2} where (name='{a}')";  // 넣으려는 SQL문
            if (make_connection())
            {
                MySqlCommand cmd = new MySqlCommand(reservation, conn);
             //   MySqlCommand cmd1 = new MySqlCommand(paydata, conn);
                MySqlCommand cmd2 = new MySqlCommand(reservation22, conn);
              //  MySqlCommand cmd3 = new MySqlCommand(paydata22, conn);

                cmd.ExecuteNonQuery();  //SQL문 실행
             //   cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
              //  cmd3.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                string readString = "";
                while (reader.Read())
                {
                    readString += string.Format("{0},{1},{2},{3},{4}, {5}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5] + Environment.NewLine);
                }
                richTextBox1.Text = readString;
                conn.Close();//conn이라는 DB연결 객체를 해제
                MessageBox.Show("쿼리 전송 완료");
            }
            else
            {
                MessageBox.Show("쿼리 전송 실패");
            }
        }
    }
   

}
