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
    public partial class DecryptionPage : Form
    {
        public string plainText { get; set; }
        public string reducablePlainText { get; set; }
        public string key { get; set; }
        public string reducableCipherText { get; set; }
        public string cipherText { get; set; }
        public string inverseKey { get; set; }
        HillCypherHelper helper = new HillCypherHelper();
        public DecryptionPage(string cipherText, string key)
        {
            InitializeComponent();
            this.cipherText = cipherText;
            this.key = key;
            inverseKey = helper.GetInverseKeyMatrixAsString(key);
            plainText = helper.Decryption(cipherText, key);
            reducableCipherText = cipherText;
            reducablePlainText = plainText;
        }

        private void DecryptionPage_Load(object sender, EventArgs e)
        {
            //View The Key Matrix
            labelA.Text = key[0].ToString(); labelB.Text = key[1].ToString(); labelC.Text = key[2].ToString();
            labelD.Text = key[3].ToString(); labelE.Text = key[4].ToString(); labelF.Text = key[5].ToString();
            labelG.Text = key[6].ToString(); labelH.Text = key[7].ToString(); labelI.Text = key[8].ToString();

            //View The Inverse Key Matrix
            labelInversea2.Text = inverseKey[0].ToString(); labelInverseb2.Text = inverseKey[1].ToString(); labelInversec2.Text = inverseKey[2].ToString();
            labelInversed2.Text = inverseKey[3].ToString(); labelInversee2.Text = inverseKey[4].ToString(); labelInversef2.Text = inverseKey[5].ToString();
            labelInverseg2.Text = inverseKey[6].ToString(); labelInverseh2.Text = inverseKey[7].ToString(); labelInversei2.Text = inverseKey[8].ToString();

            //View The Inverse Key Matrix
            labelInverseA.Text = inverseKey[0].ToString(); labelInverseB.Text = inverseKey[1].ToString(); labelInverseC.Text = inverseKey[2].ToString();
            labelInverseD.Text = inverseKey[3].ToString(); labelInverseE.Text = inverseKey[4].ToString(); labelInverseF.Text = inverseKey[5].ToString();
            labelInverseG.Text = inverseKey[6].ToString(); labelInverseH.Text = inverseKey[7].ToString(); labelInverseI.Text = inverseKey[8].ToString();

            //Sets Plain Text That Will Be Encrypted
            labelX.Text = cipherText[0].ToString();
            labelY.Text = cipherText[1].ToString();
            labelZ.Text = cipherText[2].ToString();

            //Sets The Formulas Used To Calculate The Ecryption
            labelFormula1.Text = inverseKey[0].ToString() + cipherText[0].ToString() + "+"
                + inverseKey[1].ToString() + cipherText[1].ToString() + "+"
                + inverseKey[2].ToString() + cipherText[2].ToString();
            labelFormula2.Text = inverseKey[3].ToString() + cipherText[0].ToString() + "+"
                + inverseKey[4].ToString() + cipherText[1].ToString() + "+"
                + inverseKey[5].ToString() + cipherText[2].ToString();
            labelFormula3.Text = inverseKey[6].ToString() + cipherText[0].ToString() + "+"
                + inverseKey[7].ToString() + cipherText[1].ToString() + "+"
                + inverseKey[8].ToString() + cipherText[2].ToString();

            //Shows The Output of The Formula AKA The Encrypted Text
            labelxOut.Text = reducablePlainText[0].ToString();
            labelyOut.Text = reducablePlainText[1].ToString();
            labelzOut.Text = reducablePlainText[2].ToString();

            //Shows The Complete Plain Text
            labelPlain.Text = plainText.ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Reduces The String To Show The Next Calculation
            reducablePlainText = reducablePlainText.Remove(0, 3);
            reducableCipherText = reducableCipherText.Remove(0, 3);

            if (reducableCipherText.Length != 0)
            {
                //Sets Plain Text That Will Be Encrypted
                labelX.Text = reducableCipherText[0].ToString();
                labelY.Text = reducableCipherText[1].ToString();
                labelZ.Text = reducableCipherText[2].ToString();

                //Sets The Formulas Used To Calculate The Ecryption
                labelFormula1.Text = inverseKey[0].ToString() + reducableCipherText[0].ToString() + "+"
                    + inverseKey[1].ToString() + reducableCipherText[1].ToString() + "+"
                    + inverseKey[2].ToString() + reducableCipherText[2].ToString();
                labelFormula2.Text = inverseKey[3].ToString() + reducableCipherText[0].ToString() + "+"
                    + inverseKey[4].ToString() + reducableCipherText[1].ToString() + "+"
                    + inverseKey[5].ToString() + reducableCipherText[2].ToString();
                labelFormula3.Text = inverseKey[6].ToString() + reducableCipherText[0].ToString() + "+"
                    + inverseKey[7].ToString() + reducableCipherText[1].ToString() + "+"
                    + inverseKey[8].ToString() + reducableCipherText[2].ToString();

                //Shows The Output of The Formula AKA The Encrypted Text
                labelxOut.Text = reducablePlainText[0].ToString();
                labelyOut.Text = reducablePlainText[1].ToString();
                labelzOut.Text = reducablePlainText[2].ToString();
            }
            else //If All The Calculations Have Been Shown Restart From Beginning
            {
                reducablePlainText = plainText;
                reducableCipherText = cipherText;

                //Sets Plain Text That Will Be Encrypted
                labelX.Text = reducableCipherText[0].ToString();
                labelY.Text = reducableCipherText[1].ToString();
                labelZ.Text = reducableCipherText[2].ToString();

                //Sets The Formulas Used To Calculate The Ecryption
                labelFormula1.Text = inverseKey[0].ToString() + reducableCipherText[0].ToString() + "+"
                    + inverseKey[1].ToString() + reducableCipherText[1].ToString() + "+"
                    + inverseKey[2].ToString() + reducableCipherText[2].ToString();
                labelFormula2.Text = inverseKey[3].ToString() + reducableCipherText[0].ToString() + "+"
                    + inverseKey[4].ToString() + reducableCipherText[1].ToString() + "+"
                    + inverseKey[5].ToString() + reducableCipherText[2].ToString();
                labelFormula3.Text = inverseKey[6].ToString() + reducableCipherText[0].ToString() + "+"
                    + inverseKey[7].ToString() + reducableCipherText[1].ToString() + "+"
                    + inverseKey[8].ToString() + reducableCipherText[2].ToString();

                //Shows The Output of The Formula AKA The Encrypted Text
                labelxOut.Text = reducablePlainText[0].ToString();
                labelyOut.Text = reducablePlainText[1].ToString();
                labelzOut.Text = reducablePlainText[2].ToString();
            }
        }
    }
}
