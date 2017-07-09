using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatterExample
{
    /// <summary>
    /// Implementation B
    /// </summary>
    public class BritishEnglish : IEnglish
    {
        public string EnglishSentence
        {
            get
            {
                return "I'm going to a pub \nI'm eating a biscuit and a sweet \nI'm gonna eat fish and chips at the pub";
            }
        }
    }
}
