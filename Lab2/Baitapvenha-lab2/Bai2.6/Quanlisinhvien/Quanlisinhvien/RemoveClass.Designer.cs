
namespace Quanlisinhvien
{
    partial class RemoveClass
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
            this.removeBtn = new System.Windows.Forms.Button();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(332, 112);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(112, 34);
            this.removeBtn.TabIndex = 0;
            this.removeBtn.Text = "Xóa";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // idTbox
            // 
            this.idTbox.Location = new System.Drawing.Point(228, 66);
            this.idTbox.Name = "idTbox";
            this.idTbox.Size = new System.Drawing.Size(409, 31);
            this.idTbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã lớp:";
            // 
            // RemoveClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTbox);
            this.Controls.Add(this.removeBtn);
            this.Name = "RemoveClass";
            this.Text = "RemoveClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.Label label1;
    }
}