using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Emgu.CV.Structure;

namespace Club_Project
{
    public partial class MainForm : Form
    {
        Image<Bgr, Byte> openImg;

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            startPanel.Visible = true;
            b2t_Panel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e) // 홈 버튼 클릭시
        {
            b2t_Panel.Visible = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b2t_Icon_Click(object sender, EventArgs e)
        {
            b2t_Panel.Visible = true;
        }

        private void t2b_Icon_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void b2t_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void b2t_openButton_Click_1(object sender, EventArgs e)
        {
            string openstrFilename;

            ImageOpen.Title = "이미지 읽기";
            ImageOpen.Filter = "All Files(*.*)|*.*|Bitmap File(*.bmp)|*.bmp|JPEG File(*.jpg)|*.jpg";

            // 다이얼로그의 확인 처리
            if (ImageOpen.ShowDialog() == DialogResult.OK)
            {
                openstrFilename = ImageOpen.FileName;
                openImg = new Image<Bgr, byte>(openstrFilename);
                b2t_openImageBox.Image = openImg;
                //b2t_openImageBox.Visible = true;
            }
        }

        private void b2t_openImageBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
