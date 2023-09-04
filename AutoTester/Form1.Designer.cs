namespace AutoTester
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TypeOfTestCasesComboBox = new System.Windows.Forms.ComboBox();
            this.epsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTestCasesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.leftBorderTextBox = new System.Windows.Forms.TextBox();
            this.rightBorderTextBox = new System.Windows.Forms.TextBox();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveResultToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveResultToolStripMenuItem
            // 
            this.saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            this.saveResultToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.saveResultToolStripMenuItem.Text = "Сохранить результаты";
            this.saveResultToolStripMenuItem.Click += new System.EventHandler(this.saveResultToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TypeOfTestCasesComboBox);
            this.groupBox1.Controls.Add(this.epsTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.amountTestCasesTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки генератора тест-кейсов";
            // 
            // TypeOfTestCasesComboBox
            // 
            this.TypeOfTestCasesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOfTestCasesComboBox.FormattingEnabled = true;
            this.TypeOfTestCasesComboBox.Items.AddRange(new object[] {
            "Позитивный (+)",
            "Негативный  (-)"});
            this.TypeOfTestCasesComboBox.Location = new System.Drawing.Point(181, 64);
            this.TypeOfTestCasesComboBox.Name = "TypeOfTestCasesComboBox";
            this.TypeOfTestCasesComboBox.Size = new System.Drawing.Size(116, 21);
            this.TypeOfTestCasesComboBox.TabIndex = 6;
            // 
            // epsTextBox
            // 
            this.epsTextBox.Location = new System.Drawing.Point(181, 102);
            this.epsTextBox.Name = "epsTextBox";
            this.epsTextBox.Size = new System.Drawing.Size(116, 20);
            this.epsTextBox.TabIndex = 4;
            this.epsTextBox.Text = "10";
            this.epsTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            this.epsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Точность вычисления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип тест-кейсов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество тест-кейсов";
            // 
            // amountTestCasesTextBox
            // 
            this.amountTestCasesTextBox.Location = new System.Drawing.Point(181, 28);
            this.amountTestCasesTextBox.Name = "amountTestCasesTextBox";
            this.amountTestCasesTextBox.Size = new System.Drawing.Size(116, 20);
            this.amountTestCasesTextBox.TabIndex = 0;
            this.amountTestCasesTextBox.Text = "3";
            this.amountTestCasesTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            this.amountTestCasesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultRichTextBox);
            this.groupBox2.Location = new System.Drawing.Point(379, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 433);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты тестирования";
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(415, 414);
            this.resultRichTextBox.TabIndex = 0;
            this.resultRichTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.methodComboBox);
            this.groupBox3.Controls.Add(this.leftBorderTextBox);
            this.groupBox3.Controls.Add(this.rightBorderTextBox);
            this.groupBox3.Controls.Add(this.stepTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(0, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 225);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Исходные данные";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 39);
            this.label10.TabIndex = 12;
            this.label10.Text = "Коэффициенты полинома: a = Rand[1,7E-308;\r\n1,7E+308]\r\n\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Количество коэффициентов полинома: n = Rand[0; 15]";
            // 
            // methodComboBox
            // 
            this.methodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Items.AddRange(new object[] {
            "Парабол (Симпсона)",
            "Трапеций",
            "Монте-Карло"});
            this.methodComboBox.Location = new System.Drawing.Point(181, 126);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(116, 21);
            this.methodComboBox.TabIndex = 6;
            // 
            // leftBorderTextBox
            // 
            this.leftBorderTextBox.Location = new System.Drawing.Point(181, 36);
            this.leftBorderTextBox.Name = "leftBorderTextBox";
            this.leftBorderTextBox.Size = new System.Drawing.Size(116, 20);
            this.leftBorderTextBox.TabIndex = 9;
            this.leftBorderTextBox.Text = "-10";
            this.leftBorderTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            this.leftBorderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.borderTextBoxes_KeyPress);
            // 
            // rightBorderTextBox
            // 
            this.rightBorderTextBox.Location = new System.Drawing.Point(181, 66);
            this.rightBorderTextBox.Name = "rightBorderTextBox";
            this.rightBorderTextBox.Size = new System.Drawing.Size(116, 20);
            this.rightBorderTextBox.TabIndex = 8;
            this.rightBorderTextBox.Text = "10";
            this.toolTip1.SetToolTip(this.rightBorderTextBox, "Правая граница должна быть  больше левой!");
            this.rightBorderTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            this.rightBorderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.borderTextBoxes_KeyPress);
            // 
            // stepTextBox
            // 
            this.stepTextBox.Location = new System.Drawing.Point(181, 96);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(116, 20);
            this.stepTextBox.TabIndex = 7;
            this.stepTextBox.Text = "0,001";
            this.toolTip1.SetToolTip(this.stepTextBox, "Шаг интегрирования должен быть в пределах [0.000001; 0.5]!");
            this.stepTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            this.stepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Шаг интегрирования";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Метод интегрирования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Правая граница диапазона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Левая граница диапазона";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(124, 401);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(116, 45);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Начать тестирование";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoTester";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTestCasesTextBox;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.TextBox epsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem saveResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox leftBorderTextBox;
        private System.Windows.Forms.TextBox rightBorderTextBox;
        private System.Windows.Forms.TextBox stepTextBox;
        private System.Windows.Forms.ComboBox TypeOfTestCasesComboBox;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

