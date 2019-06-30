using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apocalypse
{
    public enum NPCType
    {
        One, Two
    }

    public class Choice
    {
        public int From, To, AttAdjust;
        public Choice(int from, int to, int aa)
        {
            From = from;
            To = to;
            AttAdjust = aa;
        }
    }

    public class Dialog
    {
        public int State;
        public List<Choice> Choices;
        public List<string> Msgs;
        public Dialog(List<Choice> choices, List<string> msgs)
        {
            State = 0;
            Choices = choices;
            Msgs = msgs;
        }
    }

    interface ISpeakable
    {
        Dialog Dialog { get; set; }
        List<Choice> ChoicesRemembered { get; set; }

    }
}
