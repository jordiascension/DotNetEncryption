using System.Security.Cryptography;
using System.Text;

namespace DotnetCoreCryptography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            string original = txtData.Text;

            using (var myAes = Aes.Create())
            {
                var encrypted = MyEncryption.EncryptBytes(Encoding.UTF8.GetBytes(original), 
                    myAes.Key, myAes.IV);
                var plainBytes = MyEncryption.DecryptBytes(encrypted, myAes.Key, myAes.IV);
                var roundtrip = Encoding.UTF8.GetString(plainBytes);

                MessageBox.Show("Original: " + original);
                MessageBox.Show("Encrypted: " + Convert.ToBase64String(encrypted));
                MessageBox.Show("Round Trip: " + roundtrip);
            }
        }

        private void btnEncryptionRsa_Click(object sender, EventArgs e)
        {
            string original = txtData.Text;

            using (var rsa = RSA.Create())
            {
                var encrypted = RSAEncryption.EncryptBytes(Encoding.UTF8.GetBytes(original), 
                    rsa.ExportParameters(false));
                var plainBytes = RSAEncryption.DecryptBytes(encrypted, rsa.ExportParameters(true));
                var roundtrip = Encoding.UTF8.GetString(plainBytes);

                MessageBox.Show("Original: " + original);
                MessageBox.Show("Encrypted: " + Convert.ToBase64String(encrypted));
                MessageBox.Show("Round Trip: " + roundtrip);
            }
        }
    }
}