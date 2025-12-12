using System.Windows.Forms;

namespace buithanhthang_2121110129
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

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
            this.textBox1 = new TextBox();

            this.btnMC = new Button();
            this.btnMR = new Button();
            this.btnMS = new Button();
            this.btnMPlus = new Button();
            this.btnMMinus = new Button();

            this.btnBack = new Button();
            this.btnCE = new Button();
            this.btnC = new Button();
            this.btnSign = new Button();
            this.btnSqrt = new Button();

            this.btn7 = new Button();
            this.btn8 = new Button();
            this.btn9 = new Button();
            this.btnDiv = new Button();
            this.btnPercent = new Button();

            this.btn4 = new Button();
            this.btn5 = new Button();
            this.btn6 = new Button();
            this.btnMul = new Button();
            this.btnReciprocal = new Button();

            this.btn1 = new Button();
            this.btn2 = new Button();
            this.btn3 = new Button();
            this.btnMinus = new Button();

            this.btn0 = new Button();
            this.btnDot = new Button();
            this.btnEqual = new Button();
            this.btnPlus = new Button();

            this.SuspendLayout();

            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Size = new System.Drawing.Size(360, 30);
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = HorizontalAlignment.Right;

            int x = 12, y = 60;
            int w = 70, h = 45;
            int gap = 5;

            Button[] row1 = { btnMC, btnMR, btnMS, btnMPlus, btnMMinus };
            string[] row1Text = { "MC", "MR", "MS", "M+", "M-" };

            Button[] row2 = { btnBack, btnCE, btnC, btnSign, btnSqrt };
            string[] row2Text = { "←", "CE", "C", "±", "√" };

            Button[] row3 = { btn7, btn8, btn9, btnDiv, btnPercent };
            string[] row3Text = { "7", "8", "9", "/", "%" };

            Button[] row4 = { btn4, btn5, btn6, btnMul, btnReciprocal };
            string[] row4Text = { "4", "5", "6", "*", "1/x" };

            Button[] row5 = { btn1, btn2, btn3, btnMinus };
            string[] row5Text = { "1", "2", "3", "-" };

            Button[] row6 = { btn0, btnDot, btnEqual, btnPlus };
            string[] row6Text = { "0", ".", "=", "+" };

            CreateRow(row1, row1Text, x, ref y, w, h, gap);
            CreateRow(row2, row2Text, x, ref y, w, h, gap);
            CreateRow(row3, row3Text, x, ref y, w, h, gap);
            CreateRow(row4, row4Text, x, ref y, w, h, gap);
            CreateRow(row5, row5Text, x, ref y, w, h, gap);
            CreateRow(row6, row6Text, x, ref y, w, h, gap);

            this.ClientSize = new System.Drawing.Size(385, 380);
            this.Controls.Add(this.textBox1);

            foreach (var c in this.Controls)
                if (c is Button btn) btn.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.Name = "Form6";
            this.Text = "Calculator";
            this.ResumeLayout(false);
        }

        private void CreateRow(Button[] btns, string[] texts, int x, ref int y, int w, int h, int gap)
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].Text = texts[i];
                btns[i].Size = new System.Drawing.Size(w, h);
                btns[i].Location = new System.Drawing.Point(x + (w + gap) * i, y);
                btns[i].Click += Button_Click;
                this.Controls.Add(btns[i]);
            }
            y += h + gap;
        }

        #endregion

        private TextBox textBox1;

        private Button btnMC, btnMR, btnMS, btnMPlus, btnMMinus;
        private Button btnBack, btnCE, btnC, btnSign, btnSqrt;
        private Button btn7, btn8, btn9, btnDiv, btnPercent;
        private Button btn4, btn5, btn6, btnMul, btnReciprocal;
        private Button btn1, btn2, btn3, btnMinus;
        private Button btn0, btnDot, btnEqual, btnPlus;
    }
}
