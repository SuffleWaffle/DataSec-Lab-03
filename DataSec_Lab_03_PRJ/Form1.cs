using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSec_Lab_03_PRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MyShowToolTip(TextBox tb, byte[] arr)
        {
            string binValues = "";
            
            for(int i = 0; i < arr.Length; i++)
            {
                binValues += Convert.ToString(arr[i], 2)+" ";
            }

            toolTipHEX.SetToolTip(tb, binValues);
        }

        byte[] myXOR(byte[] textArr , byte[] keyArr)
        {
            int textLength = textArr.Length;
            int keyLength = keyArr.Length;
            byte[] cipherArr = new byte[textLength];
            
            for(int i = 0; i < textLength; i++)
            {
                byte p = textArr[i];
                byte k = keyArr[i % keyLength]; // MOD operation
                byte c = (byte)(p ^ k); //XOR Operation
                cipherArr[i] = c;
            }
            
            return cipherArr;
        }

        string MyCipher(TextBox tbText, TextBox tbKey, TextBox tbCipher, string cipher = "")
        {
            string text = tbText.Text;
            byte[] textArr;
            
            if (cipher == "") textArr = Encoding.Unicode.GetBytes(text);
            else textArr = Encoding.Unicode.GetBytes(cipher);
            
            MyShowToolTip(tbText, textArr); //Create tooltip
            
            string key = tbKey.Text;
            byte[] keyArr = Encoding.Unicode.GetBytes(key);
            
            MyShowToolTip(tbKey, keyArr); //Create tooltip
            
            byte[] cipherArr = myXOR(textArr, keyArr);
            
            cipher = Encoding.Unicode.GetString(cipherArr);
            tbCipher.Text = cipher;
            
            MyShowToolTip(tbCipher, cipherArr); //Create tooltip
            
            return cipher;
        }

        string MyCipher(TextBox tbText, TextBox tbCipher, string cipher = "")
        {
            string text = tbText.Text;
            byte[] textArr;
            
            if (cipher == "") textArr = Encoding.Unicode.GetBytes(text);
            else textArr = Encoding.Unicode.GetBytes(cipher);
            
            MyShowToolTip(tbText, textArr);
            
            cipher = text;
            tbCipher.Text = cipher;
            
            MyShowToolTip(tbCipher, textArr);
            
            return cipher;
        }

        private void buttonXOR_Click(object sender, EventArgs e)
        {
            string cipher = "";
            if (string.IsNullOrEmpty(TextBoxKeyIn.Text))
            {
                cipher = MyCipher(TextBoxPIn, TextBoxCIn);
                TextBoxPOut.Text = TextBoxCIn.Text;
                TextBoxKeyOut.Text = TextBoxKeyIn.Text;
                MyCipher(TextBoxPOut, TextBoxCOut, cipher); 
                
                return;
            }
            cipher = MyCipher(TextBoxPIn, TextBoxKeyIn, TextBoxCIn); // Encrypt
            
            TextBoxPOut.Text = TextBoxCIn.Text;
            TextBoxKeyOut.Text = TextBoxKeyIn.Text;
            
            MyCipher(TextBoxPOut, TextBoxKeyOut, TextBoxCOut, cipher); // Decrypt
        }

        private void buttonRESET_Click(object sender, EventArgs e)
        {
            TextBoxPIn.Text = "";
            TextBoxKeyIn.Text = "";
            TextBoxCIn.Text = "";
            TextBoxPOut.Text = "";
            TextBoxKeyOut.Text = "";
            TextBoxCOut.Text = "";
        }
    }

    
}
