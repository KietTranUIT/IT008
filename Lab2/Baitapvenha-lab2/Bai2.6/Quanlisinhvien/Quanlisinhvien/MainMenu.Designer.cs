
namespace Quanlisinhvien
{
    partial class MainMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.classBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu:";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(195, 163);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(194, 34);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Kết nối cơ sở dữ liệu";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(448, 163);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(128, 34);
            this.disconnectBtn.TabIndex = 3;
            this.disconnectBtn.Text = "Ngắt kết nối";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // classBtn
            // 
            this.classBtn.Location = new System.Drawing.Point(195, 243);
            this.classBtn.Name = "classBtn";
            this.classBtn.Size = new System.Drawing.Size(143, 34);
            this.classBtn.TabIndex = 4;
            this.classBtn.Text = "Quản lí lớp học";
            this.classBtn.UseVisualStyleBackColor = true;
            this.classBtn.Click += new System.EventHandler(this.classBtn_Click);
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(448, 243);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(159, 34);
            this.studentBtn.TabIndex = 5;
            this.studentBtn.Text = "Quản lí sinh viên";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.classBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button classBtn;
        private System.Windows.Forms.Button studentBtn;
    }
}

