namespace ODP_Helper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_FastOdpRandomStr = new System.Windows.Forms.Button();
            this.textBox_FastOdpContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_FastOdpAES = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ClassicOdpRSA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ClassicOdpServer = new System.Windows.Forms.TextBox();
            this.textBox_ClassicOdpContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ClassicOdpAES = new System.Windows.Forms.TextBox();
            this.textBox_ODPRst = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 323);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_FastOdpRandomStr);
            this.tabPage1.Controls.Add(this.textBox_FastOdpContent);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_FastOdpAES);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(401, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fast-ODP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_FastOdpRandomStr
            // 
            this.button_FastOdpRandomStr.Location = new System.Drawing.Point(320, 262);
            this.button_FastOdpRandomStr.Name = "button_FastOdpRandomStr";
            this.button_FastOdpRandomStr.Size = new System.Drawing.Size(75, 21);
            this.button_FastOdpRandomStr.TabIndex = 11;
            this.button_FastOdpRandomStr.Text = "随机生成";
            this.button_FastOdpRandomStr.UseVisualStyleBackColor = true;
            this.button_FastOdpRandomStr.Click += new System.EventHandler(this.button_FastOdpRandomStr_Click);
            // 
            // textBox_FastOdpContent
            // 
            this.textBox_FastOdpContent.Location = new System.Drawing.Point(6, 6);
            this.textBox_FastOdpContent.Multiline = true;
            this.textBox_FastOdpContent.Name = "textBox_FastOdpContent";
            this.textBox_FastOdpContent.Size = new System.Drawing.Size(389, 241);
            this.textBox_FastOdpContent.TabIndex = 2;
            this.textBox_FastOdpContent.Text = "[在这里输入开车内容]";
            this.textBox_FastOdpContent.TextChanged += new System.EventHandler(this.textBox_FastOdpContent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "消息密码(AES)";
            // 
            // textBox_FastOdpAES
            // 
            this.textBox_FastOdpAES.Location = new System.Drawing.Point(95, 262);
            this.textBox_FastOdpAES.Name = "textBox_FastOdpAES";
            this.textBox_FastOdpAES.Size = new System.Drawing.Size(219, 21);
            this.textBox_FastOdpAES.TabIndex = 0;
            this.textBox_FastOdpAES.TextChanged += new System.EventHandler(this.textBox_FastOdpAES_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox_ClassicOdpRSA);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox_ClassicOdpServer);
            this.tabPage2.Controls.Add(this.textBox_ClassicOdpContent);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox_ClassicOdpAES);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(401, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classic-ODP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "随机生成";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "RSA Public Key";
            // 
            // textBox_ClassicOdpRSA
            // 
            this.textBox_ClassicOdpRSA.Location = new System.Drawing.Point(107, 239);
            this.textBox_ClassicOdpRSA.Name = "textBox_ClassicOdpRSA";
            this.textBox_ClassicOdpRSA.Size = new System.Drawing.Size(288, 21);
            this.textBox_ClassicOdpRSA.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "ODP-Server 地址";
            // 
            // textBox_ClassicOdpServer
            // 
            this.textBox_ClassicOdpServer.Location = new System.Drawing.Point(107, 212);
            this.textBox_ClassicOdpServer.Name = "textBox_ClassicOdpServer";
            this.textBox_ClassicOdpServer.Size = new System.Drawing.Size(288, 21);
            this.textBox_ClassicOdpServer.TabIndex = 6;
            this.textBox_ClassicOdpServer.Text = "sample.com:687";
            // 
            // textBox_ClassicOdpContent
            // 
            this.textBox_ClassicOdpContent.Location = new System.Drawing.Point(6, 10);
            this.textBox_ClassicOdpContent.Multiline = true;
            this.textBox_ClassicOdpContent.Name = "textBox_ClassicOdpContent";
            this.textBox_ClassicOdpContent.Size = new System.Drawing.Size(389, 196);
            this.textBox_ClassicOdpContent.TabIndex = 5;
            this.textBox_ClassicOdpContent.Text = "[在这里输入开车内容]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "消息密码(AES)";
            // 
            // textBox_ClassicOdpAES
            // 
            this.textBox_ClassicOdpAES.Location = new System.Drawing.Point(107, 266);
            this.textBox_ClassicOdpAES.Name = "textBox_ClassicOdpAES";
            this.textBox_ClassicOdpAES.Size = new System.Drawing.Size(207, 21);
            this.textBox_ClassicOdpAES.TabIndex = 3;
            // 
            // textBox_ODPRst
            // 
            this.textBox_ODPRst.Location = new System.Drawing.Point(427, 34);
            this.textBox_ODPRst.Multiline = true;
            this.textBox_ODPRst.Name = "textBox_ODPRst";
            this.textBox_ODPRst.Size = new System.Drawing.Size(351, 301);
            this.textBox_ODPRst.TabIndex = 1;
            this.textBox_ODPRst.Text = "[ODP 消息将在这里生成]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 347);
            this.Controls.Add(this.textBox_ODPRst);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soap | ODP 消息体生成工具";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_FastOdpContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FastOdpAES;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ClassicOdpRSA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ClassicOdpServer;
        private System.Windows.Forms.TextBox textBox_ClassicOdpContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ClassicOdpAES;
        private System.Windows.Forms.TextBox textBox_ODPRst;
        private System.Windows.Forms.Button button_FastOdpRandomStr;
        private System.Windows.Forms.Button button1;

    }
}

