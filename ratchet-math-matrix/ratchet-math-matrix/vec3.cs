using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Math
{
    public struct vec3
    {
        public float x;
        public float y;
        public float z;
        public vec3(float x, float y, float z) { this.x = x;  this.y = y;  this.z = z; }
        public static float Dot(vec3 a, vec3 b) { return a.x * b.x + a.y * b.y + a.z * b.z; }
        public static vec3 Cross(vec3 a, vec3 b) { return new vec3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x); }
        public float Norm() { return (float)System.Math.Sqrt(x * x + y * y + z * z); }
        public vec3 Normalize() { float norm = Norm(); return new vec3(x / norm, y / norm, z / norm); }
        public static vec3 operator +(vec3 a, vec3 b) { return new vec3(a.x + b.x, a.y + b.y, a.z + b.z); }
        public static vec3 operator -(vec3 a, vec3 b) { return new vec3(a.x - b.x, a.y - b.y, a.z - b.z); }
        public static vec3 operator *(vec3 a, vec3 b) { return new vec3(a.x * b.x, a.y * b.y, a.z * b.z); }
        public static vec3 operator /(vec3 a, vec3 b) { return new vec3(a.x / b.x, a.y / b.y, a.z / b.z); }
        public static vec3 operator *(vec3 a, float b) { return new vec3(a.x * b, a.y * b, a.z * b); }
        public static vec3 operator /(vec3 a, float b) { return new vec3(a.x / b, a.y / b, a.z / b); }
        public static vec3 operator *(float a, vec3 b) { return new vec3(a * b.x, a * b.y, a * b.z); }
        public static vec3 operator /(float a, vec3 b) { return new vec3(a / b.x, a / b.y, a / b.z); }

        public static vec3 operator -(vec3 a) { return new vec3(-a.x, -a.y, -a.z); }
    }
}
