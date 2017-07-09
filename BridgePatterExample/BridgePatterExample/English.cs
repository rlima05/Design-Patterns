using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatterExample
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public class English
    {
        private readonly IEnglish _english;
        public string EnglishSentence { get { return _english.EnglishSentence; } }
            
        public English(IEnglish english)
        {
            _english = english;
        }


    }
}
