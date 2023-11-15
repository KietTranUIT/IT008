
namespace Quanlisinhvien
{
    partial class StudentManagement
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
            this.modifyBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.class_id = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.math = new System.Windows.Forms.ColumnHeader();
            this.Literature = new System.Windows.Forms.ColumnHeader();
            this.English = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ SINH VIÊN";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(106, 127);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 34);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(308, 127);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(112, 34);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Xóa";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(508, 127);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(210, 34);
            this.modifyBtn.TabIndex = 3;
            this.modifyBtn.Text = "Tìm kiếm và chỉnh sửa";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.class_id,
            this.id,
            this.name,
            this.math,
            this.Literature,
            this.English});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(106, 220);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 218);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // class_id
            // 
            this.class_id.Text = "Mã lớp";
            this.class_id.Width = 100;
            // 
            // id
            // 
            this.id.Text = "MSSV";
            this.id.Width = 100;
            // 
            // name
            // 
            this.name.Text = "Họ và tên";
            this.name.Width = 220;
            // 
            // math
            // 
            this.math.Text = "Toán";
            // 
            // Literature
            // 
            this.Literature.Text = "Văn";
            // 
            // English
            // 
            this.English.Text = "Anh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách sinh viên: ";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(531, 180);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(187, 34);
            this.refresh.TabIndex = 6;
            this.refresh.Text = "Làm mới danh sách";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Name = "StudentManagement";
            this.Text = "StudentManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentManagement_FormClosed);
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader class_id;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader math;
        private System.Windows.Forms.ColumnHeader Literature;
        private System.Windows.Forms.ColumnHeader English;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refresh;
    }
}