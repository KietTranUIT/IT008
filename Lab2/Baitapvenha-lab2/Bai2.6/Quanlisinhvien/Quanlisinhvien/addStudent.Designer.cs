
namespace Quanlisinhvien
{
    partial class addStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.mathTbox = new System.Windows.Forms.TextBox();
            this.literatureTbox = new System.Windows.Forms.TextBox();
            this.englishTbox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mssv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Điểm toán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Điểm văn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điểm anh:";
            // 
            // idTbox
            // 
            this.idTbox.Location = new System.Drawing.Point(173, 80);
            this.idTbox.Name = "idTbox";
            this.idTbox.Size = new System.Drawing.Size(179, 31);
            this.idTbox.TabIndex = 7;
            // 
            // nameTbox
            // 
            this.nameTbox.Location = new System.Drawing.Point(173, 131);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(337, 31);
            this.nameTbox.TabIndex = 8;
            // 
            // mathTbox
            // 
            this.mathTbox.Location = new System.Drawing.Point(173, 185);
            this.mathTbox.Name = "mathTbox";
            this.mathTbox.Size = new System.Drawing.Size(179, 31);
            this.mathTbox.TabIndex = 9;
            // 
            // literatureTbox
            // 
            this.literatureTbox.Location = new System.Drawing.Point(173, 237);
            this.literatureTbox.Name = "literatureTbox";
            this.literatureTbox.Size = new System.Drawing.Size(179, 31);
            this.literatureTbox.TabIndex = 10;
            // 
            // englishTbox
            // 
            this.englishTbox.Location = new System.Drawing.Point(173, 289);
            this.englishTbox.Name = "englishTbox";
            this.englishTbox.Size = new System.Drawing.Size(179, 31);
            this.englishTbox.TabIndex = 11;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(201, 369);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(155, 34);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Thêm sinh viên";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(172, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 29);
            this.listBox1.TabIndex = 13;
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.englishTbox);
            this.Controls.Add(this.literatureTbox);
            this.Controls.Add(this.mathTbox);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.idTbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addStudent";
            this.Text = "addStudent";
            this.Load += new System.EventHandler(this.addStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.TextBox mathTbox;
        private System.Windows.Forms.TextBox literatureTbox;
        private System.Windows.Forms.TextBox englishTbox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}