using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Encrypt.Encryptor;

namespace Encrypt
{
    public partial class Form1 : Form
    {
        List<Encryptor> encryptors = new List<Encryptor>();
        public Form1()
        {
            InitializeComponent();
            
        }
        char Increment(char ch)
        {
            return (char)((int)ch + 1);
        }
        char Decrement(char ch)
        {
            return (char)((int)ch - 1);
        }
        char Zero(char ch)
        {
            return ch;
        }
        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            //encryptors.Clear();
            if (lbEncryptors.SelectedIndex != -1)
            {
                lbCommand.Items.Add(lbEncryptors.SelectedItem);
                switch (lbEncryptors.SelectedIndex)
                {
                    case 0:
                        encryptors.Add(new Encryptor(new EncryptMethod(Increment), 'I'));
                        break;
                    case 1:
                        encryptors.Add(new Encryptor(new EncryptMethod(Decrement), 'D'));
                        break;
                    case 2:
                        encryptors.Add(new Encryptor(new EncryptMethod(Zero), 'Z'));
                        break;
                }
            }
            Console.WriteLine(encryptors.Count);
        }




        private void btnRemoveCommand_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("aa");
            Console.WriteLine(lbCommand.SelectedIndex);
            if (lbCommand.SelectedIndex != -1)
            {
                encryptors.RemoveAt(lbCommand.SelectedIndex);
                lbCommand.Items.Remove(lbCommand.SelectedItem);
                
            }

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (lbCommand.Items.Count != 0)
            {
                string text = tbText.Text;
                string key = "";
                char[] chars = new char[text.Length];
                int j = 0;

                for (int i = 0; i < chars.Length; i++) { chars[i] = text[i]; }

                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = encryptors[j].Encrypt(chars[i]);
                    key += encryptors[j].Key;
                    j++;
                    if (j > encryptors.Count - 1) j = 0;
                }
                string shifred = "";
                foreach (char ch in chars) shifred += ch;

                tbEncrypted.Text = shifred;
                tbKey.Text = key;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decryptor dec = new Decryptor(tbKey.Text);
            tbDecrypted.Text = dec.Dec(tbEncrypted.Text);
            Console.WriteLine("mum");
        }
    }
}
