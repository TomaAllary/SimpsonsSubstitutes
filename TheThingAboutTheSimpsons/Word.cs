﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace TheThingAboutTheSimpsons
{
    class Word
    {
        public double Score { get; set; }
        public string word { get; set; }

        public List<Word> listSynonyms = new List<Word>();
        public Word (string word, bool isSynonym)
        {
            this.word = word;
            if (!isSynonym) {
                Score = 2.0;
                FindSynonyms();
            }
            else {
                Score = 1.0;
            }
        }

        public void FindSynonyms()
        {
            using (WebClient client = new WebClient())
            {
                
                string htmlCode = client.DownloadString("http://www.synonymy.com/synonym.php?word=" + this.word + "&x=0&y=0");
                string[] test = htmlCode.Split(new string[] { "word=" }, StringSplitOptions.None);                             
                List<string> wordsFinal = new List<string>();
                for (int i = 1; i < test.Length; i++)
                    listSynonyms.Add(new Word(test[i].Substring(0, test[i].IndexOf('>') - 1), true));
                ;
            }
        }
    }
}
