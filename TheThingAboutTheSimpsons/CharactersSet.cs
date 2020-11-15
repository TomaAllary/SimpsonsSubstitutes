using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThingAboutTheSimpsons {
    public class CharactersSet {
        public string SetName { get; set;}
        public List<string> charactersName = new List<string>();
        public CharactersSet(string setName) {
            SetName = setName;
        }
    }
}
