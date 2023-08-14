using System.Security.Cryptography;
using System.Text;

namespace RSASender
{
    public partial class Form1 : Form
    {
        RSAEncryption rsaEncrypter;
        public Form1()
        {
            InitializeComponent();
            rsaEncrypter = new RSAEncryption();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] encryptData = Encoding.UTF8.GetBytes(plainTextBox.Text);

                using (var rsa = RSA.Create())
                {
                    if (string.IsNullOrEmpty(exponentTextBox.Text) || string.IsNullOrEmpty(modulusTextBox.Text))
                    {
                        MessageBox.Show("Please enter both exponent and modulus");
                    }
                    else
                    {
                        var rsaParameters = new RSAParameters
                        {
                            Exponent = Convert.FromHexString(exponentTextBox.Text.Replace("-", "")),
                            Modulus = Convert.FromHexString(modulusTextBox.Text.Replace("-", ""))
                        };
                        rsa.ImportParameters(rsaParameters);

                        cypherBytesTextBox.Text = BitConverter.ToString(rsaEncrypter.EncryptData(rsa, encryptData));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exeption: {ex.Message}");
                throw;
            }
        }
    }
}