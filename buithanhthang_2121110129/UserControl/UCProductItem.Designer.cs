namespace buithanhthang_2121110129.UserControl
{
    partial class UCProductItem
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
            pnlMain = new Panel();
            btnDelete = new Button();
            pnlControl = new Panel();
            txtProductValue = new TextBox();
            numUDQuantity = new NumericUpDown();
            lblProductName = new Label();
            lblProductPrice = new Label();
            pnlMain.SuspendLayout();
            pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUDQuantity).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(192, 192, 255);
            pnlMain.Controls.Add(btnDelete);
            pnlMain.Controls.Add(pnlControl);
            pnlMain.Controls.Add(lblProductName);
            pnlMain.Controls.Add(lblProductPrice);
            pnlMain.Location = new Point(4, 3);
            pnlMain.Margin = new Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(623, 51);
            pnlMain.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(563, 8);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(38, 33);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlControl
            // 
            pnlControl.Controls.Add(txtProductValue);
            pnlControl.Controls.Add(numUDQuantity);
            pnlControl.Location = new Point(314, 22);
            pnlControl.Margin = new Padding(4, 3, 4, 3);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(249, 33);
            pnlControl.TabIndex = 2;
            // 
            // txtProductValue
            // 
            txtProductValue.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductValue.Location = new Point(88, 3);
            txtProductValue.Margin = new Padding(4, 3, 4, 3);
            txtProductValue.Name = "txtProductValue";
            txtProductValue.Size = new Size(154, 22);
            txtProductValue.TabIndex = 1;
            // 
            // numUDQuantity
            // 
            numUDQuantity.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUDQuantity.Location = new Point(4, 3);
            numUDQuantity.Margin = new Padding(4, 3, 4, 3);
            numUDQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numUDQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUDQuantity.Name = "numUDQuantity";
            numUDQuantity.Size = new Size(79, 22);
            numUDQuantity.TabIndex = 0;
            numUDQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numUDQuantity.ValueChanged += numUDQuantity_ValueChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(4, 0);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(44, 16);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Name";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProductPrice.Location = new Point(4, 35);
            lblProductPrice.Margin = new Padding(4, 0, 4, 0);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(52, 13);
            lblProductPrice.TabIndex = 0;
            lblProductPrice.Text = "Price vnd";
            // 
            // UCProductItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UCProductItem";
            Size = new Size(631, 58);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlControl.ResumeLayout(false);
            pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUDQuantity).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TextBox txtProductValue;
        private System.Windows.Forms.NumericUpDown numUDQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Button btnDelete;
    }
}
