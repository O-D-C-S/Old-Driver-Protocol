namespace ODPGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ResourcetextBox = new System.Windows.Forms.TextBox();
            this.singleImagecheckBox = new System.Windows.Forms.CheckBox();
            this.ODPMsgtextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ResourcetextBox
            // 
            this.ResourcetextBox.Location = new System.Drawing.Point(12, 87);
            this.ResourcetextBox.Multiline = true;
            this.ResourcetextBox.Name = "ResourcetextBox";
            this.ResourcetextBox.Size = new System.Drawing.Size(329, 109);
            this.ResourcetextBox.TabIndex = 0;
            this.ResourcetextBox.Text = "[在这里输入 资源/需求]";
            this.ResourcetextBox.TextChanged += new System.EventHandler(this.ResourcetextBox_TextChanged);
            // 
            // singleImagecheckBox
            // 
            this.singleImagecheckBox.AutoSize = true;
            this.singleImagecheckBox.Location = new System.Drawing.Point(12, 65);
            this.singleImagecheckBox.Name = "singleImagecheckBox";
            this.singleImagecheckBox.Size = new System.Drawing.Size(240, 16);
            this.singleImagecheckBox.TabIndex = 1;
            this.singleImagecheckBox.Text = "资源是一个单独的图片，我稍后自己添加";
            this.singleImagecheckBox.UseVisualStyleBackColor = true;
            this.singleImagecheckBox.CheckedChanged += new System.EventHandler(this.singleImagecheckBox_CheckedChanged);
            // 
            // ODPMsgtextBox
            // 
            this.ODPMsgtextBox.Location = new System.Drawing.Point(347, 12);
            this.ODPMsgtextBox.Multiline = true;
            this.ODPMsgtextBox.Name = "ODPMsgtextBox";
            this.ODPMsgtextBox.Size = new System.Drawing.Size(444, 208);
            this.ODPMsgtextBox.TabIndex = 3;
            this.ODPMsgtextBox.Text = "[ODP 消息将在这里生成]";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "声明资源类型";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Old Driver",
            "Passengers"});
            this.comboBox1.Location = new System.Drawing.Point(64, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "[在这里选择]";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "我是...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "PlainText";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(12, 204);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(150, 16);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "添加 ODP Ending(推荐)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 232);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ODPMsgtextBox);
            this.Controls.Add(this.singleImagecheckBox);
            this.Controls.Add(this.ResourcetextBox);
            this.Name = "Form1";
            this.Text = "ODP 消息生成器 | ODP v0.2alpha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResourcetextBox;
        private System.Windows.Forms.CheckBox singleImagecheckBox;
        private System.Windows.Forms.TextBox ODPMsgtextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

