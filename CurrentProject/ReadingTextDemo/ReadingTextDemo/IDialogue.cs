using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextDemo
{
    
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

    public class Dialogue
    {
        public int State;
        public List<Choice> Choices;
        public List<string> Msgs;
        public Dialogue(List<Choice> choices, List<string> msgs)
        {
            State = 0;
            Choices = choices;
            Msgs = msgs;
        }

    }

    public interface ISpeakable
    {
        //Properties for ISpeakable
        Dialogue Dialogue { get; set; }
        List<Choice> ChoicesRemembered { get; set; }



    }
}
