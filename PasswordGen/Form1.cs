/*
 * iGenerate - By a.Cincarevic 2017
 * 
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

        public  string someNumbers = "0123456789";
        public  string someSymbols = "!#%&/?=*^";

        public Form1()
        {
            InitializeComponent();
            label_newPassword.Text = GenerateNewPassword(trackBar_passLength.Value);
        }

        public string GenerateNewPassword(int newGenLength)
        {
            if (!checkBox_chars.Checked) characterSet = "";
            if (checkBox_num.Checked) characterSet += someNumbers;
            if (checkBox_sym.Checked) characterSet += someSymbols;

            //MessageBox.Show("Generate Length:" + newGenLength);
            if (newGenLength < 0) throw new ArgumentException("negative length?", "Length");
            if (newGenLength > int.MaxValue / 8) throw new ArgumentException("length is too big", "Length");
            if (characterSet == null) throw new ArgumentNullException("missing text/char referens");

            var characterArray = characterSet.Distinct().ToArray();

            if (characterArray.Length == 0) {
                MessageBox.Show("Select a textmethod");
                //throw new ArgumentException("text/char referens can't be empty", "characterSet");
            }

            var bytes = new byte[newGenLength * 8];
            new RNGCryptoServiceProvider().GetBytes(bytes);

            var newGenString = new char[newGenLength];
            for (int i = 0; i < newGenLength; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                newGenString[i] = characterArray[value % (uint)characterArray.Length];
            }
            return new string(newGenString);
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

        
    }
}
