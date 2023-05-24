namespace ModernCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnExit = new Button();
            panelHistory = new Panel();
            panel1 = new Panel();
            txtFinal2 = new TextBox();
            txtFinal1 = new TextBox();
            btnCancel = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubstract = new Button();
            btnAdd = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            btnClearAll = new Button();
            btnModulo = new Button();
            btnSquare = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnDot = new Button();
            btnDouble = new Button();
            btnFraction = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btnNegative = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnExit);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(619, 76);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(539, 0);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 76);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelHistory
            // 
            panelHistory.Dock = DockStyle.Bottom;
            panelHistory.Location = new Point(0, 864);
            panelHistory.Margin = new Padding(0);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(619, 76);
            panelHistory.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 76);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 76);
            panel1.TabIndex = 2;
            // 
            // txtFinal2
            // 
            txtFinal2.BackColor = Color.FromArgb(32, 32, 32);
            txtFinal2.BorderStyle = BorderStyle.None;
            txtFinal2.Dock = DockStyle.Top;
            txtFinal2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtFinal2.ForeColor = Color.Transparent;
            txtFinal2.Location = new Point(0, 152);
            txtFinal2.Multiline = true;
            txtFinal2.Name = "txtFinal2";
            txtFinal2.Size = new Size(619, 52);
            txtFinal2.TabIndex = 3;
            txtFinal2.TextAlign = HorizontalAlignment.Right;
            txtFinal2.TextChanged += txtFinal2_TextChanged;
            // 
            // txtFinal1
            // 
            txtFinal1.BackColor = Color.FromArgb(32, 32, 32);
            txtFinal1.BorderStyle = BorderStyle.None;
            txtFinal1.Dock = DockStyle.Top;
            txtFinal1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtFinal1.ForeColor = Color.Transparent;
            txtFinal1.Location = new Point(0, 204);
            txtFinal1.Multiline = true;
            txtFinal1.Name = "txtFinal1";
            txtFinal1.Size = new Size(619, 71);
            txtFinal1.TabIndex = 4;
            txtFinal1.Text = "0";
            txtFinal1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.FromArgb(52, 52, 52);
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(468, 281);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 89);
            btnCancel.TabIndex = 5;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(52, 52, 52);
            btnDivide.FlatAppearance.BorderColor = Color.Black;
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.ForeColor = Color.White;
            btnDivide.Location = new Point(468, 376);
            btnDivide.Margin = new Padding(0);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(150, 89);
            btnDivide.TabIndex = 6;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnMathOperation_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(52, 52, 52);
            btnMultiply.FlatAppearance.BorderColor = Color.Black;
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.ForeColor = Color.White;
            btnMultiply.Location = new Point(468, 471);
            btnMultiply.Margin = new Padding(0);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(150, 89);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMathOperation_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.BackColor = Color.FromArgb(52, 52, 52);
            btnSubstract.FlatAppearance.BorderColor = Color.Black;
            btnSubstract.FlatAppearance.BorderSize = 0;
            btnSubstract.FlatStyle = FlatStyle.Flat;
            btnSubstract.ForeColor = Color.White;
            btnSubstract.Location = new Point(468, 566);
            btnSubstract.Margin = new Padding(0);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(150, 89);
            btnSubstract.TabIndex = 8;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = false;
            btnSubstract.Click += btnMathOperation_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(52, 52, 52);
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(468, 661);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 89);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnMathOperation_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(96, 168, 217);
            btnEquals.FlatAppearance.BorderColor = Color.Black;
            btnEquals.FlatAppearance.BorderSize = 0;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.ForeColor = Color.White;
            btnEquals.Location = new Point(468, 756);
            btnEquals.Margin = new Padding(0);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(150, 89);
            btnEquals.TabIndex = 10;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(52, 52, 52);
            btnClear.FlatAppearance.BorderColor = Color.Black;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(312, 281);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 89);
            btnClear.TabIndex = 11;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.FromArgb(52, 52, 52);
            btnClearAll.FlatAppearance.BorderColor = Color.Black;
            btnClearAll.FlatAppearance.BorderSize = 0;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.ForeColor = Color.White;
            btnClearAll.Location = new Point(156, 281);
            btnClearAll.Margin = new Padding(0);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(150, 89);
            btnClearAll.TabIndex = 12;
            btnClearAll.Text = "CE";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnModulo
            // 
            btnModulo.BackColor = Color.FromArgb(52, 52, 52);
            btnModulo.FlatAppearance.BorderColor = Color.Black;
            btnModulo.FlatAppearance.BorderSize = 0;
            btnModulo.FlatStyle = FlatStyle.Flat;
            btnModulo.ForeColor = Color.White;
            btnModulo.Location = new Point(0, 281);
            btnModulo.Margin = new Padding(0);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(150, 89);
            btnModulo.TabIndex = 13;
            btnModulo.Text = "%";
            btnModulo.UseVisualStyleBackColor = false;
            btnModulo.Click += btnOperations;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.FromArgb(52, 52, 52);
            btnSquare.FlatAppearance.BorderColor = Color.Black;
            btnSquare.FlatAppearance.BorderSize = 0;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.ForeColor = Color.White;
            btnSquare.Location = new Point(312, 376);
            btnSquare.Margin = new Padding(0);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(150, 89);
            btnSquare.TabIndex = 14;
            btnSquare.Text = "√";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnOperations;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(73, 73, 73);
            btn9.FlatAppearance.BorderColor = Color.Black;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Location = new Point(312, 471);
            btn9.Margin = new Padding(0);
            btn9.Name = "btn9";
            btn9.Size = new Size(150, 89);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += BtnNum_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(73, 73, 73);
            btn6.FlatAppearance.BorderColor = Color.Black;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Location = new Point(312, 566);
            btn6.Margin = new Padding(0);
            btn6.Name = "btn6";
            btn6.Size = new Size(150, 89);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += BtnNum_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(73, 73, 73);
            btn3.FlatAppearance.BorderColor = Color.Black;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Location = new Point(312, 661);
            btn3.Margin = new Padding(0);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 89);
            btn3.TabIndex = 17;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += BtnNum_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(73, 73, 73);
            btnDot.FlatAppearance.BorderColor = Color.Black;
            btnDot.FlatAppearance.BorderSize = 0;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Location = new Point(312, 756);
            btnDot.Margin = new Padding(0);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(150, 89);
            btnDot.TabIndex = 18;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += BtnNum_Click;
            // 
            // btnDouble
            // 
            btnDouble.BackColor = Color.FromArgb(52, 52, 52);
            btnDouble.FlatAppearance.BorderColor = Color.Black;
            btnDouble.FlatAppearance.BorderSize = 0;
            btnDouble.FlatStyle = FlatStyle.Flat;
            btnDouble.ForeColor = Color.White;
            btnDouble.Location = new Point(156, 376);
            btnDouble.Margin = new Padding(0);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(150, 89);
            btnDouble.TabIndex = 19;
            btnDouble.Text = "x^2";
            btnDouble.UseVisualStyleBackColor = false;
            btnDouble.Click += btnOperations;
            // 
            // btnFraction
            // 
            btnFraction.BackColor = Color.FromArgb(52, 52, 52);
            btnFraction.FlatAppearance.BorderColor = Color.Black;
            btnFraction.FlatAppearance.BorderSize = 0;
            btnFraction.FlatStyle = FlatStyle.Flat;
            btnFraction.ForeColor = Color.White;
            btnFraction.Location = new Point(0, 376);
            btnFraction.Margin = new Padding(0);
            btnFraction.Name = "btnFraction";
            btnFraction.Size = new Size(150, 89);
            btnFraction.TabIndex = 20;
            btnFraction.Text = "⅟x";
            btnFraction.UseVisualStyleBackColor = false;
            btnFraction.Click += btnOperations;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(73, 73, 73);
            btn7.FlatAppearance.BorderColor = Color.Black;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Location = new Point(0, 471);
            btn7.Margin = new Padding(0);
            btn7.Name = "btn7";
            btn7.Size = new Size(150, 89);
            btn7.TabIndex = 21;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += BtnNum_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(73, 73, 73);
            btn8.FlatAppearance.BorderColor = Color.Black;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Location = new Point(156, 471);
            btn8.Margin = new Padding(0);
            btn8.Name = "btn8";
            btn8.Size = new Size(150, 89);
            btn8.TabIndex = 22;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += BtnNum_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(73, 73, 73);
            btn5.FlatAppearance.BorderColor = Color.Black;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Location = new Point(156, 566);
            btn5.Margin = new Padding(0);
            btn5.Name = "btn5";
            btn5.Size = new Size(150, 89);
            btn5.TabIndex = 23;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += BtnNum_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(73, 73, 73);
            btn2.FlatAppearance.BorderColor = Color.Black;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Location = new Point(156, 661);
            btn2.Margin = new Padding(0);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 89);
            btn2.TabIndex = 24;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += BtnNum_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(73, 73, 73);
            btn4.FlatAppearance.BorderColor = Color.Black;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Location = new Point(0, 566);
            btn4.Margin = new Padding(0);
            btn4.Name = "btn4";
            btn4.Size = new Size(150, 89);
            btn4.TabIndex = 25;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += BtnNum_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(73, 73, 73);
            btn1.FlatAppearance.BorderColor = Color.Black;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Location = new Point(0, 661);
            btn1.Margin = new Padding(0);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 89);
            btn1.TabIndex = 26;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += BtnNum_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(73, 73, 73);
            btn0.FlatAppearance.BorderColor = Color.Black;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Location = new Point(156, 756);
            btn0.Margin = new Padding(0);
            btn0.Name = "btn0";
            btn0.Size = new Size(150, 89);
            btn0.TabIndex = 27;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += BtnNum_Click;
            // 
            // btnNegative
            // 
            btnNegative.BackColor = Color.FromArgb(73, 73, 73);
            btnNegative.FlatAppearance.BorderColor = Color.Black;
            btnNegative.FlatAppearance.BorderSize = 0;
            btnNegative.FlatStyle = FlatStyle.Flat;
            btnNegative.Location = new Point(0, 756);
            btnNegative.Margin = new Padding(0);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(150, 89);
            btnNegative.TabIndex = 28;
            btnNegative.Text = "+/-";
            btnNegative.UseVisualStyleBackColor = false;
            btnNegative.Click += btnOperations;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(619, 940);
            Controls.Add(btnNegative);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnFraction);
            Controls.Add(btnDouble);
            Controls.Add(btnDot);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnSquare);
            Controls.Add(btnModulo);
            Controls.Add(btnClearAll);
            Controls.Add(btnClear);
            Controls.Add(btnEquals);
            Controls.Add(btnAdd);
            Controls.Add(btnSubstract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnCancel);
            Controls.Add(txtFinal1);
            Controls.Add(txtFinal2);
            Controls.Add(panel1);
            Controls.Add(panelHistory);
            Controls.Add(panelMenu);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panelHistory;
        private Button btnExit;
        private Panel panel1;
        private TextBox txtFinal2;
        private TextBox txtFinal1;
        private Button btnCancel;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubstract;
        private Button btnAdd;
        private Button btnEquals;
        private Button btnClear;
        private Button btnClearAll;
        private Button btnModulo;
        private Button btnSquare;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btnDot;
        private Button btnDouble;
        private Button btnFraction;
        private Button btn7;
        private Button btn8;
        private Button btn5;
        private Button btn2;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private Button btnNegative;
    }
}