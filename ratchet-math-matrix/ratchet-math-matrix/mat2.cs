using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Math
{
    public struct mat2
    {
        public float m11;
        public float m12;
        public float m21;
        public float m22;

        public mat2(float m11, float m21, float m12, float m22) { this.m11 = m11; this.m21 = m21; this.m12 = m12; this.m22 = m22; }

        public mat2 Transpose() { return new mat2(m11, m12, m21, m22); }

        public static mat2 Identity()
        {
            return new mat2(1.0f, 0.0f,
                            0.0f, 1.0f);
        }

        public static mat2 Rotation(double Angle)
        {
            return new mat2((float)System.Math.Cos(Angle), -(float)System.Math.Sin(Angle),
                            (float)System.Math.Sin(Angle),(float)System.Math.Cos(Angle));
        }

        public mat2 Scale(float x, float y)
        {
            return new mat2(x, 0.0f,
                            0.0f, y);
        }

        public static vec2 operator* (mat2 a, vec2 b)
        {
            return new vec2(a.m11 * b.x + a.m21 * b.y,
                            a.m12 * b.x + a.m22 * b.y);
        }

        public static mat2 operator *(mat2 a, mat2 b)
        {
            return new mat2(a.m11 * b.m11 + a.m21 * b.m12,
                            a.m11 * b.m21 + a.m21 * b.m22,
                            a.m12 * b.m11 + a.m22 * b.m12,
                            a.m12 * b.m21 + a.m22 * b.m22);
        }

    }
}
