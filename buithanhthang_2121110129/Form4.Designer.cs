namespace buithanhthang_2121110129
{
    partial class Form4
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
            tbX = new TextBox();
            tbY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbKQ = new TextBox();
            btLuu = new Button();
            btCong = new Button();
            btThoat = new Button();
            btNhan = new Button();
            SuspendLayout();
            // 
            // tbX
            // 
            tbX.Location = new Point(74, 14);
            tbX.Name = "tbX";
            tbX.Size = new Size(287, 23);
            tbX.TabIndex = 0;
            // 
            // tbY
            // 
            tbY.Location = new Point(74, 54);
            tbY.Name = "tbY";
            tbY.Size = new Size(287, 23);
            tbY.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "Số x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 57);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Số y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 104);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Kết quả";
            // 
            // tbKQ
            // 
            tbKQ.Location = new Point(74, 101);
            tbKQ.Name = "tbKQ";
            tbKQ.Size = new Size(287, 23);
            tbKQ.TabIndex = 5;
            // 
            // btLuu
            // 
            btLuu.Location = new Point(15, 417);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(75, 23);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // btCong
            // 
            btCong.Location = new Point(143, 417);
            btCong.Name = "btCong";
            btCong.Size = new Size(75, 23);
            btCong.TabIndex = 7;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(305, 417);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(75, 23);
            btThoat.TabIndex = 8;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(224, 417);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(75, 23);
            btNhan.TabIndex = 9;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 450);
            Controls.Add(btNhan);
            Controls.Add(btThoat);
            Controls.Add(btCong);
            Controls.Add(btLuu);
            Controls.Add(tbKQ);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbY);
            Controls.Add(tbX);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbX;
        private TextBox tbY;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbKQ;
        private Button btLuu;
        private Button btCong;
        private Button btThoat;
        private Button btNhan;
    }
}