using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt
{
    internal class Decryptor
    {
        List<DMethod> decrypts = new List<DMethod>();
        string key;

        public Decryptor(string key)
        {
            this.key = key;
            Console.WriteLine("konstruct");
        }
        public void FillDecrypts()
        {
            decrypts.Clear();
            foreach (char i in key)
            {
                switch (i)
                {
                    case 'I':
                        decrypts.Add(new IncrementDecrypt());
                        break;
                    case 'D':
                        decrypts.Add(new DecrementDecrypt());
                        break;
                    case 'Z':
                        decrypts.Add(new ZeroDecrypt());
                        break;

                }
                Console.WriteLine(i);
            }

            foreach(DMethod decrypt in decrypts)
            {
                Console.WriteLine(decrypt);
            }

        }
        public string Dec(string text)
        {
            FillDecrypts();
            
            char[] textArr = text.ToArray<char>();

            

            int j = 0;
            foreach (DMethod decrypt in decrypts) 
            {
                textArr[j] = decrypt.Decrypt(textArr[j]);
                j++;
                if (j == textArr.Length) j = 0;
            }
            string UnShifr = "";
            foreach (char ch in textArr) UnShifr += ch;
            return UnShifr;




            //for (int i = 0; i < textArr.Length; ++i)
            //{
            //Console.WriteLine("arr " + textArr[i]);

            //textArr[i] = method.Decrypt(textArr[i]);
            //str += textArr[i];
            //Console.WriteLine("arr1 " + textArr[i]);

            //}
        
            //Console.WriteLine(str + "--");

            //return str;
        }
    }

}
