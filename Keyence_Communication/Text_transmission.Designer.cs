
namespace Keyence_Communication
{
    partial class Text_transmission
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_port = new System.Windows.Forms.ComboBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_receive = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // cbo_port
            // 
            this.cbo_port.FormattingEnabled = true;
            this.cbo_port.Location = new System.Drawing.Point(91, 10);
            this.cbo_port.Name = "cbo_port";
            this.cbo_port.Size = new System.Drawing.Size(139, 23);
            this.cbo_port.TabIndex = 1;
            this.cbo_port.SelectedIndexChanged += new System.EventHandler(this.cbo_port_SelectedIndexChanged);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(284, 13);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(91, 57);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(139, 23);
            this.txt_send.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Send:";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(284, 56);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Location = new System.Drawing.Point(387, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Receive:";
            // 
            // rtxt_receive
            // 
            this.rtxt_receive.Location = new System.Drawing.Point(91, 113);
            this.rtxt_receive.Name = "rtxt_receive";
            this.rtxt_receive.Size = new System.Drawing.Size(196, 191);
            this.rtxt_receive.TabIndex = 6;
            this.rtxt_receive.Text = "";
            // 
            // Text_transmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxt_receive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.cbo_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Text_transmission";
            this.Text = "Text_transmission";
            this.Load += new System.EventHandler(this.Text_transmission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_port;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxt_receive;
    }
}