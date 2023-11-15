
namespace Quanlisinhvien
{
    partial class RemoveStudent
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
            this.idTbox = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mssv:";
            // 
            // idTbox
            // 
            this.idTbox.Location = new System.Drawing.Point(340, 57);
            this.idTbox.Name = "idTbox";
            this.idTbox.Size = new System.Drawing.Size(236, 31);
            this.idTbox.TabIndex = 1;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(340, 105);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(112, 34);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Xóa";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 177);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.idTbox);
            this.Controls.Add(this.label1);
            this.Name = "RemoveStudent";
            this.Text = "RemoveStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.Button removeBtn;
    }
}