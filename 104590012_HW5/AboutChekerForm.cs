using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTest
{
    internal class AboutCheckerModelForm : Form
    {
        private const String COMMA = ",";
        private const String LINK_1 = "http://www.ntut.edu.tw/bin/home.php";
        private const String LINK_2 = "http://csie.ntut.edu.tw/csie/index_i.htm";
        private const String MOUSE = "@";
        private const String TEXT_1 = "About Spelling Checker";
        private const String TEXT_2 = "Spelling Checker 1000 Words";
        private const String TEXT_3 = "CSIE";
        private const String TEXT_4 = "NTUT";
        private const String TEXT_5 = "All rights reserved";
        private const String TEXT_6 = "莊文翊";

        /// <summary>
        /// 顯示所有label text或是圖示
        /// </summary>
        public AboutCheckerModelForm()
        {
            GetTextOne();
            GetTextTwo();
            GetMouse();
            GetTextThree();
            GetComma();
            GetTextFour();
            GetTextFive();
            GetTextSix();
            GetPicture();
            GetButton();
        }

        /// <summary>
        /// 關閉視窗
        /// </summary>
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 取得按鈕
        /// </summary>
        private void GetButton()
        {
            Button close = new Button();
            close.Text = "OK";
            close.Click += Close;
            const int X9 = 120;
            const int Y9 = 150;
            close.Location = new System.Drawing.Point(X9, Y9);
            Controls.Add(close);
        }

        /// <summary>
        /// 取得，
        /// </summary>
        private void GetComma()
        {
            Label comma = new Label();
            comma.Text = COMMA;
            comma.AutoSize = true;
            const int X = 105;
            const int Y = 60;
            comma.Location = new System.Drawing.Point(X, Y);
            Controls.Add(comma);
        }

        /// <summary>
        /// 取得@
        /// </summary>
        private void GetMouse()
        {
            Label mouse = new Label();
            mouse.Text = MOUSE;
            mouse.AutoSize = true;
            const int X = 60;
            const int Y = 60;
            mouse.Location = new System.Drawing.Point(X, Y);
            Controls.Add(mouse);
        }

        /// <summary>
        /// 取得圖片
        /// </summary>
        private void GetPicture()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            PictureBox picture = new PictureBox();
            picture.Image = global::_104590012_HW2.Properties.Resources.word_icon;
            const int X2 = 5;
            const int Y2 = 40;
            picture.Location = new System.Drawing.Point(X2, Y2);
            const int X3 = 39;
            const int Y3 = 40;
            picture.Size = new System.Drawing.Size(X3, Y3);
            Controls.Add(picture);
        }

        /// <summary>
        /// 取得All rights reserved
        /// </summary>
        private void GetTextFive()
        {
            Label line4 = new Label();
            line4.Text = TEXT_5;
            line4.AutoSize = true;
            const int X7 = 60;
            const int Y7 = 90;
            line4.Location = new System.Drawing.Point(X7, Y7);
            Controls.Add(line4);
        }

        /// <summary>
        /// 取得NTUT
        /// </summary>
        private void GetTextFour()
        {
            LinkLabel line3 = new LinkLabel();
            line3.Text = TEXT_4;
            line3.AutoSize = true;
            const int X6 = 115;
            const int Y6 = 60;
            line3.Location = new System.Drawing.Point(X6, Y6);
            Controls.Add(line3);
            line3.Click += Link2;
        }

        /// <summary>
        /// 取得About Spelling Checker
        /// </summary>
        private void GetTextOne()
        {
            this.Text = TEXT_1;
            this.ControlBox = false;
            const int X1 = 250;
            const int Y1 = 250;
            this.Size = new System.Drawing.Size(X1, Y1);
        }

        /// <summary>
        /// 取得name
        /// </summary>
        private void GetTextSix()
        {
            Label line5 = new Label();
            line5.Text = TEXT_6;
            line5.AutoSize = true;
            const int X8 = 60;
            const int Y8 = 120;
            line5.Location = new System.Drawing.Point(X8, Y8);
            Controls.Add(line5);
        }

        /// <summary>
        /// 取得CSIE
        /// </summary>
        private void GetTextThree()
        {
            LinkLabel line2 = new LinkLabel();
            line2.Text = TEXT_3;
            line2.AutoSize = true;
            const int X5 = 75;
            const int Y5 = 60;
            line2.Location = new System.Drawing.Point(X5, Y5);
            Controls.Add(line2);
            line2.Click += Link1;
        }

        /// <summary>
        /// 取得Spelling Checker 1000 Words
        /// </summary>
        private void GetTextTwo()
        {
            Label line1 = new Label();
            line1.Text = TEXT_2;
            line1.AutoSize = true;
            const int X4 = 60;
            const int Y4 = 30;
            line1.Location = new System.Drawing.Point(X4, Y4);
            Controls.Add(line1);
        }

        /// <summary>
        /// CSIE
        /// </summary>

        private void Link1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(LINK_2);
        }

        /// <summary>
        /// NTUT
        /// </summary>
        private void Link2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(LINK_1);
        }

        // 初始
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AboutCheckerModelForm
            // 
            this.AccessibleName = "AboutSpellingChecker";
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "AboutCheckerModelForm";
            this.ResumeLayout(false);

        }
    }
}