namespace Club_Project
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.startPanel = new System.Windows.Forms.Panel();
            this.b2t_Panel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b2t_openButton = new System.Windows.Forms.PictureBox();
            this.b2t_openImageBox = new Emgu.CV.UI.ImageBox();
            this.b2t_Icon = new System.Windows.Forms.PictureBox();
            this.t2b_Icon = new System.Windows.Forms.PictureBox();
            this.ImageOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.startPanel.SuspendLayout();
            this.b2t_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2t_openButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2t_openImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2t_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2b_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleName = "homePanel";
            this.splitContainer1.Panel1.Controls.Add(this.homeIcon);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleName = "mainPanel";
            this.splitContainer1.Panel2.Controls.Add(this.startPanel);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(738, 375);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // homeIcon
            // 
            this.homeIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeIcon.Location = new System.Drawing.Point(0, 0);
            this.homeIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(738, 41);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeIcon.TabIndex = 0;
            this.homeIcon.TabStop = false;
            this.homeIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.b2t_Panel);
            this.startPanel.Controls.Add(this.b2t_Icon);
            this.startPanel.Controls.Add(this.t2b_Icon);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPanel.Location = new System.Drawing.Point(0, 0);
            this.startPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(738, 332);
            this.startPanel.TabIndex = 2;
            this.startPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.startPanel_Paint);
            // 
            // b2t_Panel
            // 
            this.b2t_Panel.Controls.Add(this.richTextBox1);
            this.b2t_Panel.Controls.Add(this.pictureBox1);
            this.b2t_Panel.Controls.Add(this.b2t_openButton);
            this.b2t_Panel.Controls.Add(this.b2t_openImageBox);
            this.b2t_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b2t_Panel.Location = new System.Drawing.Point(0, 0);
            this.b2t_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b2t_Panel.Name = "b2t_Panel";
            this.b2t_Panel.Size = new System.Drawing.Size(738, 332);
            this.b2t_Panel.TabIndex = 2;
            this.b2t_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.b2t_Panel_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(461, 6);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 322);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(344, 150);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // b2t_openButton
            // 
            this.b2t_openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b2t_openButton.Location = new System.Drawing.Point(355, 62);
            this.b2t_openButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b2t_openButton.Name = "b2t_openButton";
            this.b2t_openButton.Size = new System.Drawing.Size(25, 0);
            this.b2t_openButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b2t_openButton.TabIndex = 3;
            this.b2t_openButton.TabStop = false;
            this.b2t_openButton.Click += new System.EventHandler(this.b2t_openButton_Click_1);
            // 
            // b2t_openImageBox
            // 
            this.b2t_openImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b2t_openImageBox.BackColor = System.Drawing.SystemColors.Control;
            this.b2t_openImageBox.Location = new System.Drawing.Point(6, 6);
            this.b2t_openImageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b2t_openImageBox.Name = "b2t_openImageBox";
            this.b2t_openImageBox.Size = new System.Drawing.Size(267, 320);
            this.b2t_openImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b2t_openImageBox.TabIndex = 2;
            this.b2t_openImageBox.TabStop = false;
            this.b2t_openImageBox.Click += new System.EventHandler(this.b2t_openImageBox_Click);
            // 
            // b2t_Icon
            // 
            this.b2t_Icon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b2t_Icon.Location = new System.Drawing.Point(285, 75);
            this.b2t_Icon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b2t_Icon.Name = "b2t_Icon";
            this.b2t_Icon.Size = new System.Drawing.Size(169, 39);
            this.b2t_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b2t_Icon.TabIndex = 0;
            this.b2t_Icon.TabStop = false;
            this.b2t_Icon.Click += new System.EventHandler(this.b2t_Icon_Click);
            // 
            // t2b_Icon
            // 
            this.t2b_Icon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t2b_Icon.Location = new System.Drawing.Point(285, 225);
            this.t2b_Icon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.t2b_Icon.Name = "t2b_Icon";
            this.t2b_Icon.Size = new System.Drawing.Size(169, 39);
            this.t2b_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.t2b_Icon.TabIndex = 1;
            this.t2b_Icon.TabStop = false;
            this.t2b_Icon.Click += new System.EventHandler(this.t2b_Icon_Click);
            // 
            // ImageOpen
            // 
            this.ImageOpen.FileName = "openFileDialog1";
            this.ImageOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 375);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "B&T";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.startPanel.ResumeLayout(false);
            this.b2t_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2t_openButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2t_openImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2t_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2b_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox b2t_Icon;
        private System.Windows.Forms.PictureBox t2b_Icon;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Panel b2t_Panel;
        private System.Windows.Forms.OpenFileDialog ImageOpen;
        private Emgu.CV.UI.ImageBox b2t_openImageBox;
        private System.Windows.Forms.PictureBox b2t_openButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

