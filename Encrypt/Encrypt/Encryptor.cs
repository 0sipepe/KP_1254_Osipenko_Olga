using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt
{
    internal class Encryptor
    {
        public delegate char EncryptMethod(char ch); 

        EncryptMethod method;
        //string name;
        char key;

        //public string Name { get { return name; } }
        

        public char Key { get { return key; } }
       

        public Encryptor(EncryptMethod m, char k)
        {
            method = m;
            //this.name = n;
            key = k;
        }

        public char Encrypt(char c) { return method(c); }      

        //public override string ToString() { return name; }
        
    }
}

