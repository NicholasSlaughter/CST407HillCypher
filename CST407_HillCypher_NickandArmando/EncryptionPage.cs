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
    public partial class EncryptionPage : Form
    {
        public string plainText { get; set; }
        public string reducablePlainText { get; set; }
        public string key { get; set; }
        public string reducableCipherText { get; set; }
        public string cipherText { get; set; }
        HillCypherHelper helper = new HillCypherHelper();
        public EncryptionPage(string plainText, string key)
        {
            InitializeComponent();
            this.plainText = plainText;
            this.key = key;
            cipherText = helper.Encryption(plainText, key);
            reducableCipherText = cipherText;
            reducablePlainText = plainText;
        }

        private void EncryptionPage_Load(object sender, EventArgs e)
        {
            //Set The Key Matrix
            labelA.Text = key[0].ToString(); labelB.Text = key[1].ToString(); labelC.Text = key[2].ToString();
            labelD.Text = key[3].ToString(); labelE.Text = key[4].ToString(); labelF.Text = key[5].ToString();
            labelG.Text = key[6].ToString(); labelH.Text = key[7].ToString(); labelI.Text = key[8].ToString();

            //Sets Plain Text That Will Be Encrypted
            labelX.Text = plainText[0].ToString();
            labelY.Text = plainText[1].ToString();
            labelZ.Text = plainText[2].ToString();

            //Sets The Formulas Used To Calculate The Ecryption
            labelFormula1.Text = key[0].ToString() + plainText[0].ToString() + "+"
                + key[1].ToString() + plainText[1].ToString() + "+"
                + key[2].ToString() + plainText[2].ToString();
            labelFormula2.Text = key[3].ToString() + plainText[0].ToString() + "+"
                + key[4].ToString() + plainText[1].ToString() + "+"
                + key[5].ToString() + plainText[2].ToString();
            labelFormula3.Text = key[6].ToString() + plainText[0].ToString() + "+"
                + key[7].ToString() + plainText[1].ToString() + "+"
                + key[8].ToString() + plainText[2].ToString();

            //Shows The Output of The Formula AKA The Encrypted Text
            //labelxOut.Text = reducableCipherText[0].ToString();
            //labelyOut.Text = reducableCipherText[1].ToString();
            //labelzOut.Text = reducableCipherText[2].ToString();

            ////Shows The Complete Cipher Text
            //labelCipher.Text = cipherText.ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Reduces The String To Show The Next Calculation
            reducablePlainText = reducablePlainText.Remove(0, 3);
            //reducableCipherText = reducableCipherText.Remove(0, 3);

            if (reducablePlainText.Length != 0)
            {
                //Sets Plain Text That Will Be Encrypted
                labelX.Text = reducablePlainText[0].ToString();
                labelY.Text = reducablePlainText[1].ToString();
                labelZ.Text = reducablePlainText[2].ToString();

                //Sets The Formulas Used To Calculate The Ecryption
                labelFormula1.Text = key[0].ToString() + reducablePlainText[0].ToString() + "+"
                    + key[1].ToString() + reducablePlainText[1].ToString() + "+"
                    + key[2].ToString() + reducablePlainText[2].ToString();
                labelFormula2.Text = key[3].ToString() + reducablePlainText[0].ToString() + "+"
                    + key[4].ToString() + reducablePlainText[1].ToString() + "+"
                    + key[5].ToString() + reducablePlainText[2].ToString();
                labelFormula3.Text = key[6].ToString() + reducablePlainText[0].ToString() + "+"
                    + key[7].ToString() + reducablePlainText[1].ToString() + "+"
                    + key[8].ToString() + reducablePlainText[2].ToString();

                //Shows The Output of The Formula AKA The Encrypted Text
                //labelxOut.Text = reducableCipherText[0].ToString();
                //labelyOut.Text = reducableCipherText[1].ToString();
                //labelzOut.Text = reducableCipherText[2].ToString();
            }
            else //If All The Calculations Have Been Shown Restart From Beginning
            {
                reducablePlainText = plainText;
                reducableCipherText = cipherText;

                //Sets Plain Text That Will Be Encrypted
                labelX.Text = reducablePlainText[0].ToString();
                labelY.Text = reducablePlainText[1].ToString();
                labelZ.Text = reducablePlainText[2].ToString();

                //Sets The Formulas Used To Calculate The Ecryption
                labelFormula1.Text = key[0].ToString() + reducablePlainText[0].ToString() + "+"
                    + key[1].ToString() + reducablePlainText[1].ToString() + "+"
                    + key[2].ToString() + reducablePlainText[2].ToString();
                labelFormula2.Text = key[3].ToString() + reducablePlainText[0].ToString() + "+"
                    + key[4].ToString() + reducablePlainText[1].ToString() + "+"
                    + key[5].ToString() + reducablePlainText[2].ToString();
                labelFormula3.Text = key[6].ToString() + reducablePlainText[0].ToString() + "+"
                    + key[7].ToString() + reducablePlainText[1].ToString() + "+"
                    + key[8].ToString() + reducablePlainText[2].ToString();

                //Shows The Output of The Formula AKA The Encrypted Text
                //labelxOut.Text = reducableCipherText[0].ToString();
                //labelyOut.Text = reducableCipherText[1].ToString();
                //labelzOut.Text = reducableCipherText[2].ToString();
            }
        }
    }
}
