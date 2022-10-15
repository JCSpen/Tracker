using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class Navigation
    {
        public int xCord = 0;
        public int yCord = 0;
        bool pointExists = false;
        public Dictionary<string,int> navData = new Dictionary<string,int>();
        public void Up()
        {
            yCord++;
            alterNavData();
        }

        public void Down()
        {
            yCord--;
            alterNavData();
        }

        public void Left()
        {
            xCord--;
            alterNavData();
        }

        public void Right()
        {
            xCord++;
            alterNavData();
        }

        public void alterNavData()
        {
            pointExists = existingCoordinate();
            if (pointExists)
            {
                navData["(" + xCord + "," + yCord + ")"]++;
            }
            else
                navData.Add("(" + xCord + "," + yCord + ")", 0);
        }

        bool existingCoordinate()
        {
          if(navData.ContainsKey("(" + xCord + "," + yCord + ")"))
            {
                return true;
            }
            return false;

        }
        public void sortNavData()
    {
        var sortedDict = from entry in navData orderby entry.Value descending select entry;
        foreach (var value in sortedDict)
        {
            Console.WriteLine(value);
            break;
        }
    }
    }

