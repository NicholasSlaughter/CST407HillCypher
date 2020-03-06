using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST407_HillCypher_NickandArmando
{
    public partial class HomePage : Form
    {
        HillCypherHelper helper = new HillCypherHelper();
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlainTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CipherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string plainText;
            string key = textBox3.Text.ToString();
            if(!helper.KeyChecker(key))
            {
                //Error Event Handler & Clear TextBoxes
            }
            key = helper.KeyPadding(key);
            plainText = helper.PlainTextPadding(textBox1.Text.ToString());

            //this.Hide();
            EncryptionPage ep = new EncryptionPage(plainText, key);
            ep.Show();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string cipherText = textBox2.Text.ToString();
            string key = textBox3.Text.ToString();
            if (!helper.KeyChecker(key) || !helper.CipherTextChecker(cipherText))
            {
                //Error Event Handler & Clear TextBoxes
            }
            key = helper.KeyPadding(key);            

            //this.Hide();
            DecryptionPage dp = new DecryptionPage(cipherText, key);
            dp.Show();
        }
    }
}
