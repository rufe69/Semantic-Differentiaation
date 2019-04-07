using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemDiff
{
    public class Result
    {
        public List<int> Assessment;
        public List<int> Strength;
        public List<int> Activity;

        public Result()
        {
            Assessment = new List<int>();
            Strength = new List<int>();
            Activity = new List<int>();
        }
    }
}
