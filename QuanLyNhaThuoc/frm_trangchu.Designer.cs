namespace QuanLyNhaThuoc
{
    partial class frm_trangchu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_side = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_banhang = new System.Windows.Forms.Button();
            this.btn_thuoc = new System.Windows.Forms.Button();
            this.userControl_banhang1 = new QuanLyNhaThuoc.UserControl_banhang();
            this.userControl_thuoc1 = new QuanLyNhaThuoc.UserControl_thuoc();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_banhang);
            this.panel1.Controls.Add(this.panel_side);
            this.panel1.Controls.Add(this.btn_thuoc);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 608);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_side.Location = new System.Drawing.Point(0, 70);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(7, 64);
            this.panel_side.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControl_banhang1);
            this.panel2.Controls.Add(this.userControl_thuoc1);
            this.panel2.Location = new System.Drawing.Point(206, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 517);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::QuanLyNhaThuoc.Properties.Resources.power_button_off;
            this.button2.Location = new System.Drawing.Point(1144, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 37);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_banhang
            // 
            this.btn_banhang.FlatAppearance.BorderSize = 0;
            this.btn_banhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_banhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_banhang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_banhang.Image = global::QuanLyNhaThuoc.Properties.Resources.shopping_cart;
            this.btn_banhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.Location = new System.Drawing.Point(12, 140);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.Size = new System.Drawing.Size(188, 64);
            this.btn_banhang.TabIndex = 5;
            this.btn_banhang.Text = "Bán hàng";
            this.btn_banhang.UseVisualStyleBackColor = true;
            this.btn_banhang.Click += new System.EventHandler(this.btn_banhang_Click);
            // 
            // btn_thuoc
            // 
            this.btn_thuoc.FlatAppearance.BorderSize = 0;
            this.btn_thuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thuoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thuoc.Image = global::QuanLyNhaThuoc.Properties.Resources.pills;
            this.btn_thuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thuoc.Location = new System.Drawing.Point(12, 70);
            this.btn_thuoc.Name = "btn_thuoc";
            this.btn_thuoc.Size = new System.Drawing.Size(188, 64);
            this.btn_thuoc.TabIndex = 1;
            this.btn_thuoc.Text = "Thuốc";
            this.btn_thuoc.UseVisualStyleBackColor = true;
            this.btn_thuoc.Click += new System.EventHandler(this.btn_thuoc_Click);
            // 
            // userControl_banhang1
            // 
            this.userControl_banhang1.Location = new System.Drawing.Point(63, 43);
            this.userControl_banhang1.Name = "userControl_banhang1";
            this.userControl_banhang1.Size = new System.Drawing.Size(774, 448);
            this.userControl_banhang1.TabIndex = 1;
            // 
            // userControl_thuoc1
            // 
            this.userControl_thuoc1.Location = new System.Drawing.Point(88, 43);
            this.userControl_thuoc1.Name = "userControl_thuoc1";
            this.userControl_thuoc1.Size = new System.Drawing.Size(749, 404);
            this.userControl_thuoc1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(203, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 10);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xin chào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Admin";
            // 
            // frm_trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_trangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_trangchu";
            this.Load += new System.EventHandler(this.frm_trangchu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_thuoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Button btn_banhang;
        private System.Windows.Forms.Panel panel2;
        private UserControl_thuoc userControl_thuoc1;
        private UserControl_banhang userControl_banhang1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}