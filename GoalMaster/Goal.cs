using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalMaster
{
    [Serializable]
    public class Goal : IComparable
    {
        private bool skip;
        private int g_goalNumber;
        private string g_fiction;
        private string g_text;
        private string g_summary;
        private int g_type;
        private int g_target;
        private int g_gold;
        private int g_gems;
        private int g_goods;
        private int g_loot;
        private bool g_t1special;
        private int g_special;
        private int g_specials;
        private int g_state;
        private int g_reverse;
        private int g_optional;
        private int g_bonus;
        private int g_final;
        private int g_irreversible;
        private int g_mindiff;
        private int g_maxdiff;
        private int g_visible;

        public bool SkipGoal
        {
            get { return skip; }
            set { skip = value; }
        }

        public int Number
        {
            get { return g_goalNumber; }
            set { g_goalNumber = value; }
        }

        public string Fiction
        {
            get { return g_fiction; }
            set { g_fiction = value; }
        }

        public string Text
        {
            get { return g_text; }
            set { g_text = value; }
        }

        public string Summary
        {
            get { return g_summary; }
            set { g_summary = value; }
        }

        public int Type
        {
            get { return g_type; }
            set { g_type = value; }
        }

        public int Target
        {
            get { return g_target; }
            set { g_target = value; }
        }

        public int Gold
        {
            get { return g_gold; }
            set { g_gold = value; }
        }

        public int Gems
        {
            get { return g_gems; }
            set { g_gems = value; }
        }

        public int Goods
        {
            get { return g_goods; }
            set { g_goods = value; }
        }

        public int Loot
        {
            get { return g_loot; }
            set { g_loot = value; }
        }

        public bool T1Special
        {
            get { return g_t1special; }
            set { g_t1special = value; }
        }

        public int Special
        {
            get { return g_special; }
            set { g_special = value; }
        }

        public int Specials
        {
            get { return g_specials; }
            set { g_specials = value; }
        }

        public int State
        {
            get { return g_state; }
            set { g_state = value; }
        }

        public int Reverse
        {
            get { return g_reverse; }
            set { g_reverse = value; }
        }

        public int Optional
        {
            get { return g_optional; }
            set { g_optional = value; }
        }

        public int Bonus
        {
            get { return g_bonus; }
            set { g_bonus = value; }
        }

        public int Final
        {
            get { return g_final; }
            set { g_final = value; }
        }

        public int Irreversible
        {
            get { return g_irreversible; }
            set { g_irreversible = value; }
        }

        public int MinDiff
        {
            get { return g_mindiff; }
            set { g_mindiff = value; }
        }

        public int MaxDiff
        {
            get { return g_maxdiff; }
            set { g_maxdiff = value; }
        }

        public int Visible
        {
            get { return g_visible; }
            set { g_visible = value; }
        }

        public int CompareTo(object obj)
        {
            if (obj is Goal)
            {
                Goal compGoal = (Goal)obj;
                return Number.CompareTo(compGoal.Number);
            }
            else
            {
                throw new ArgumentException("Object is not a \"Goal\" type.");
            }
        }
    }
}
