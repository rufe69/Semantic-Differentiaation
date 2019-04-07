using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemDiff
{
    public class Respondent
    {
        public string Name;
        public int Age;
        public string AddedInfo;

        public Test Aggressive;
        public Test Bulling;
        public Test Abuse;
        public Test Conflict;
        public Test Suppression;
        public Test Provocation;

        public Respondent()
        {
            Name = "Новый респондент";

            Aggressive = new Test();
            Bulling = new Test();
            Abuse = new Test();
            Conflict = new Test();
            Suppression = new Test();
            Provocation = new Test();
        }
    }
}
