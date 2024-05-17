
namespace udpSocketClient
{
    partial class Form1
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
            this.TXT_IP = new System.Windows.Forms.TextBox();
            this.TXT_PORT = new System.Windows.Forms.TextBox();
            this.BTN_CONNECT = new System.Windows.Forms.Button();
            this.RTB_HISTORY = new System.Windows.Forms.RichTextBox();
            this.TXT_CHAT = new System.Windows.Forms.TextBox();
            this.LST_LOG = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_IP
            // 
            this.TXT_IP.Location = new System.Drawing.Point(49, 49);
            this.TXT_IP.Name = "TXT_IP";
            this.TXT_IP.Size = new System.Drawing.Size(242, 21);
            this.TXT_IP.TabIndex = 0;
            this.TXT_IP.TextChanged += new System.EventHandler(this.TXT_IP_TextChanged);
            // 
            // TXT_PORT
            // 
            this.TXT_PORT.Location = new System.Drawing.Point(416, 49);
            this.TXT_PORT.Name = "TXT_PORT";
            this.TXT_PORT.Size = new System.Drawing.Size(242, 21);
            this.TXT_PORT.TabIndex = 1;
            // 
            // BTN_CONNECT
            // 
            this.BTN_CONNECT.Location = new System.Drawing.Point(12, 104);
            this.BTN_CONNECT.Name = "BTN_CONNECT";
            this.BTN_CONNECT.Size = new System.Drawing.Size(89, 23);
            this.BTN_CONNECT.TabIndex = 2;
            this.BTN_CONNECT.Text = "시작";
            this.BTN_CONNECT.UseVisualStyleBackColor = true;
            this.BTN_CONNECT.Click += new System.EventHandler(this.BTN_CONNECT_Click);
            // 
            // RTB_HISTORY
            // 
            this.RTB_HISTORY.Location = new System.Drawing.Point(12, 133);
            this.RTB_HISTORY.Name = "RTB_HISTORY";
            this.RTB_HISTORY.Size = new System.Drawing.Size(776, 187);
            this.RTB_HISTORY.TabIndex = 3;
            this.RTB_HISTORY.Text = "";
            // 
            // TXT_CHAT
            // 
            this.TXT_CHAT.Location = new System.Drawing.Point(12, 326);
            this.TXT_CHAT.Name = "TXT_CHAT";
            this.TXT_CHAT.Size = new System.Drawing.Size(776, 21);
            this.TXT_CHAT.TabIndex = 4;
            this.TXT_CHAT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_CHAT_KeyDown);
            // 
            // LST_LOG
            // 
            this.LST_LOG.FormattingEnabled = true;
            this.LST_LOG.ItemHeight = 12;
            this.LST_LOG.Location = new System.Drawing.Point(12, 353);
            this.LST_LOG.Name = "LST_LOG";
            this.LST_LOG.Size = new System.Drawing.Size(776, 88);
            this.LST_LOG.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(351, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "서버 정보";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LST_LOG);
            this.Controls.Add(this.TXT_CHAT);
            this.Controls.Add(this.RTB_HISTORY);
            this.Controls.Add(this.BTN_CONNECT);
            this.Controls.Add(this.TXT_PORT);
            this.Controls.Add(this.TXT_IP);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_IP;
        private System.Windows.Forms.TextBox TXT_PORT;
        private System.Windows.Forms.Button BTN_CONNECT;
        private System.Windows.Forms.RichTextBox RTB_HISTORY;
        private System.Windows.Forms.TextBox TXT_CHAT;
        private System.Windows.Forms.ListBox LST_LOG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

