using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json;
using System.IO;

namespace Questions
{
    internal class Results

    {
        internal string name, surname;    //testbox
        internal /*List<string> */ string likeSpiders, likeScorps; // radiobutton
        internal List<string> knowSpiders, knowScorps; //checkbox
        internal string gender; // domericupdown

        internal int age;   //numericupdown
        internal string group;    //combobox
        internal string selfInfo;  //richTextbox
        //internal int num;



        public Results(string nm, string snm, /*List<string> lsp, List<string> lsc*/ string lsp, string lsc, List<string> ksp, List<string> ksc, string gend, int age, string gr, string selfInf /*int num*/ )
        {
            name = nm;
            surname = snm;
            likeSpiders = lsp;
            likeScorps = lsc;
            knowSpiders = ksp;
            knowScorps = ksc;
            gender = gend;
            this.age = age;
            group = gr;
            selfInfo = selfInf;

        }
        
  


    }
}
