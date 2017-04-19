using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Math
{
    public struct vec4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public vec4(float x, float y, float z, float w) { this.x = x; this.y = y; this.z = z; this.w = w; }
        public vec4(vec3 v, float w) { this.x = v.x; this.y = v.y; this.z = v.z; this.w = w; }

        public static float Dot(vec4 a, vec4 b) { return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w; }
        public static vec4 operator +(vec4 a, vec4 b) { return new vec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w); }
        public static vec4 operator -(vec4 a, vec4 b) { return new vec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w); }
        public static vec4 operator *(vec4 a, vec4 b) { return new vec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w); }
        public static vec4 operator /(vec4 a, vec4 b) { return new vec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w); }
        public static vec4 operator *(vec4 a, float b) { return new vec4(a.x * b, a.y * b, a.z * b, a.w * b); }
        public static vec4 operator /(vec4 a, float b) { return new vec4(a.x / b, a.y / b, a.z / b, a.w / b); }
        public static vec4 operator *(float a, vec4 b) { return new vec4(a * b.x, a * b.y, a * b.z, a * b.w); }
        public static vec4 operator /(float a, vec4 b) { return new vec4(a / b.x, a / b.y, a / b.z, a / b.w); }
        public static vec4 operator -(vec4 a) { return new vec4(-a.x, -a.y, -a.z, -a.w); }
    }
}
