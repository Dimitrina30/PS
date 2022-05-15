using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class Logger
    {

        static private List<string> currentSessionActivities = new List<string>();
        static private ICollection<string> fileContent;
        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
            + LoginValidation.currentUserUsername + ";"
            + LoginValidation.currentUserRole + ";"
            + activity;
            currentSessionActivities.Add(activityLine);

            string fileName = "test.txt";
            if (File.Exists(fileName))
            {
                File.AppendAllText("fileName", activityLine + "\n");
            }

        }
        public static IEnumerable<string> GetCurrentSessionActivity(string filter)
        {
            // StringBuilder currentActivity = new StringBuilder();

            List<string> currentActivity = (from activity in currentSessionActivities where activity.Contains(filter) select activity).ToList();


            return currentActivity;
        }

        public static IEnumerable<string> getFileContent()
        {
            return fileContent;
        }


    }
}