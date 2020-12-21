namespace DotChatWF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listMessages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.fieldMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.updateLoop = new System.Windows.Forms.Timer(this.components);
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.TextIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listMessages
            // 
            this.listMessages.BackColor = System.Drawing.Color.White;
            this.listMessages.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.listMessages.ForeColor = System.Drawing.Color.DimGray;
            this.listMessages.FormattingEnabled = true;
            this.listMessages.ItemHeight = 19;
            this.listMessages.Location = new System.Drawing.Point(12, 12);
            this.listMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(305, 327);
            this.listMessages.TabIndex = 0;
            this.listMessages.SelectedIndexChanged += new System.EventHandler(this.listMessages_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(15, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // fieldUsername
            // 
            this.fieldUsername.AutoCompleteCustomSource.AddRange(new string[] {
            "You are not logged in"});
            this.fieldUsername.BackColor = System.Drawing.Color.White;
            this.fieldUsername.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.fieldUsername.ForeColor = System.Drawing.Color.DimGray;
            this.fieldUsername.Location = new System.Drawing.Point(91, 374);
            this.fieldUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.ReadOnly = true;
            this.fieldUsername.Size = new System.Drawing.Size(355, 27);
            this.fieldUsername.TabIndex = 3;
            this.fieldUsername.Text = "You are not loggined in";
            this.fieldUsername.TextChanged += new System.EventHandler(this.fieldUsername_TextChanged);
            // 
            // fieldMessage
            // 
            this.fieldMessage.BackColor = System.Drawing.Color.Snow;
            this.fieldMessage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.fieldMessage.ForeColor = System.Drawing.Color.DimGray;
            this.fieldMessage.Location = new System.Drawing.Point(91, 409);
            this.fieldMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fieldMessage.Multiline = true;
            this.fieldMessage.Name = "fieldMessage";
            this.fieldMessage.Size = new System.Drawing.Size(355, 30);
            this.fieldMessage.TabIndex = 4;
            this.fieldMessage.TextChanged += new System.EventHandler(this.fieldMessage_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(664, 375);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(124, 108);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // updateLoop
            // 
            this.updateLoop.Enabled = true;
            this.updateLoop.Interval = 1000;
            this.updateLoop.Tick += new System.EventHandler(this.updateLoop_Tick);
            // 
            // btnAuth
            // 
            this.btnAuth.BackColor = System.Drawing.Color.Transparent;
            this.btnAuth.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAuth.Location = new System.Drawing.Point(12, 455);
            this.btnAuth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(161, 32);
            this.btnAuth.TabIndex = 6;
            this.btnAuth.Text = "Authentification";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.Transparent;
            this.btnReg.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnReg.Location = new System.Drawing.Point(204, 455);
            this.btnReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(141, 32);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Registartion";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.listBox1.ForeColor = System.Drawing.Color.DimGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(447, 12);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 327);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(496, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextPort
            // 
            this.TextPort.BackColor = System.Drawing.Color.Snow;
            this.TextPort.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.TextPort.ForeColor = System.Drawing.Color.DimGray;
            this.TextPort.Location = new System.Drawing.Point(496, 409);
            this.TextPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextPort.Multiline = true;
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(141, 30);
            this.TextPort.TabIndex = 10;
            this.TextPort.TextChanged += new System.EventHandler(this.TextPort_TextChanged);
            // 
            // TextIp
            // 
            this.TextIp.BackColor = System.Drawing.Color.Snow;
            this.TextIp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.TextIp.ForeColor = System.Drawing.Color.DimGray;
            this.TextIp.Location = new System.Drawing.Point(496, 371);
            this.TextIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextIp.Multiline = true;
            this.TextIp.Name = "TextIp";
            this.TextIp.Size = new System.Drawing.Size(141, 30);
            this.TextIp.TabIndex = 11;
            this.TextIp.TextChanged += new System.EventHandler(this.TextIp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(466, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(452, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Port";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextIp);
            this.Controls.Add(this.TextPort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.fieldMessage);
            this.Controls.Add(this.fieldUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewYear";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldUsername;
        private System.Windows.Forms.TextBox fieldMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer updateLoop;
    private System.Windows.Forms.Button btnAuth;
    private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.TextBox TextIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

