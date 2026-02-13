using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_LAB_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (radioButton_Dec.Checked)
            {
                int key = Decimation.GetKey(richTextBox_Key.Text);
                if (!Decimation.IsValidKey(key))
                {
                    MessageBox.Show("Проверьте ваш ключ, чтобы он содержал цифры и был взамно простым с размером алфавита(33)", "Ошибка");
                    return;
                }
                string plainText = Vigener.GetPlainTextWithSpaces(richTextBox_Text.Text);

                Func<string, int, string> processFunc;

                if (radioButton_Enci.Checked)
                    processFunc = Decimation.Encipher;
                else
                    processFunc = Decimation.Decipher;

                string cipher = processFunc(plainText, key);

                if (cipher != plainText)
                    richTextBox_Result.Text = cipher;
            }

            if (radioButton_Vig.Checked)
            {
                string key = Decimation.GetPlainText(richTextBox_Key.Text);
                if (key is "")
                {
                    MessageBox.Show("Проверьте ваш ключ, чтобы он содержал русские буквы", "Ошибка");
                    return;
                }

                Func<string, string, string> processFunc;

                if (radioButton_Enci.Checked)
                    processFunc = Vigener.Encipher;
                else
                    processFunc = Vigener.Decipher;

                var result = processFunc(richTextBox_Text.Text, key);

                if (result == "")
                {
                    MessageBox.Show("Проверьте ваш вводимый текст, чтобы он содержал русские буквы", "Ошибка");
                    return;
                }
                richTextBox_Result.Text = result;
            }

        }

        private void openFileMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                StreamReader sw = null;
                try
                {
                    sw = new StreamReader(openFileDialog.FileName);
                    StringBuilder sb = new StringBuilder();
                    string fileContent = sw.ReadToEnd();

                    foreach (char item in fileContent)
                    {
                        if (item != '\n')
                        {
                            sb.Append(item);
                        }
                    }

                    richTextBox_Text.Text = sb.ToString();
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Dispose();
                    }
                }
            }
        }

        private void saveFileMenu_Click(object sender, EventArgs e)
        {
            if (richTextBox_Result.Text.Length == 0)
            {
                MessageBox.Show("Нет результатов для сохранения", "Внимание");
                return;
            }

            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                StreamWriter sw = null;
                try
                {
                    sw = new StreamWriter(saveFileDialog.FileName);
                    sw.WriteLine(richTextBox_Result.Text);
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Dispose();
                    }
                }
            }
        }

        private void menuButtonClear_Click(object sender, EventArgs e)
        {
            richTextBox_Key.Text = string.Empty;
            richTextBox_Text.Text = string.Empty;
            richTextBox_Result.Text = string.Empty;
        }
    }
}
