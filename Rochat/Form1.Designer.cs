namespace Rochat
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chat_text = new System.Windows.Forms.TextBox();
            this.send_text = new System.Windows.Forms.TextBox();
            this.send_msg = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.send_text);
            this.groupBox1.Controls.Add(this.chat_text);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chatiechat";
            // 
            // chat_text
            // 
            this.chat_text.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chat_text.Location = new System.Drawing.Point(6, 20);
            this.chat_text.Multiline = true;
            this.chat_text.Name = "chat_text";
            this.chat_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chat_text.Size = new System.Drawing.Size(545, 299);
            this.chat_text.TabIndex = 0;
            this.chat_text.TextChanged += new System.EventHandler(this.chat_text_TextChanged);
            // 
            // send_text
            // 
            this.send_text.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send_text.Location = new System.Drawing.Point(6, 342);
            this.send_text.Name = "send_text";
            this.send_text.Size = new System.Drawing.Size(545, 26);
            this.send_text.TabIndex = 1;
            this.send_text.TextChanged += new System.EventHandler(this.send_text_TextChanged);
            this.send_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.send_msg_KeyDown);
            // 
            // send_msg
            // 
            this.send_msg.Location = new System.Drawing.Point(18, 394);
            this.send_msg.Name = "send_msg";
            this.send_msg.Size = new System.Drawing.Size(205, 41);
            this.send_msg.TabIndex = 1;
            this.send_msg.Text = "Submit";
            this.send_msg.UseVisualStyleBackColor = true;
            this.send_msg.Click += new System.EventHandler(this.send_msg_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(358, 394);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(205, 41);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(582, 445);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.send_msg);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rochat v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox chat_text;
        private System.Windows.Forms.TextBox send_text;
        private System.Windows.Forms.Button send_msg;
        private System.Windows.Forms.Button exit;
    }
}

