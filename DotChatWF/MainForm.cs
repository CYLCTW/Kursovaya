﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DotChatWF
{
    public partial class MainForm : Form
    {
        int lastMsgID = 1;
        AuthentificationForm AuthForm;
        RegistartionForm RegForm;
        public TextBox TextBox_username;
        public TextBox TextBox_port;
        public ListBox ListBox_listMessages;
        public int int_token;
        //
        public string IP { get; set; } = "Press";
        public string Port { get; set; } = "Press";

        //
        public MainForm()
        {
            InitializeComponent();
        }
        private void updateLoop_Tick(object sender, EventArgs e)
        {   
            Message msg = GetMessage(lastMsgID);
            if (msg != null) {
                listMessages.Items.Add($"[{DateTime.Now.ToShortTimeString()}] [{msg.username}]: {msg.text}");
                lastMsgID++;
            }
        } 
        private void btnSend_Click(object sender, EventArgs e) {
                if (int_token == 0)
                {
                MessageBox.Show("Please log in or register");
                }
            else 
            {
                if (fieldMessage.Text.Length != 0)
                {
                    SendMessage(new Message()
                    {
                        username = fieldUsername.Text,
                        text = fieldMessage.Text,
                    });
                }
                ListBox_listMessages = listMessages;
                updateLoop_Tick(sender, e);
            }
        }
        void SendMessage(Message msg)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = new DateTime(DateTime.Now.Year + 1, 1, 1, 0, 0, 0, 1);
            TimeSpan ts = dt2 - dt1;
            listBox1.Items.Add($"Осталось {ts.Days} д, {ts.Hours} ч, {ts.Minutes} м, {ts.Seconds} с до НГ");
            WebRequest req = WebRequest.Create($"http://{IP}:{Port}/api/chat");
            req.Method = "POST";
            string postData = JsonConvert.SerializeObject(msg);
            req.ContentType = "application/json";
            StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
            reqStream.Write(postData);
            reqStream.Close();
            req.GetResponse();
        }
        Message GetMessage(int id)
        {
            try
            {
                WebRequest req = WebRequest.Create($"http://{IP}:{Port}/api/chat/{id}");
                req.Method = "GET";
                WebResponse resp = req.GetResponse();
                string smsg = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                if (smsg == "Not found") return null;
                return JsonConvert.DeserializeObject<Message>(smsg);
            }
            catch { return null; }
        } 
        private void btnAuth_Click(object sender, EventArgs e)
        {
            Port = TextPort.Text;
            IP = TextIp.Text;
            AuthForm.MForm = this;
            AuthForm.Show();
            this.Visible = false;
            CheckStatusOffline();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string Height1 = File.ReadLines("Config.Json").Skip(4).First();
            string Width1 = File.ReadLines("Config.Json").Skip(7).First();
            int W = Convert.ToInt32(Width1);
            int H = Convert.ToInt32(Height1);
            this.Size = new Size(W, H);
            int_token = 0;
            AuthForm = new AuthentificationForm();
            RegForm = new RegistartionForm();
            TextBox_username = fieldUsername;
        }
        public void CheckStatusOffline()
        {
            if (int_token != 0)
            {
                Message Here = new Message();                 
                Here.username = "Server";
                Here.text = fieldUsername.Text + " is OFFLINE";
                Here.list = "";                             
                SendMessage(Here);
            }
        }
        public void CheckStatusOnline()
        {
            Message authok = new Message();
            authok.username = "Server";
            authok.text = fieldUsername.Text + " is ONLINE";
            WebRequest reqt = WebRequest.Create($"http://{IP}:{Port}/api/chat");
            reqt.Method = "POST";                                                       
            string postdata = JsonConvert.SerializeObject(authok);                                 
            reqt.ContentType = "application/json";                                                                                                                                                    
            StreamWriter reqtStream = new StreamWriter(reqt.GetRequestStream());        
            reqtStream.Write(postdata);                                                 
            reqtStream.Close();                                                        
            reqt.GetResponse();
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            Port = TextPort.Text;
            IP = TextIp.Text;
            RegForm.mForm = this;
            RegForm.Show();
            this.Visible = false;
            CheckStatusOffline();
        }
        private void fieldUsername_TextChanged(object sender, EventArgs e)
        {
        }
        private void listMessages_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        private void fieldMessage_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            CheckStatusOffline();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                if (TextBox_username.Text == "Admin")
                {
                    listMessages.Items.Clear();
                }
        updateLoop_Tick(sender, e); 
        }

        private void TextPort_TextChanged(object sender, EventArgs e)
        {
            Port = TextPort.Text;
        }

        private void TextIp_TextChanged(object sender, EventArgs e)
        {
            IP = TextIp.Text;
        }
    }
    [Serializable]
    public class Message
    {
        public string username = "";
        public string text = "";
        public string list = "";
        public DateTime timestamp;
    }
}
