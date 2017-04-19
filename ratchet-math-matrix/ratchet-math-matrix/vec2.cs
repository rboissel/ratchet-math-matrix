using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Math
{
    public struct vec2
    {
        public float x;
        public float y;
        public vec2(float x, float y) { this.x = x;  this.y = y; }
        public static float Dot(vec2 a, vec2 b) { return a.x * b.x + a.y * b.y; }
        public float Norm() { return (float)System.Math.Sqrt(x * x + y * y); }
        public vec2 Normalize() { float norm = Norm(); return new vec2(x / norm, y / norm); }
        public static vec2 operator +(vec2 a, vec2 b) { return new vec2(a.x + b.x, a.y + b.y); }
        public static vec2 operator -(vec2 a, vec2 b) { return new vec2(a.x - b.x, a.y - b.y); }
        public static vec2 operator *(vec2 a, vec2 b) { return new vec2(a.x * b.x, a.y * b.y); }
        public static vec2 operator /(vec2 a, vec2 b) { return new vec2(a.x / b.x, a.y / b.y); }
        public static vec2 operator *(vec2 a, float b) { return new vec2(a.x * b, a.y * b); }
        public static vec2 operator /(vec2 a, float b) { return new vec2(a.x / b, a.y / b); }
        public static vec2 operator *(float a, vec2 b) { return new vec2(a * b.x, a * b.y); }
        public static vec2 operator /(float a, vec2 b) { return new vec2(a / b.x, a / b.y); }
        public static vec2 operator -(vec2 a) { return new vec2(-a.x, -a.y); }

    }
}
