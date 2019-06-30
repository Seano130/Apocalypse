using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ApocalypseRPGv1
{
    public class DialogReader
    {
    
        public string dialogFilename;
        protected List<string> lexicon;

        public DialogReader(List<string>lex)
        {
            lexicon = lex;
        }
        
        public List<string> ReadDialogMsgs()
        {
            List<string> msgs = new List<string>();
            using (StreamReader sr = new StreamReader(dialogFilename))
            {
                while (sr.Peek() >= 0 )
                {
                    string line = sr.ReadLine();
                    msgs.Add(line);
                }
            }
            return msgs;

        }

        public Dialogue ReadDialogOrders(NPCType type)
        {
            string dialogOrderFilename = type.ToString() + "DialogOrder.Text";
            List<Choice> choices = new List<Choice>();
            using (StreamReader sr = new StreamReader(dialogOrderFilename))
            {
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();// read in 1 line at a time
                    string[] quartet = line.Split(',');// split 3 ints by the ,
                    int from = Convert.ToInt32(quartet[0]);
                    int act = Convert.ToInt32(quartet[1]);
                    int react = Convert.ToInt32(quartet[2]);
                    int att = Convert.ToInt32(quartet[2]);
                    Choice ch = new Choice(from, act, react, att);
                    choices.Add(ch);// add this current choice to the List<>
                }
            }
            // now we have all info for this vendor's dialog/plot, so create his Dialog Object...
            return new Dialogue(lexicon, choices);

        }
    }
}
