using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
namespace ApocalypseRPGv1
{
    public delegate void UpdateHandler(List<ILocateable> everthing, Player jeff, DisplayText msgs);

    public enum GameMode
    {
        Combat, Dialog, Explore
    }


    public class Game
    {
        public GameMode Mode;
        protected NPCType dlgNPCType;
        public event UpdateHandler Update;// event that triggers whenever something in game happens
        public static Random rand = new Random(); // Random num generator for combat

        protected Timer tmr = new Timer(); // Timer tick
        protected List<ILocateable> character = new List<ILocateable>(); // Creating a new list for "Locateable"
        protected List<ICarry> IO = new List<ICarry>();
        protected Character Player1;
        protected Player jeff;
        protected NPC enemy;
        List<string> lexicon = new List<string>();
        protected Dictionary<NPCType, Dialogue> dialogs = new Dictionary<NPCType, Dialogue>();
        protected List<string> log = new List<string>(); 
        protected int Attitude = 0;
      

        public Game()
        {
            Mode = GameMode.Explore;//default to explore mode
            Animation aniPlayer = new Animation(Properties.Resources.Player1, 64, 64, 0, 0, 1, 1, 1.0, 1.0, true);
            Animation aniEnemy1 = new Animation(Properties.Resources.Enemy1, 64, 64, 0, 0, 1, 1, 1.0, 1.0, true);

            jeff = new Player("Jeff", aniPlayer, new Vector(100, 100), new Vector(0, 0), null, 3);
            enemy = new NPC("Enemy1", aniEnemy1, new Vector(200, 200), new Vector(0, 0), null, 0);
            character.Add(enemy);
            tmr = new Timer();
            tmr.Interval = 16;
            tmr.Tick += Tmr_Tick; ;
            tmr.Start();
        }

        public void InputFromUser(Direction dir)
        {// set jeff's Velocity based on what FrmMain told us it is....

            if (dir == Direction.Left)
            {
                jeff.Vel.X = -jeff.MaxSpeed;
            }
            else if (dir == Direction.Right)
            {
                jeff.Vel.X = jeff.MaxSpeed;
            }
            else if (dir == Direction.Up)
            {
                jeff.Vel.Y = -jeff.MaxSpeed;
            }
            else if (dir == Direction.Down)
            {
                jeff.Vel.Y = jeff.MaxSpeed;
            }
            else if (dir == Direction.None)
            {
                jeff.Vel.X = 0;
                jeff.Vel.Y = 0;
            }


        }

        protected Dialogue Respond(NPCType type, int stateWeAreGoingTo)
        {
            Dialogue dlg = dialogs[type]; // get the correct dialog based on NPC type
 //           tbDialog.Text = "";// clear out previous menu
            // assume we walked up on NPCType.One:
            int oldState = dlg.State;// where were we before this action

            if (oldState != stateWeAreGoingTo)
            {
                List<Choice> allChoices = dlg.Choices;
                foreach (Choice ch in allChoices)
                {
                    if (ch.From == oldState && ch.Action == stateWeAreGoingTo)
                    {
                        Attitude += ch.AttAdjust;
                    }
                }



                List<Choice> allowedChoices = new List<Choice>();
                string fromMsg = lexicon[stateWeAreGoingTo];// get starting msg
                                                            //           tbDialog.AppendText(fromMsg + "\r\n");
                foreach (Choice ch in allChoices)
                {
                    if (ch.From == stateWeAreGoingTo)
                    {   // add only choices that start at state 0...
                        allowedChoices.Add(ch);
                    }
                }

                foreach (Choice ch in allowedChoices)
                {
                    int to = ch.Action;// get string index for "TO"
                    string msg = lexicon[to];
                    //               tbDialog.AppendText(to + ") " + msg + "\r\n");
                }
                //           tbDialog.AppendText("9) Exit\r\n");
                dlg.State = stateWeAreGoingTo;
            }
            return dlg;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            // jeff.React();
            

            jeff.Move(1.0);

            if(Update != null)
            {// if anyone is listening, here is my package of updated stuff...
                if (Mode == GameMode.Explore || Mode == GameMode.Combat)
                {
                    DisplayText dt = new DisplayText(log, null);
                    Update(character, jeff, dt);
                }
                else
                {
                    //in Dialog Mode, so send menu with list of choices..
                    Dialogue dlg = dialogs[dlgNPCType];
                    int oldState = dlg.State;
                    dlg = Respond(dlgNPCType, oldState);
                    Update(character, jeff, dlg.ConvertToDisplayText());
                }
            }

        }
    }
}
