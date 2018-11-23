namespace QuanLyNhaThuoc
{
    partial class UserControl_thuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_thuoc = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_thuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_thuoc
            // 
            this.dg_thuoc.AllowUserToAddRows = false;
            this.dg_thuoc.AllowUserToDeleteRows = false;
            this.dg_thuoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_thuoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_thuoc.Location = new System.Drawing.Point(15, 47);
            this.dg_thuoc.Name = "dg_thuoc";
            this.dg_thuoc.ReadOnly = true;
            this.dg_thuoc.Size = new System.Drawing.Size(606, 345);
            this.dg_thuoc.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 19;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 20);
            this.textBox1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(627, 47);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(87, 27);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // UserControl_thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dg_thuoc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_them);
            this.Name = "UserControl_thuoc";
            this.Size = new System.Drawing.Size(749, 404);
            ((System.ComponentModel.ISupportInitialize)(this.dg_thuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_thuoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btn_them;
    }
}
