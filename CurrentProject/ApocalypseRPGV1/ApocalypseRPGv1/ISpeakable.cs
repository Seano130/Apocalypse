using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ApocalypseRPGv1
{
    public enum NPCType
    {
        One, Two
    }

    //Containter package for entire list of text that should be shown to user
    public class DisplayText
    {
        public List<string> Log;
        public List<string> Choices;
        public DisplayText(List<string> react, List<string> chcs)
        {
            Log = react;
            Choices = chcs;

        }

    }

    public class Choice
    {
        public int From, Action, Reaction, AttAdjust;
        public Choice(int from, int act, int react, int aa)
        {
            From = from;// "You see a vendor"
            Action = act; // "buy"
            Reaction = react; // "Sword"
            AttAdjust = aa; // +0
        }
        #region DELETEMELATER
        List<string> Messages = new List<string>(new string[]
        {
            "Test1", "Test2", "Test3", "Test4"
        });
        #endregion
    }

    public class Dialogue
    {
        protected List<string> lexicon;
        protected int state;
        public int State
        {
            get
            {//honest getter...
                return state;
            }

            set
            {
                if(value == state)
                { // not changing state, so don't alter Reaction

                }
                else
                { // we are changing state by making a Choice
                    // so find the Reaction based on that choice
                    foreach(Choice ch in Choices)
                    {
                        if(ch.From == state)
                        {
                            if(ch.Action == value)
                            {
                                PreviousReaction = lexicon [ch.Reaction];
                                state = value; // allow state to change
                            }
                        }
                    } 
                }
            }   
        }
        public List<Choice> Choices;
        public string PreviousReaction;
       

        public Dialogue(List<string> lex, List<Choice> choices)
        {
            lexicon = lex; // complete epitome of everything that can be said
            State = 0; 
            Choices = choices;
            
        }

       public DisplayText ConvertToDisplayText()
        {
            List<string> log = new List<string>();
            log.Add(PreviousReaction);
            List<string> choicesAsStrings = new List<string>();
            foreach(Choice ch in Choices)
            {
                int action = ch.Action;
                string oneChoice = lexicon[action];
                choicesAsStrings.Add(oneChoice);

            }

            DisplayText dt = new DisplayText(log, choicesAsStrings);
            return dt;

        }


    }



    public interface ISpeakable
    {
        //Properties for ISpeakable
        Dialogue Dialogue { get; set; }
        List<Choice> ChoicesRemembered { get; set; }



    }
}
