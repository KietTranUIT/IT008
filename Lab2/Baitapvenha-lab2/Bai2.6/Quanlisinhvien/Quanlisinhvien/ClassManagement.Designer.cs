
namespace Quanlisinhvien
{
    partial class ClassManagement
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
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.number = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(219, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ LỚP HỌC";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(80, 111);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 34);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(354, 111);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(112, 34);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Xóa";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.number});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(80, 224);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(648, 193);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Mã lớp học";
            this.id.Width = 150;
            // 
            // number
            // 
            this.number.Text = "Số lượng sinh viên";
            this.number.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách lớp học:";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(541, 168);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(187, 34);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Làm mới danh sách";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // ClassManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Name = "ClassManagement";
            this.Text = "ClassManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClassManagement_FormClosed);
            this.Load += new System.EventHandler(this.ClassManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshBtn;
    }
}