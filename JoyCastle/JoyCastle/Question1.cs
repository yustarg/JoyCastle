using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyCastle
{
    class Question1
    {
        private Dictionary<string, bool> mMap = new Dictionary<string, bool>();

        public Question1() { }

        public bool DoSegmentString(string s, List<string> wordSet)
        {       
            if (wordSet.Contains(s))
            {
                return true;
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (!mMap.ContainsKey(s.Substring(0, i)))
                {
                    mMap.Add(s.Substring(0, i), DoSegmentString(s.Substring(0, i), wordSet));
                }

                if (!mMap.ContainsKey(s.Substring(i)))
                {
                    mMap.Add(s.Substring(i), DoSegmentString(s.Substring(i), wordSet));
                }

                if (mMap[s.Substring(0, i)] && mMap[s.Substring(i)])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
