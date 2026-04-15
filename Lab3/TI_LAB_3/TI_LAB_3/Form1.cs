using System.Windows.Forms.VisualStyles;

namespace TI_LAB_3
{
    public partial class Form1 : Form
    {
        int IntegerR { get; set; }
        int IntegerFunctionR { get; set; }
        int IntegerE { get; set; }
        int IntegerD { get; set; }

        byte[] OpenedPlainFileBytes { get; set; }

        byte[] OpenedCipherFileBytes { get; set; }

        ushort[] CipherResult { get; set; }

        byte[] DecipherResult { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int IntegerP = 0;
            int IntegerQ = 0;

            if (!int.TryParse(txtBoxP.Text, out IntegerP) || !RSA.IsPrime(IntegerP))
            {
                MessageBox.Show("Значение P должно быть целое простое число!", "Внимание");
                return;
            }

            if (!int.TryParse(txtBoxQ.Text, out IntegerQ) || !RSA.IsPrime(IntegerQ))
            {
                MessageBox.Show("Значение Q должно быть целое простое число!", "Внимание");
                return;
            }

            IntegerR = IntegerP * IntegerQ;
            if (IntegerR is < 256 or > ushort.MaxValue)
            {
                MessageBox.Show($"Произведение чисел P и Q должно быть не меньше 256 и не больше {ushort.MaxValue}!", "Внимание");
                return;
            }

            txtBoxR.Text = IntegerR.ToString();
            IntegerFunctionR = RSA.EulerPhi(IntegerR);
            txtBoxFuncR.Text = IntegerFunctionR.ToString();

            int IntegerParamD = 0;
            if (!int.TryParse(txtBoxD.Text, out IntegerParamD))
            {
                MessageBox.Show("Значение закрытой константы D должно быть числом!", "Внимание");
                return;
            }

            if (IntegerParamD <= 1 || IntegerParamD >= IntegerFunctionR)
            {
                MessageBox.Show("Значение закрытой константы D должно быть больше 1 и меньше функции Эйлера!", "Внимание");
                return;
            }

            IntegerD = IntegerParamD;

            int gcd = RSA.FindGcd(IntegerParamD, IntegerFunctionR);
            if (gcd != 1)
            {
                MessageBox.Show("Ваша закрытая константа D не взаимно простая с функцией Эйлера!", "Внимание");
                return;
            }

            var extendedEuclidResult = RSA.ExtendedEuclidean(IntegerFunctionR, IntegerD);
            IntegerE = extendedEuclidResult.y;
            txtBoxE.Text = IntegerE.ToString();
        }

        private void radioBtnCipher_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPlainText.Clear();
            txtBoxCipherText.Clear();
            btnCrypto.Text = "Зашифровать";
        }

        private void radioBtnDecipher_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPlainText.Clear();
            txtBoxCipherText.Clear();
            btnCrypto.Text = "Дешифровать";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxP.Clear();
            txtBoxQ.Clear();
            txtBoxR.Clear();
            txtBoxE.Clear();
            txtBoxD.Clear();
            txtBoxFuncR.Clear();
            txtBoxPlainText.Clear();
            txtBoxCipherText.Clear();
        }

        private void btnCrypto_Click(object sender, EventArgs e)
        {
            if (radioBtnCipher.Checked)
            {
                if (txtBoxPlainText.Text.Length == 0)
                {
                    MessageBox.Show("Длина исходного текста должна быть отлична от нуля!", "Внимание");
                    return;
                }

                CipherResult = new ushort[OpenedPlainFileBytes.Length];
                for (int i = 0; i < CipherResult.Length; i++)
                {
                    CipherResult[i] = OpenedPlainFileBytes[i];
                }

                for (int i = 0; i < CipherResult.Length; i++)
                {
                    CipherResult[i] = (ushort)RSA.QuickPowerMod(CipherResult[i], IntegerE, IntegerR);
                }

                txtBoxCipherText.Text = string.Join(" ", CipherResult);
            }

            if (radioBtnDecipher.Checked)
            {
                if (txtBoxCipherText.Text.Length == 0)
                {
                    MessageBox.Show("Длина зашифрованного текста должна быть отлична от нуля!", "Внимание");
                    return;
                }

                ushort[] tempShort = new ushort[CipherResult.Length];

                for (int i = 0; i < tempShort.Length; i++)
                {
                    tempShort[i] = (ushort)RSA.QuickPowerMod(CipherResult[i], IntegerD, IntegerR);
                }

                DecipherResult = new byte[tempShort.Length];
                for (var index = 0; index < tempShort.Length; index++)
                {
                    var item = tempShort[index];
                    var bytes = BitConverter.GetBytes(item);
                    if (!BitConverter.IsLittleEndian)
                        Array.Reverse(bytes);
                    DecipherResult[index] = bytes[0];

                }

                txtBoxPlainText.Text = string.Join(" ", tempShort);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (radioBtnCipher.Checked)
            {
                if (openFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    OpenedPlainFileBytes = File.ReadAllBytes(openFileDialog.FileName);
                    txtBoxPlainText.Text = string.Join(" ", OpenedPlainFileBytes);
                }
            }
            else
            {
                if (openFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    OpenedCipherFileBytes = File.ReadAllBytes(openFileDialog.FileName);

                    if (OpenedCipherFileBytes.Length % 2 != 0)
                    {
                        OpenedCipherFileBytes = OpenedCipherFileBytes.Append((byte)0).ToArray();
                    }

                    CipherResult = new ushort[OpenedCipherFileBytes.Length / 2];

                    for (int i = 0; i < OpenedCipherFileBytes.Length; i += 2)
                    {
                        byte[] bytes = [OpenedCipherFileBytes[i], OpenedCipherFileBytes[i + 1]];
                        ushort combinedShort = BitConverter.ToUInt16(bytes, 0);
                        CipherResult[i / 2] = combinedShort;
                    }

                    txtBoxCipherText.Text = string.Join(" ", CipherResult);
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (radioBtnCipher.Checked)
            {
                if (txtBoxCipherText.Text.Length == 0)
                {
                    MessageBox.Show("Нет данных для сохранения!", "Внимание");
                    return;
                }
                if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    using FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                    foreach (var item in CipherResult)
                    {
                        byte[] bytes = BitConverter.GetBytes(item);
                        fileStream.Write(bytes, 0, bytes.Length);
                    }
                }
            } else
            {
                if (txtBoxPlainText.Text.Length == 0)
                {
                    MessageBox.Show("Нет данных для сохранения!", "Внимание");
                    return;
                }

                if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, DecipherResult);
                }
            }

        }
    }
}
