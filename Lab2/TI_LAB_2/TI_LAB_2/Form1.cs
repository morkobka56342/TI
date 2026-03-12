using System.Collections;
using System.Text;

namespace TI_LAB_2
{
    public partial class MainForm : Form
    {
        private const int BITS_TO_SHOW = 160;
        private const int REGISTER_LENGTH = 40;


        readonly StreamCipher streamCipher = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBoxRegister_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (textBoxRegister.Text.Length < REGISTER_LENGTH)
            {
                MessageBox.Show("Длина вашего ключа должна равняться 40 состояниям!", "Внимание");
                return;
            }


            if (textBoxPlainText.Text.Length == 0)
            {
                MessageBox.Show("Выберите файл с исходным текстом для шифрования/дешифрования!", "Внимание");
                return;
            }

            streamCipher.ProduceRegister(textBoxRegister.Text);
            streamCipher.ProduceKey(streamCipher.PlainText.Length);
            textBoxGenKey.Text = BitArrayToStr(streamCipher.KeyBit);

            streamCipher.Cipher();
            textBoxCipherText.Text = BitArrayToStr(streamCipher.CipherBit);
        }

        string BitArrayToStr(BitArray array)
        {
            StringBuilder temp = new();
            if (array.Length <= BITS_TO_SHOW * 2) 
            {
                foreach (bool bit in array)
                {
                    temp.Append(bit ? 1 : 0);
                }
            }
            else
            {
                temp.Append("Первые " + (BITS_TO_SHOW / 8) + " байт: \n");
                for (int i = 0; i < BITS_TO_SHOW; i++) 
                    temp.Append(array[i] ? 1 : 0);

                temp.Append($"{Environment.NewLine}Последние " + (BITS_TO_SHOW / 8) + " байт: \n");
                for (int i = BITS_TO_SHOW; i > 0; i--) 
                {
                    temp.Append(array[array.Length - i] ? 1 : 0);
                }
            }

            return temp.ToString();
        }
        private void menuBtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                StringBuilder str = new StringBuilder();

                var bytes = File.ReadAllBytes(openFileDialog.FileName);
                for (int i = 0; i < bytes.Length; i++)
                {
                    BitArray currentByteBits = new BitArray(new[] { bytes[i] });
                    foreach (bool bit in currentByteBits)
                    {
                        str.Append(bit ? 1 : 0);
                    }
                }

                streamCipher.PlainText = new BitArray(str.Length);
                for (int i = 0; i < streamCipher.PlainText.Length; i++)
                {
                    if (str[i] == '1')
                        streamCipher.PlainText[i] = true;                    
                    else                    
                        streamCipher.PlainText[i] = false;                   
                }

                textBoxPlainText.Text = BitArrayToStr(streamCipher.PlainText);
                textBoxCipherText.Clear();
                textBoxGenKey.Clear();
            }
        }
        private void menuBtnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                using FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                byte[] result = new byte[streamCipher.CipherBit.Count / 8];
                streamCipher.CipherBit.CopyTo(result, 0);
                fileStream.Write(result, 0, result.Length);
            }
        }
        private void menuBtnClear_Click(object sender, EventArgs e)
        {
            textBoxCipherText.Clear();
            textBoxGenKey.Clear();
            textBoxPlainText.Clear();
            textBoxRegister.Clear();
        }
    }
}
