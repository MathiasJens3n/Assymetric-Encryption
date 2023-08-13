using System.Security.Cryptography;
using System.Text;

namespace RSASender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            using (var rsa = RSA.Create())
            {
                var rsaParameters = new RSAParameters();
                rsaParameters.Exponent = Convert.FromHexString(exponentTextBox.Text.Replace("-",""));
                rsaParameters.Modulus = Convert.FromHexString(modulusTextBox.Text.Replace("-", ""));
                rsa.ImportParameters(rsaParameters);

                cypherBytesTextBox.Text = BitConverter.ToString(rsa.Encrypt(Encoding.UTF8.GetBytes(plainTextBox.Text), RSAEncryptionPadding.OaepSHA256));
            }

        }
    }
}