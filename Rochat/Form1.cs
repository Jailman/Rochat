using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace Rochat
{
    public partial class Form1 : Form
    {
        HttpWebResponse Response = null;
        public string ConnectTuLing(string p_strMessage)
        {
            string result = null;
            try
            {
                //注册码自己到网上注册去
                String APIKEY = "apikey";
                String _strMessage = p_strMessage;
                String INFO = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(_strMessage));
                String getURL = "http://www.tuling123.com/openapi/api?key=" + APIKEY + "&info=" + INFO;
                HttpWebRequest MyRequest = (HttpWebRequest)HttpWebRequest.Create(getURL);
                HttpWebResponse MyResponse = (HttpWebResponse)MyRequest.GetResponse();
                Response = MyResponse;
                using (Stream MyStream = MyResponse.GetResponseStream())
                {
                    long ProgMaximum = MyResponse.ContentLength;
                    long totalDownloadedByte = 0;
                    byte[] by = new byte[1024];
                    int osize = MyStream.Read(by, 0, by.Length);
                    Encoding encoding = Encoding.UTF8;
                    while (osize > 0)
                    {
                        totalDownloadedByte = osize + totalDownloadedByte;
                        result += encoding.GetString(by, 0, osize);
                        long ProgValue = totalDownloadedByte;
                        osize = MyStream.Read(by, 0, by.Length);
                    }
                }
                //解析json
                JsonReader reader = new JsonTextReader(new StringReader(result));
                while (reader.Read())
                {
                    //text中的内容才是你需要的
                    if (reader.Path == "text")
                    {
                        //结果赋值
                        result = reader.Value.ToString();
                    }
                    Console.WriteLine(reader.TokenType + "\t\t" + reader.ValueType + "\t\t" + reader.Value);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        string tuling = " 图灵说：";
        string me = " 我说：";
        private void send_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chat_text.AppendText(DateTime.Now.ToString() + me + Environment.NewLine + send_text.Text.TrimStart() + Environment.NewLine);
                chat_text.AppendText(DateTime.Now.ToString() + tuling + Environment.NewLine + ConnectTuLing(send_text.Text) + Environment.NewLine);
                send_text.Text = "";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chat_text.Text = "当前时间："+ DateTime.Now.ToString() + Environment.NewLine;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void send_msg_Click(object sender, EventArgs e)
        {
            chat_text.AppendText(DateTime.Now.ToString() + me + Environment.NewLine + send_text.Text.TrimStart() + Environment.NewLine);
            chat_text.AppendText(DateTime.Now.ToString() + tuling + Environment.NewLine + ConnectTuLing(send_text.Text) + Environment.NewLine);
            send_text.Text = "";
        }

        private void chat_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void send_text_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

