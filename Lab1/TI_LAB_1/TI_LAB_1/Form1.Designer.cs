namespace TI_LAB_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_Text = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Key = new System.Windows.Forms.RichTextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.radioButton_Dec = new System.Windows.Forms.RadioButton();
            this.radioButton_Vig = new System.Windows.Forms.RadioButton();
            this.radioButton_Enci = new System.Windows.Forms.RadioButton();
            this.radioButton_Deci = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonClear = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_Text
            // 
            this.richTextBox_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Text.Location = new System.Drawing.Point(24, 64);
            this.richTextBox_Text.Name = "richTextBox_Text";
            this.richTextBox_Text.Size = new System.Drawing.Size(269, 96);
            this.richTextBox_Text.TabIndex = 0;
            this.richTextBox_Text.Text = "";
            // 
            // richTextBox_Key
            // 
            this.richTextBox_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Key.Location = new System.Drawing.Point(24, 198);
            this.richTextBox_Key.Name = "richTextBox_Key";
            this.richTextBox_Key.Size = new System.Drawing.Size(269, 96);
            this.richTextBox_Key.TabIndex = 1;
            this.richTextBox_Key.Text = "";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(21, 45);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(113, 16);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Исходный текст:";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(21, 179);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(44, 16);
            this.labelKey.TabIndex = 3;
            this.labelKey.Text = "Ключ:";
            // 
            // radioButton_Dec
            // 
            this.radioButton_Dec.AutoSize = true;
            this.radioButton_Dec.Location = new System.Drawing.Point(3, 12);
            this.radioButton_Dec.Name = "radioButton_Dec";
            this.radioButton_Dec.Size = new System.Drawing.Size(146, 20);
            this.radioButton_Dec.TabIndex = 4;
            this.radioButton_Dec.Text = "Метод децимаций";
            this.radioButton_Dec.UseVisualStyleBackColor = true;
            // 
            // radioButton_Vig
            // 
            this.radioButton_Vig.AutoSize = true;
            this.radioButton_Vig.Location = new System.Drawing.Point(3, 51);
            this.radioButton_Vig.Name = "radioButton_Vig";
            this.radioButton_Vig.Size = new System.Drawing.Size(350, 20);
            this.radioButton_Vig.TabIndex = 5;
            this.radioButton_Vig.TabStop = true;
            this.radioButton_Vig.Text = "Алгоритм Виженера (самогенерирующийся ключ)";
            this.radioButton_Vig.UseVisualStyleBackColor = true;
            // 
            // radioButton_Enci
            // 
            this.radioButton_Enci.AutoSize = true;
            this.radioButton_Enci.Location = new System.Drawing.Point(3, 8);
            this.radioButton_Enci.Name = "radioButton_Enci";
            this.radioButton_Enci.Size = new System.Drawing.Size(114, 20);
            this.radioButton_Enci.TabIndex = 6;
            this.radioButton_Enci.Text = "Шифрование";
            this.radioButton_Enci.UseVisualStyleBackColor = true;
            // 
            // radioButton_Deci
            // 
            this.radioButton_Deci.AutoSize = true;
            this.radioButton_Deci.Location = new System.Drawing.Point(3, 54);
            this.radioButton_Deci.Name = "radioButton_Deci";
            this.radioButton_Deci.Size = new System.Drawing.Size(129, 20);
            this.radioButton_Deci.TabIndex = 7;
            this.radioButton_Deci.TabStop = true;
            this.radioButton_Deci.Text = "Дешифрование";
            this.radioButton_Deci.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(395, 198);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(350, 40);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "Рассчитать";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(395, 258);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(80, 16);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Результат:";
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Result.Location = new System.Drawing.Point(398, 278);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.Size = new System.Drawing.Size(347, 147);
            this.richTextBox_Result.TabIndex = 10;
            this.richTextBox_Result.Text = "";
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.menuButtonClear});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 30);
            this.mainMenu.TabIndex = 11;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenu,
            this.saveFileMenu});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(59, 26);
            this.menu.Text = "Файл";
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.Size = new System.Drawing.Size(166, 26);
            this.openFileMenu.Text = "Открыть";
            this.openFileMenu.Click += new System.EventHandler(this.openFileMenu_Click);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.Size = new System.Drawing.Size(166, 26);
            this.saveFileMenu.Text = "Сохранить";
            this.saveFileMenu.Click += new System.EventHandler(this.saveFileMenu_Click);
            // 
            // menuButtonClear
            // 
            this.menuButtonClear.Name = "menuButtonClear";
            this.menuButtonClear.Size = new System.Drawing.Size(125, 26);
            this.menuButtonClear.Text = "Очистить поля";
            this.menuButtonClear.Click += new System.EventHandler(this.menuButtonClear_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.OverwritePrompt = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_Dec);
            this.panel1.Controls.Add(this.radioButton_Vig);
            this.panel1.Location = new System.Drawing.Point(398, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 100);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton_Enci);
            this.panel2.Controls.Add(this.radioButton_Deci);
            this.panel2.Location = new System.Drawing.Point(24, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox_Result);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.richTextBox_Key);
            this.Controls.Add(this.richTextBox_Text);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №1";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Text;
        private System.Windows.Forms.RichTextBox richTextBox_Key;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.RadioButton radioButton_Dec;
        private System.Windows.Forms.RadioButton radioButton_Vig;
        private System.Windows.Forms.RadioButton radioButton_Enci;
        private System.Windows.Forms.RadioButton radioButton_Deci;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem menuButtonClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

