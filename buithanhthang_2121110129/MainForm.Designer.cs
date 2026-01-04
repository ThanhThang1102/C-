using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace buithanhthang_2121110129
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlContainer = new Panel();
            pnlMain = new Panel();
            pnlMove = new Panel();
            cbMenu = new System.Windows.Forms.ComboBox();
            cbSetting = new System.Windows.Forms.ComboBox();
            lblTabShow = new Label();
            btnMinimize = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            timer = new System.Windows.Forms.Timer(components);
            pnlContainer.SuspendLayout();
            pnlMove.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(pnlMain);
            pnlContainer.Controls.Add(pnlMove);
            pnlContainer.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Margin = new Padding(4, 3, 4, 3);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1366, 768);
            pnlContainer.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.Location = new Point(0, 35);
            pnlMain.Margin = new Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1366, 733);
            pnlMain.TabIndex = 2;
            // 
            // pnlMove
            // 
            pnlMove.BackColor = Color.DarkOrange;
            pnlMove.Controls.Add(cbMenu);
            pnlMove.Controls.Add(cbSetting);
            pnlMove.Controls.Add(lblTabShow);
            pnlMove.Controls.Add(btnMinimize);
            pnlMove.Controls.Add(btnClose);
            pnlMove.Location = new Point(0, 0);
            pnlMove.Margin = new Padding(4, 3, 4, 3);
            pnlMove.Name = "pnlMove";
            pnlMove.Size = new Size(1366, 35);
            pnlMove.TabIndex = 0;
            pnlMove.MouseDown += pnlMove_MouseDown;
            pnlMove.MouseMove += pnlMove_MouseMove;
            pnlMove.MouseUp += pnlMove_MouseUp;
            // 
            // cbMenu
            // 
            cbMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMenu.FormattingEnabled = true;
            cbMenu.Location = new Point(781, 2);
            cbMenu.Name = "cbMenu";
            cbMenu.Size = new Size(250, 32);
            cbMenu.TabIndex = 5;
            cbMenu.SelectedIndexChanged += cbMenu_SelectedIndexChanged;
            // 
            // cbSetting
            // 
            cbSetting.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSetting.FormattingEnabled = true;
            cbSetting.Location = new Point(1038, 2);
            cbSetting.Margin = new Padding(4, 3, 4, 3);
            cbSetting.Name = "cbSetting";
            cbSetting.Size = new Size(200, 32);
            cbSetting.TabIndex = 3;
            cbSetting.SelectedIndexChanged += cbSetting_SelectedIndexChanged;
            // 
            // lblTabShow
            // 
            lblTabShow.AutoSize = true;
            lblTabShow.ForeColor = SystemColors.ButtonHighlight;
            lblTabShow.Location = new Point(19, 5);
            lblTabShow.Margin = new Padding(4, 0, 4, 0);
            lblTabShow.Name = "lblTabShow";
            lblTabShow.Size = new Size(187, 24);
            lblTabShow.TabIndex = 2;
            lblTabShow.Text = "Tab đang hiển thị: ";
            // 
            // btnMinimize
            // 
            btnMinimize.Image = Properties.Resources.subtract_26px;
            btnMinimize.Location = new Point(1246, 0);
            btnMinimize.Margin = new Padding(4, 3, 4, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(60, 35);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_26px;
            btnClose.Location = new Point(1306, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(60, 35);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += MainForm_FormClosed;
            pnlContainer.ResumeLayout(false);
            pnlMove.ResumeLayout(false);
            pnlMove.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTabShow;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cbSetting;
        private System.Windows.Forms.ComboBox cbMenu;
    }
}