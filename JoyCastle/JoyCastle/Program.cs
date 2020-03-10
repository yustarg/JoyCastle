using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyCastle
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1 segmentString = new Question1();
            bool canBeSegmented = segmentString.DoSegmentString("castlejoycastlecatjoy", 
                                            new List<string>() { "joy", "castle", "cat" });
            Console.WriteLine("Qustion1. Can input string be segmented? " + canBeSegmented);

            Question2 overlapRects = new Question2();
            int count = overlapRects.DoCalculateOverlapRects();
            Console.WriteLine("Qustion2. The number of overlapped rects? " + count);

            Console.ReadLine();
        }
    }
}
