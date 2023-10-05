/*
 * iGenerate - By a.Cincarevic - 2017
 * Inspired by Dashlane's Password Generator
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PasswordGen
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string characterSet =
       "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
       "abcdefghijklmnopqrstuvwxyz";

        public string someNumbers = "0123456789";
        public string someSymbols = "!/#%&$?=*^~";

        public bool useChars = true;
        public bool useNumbers = true;
        public bool useSymbols = false;

        public Form1()
        {
            InitializeComponent();
            label_newPassword.Text = GenerateNewPassword(trackBar_passLength.Value);
        }

        public string GenerateNewPassword(int newGenLength)
        {
            string outString = "";
            outString = useChars ? outString += characterSet : outString += "";
            outString = useNumbers ? outString += someNumbers : outString += "";
            outString = useSymbols ? outString += someSymbols : outString += "";

            string characters = outString;

            //MessageBox.Show("Generate Length:" + newGenLength);
            if (newGenLength < 0) throw new ArgumentException("negative length?", "Length");
            if (newGenLength > int.MaxValue / 8) throw new ArgumentException("length is too big", "Length");
            if (characters == null) throw new ArgumentNullException("missing text/char referens");

            try {
                
                var charArr = characters.Distinct().ToArray();

                if (charArr.Length == 0) {
                    MessageBox.Show("Select a textmethod");
                    //throw new ArgumentException("empty referens", "characterSet");
                }

                var bytes = new byte[newGenLength * 8];
                new RNGCryptoServiceProvider().GetBytes(bytes);

                var newGenString = new char[newGenLength];
                for (int i = 0; i < newGenLength; i++)
                {
                    ulong value = BitConverter.ToUInt64(bytes, i * 8);
                    newGenString[i] = charArr[value % (uint)charArr.Length];
                }
                return new string(newGenString);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Fel uppstod:" + ex);
                return "";
            }
        }
        
        
        private void linkLabel_generateNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label_newPassword.Text = GenerateNewPassword(trackBar_passLength.Value);
        }

        private void trackBar_passLength_Scroll(object sender, EventArgs e)
        {
            int newLength = trackBar_passLength.Value;
            label_newPassLength.Text = "Length ( " + newLength.ToString() + " )";
            label_newPassword.Text = GenerateNewPassword(newLength);
        }

        private void linkLabel_copy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(label_newPassword.Text);
        }

        private void checkBox_chars_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_chars.Checked) useChars = true;
            else useChars = false;
        }

        private void checkBox_num_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_num.Checked) useNumbers = true;
            else useNumbers = false;
        }

        private void checkBox_sym_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sym.Checked) useSymbols = true;
            else useSymbols = false;
        }
    }
}
