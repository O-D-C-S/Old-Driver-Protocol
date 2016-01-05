using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP_Helper
{
    public partial class Form1 : Form
    {
        #region global
        Random ra = new Random();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void renderFastODPMsg()
        {
            string fastodpmsg = Encrypt_FastODP(textBox_FastOdpContent.Text, textBox_FastOdpAES.Text);
            textBox_ODPRst.Text = string.Format("=====[Fast-ODP生成结果]=====\r\n{0}\r\n\r\n消息密码:\r\n{1}", fastodpmsg, textBox_FastOdpAES.Text);
        }

        private void renderClassicODPMsg()
        {
            string classicodpmsg = "233";
            textBox_ODPRst.Text = string.Format("Fast-ODP生成结果:\r\n{0}", classicodpmsg);
        }


        #region Input Events
        private void textBox_FastOdpContent_TextChanged(object sender, EventArgs e)
        {
            renderFastODPMsg();
        }

        private void textBox_FastOdpAES_TextChanged(object sender, EventArgs e)
        {
            renderFastODPMsg();
        }
        #endregion

        #region Data Helpers
        /// <summary>
        /// 生成FastODP消息体
        /// </summary>
        /// <param name="Content">开车内容</param>
        /// <param name="AESkey">消息密钥</param>
        /// <returns></returns>
        private string Encrypt_FastODP(string Content, string AESkey)
        {
            //处理AES Key
            string key = AESkey;

            //不足32时使用odp字符循环补全
            if (key.Length > 32)
            {
                key = key.Substring(0, 32);
            }
            else if (key.Length < 32)
            {
                string paddingStr = "odpodpodpodpodp";
                while (true)
                {
                    key += paddingStr;
                    if (key.Length < 32)
                    {
                        continue;
                    }
                    else if (key.Length > 32)
                    {
                        key = key.Substring(0, 32);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //base64
            byte[] rawContentArray = UTF8Encoding.UTF8.GetBytes(Content);
            string ContentBase64 = Convert.ToBase64String(rawContentArray, 0, rawContentArray.Length);

            //拼接消息
            string wait4AES = "local@" + ContentBase64;

            //AES加密
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB; //use ECB mode
            rDel.Padding = PaddingMode.PKCS7; // padding mode PKCS7

            ICryptoTransform cTransform = rDel.CreateEncryptor();

            byte[] ContentBase64Array = UTF8Encoding.UTF8.GetBytes(ContentBase64);
            byte[] resultArray = cTransform.TransformFinalBlock(ContentBase64Array, 0, ContentBase64Array.Length);

            //base64 again
            string finalStr = Convert.ToBase64String(resultArray, 0, resultArray.Length);
            return "odp://" + finalStr + "/";
        }

        private string Encrypt_ClassicODP(string Content, string AESkey, string RSAKey, string Server, int port)
        {
            return "TODO";
        }

        private string getRandomString(int _Length)
        {
            string _strList = "qwertyuioplkjhgfdsazxcvbnm1234567890";
            string _buffer = "";
            for (int i = 1; i <= _Length; i++)
            {
                _buffer += _strList[ra.Next(0, 35)];
            }
            return _buffer;
        }
        #endregion

        private void button_FastOdpRandomStr_Click(object sender, EventArgs e)
        {
            textBox_FastOdpAES.Text = getRandomString(32);
        }
    }
}
