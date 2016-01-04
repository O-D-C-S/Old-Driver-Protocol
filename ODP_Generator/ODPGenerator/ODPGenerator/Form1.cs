using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODPGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ODPVersion = "0.2alpha";

        private enum ODPCharacter
        {
            OldDriver = 0,
            Passenger = 1
        }

        #region ODPMessageRender
        ODPCharacter _ODP_character = ODPCharacter.OldDriver;
        bool _ODP_singleImage = false;
        bool _ODP_TypeDefined = true;
        bool _ODP_ENDING = true;
        #endregion

        private void singleImagecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (singleImagecheckBox.Checked)
            {
                ResourcetextBox.Enabled = false;
                ResourcetextBox.Text = "[在这里放置一个图片]";
                textBox1.Text = "Image";
                _ODP_singleImage = true;
            }
            else
            {
                ResourcetextBox.Enabled = true;
                ResourcetextBox.Text = "";
                _ODP_singleImage = false;
            }
            renderODPMessage();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                _ODP_character = ODPCharacter.OldDriver;
            }
            else
            {
                _ODP_character = ODPCharacter.Passenger;
            }
            renderODPMessage();
        }

        private void renderODPMessage()
        {
            string behavior;
            behavior = _ODP_character == ODPCharacter.OldDriver ? _ODP_singleImage ? "PREVIEW" : "DRIVING" : "REQUEST";
            ODPMsgtextBox.Text = string.Format("ODP/{0} {1}\r\n", ODPVersion, behavior);

            string type = "Type/";
            type = _ODP_TypeDefined ? type + textBox1.Text +"\r\n": "";
            ODPMsgtextBox.Text += string.Format("{0}", type);

            string content = ResourcetextBox.Text;
            ODPMsgtextBox.Text += "\r\n" + content;

            string ending;
            ending = _ODP_ENDING ? "\r\nODP/END" : "";
            ODPMsgtextBox.Text += ending;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                _ODP_TypeDefined = true;
            }
            else
            {
                textBox1.Enabled = false;
                _ODP_TypeDefined = false;
            }
            renderODPMessage();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            renderODPMessage();
        }

        private void ResourcetextBox_TextChanged(object sender, EventArgs e)
        {
            renderODPMessage();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                _ODP_ENDING = true;
            }
            else
            {
                _ODP_ENDING = false;
            }
            renderODPMessage();
        }
    }
}
