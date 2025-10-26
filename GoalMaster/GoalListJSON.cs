using System.IO;
using Newtonsoft.Json;

namespace GoalMaster
{
    internal class GoalListJSON
    {
        internal static void SaveGoalsJSON(string goalListFilepath, GoalsData gData)
        {
            string goalsData = JsonConvert.SerializeObject(gData, Formatting.Indented);
            File.WriteAllText(goalListFilepath, goalsData);
        }

        internal static GoalsData GetGoalsJSON(string goalListfilepath)
        {
            string goalText = File.ReadAllText(goalListfilepath);
            GoalsData loadedGoals = JsonConvert.DeserializeObject<GoalsData>(goalText);
            return loadedGoals;
        }
    }
}
