namespace TI_LAB_3
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
            txtBoxP = new TextBox();
            txtBoxQ = new TextBox();
            lblP = new Label();
            lblQ = new Label();
            btnCalculate = new Button();
            txtBoxD = new TextBox();
            lblD = new Label();
            txtBoxR = new TextBox();
            txtBoxFuncR = new TextBox();
            lblR = new Label();
            lblFuncR = new Label();
            lblE = new Label();
            txtBoxE = new TextBox();
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            btnOpenFile = new ToolStripMenuItem();
            btnSaveFile = new ToolStripMenuItem();
            btnClear = new ToolStripMenuItem();
            txtBoxPlainText = new RichTextBox();
            txtBoxCipherText = new RichTextBox();
            lblPlainText = new Label();
            lblRes = new Label();
            radioBtnCipher = new RadioButton();
            radioBtnDecipher = new RadioButton();
            btnCrypto = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxP
            // 
            txtBoxP.Font = new Font("Segoe UI", 10.8F);
            txtBoxP.Location = new Point(12, 67);
            txtBoxP.Name = "txtBoxP";
            txtBoxP.Size = new Size(241, 31);
            txtBoxP.TabIndex = 0;
            // 
            // txtBoxQ
            // 
            txtBoxQ.Font = new Font("Segoe UI", 10.8F);
            txtBoxQ.Location = new Point(12, 129);
            txtBoxQ.Name = "txtBoxQ";
            txtBoxQ.Size = new Size(241, 31);
            txtBoxQ.TabIndex = 1;
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Font = new Font("Segoe UI", 10.8F);
            lblP.Location = new Point(12, 39);
            lblP.Name = "lblP";
            lblP.Size = new Size(96, 25);
            lblP.TabIndex = 2;
            lblP.Text = "Введите P:";
            // 
            // lblQ
            // 
            lblQ.AutoSize = true;
            lblQ.Font = new Font("Segoe UI", 10.8F);
            lblQ.Location = new Point(12, 101);
            lblQ.Name = "lblQ";
            lblQ.Size = new Size(100, 25);
            lblQ.TabIndex = 3;
            lblQ.Text = "Введите Q:";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10.8F);
            btnCalculate.Location = new Point(12, 169);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(241, 34);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Рассчитать параметры";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtBoxD
            // 
            txtBoxD.Font = new Font("Segoe UI", 10.8F);
            txtBoxD.Location = new Point(12, 237);
            txtBoxD.Name = "txtBoxD";
            txtBoxD.Size = new Size(241, 31);
            txtBoxD.TabIndex = 5;
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Font = new Font("Segoe UI", 10.8F);
            lblD.Location = new Point(12, 206);
            lblD.Name = "lblD";
            lblD.Size = new Size(196, 25);
            lblD.TabIndex = 6;
            lblD.Text = "Закрытая константа D:";
            // 
            // txtBoxR
            // 
            txtBoxR.Font = new Font("Segoe UI", 10.8F);
            txtBoxR.Location = new Point(299, 67);
            txtBoxR.Name = "txtBoxR";
            txtBoxR.Size = new Size(241, 31);
            txtBoxR.TabIndex = 7;
            // 
            // txtBoxFuncR
            // 
            txtBoxFuncR.Font = new Font("Segoe UI", 10.8F);
            txtBoxFuncR.Location = new Point(299, 129);
            txtBoxFuncR.Name = "txtBoxFuncR";
            txtBoxFuncR.Size = new Size(241, 31);
            txtBoxFuncR.TabIndex = 8;
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Font = new Font("Segoe UI", 10.8F);
            lblR.Location = new Point(299, 39);
            lblR.Name = "lblR";
            lblR.Size = new Size(152, 25);
            lblR.TabIndex = 9;
            lblR.Text = "Произведение R:";
            // 
            // lblFuncR
            // 
            lblFuncR.AutoSize = true;
            lblFuncR.Font = new Font("Segoe UI", 10.8F);
            lblFuncR.Location = new Point(299, 101);
            lblFuncR.Name = "lblFuncR";
            lblFuncR.Size = new Size(200, 25);
            lblFuncR.TabIndex = 10;
            lblFuncR.Text = "Функция Эйлера для R:";
            // 
            // lblE
            // 
            lblE.AutoSize = true;
            lblE.Font = new Font("Segoe UI", 10.8F);
            lblE.Location = new Point(295, 206);
            lblE.Name = "lblE";
            lblE.Size = new Size(194, 25);
            lblE.TabIndex = 11;
            lblE.Text = "Открытая константа E:";
            // 
            // txtBoxE
            // 
            txtBoxE.Font = new Font("Segoe UI", 10.8F);
            txtBoxE.Location = new Point(299, 237);
            txtBoxE.Name = "txtBoxE";
            txtBoxE.Size = new Size(241, 31);
            txtBoxE.TabIndex = 12;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, btnClear });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(842, 28);
            menuStrip.TabIndex = 14;
            menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { btnOpenFile, btnSaveFile });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(59, 24);
            fileMenu.Text = "Файл";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(224, 26);
            btnOpenFile.Text = "Открыть";
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(224, 26);
            btnSaveFile.Text = "Сохранить";
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnClear
            // 
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 24);
            btnClear.Text = "Очистить поля";
            btnClear.Click += btnClear_Click;
            // 
            // txtBoxPlainText
            // 
            txtBoxPlainText.Font = new Font("Segoe UI", 10.8F);
            txtBoxPlainText.Location = new Point(12, 335);
            txtBoxPlainText.Name = "txtBoxPlainText";
            txtBoxPlainText.Size = new Size(390, 157);
            txtBoxPlainText.TabIndex = 15;
            txtBoxPlainText.Text = "";
            // 
            // txtBoxCipherText
            // 
            txtBoxCipherText.Font = new Font("Segoe UI", 10.8F);
            txtBoxCipherText.Location = new Point(430, 335);
            txtBoxCipherText.Name = "txtBoxCipherText";
            txtBoxCipherText.Size = new Size(390, 157);
            txtBoxCipherText.TabIndex = 16;
            txtBoxCipherText.Text = "";
            // 
            // lblPlainText
            // 
            lblPlainText.AutoSize = true;
            lblPlainText.Font = new Font("Segoe UI", 10.8F);
            lblPlainText.Location = new Point(12, 307);
            lblPlainText.Name = "lblPlainText";
            lblPlainText.Size = new Size(144, 25);
            lblPlainText.TabIndex = 17;
            lblPlainText.Text = "Исходный текст:";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 10.8F);
            lblRes.Location = new Point(430, 307);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(200, 25);
            lblRes.TabIndex = 18;
            lblRes.Text = "Зашифрованный текст:";
            // 
            // radioBtnCipher
            // 
            radioBtnCipher.AutoSize = true;
            radioBtnCipher.Checked = true;
            radioBtnCipher.Font = new Font("Segoe UI", 10.8F);
            radioBtnCipher.Location = new Point(623, 67);
            radioBtnCipher.Name = "radioBtnCipher";
            radioBtnCipher.Size = new Size(145, 29);
            radioBtnCipher.TabIndex = 19;
            radioBtnCipher.TabStop = true;
            radioBtnCipher.Text = "Зашифровать";
            radioBtnCipher.UseVisualStyleBackColor = true;
            radioBtnCipher.CheckedChanged += radioBtnCipher_CheckedChanged;
            // 
            // radioBtnDecipher
            // 
            radioBtnDecipher.AutoSize = true;
            radioBtnDecipher.Font = new Font("Segoe UI", 10.8F);
            radioBtnDecipher.Location = new Point(623, 104);
            radioBtnDecipher.Name = "radioBtnDecipher";
            radioBtnDecipher.Size = new Size(147, 29);
            radioBtnDecipher.TabIndex = 20;
            radioBtnDecipher.Text = "Дешифровать";
            radioBtnDecipher.UseVisualStyleBackColor = true;
            radioBtnDecipher.CheckedChanged += radioBtnDecipher_CheckedChanged;
            // 
            // btnCrypto
            // 
            btnCrypto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCrypto.Location = new Point(623, 184);
            btnCrypto.Name = "btnCrypto";
            btnCrypto.Size = new Size(197, 84);
            btnCrypto.TabIndex = 21;
            btnCrypto.Text = "Зашифровать";
            btnCrypto.UseVisualStyleBackColor = true;
            btnCrypto.Click += btnCrypto_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 520);
            Controls.Add(btnCrypto);
            Controls.Add(radioBtnDecipher);
            Controls.Add(radioBtnCipher);
            Controls.Add(lblRes);
            Controls.Add(lblPlainText);
            Controls.Add(txtBoxCipherText);
            Controls.Add(txtBoxPlainText);
            Controls.Add(menuStrip);
            Controls.Add(txtBoxE);
            Controls.Add(lblE);
            Controls.Add(lblFuncR);
            Controls.Add(lblR);
            Controls.Add(txtBoxFuncR);
            Controls.Add(txtBoxR);
            Controls.Add(lblD);
            Controls.Add(txtBoxD);
            Controls.Add(btnCalculate);
            Controls.Add(lblQ);
            Controls.Add(lblP);
            Controls.Add(txtBoxQ);
            Controls.Add(txtBoxP);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Лабораторная работа №3";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxP;
        private TextBox txtBoxQ;
        private Label lblP;
        private Label lblQ;
        private Button btnCalculate;
        private TextBox txtBoxD;
        private Label lblD;
        private TextBox txtBoxR;
        private TextBox txtBoxFuncR;
        private Label lblR;
        private Label lblFuncR;
        private Label lblE;
        private TextBox txtBoxE;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem btnOpenFile;
        private ToolStripMenuItem btnSaveFile;
        private ToolStripMenuItem btnClear;
        private RichTextBox txtBoxPlainText;
        private RichTextBox txtBoxCipherText;
        private Label lblPlainText;
        private Label lblRes;
        private RadioButton radioBtnCipher;
        private RadioButton radioBtnDecipher;
        private Button btnCrypto;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
