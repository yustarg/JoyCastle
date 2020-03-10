using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyCastle
{
    class Question2
    {
        public class Vector2
        {
            public int x, y;
            public Vector2(int x, int y) { this.x = x; this.y = y; }
        }

        public class Rect
        {
            public Vector2 bottomLeft;
            public Vector2 topRight;

            public Rect(Vector2 bl, Vector2 tr) { bottomLeft = bl; topRight = tr; }

            public bool IsOverlap(Rect other)
            {
                return Math.Max(this.bottomLeft.x, other.bottomLeft.x) <= Math.Min(this.topRight.x, other.topRight.x) &&
                    Math.Max(this.bottomLeft.y, other.bottomLeft.y) <= Math.Min(this.topRight.y, other.topRight.y);
            }
        }

        private static int RectCount = 10000;
        public int DoCalculateOverlapRects()
        {
            int _count = 0;
            Random _rd = new Random();
            List<Rect> _rects = new List<Rect>();
            for (int i = 0; i < RectCount; i++)
            {
                Rect r = new Rect(new Vector2(_rd.Next(), _rd.Next()), new Vector2(_rd.Next(), _rd.Next()));
                _rects.Add(r);
            }
            for (int i = 0; i < RectCount; i++)
            {
                for (int j = i + 1; j < RectCount; j++)
                {
                    if (_rects[i].IsOverlap(_rects[j]))
                    {
                        _count++;
                    }
                }
            }
            return _count;
        }
    }
}
