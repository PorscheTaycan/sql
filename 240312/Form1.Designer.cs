namespace _240312
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "create table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 83);
            this.button2.TabIndex = 1;
            this.button2.Text = "생성";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 145);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 67);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "ㅇ시간";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(463, 229);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(353, 64);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "이름";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 92);
            this.button3.TabIndex = 4;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(463, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(576, 117);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(463, 315);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(353, 63);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "생년월일";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(463, 405);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(353, 55);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "핸드폰번호";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(63, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 80);
            this.button4.TabIndex = 8;
            this.button4.Text = "조회\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(63, 449);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 70);
            this.button5.TabIndex = 9;
            this.button5.Text = "행 삭제\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(463, 478);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(353, 56);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "주소";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(63, 538);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 21);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(463, 565);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(353, 58);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "나이";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(463, 654);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(353, 56);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "수납여부";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(63, 582);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(168, 21);
            this.textBox9.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 722);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}

