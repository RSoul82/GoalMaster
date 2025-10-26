using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalMaster
{
    internal class GoalsCMDFile
    {
        private static readonly string[] CLEAR_GOALS_TEMPLATE = {
            "quest_delete goal_type_", 
            "quest_delete goal_state_",
            "quest_delete goal_irreversible_",
            "quest_delete goal_target_",
            "quest_delete goal_visible_",
            "quest_delete goal_loot_",
            "quest_delete goal_gold_",
            "quest_delete goal_gems_",
            "quest_delete goal_goods_",
            "quest_delete goal_final_",
            "quest_delete goal_special_",
            "quest_delete goal_specials_",
            "quest_delete goal_optional_",
            "quest_delete goal_bonus_",
            "quest_delete goal_min_diff_",
            "quest_delete goal_max_diff_",
            "quest_delete goal_reverse_" };

        public static string GenerateCMDString(List<Goal> gList)
        {
            StringBuilder cmdList = new StringBuilder();
            string start = "quest_create_mis goal_";

            for (int n = 0; n < gList.Count; n++)
            {
                if (gList[n].SkipGoal == false)
                {
                    for(int i = 0; i < CLEAR_GOALS_TEMPLATE.Length; i++)
                    {
                        cmdList.AppendLine(CLEAR_GOALS_TEMPLATE[i] + n);
                    }

                    cmdList.AppendLine(start + "state_" + n + ", " + gList[n].State);
                    cmdList.AppendLine(start + "visible_" + n + ", " + gList[n].Visible);

                    if (gList[n].Type != 0) //0 is a 'no type' goal
                    {
                        cmdList.AppendLine(start + "type_" + n + ", " + gList[n].Type);
                        if (gList[n].Type != 3) //3 is loot
                        {
                            cmdList.AppendLine(start + "target_" + n + ", " + gList[n].Target);
                        }
                        else //if goal is loot
                        {
                            if (gList[n].Gold != 0)
                                cmdList.AppendLine(start + "gold_" + n + ", " + gList[n].Gold);
                            if (gList[n].Gems != 0)
                                cmdList.AppendLine(start + "gems_" + n + ", " + gList[n].Gems);
                            if (gList[n].Goods != 0)
                                cmdList.AppendLine(start + "goods_" + n + ", " + gList[n].Goods);
                            if (gList[n].Loot != 0)
                                cmdList.AppendLine(start + "loot_" + n + ", " + gList[n].Loot);
                            if (gList[n].Special != 0)
                                cmdList.AppendLine(start + "special_" + n + ", " + gList[n].Special);
                            if (gList[n].Specials != 0)
                                cmdList.AppendLine(start + "specials_" + n + ", " + gList[n].Specials);
                        }
                    }

                    //Flags
                    if (gList[n].Reverse == 1)
                        cmdList.AppendLine(start + "reverse_" + n + ", 1");
                    if (gList[n].Optional == 1)
                        cmdList.AppendLine(start + "optional_" + n + ", 1");
                    if (gList[n].Bonus == 1)
                        cmdList.AppendLine(start + "bonus_" + n + ", 1");
                    if (gList[n].Final == 1)
                        cmdList.AppendLine(start + "final_" + n + ", 1");
                    if (gList[n].Irreversible == 1)
                        cmdList.AppendLine(start + "irreversible_" + n + ", 1");

                    //Difficulty
                    if (gList[n].MinDiff != 0)
                        cmdList.AppendLine(start + "min_diff_" + n + ", " + gList[n].MinDiff);
                    if (gList[n].MaxDiff != 2)
                        cmdList.AppendLine(start + "max_diff_" + n + ", " + gList[n].MaxDiff);
                }
            }
            return cmdList.ToString();
        }
    }
}
