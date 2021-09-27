
namespace Keyence_Communication
{
    partial class frm_monitoring
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
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_A
            // 
            this.btn_A.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_A.Location = new System.Drawing.Point(51, 118);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(176, 101);
            this.btn_A.TabIndex = 0;
            this.btn_A.Text = "Công đoạn A";
            this.btn_A.UseVisualStyleBackColor = true;
            // 
            // btn_B
            // 
            this.btn_B.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_B.Location = new System.Drawing.Point(295, 118);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(175, 101);
            this.btn_B.TabIndex = 1;
            this.btn_B.Text = "Công đoạn B";
            this.btn_B.UseVisualStyleBackColor = true;
            // 
            // btn_C
            // 
            this.btn_C.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_C.Location = new System.Drawing.Point(572, 118);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(191, 101);
            this.btn_C.TabIndex = 2;
            this.btn_C.Text = "Công đoạn C";
            this.btn_C.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lượng sản phẩm hiện tại:";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(490, 48);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(33, 37);
            this.lbl_count.TabIndex = 4;
            this.lbl_count.Text = "0";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(131, 315);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(38, 37);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "...";
            // 
            // frm_monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frm_monitoring";
            this.Text = "frm_monitoring";
            this.Load += new System.EventHandler(this.frm_monitoring_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_status;
    }
}