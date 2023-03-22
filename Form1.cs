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

        private void btnHash_Click(object sender, EventArgs e)
        {
            string original = txtData.Text;
            byte[] originalBytes = Encoding.UTF8.GetBytes(original);

            var hash = HashEncryption.ComputeHash(originalBytes);
            var verify = HashEncryption.VerifyHash(originalBytes, hash);

            Console.WriteLine("Text to Hash:      {0}", original);
            Console.WriteLine("Text hashed:       {0}", Convert.ToBase64String(hash));
            Console.WriteLine("Text Verify Result {0}", verify);

            MessageBox.Show("Text to Hash: " + original);
            MessageBox.Show("Hashed: " + Convert.ToBase64String(hash));
            MessageBox.Show("Verify: " + verify);
        }
    }
}