
namespace UDP_message
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.receivemsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_targetip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_targetport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_targetmsg = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "監聽Port";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(662, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "啟動接收";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtport
            // 
            this.txtport.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtport.Location = new System.Drawing.Point(176, 37);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(120, 32);
            this.txtport.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "接收文字";
            // 
            // receivemsg
            // 
            this.receivemsg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.receivemsg.Location = new System.Drawing.Point(176, 106);
            this.receivemsg.Name = "receivemsg";
            this.receivemsg.Size = new System.Drawing.Size(435, 32);
            this.receivemsg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "目標IP";
            // 
            // txt_targetip
            // 
            this.txt_targetip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_targetip.Location = new System.Drawing.Point(176, 210);
            this.txt_targetip.Name = "txt_targetip";
            this.txt_targetip.Size = new System.Drawing.Size(195, 32);
            this.txt_targetip.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "目標Port";
            // 
            // txt_targetport
            // 
            this.txt_targetport.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_targetport.Location = new System.Drawing.Point(176, 280);
            this.txt_targetport.Name = "txt_targetport";
            this.txt_targetport.Size = new System.Drawing.Size(120, 32);
            this.txt_targetport.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "傳送文字";
            // 
            // txt_targetmsg
            // 
            this.txt_targetmsg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_targetmsg.Location = new System.Drawing.Point(176, 350);
            this.txt_targetmsg.Name = "txt_targetmsg";
            this.txt_targetmsg.Size = new System.Drawing.Size(435, 32);
            this.txt_targetmsg.TabIndex = 10;
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsend.Location = new System.Drawing.Point(662, 344);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(110, 43);
            this.btnsend.TabIndex = 11;
            this.btnsend.Text = "傳送";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txt_targetmsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_targetport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_targetip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.receivemsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "UDP聊天室";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox receive_msg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_targetip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_targetport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_targetmsg;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox receivemsg;
        private System.Windows.Forms.Button button1;
    }
}

