namespace buithanhthang_2121110129
{
    partial class Form5
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
            textBox1 = new TextBox();
            bt0 = new Button();
            bt1 = new Button();
            bt3 = new Button();
            bt2 = new Button();
            btKQ = new Button();
            btCham = new Button();
            btNhan = new Button();
            btCong = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 23);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // bt0
            // 
            bt0.Location = new Point(12, 51);
            bt0.Name = "bt0";
            bt0.Size = new Size(75, 23);
            bt0.TabIndex = 1;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(93, 51);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 23);
            bt1.TabIndex = 2;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(255, 51);
            bt3.Name = "bt3";
            bt3.Size = new Size(75, 23);
            bt3.TabIndex = 4;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(174, 51);
            bt2.Name = "bt2";
            bt2.Size = new Size(75, 23);
            bt2.TabIndex = 3;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // btKQ
            // 
            btKQ.Location = new Point(255, 80);
            btKQ.Name = "btKQ";
            btKQ.Size = new Size(75, 23);
            btKQ.TabIndex = 8;
            btKQ.Text = "=";
            btKQ.UseVisualStyleBackColor = true;
            btKQ.Click += btKQ_Click;
            // 
            // btCham
            // 
            btCham.Location = new Point(174, 80);
            btCham.Name = "btCham";
            btCham.Size = new Size(75, 23);
            btCham.TabIndex = 7;
            btCham.Text = ".";
            btCham.UseVisualStyleBackColor = true;
            btCham.Click += btCham_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(93, 80);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(75, 23);
            btNhan.TabIndex = 6;
            btNhan.Text = "*";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btCong
            // 
            btCong.Location = new Point(12, 80);
            btCong.Name = "btCong";
            btCong.Size = new Size(75, 23);
            btCong.TabIndex = 5;
            btCong.Text = "+";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 118);
            Controls.Add(btKQ);
            Controls.Add(btCham);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(bt0);
            Controls.Add(textBox1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button bt0;
        private Button bt1;
        private Button bt3;
        private Button bt2;
        private Button btKQ;
        private Button btCham;
        private Button btNhan;
        private Button btCong;
    }
}