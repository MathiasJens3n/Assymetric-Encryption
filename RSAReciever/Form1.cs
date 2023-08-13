using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace RSAReciever
{
    public partial class Form1 : Form
    {
        readonly EncryptionManager encryptionManager;
        readonly RSAEncryption rsaEncryption;
        readonly RSA rsa;
        public Form1()
        {
            InitializeComponent();
            rsa = RSA.Create();
            encryptionManager = new EncryptionManager();
            rsaEncryption = new RSAEncryption();

            exponentTextBox.Text = BitConverter.ToString(rsa.ExportParameters(true).Exponent);
            modulusTextBox.Text = BitConverter.ToString(rsa.ExportParameters(true).Modulus);
            dTextBox.Text = BitConverter.ToString(rsa.ExportParameters(true).D);
            dpTextBox.Text = BitConverter.ToString(rsa.ExportParameters(true).DP);
            dqTextBox.Text = BitConverter.ToString(rsa.ExportParameters(true).DQ);
            inverseQTextBox.Text = BitConverter.ToString(rsa.ExportParameters(true).InverseQ);
            pTextBox.Text = BitConverter.ToString(rsa.ExportParameters(true).P);
            qTextBox.Text = BitConverter.ToString(rsa.ExportParameters(true).Q);

            try
            {
                if (rsa.KeySize < 2048)
                {
                    MessageBox.Show("Generating a new key pair...");
                    rsa.KeySize = 2048;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating or loading RSA Key: {ex.Message}");
            }
        }
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            byte[] encryptedData = Convert.FromHexString(cipherBytesTextBox.Text.Replace("-",""));
            string decryptedData = Encoding.UTF8.GetString( encryptionManager.Decrypt(rsa,encryptedData));
            decryptedTextBox.Text = decryptedData;
        }
    }
}
