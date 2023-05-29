using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt
{
    internal abstract class DMethod
    {
        public abstract char Decrypt(char ch);
    }
    class IncrementDecrypt : DMethod
    {
       // public override string ToString(){ return "I"; }
        public override char Decrypt(char ch) { return (char)((int)ch - 1); }
        
    }
    class DecrementDecrypt : DMethod
    {
        //public override string ToString() { return "D"; }
        public override char Decrypt(char ch) { Console.WriteLine((char)((int)ch + 1)); return (char)((int)ch + 1);  }
        
        
    }
    class ZeroDecrypt : DMethod
    {
        //public override string ToString() { return "Z"; }
        
        public override char Decrypt( char ch) { return ch; }
        
    }
}
