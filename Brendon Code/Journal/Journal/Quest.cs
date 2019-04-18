using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    public class Quest
    {
        private string questName, questDiscription;
        private bool completed;


        public string GetQuestName{ get{ return questName; } }
        public string GetQuestDescription { get{ return questDiscription; } }
        public bool GetCompleted { get{ return completed; } }

        public Quest(string questName, string questDiscription, bool completed)
        {
            this.questName = questName;
            this.questDiscription = questDiscription;
            this.completed = completed;
        }

    }
}
