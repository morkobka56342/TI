namespace TI_LAB_2
{
    partial class MainForm
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
            menuStrip = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuBtnOpen = new ToolStripMenuItem();
            menuBtnSave = new ToolStripMenuItem();
            menuBtnClear = new ToolStripMenuItem();
            panel1 = new Panel();
            labelRegStatus = new Label();
            textBoxRegister = new RichTextBox();
            panel2 = new Panel();
            labelPlainText = new Label();
            labelGenKey = new Label();
            textBoxPlainText = new RichTextBox();
            textBoxGenKey = new RichTextBox();
            panel3 = new Panel();
            textBoxCipherText = new RichTextBox();
            labelCipherText = new Label();
            btnResult = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.Control;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuFile, menuBtnClear });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(777, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuBtnOpen, menuBtnSave });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(59, 24);
            menuFile.Text = "Файл";
            // 
            // menuBtnOpen
            // 
            menuBtnOpen.Name = "menuBtnOpen";
            menuBtnOpen.Size = new Size(166, 26);
            menuBtnOpen.Text = "Открыть";
            menuBtnOpen.Click += menuBtnOpen_Click;
            // 
            // menuBtnSave
            // 
            menuBtnSave.Name = "menuBtnSave";
            menuBtnSave.Size = new Size(166, 26);
            menuBtnSave.Text = "Сохранить";
            menuBtnSave.Click += menuBtnSave_Click;
            // 
            // menuBtnClear
            // 
            menuBtnClear.Name = "menuBtnClear";
            menuBtnClear.Size = new Size(125, 24);
            menuBtnClear.Text = "Очистить поля";
            menuBtnClear.Click += menuBtnClear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(labelRegStatus);
            panel1.Controls.Add(textBoxRegister);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 79);
            panel1.TabIndex = 1;
            // 
            // labelRegStatus
            // 
            labelRegStatus.AutoSize = true;
            labelRegStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRegStatus.Location = new Point(10, 18);
            labelRegStatus.Name = "labelRegStatus";
            labelRegStatus.Size = new Size(238, 23);
            labelRegStatus.TabIndex = 1;
            labelRegStatus.Text = "Состояние регистра (40 бит):";
            // 
            // textBoxRegister
            // 
            textBoxRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRegister.Location = new Point(10, 44);
            textBoxRegister.MaxLength = 40;
            textBoxRegister.Name = "textBoxRegister";
            textBoxRegister.Size = new Size(393, 32);
            textBoxRegister.TabIndex = 0;
            textBoxRegister.Text = "";
            textBoxRegister.KeyDown += textBoxRegister_KeyDown;
            textBoxRegister.KeyPress += textBoxRegister_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(labelPlainText);
            panel2.Controls.Add(labelGenKey);
            panel2.Controls.Add(textBoxPlainText);
            panel2.Controls.Add(textBoxGenKey);
            panel2.Location = new Point(12, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 353);
            panel2.TabIndex = 2;
            // 
            // labelPlainText
            // 
            labelPlainText.AutoSize = true;
            labelPlainText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPlainText.Location = new Point(10, 173);
            labelPlainText.Name = "labelPlainText";
            labelPlainText.Size = new Size(138, 23);
            labelPlainText.TabIndex = 3;
            labelPlainText.Text = "Исходный текст:";
            // 
            // labelGenKey
            // 
            labelGenKey.AutoSize = true;
            labelGenKey.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGenKey.Location = new Point(10, 4);
            labelGenKey.Name = "labelGenKey";
            labelGenKey.Size = new Size(206, 23);
            labelGenKey.TabIndex = 2;
            labelGenKey.Text = "Сгенерированный ключ:";
            // 
            // textBoxPlainText
            // 
            textBoxPlainText.Location = new Point(10, 199);
            textBoxPlainText.Name = "textBoxPlainText";
            textBoxPlainText.Size = new Size(355, 144);
            textBoxPlainText.TabIndex = 1;
            textBoxPlainText.Text = "";
            // 
            // textBoxGenKey
            // 
            textBoxGenKey.Location = new Point(10, 30);
            textBoxGenKey.Name = "textBoxGenKey";
            textBoxGenKey.Size = new Size(355, 144);
            textBoxGenKey.TabIndex = 0;
            textBoxGenKey.Text = "";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.Controls.Add(textBoxCipherText);
            panel3.Controls.Add(labelCipherText);
            panel3.Location = new Point(414, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 353);
            panel3.TabIndex = 3;
            // 
            // textBoxCipherText
            // 
            textBoxCipherText.Location = new Point(7, 31);
            textBoxCipherText.Name = "textBoxCipherText";
            textBoxCipherText.Size = new Size(340, 308);
            textBoxCipherText.TabIndex = 1;
            textBoxCipherText.Text = "";
            // 
            // labelCipherText
            // 
            labelCipherText.AutoSize = true;
            labelCipherText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCipherText.Location = new Point(7, 5);
            labelCipherText.Name = "labelCipherText";
            labelCipherText.Size = new Size(192, 23);
            labelCipherText.TabIndex = 0;
            labelCipherText.Text = "Зашифрованный текст:";
            // 
            // btnResult
            // 
            btnResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnResult.Location = new Point(515, 31);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(254, 79);
            btnResult.TabIndex = 4;
            btnResult.Text = "Зашифровать/Дешифровать";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(777, 496);
            Controls.Add(btnResult);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Лабораторная работа №2";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuBtnOpen;
        private ToolStripMenuItem menuBtnSave;
        private ToolStripMenuItem menuBtnClear;
        private Panel panel1;
        private RichTextBox textBoxRegister;
        private Label labelRegStatus;
        private Panel panel2;
        private Label labelGenKey;
        private RichTextBox textBoxPlainText;
        private RichTextBox textBoxGenKey;
        private Panel panel3;
        private Label labelPlainText;
        private RichTextBox textBoxCipherText;
        private Label labelCipherText;
        private Button btnResult;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
