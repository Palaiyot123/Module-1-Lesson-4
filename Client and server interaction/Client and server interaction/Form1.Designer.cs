namespace Client_and_server_interaction
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxserverip = new System.Windows.Forms.TextBox();
            this.txtboxserverport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxportclient = new System.Windows.Forms.TextBox();
            this.txtboxcleintip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxchat = new System.Windows.Forms.TextBox();
            this.txtmessagebox = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnstart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtboxserverport);
            this.groupBox1.Controls.Add(this.txtboxserverip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP .";
            // 
            // txtboxserverip
            // 
            this.txtboxserverip.Location = new System.Drawing.Point(40, 28);
            this.txtboxserverip.Name = "txtboxserverip";
            this.txtboxserverip.Size = new System.Drawing.Size(203, 23);
            this.txtboxserverip.TabIndex = 1;
            // 
            // txtboxserverport
            // 
            this.txtboxserverport.Location = new System.Drawing.Point(305, 28);
            this.txtboxserverport.Name = "txtboxserverport";
            this.txtboxserverport.Size = new System.Drawing.Size(203, 23);
            this.txtboxserverport.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT .";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(518, 29);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(70, 23);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnconnect);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtboxportclient);
            this.groupBox2.Controls.Add(this.txtboxcleintip);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(518, 29);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(70, 23);
            this.btnconnect.TabIndex = 1;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "PORT .";
            // 
            // txtboxportclient
            // 
            this.txtboxportclient.Location = new System.Drawing.Point(305, 28);
            this.txtboxportclient.Name = "txtboxportclient";
            this.txtboxportclient.Size = new System.Drawing.Size(203, 23);
            this.txtboxportclient.TabIndex = 2;
            // 
            // txtboxcleintip
            // 
            this.txtboxcleintip.Location = new System.Drawing.Point(40, 28);
            this.txtboxcleintip.Name = "txtboxcleintip";
            this.txtboxcleintip.Size = new System.Drawing.Size(203, 23);
            this.txtboxcleintip.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP .";
            // 
            // txtboxchat
            // 
            this.txtboxchat.Location = new System.Drawing.Point(11, 180);
            this.txtboxchat.Multiline = true;
            this.txtboxchat.Name = "txtboxchat";
            this.txtboxchat.Size = new System.Drawing.Size(593, 174);
            this.txtboxchat.TabIndex = 2;
            // 
            // txtmessagebox
            // 
            this.txtmessagebox.Location = new System.Drawing.Point(12, 369);
            this.txtmessagebox.Multiline = true;
            this.txtmessagebox.Name = "txtmessagebox";
            this.txtmessagebox.Size = new System.Drawing.Size(495, 39);
            this.txtmessagebox.TabIndex = 3;
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(523, 369);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 39);
            this.btnsend.TabIndex = 4;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 424);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtmessagebox);
            this.Controls.Add(this.txtboxchat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxserverport;
        private System.Windows.Forms.TextBox txtboxserverip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxportclient;
        private System.Windows.Forms.TextBox txtboxcleintip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxchat;
        private System.Windows.Forms.TextBox txtmessagebox;
        private System.Windows.Forms.Button btnsend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

