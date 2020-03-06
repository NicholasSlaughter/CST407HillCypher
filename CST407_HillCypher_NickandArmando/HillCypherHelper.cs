using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST407_HillCypher_NickandArmando
{
    public class HillCypherHelper
    {
        public string plainText { get; set; }
        public string cipherText { get; set; }
        public string key { get; set; }
        public int[,] keyMatrix { get; set; }
        public string Encryption(string plainText, string key)
        {
            //Return Cipher Text
            return null;
        }
        public string Decryption(string cipherText, string key)
        {
            //Return Plain Text
            return null;
        }

        public void GetKeyMatrix(string key)
        {

        }
        public string GetInverseKeyMatrix(string key)
        {
            //Find the Inverse Key
            return null;
        }
        public void EncryptHelper(int [,]keyMatrix)
        {

        }

        public string PlainTextPadding(string plainText)
        {
            if (plainText.Length % 3 != 0)
            {
                int temp = plainText.Length % 3;
                temp = 3 - temp;

                for (int i = 0; i < temp; i++)
                {
                    plainText += 'x';
                }
            }
            return plainText;
        }

        public string KeyPadding(string key)
        {
            string keyFiller = "abcdefghi";

            if (key.Length != 9)
            {
                int temp = key.Length;
                temp = 9 - temp;

                for (int i = 0; i < temp; i++)
                {
                    key += keyFiller[i];
                }
            }
            return key;
        }

        public bool CipherTextChecker(string cipherText)
        {
            if (cipherText.Count() % 3 != 0)
                return false;
            else
                return true;
        }
        public bool KeyChecker(string keyText)
        {
            if (keyText.Count() < 1 && keyText.Count() > 9)
                return false;
            else
                return true;
        }
    }
}
