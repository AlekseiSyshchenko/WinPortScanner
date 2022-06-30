namespace WinPortScanner
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
            this.btScan = new System.Windows.Forms.Button();
            this.tbIpAddr = new System.Windows.Forms.TextBox();
            this.tbStartPort = new System.Windows.Forms.TextBox();
            this.tbEndPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btScan
            // 
            this.btScan.Location = new System.Drawing.Point(336, 316);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(75, 23);
            this.btScan.TabIndex = 0;
            this.btScan.Text = "Scan";
            this.btScan.UseVisualStyleBackColor = true;
            // 
            // tbIpAddr
            // 
            this.tbIpAddr.Location = new System.Drawing.Point(305, 161);
            this.tbIpAddr.Name = "tbIpAddr";
            this.tbIpAddr.Size = new System.Drawing.Size(106, 23);
            this.tbIpAddr.TabIndex = 1;
            this.tbIpAddr.Text = "8.8.8.8";
            // 
            // tbStartPort
            // 
            this.tbStartPort.Location = new System.Drawing.Point(305, 242);
            this.tbStartPort.Name = "tbStartPort";
            this.tbStartPort.Size = new System.Drawing.Size(62, 23);
            this.tbStartPort.TabIndex = 2;
            this.tbStartPort.Text = "1";
            // 
            // tbEndPort
            // 
            this.tbEndPort.Location = new System.Drawing.Point(399, 242);
            this.tbEndPort.Name = "tbEndPort";
            this.tbEndPort.Size = new System.Drawing.Size(65, 23);
            this.tbEndPort.TabIndex = 3;
            this.tbEndPort.Text = "65535";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ip address (e.g. 8.8.8.8)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start and end ports (1 - 65535)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEndPort);
            this.Controls.Add(this.tbStartPort);
            this.Controls.Add(this.tbIpAddr);
            this.Controls.Add(this.btScan);
            this.Name = "Form1";
            this.Text = "WinPortScanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btScan;
        private TextBox tbIpAddr;
        private TextBox tbStartPort;
        private TextBox tbEndPort;
        private Label label1;
        private Label label2;
    }
}