using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Math
{
    public struct mat3
    {
        public float m11;
        public float m12;
        public float m13;

        public float m21;
        public float m22;
        public float m23;

        public float m31;
        public float m32;
        public float m33;

        public mat3(float m11, float m21, float m31, float m12, float m22, float m32, float m13, float m23, float m33)
        {
            this.m11 = m11; this.m21 = m21; this.m31 = m31;
            this.m12 = m12; this.m22 = m22; this.m32 = m32;
            this.m13 = m13; this.m23 = m23; this.m33 = m33;
        }

        public mat3 Transpose() { return new mat3(m11, m12, m13, m21, m22, m23, m31, m32, m33); }

        public mat3 Translation(float x, float y)
        {
            return new mat3(1.0f, 0.0f, x,
                            0.0f, 1.0f, y,
                            0.0f, 0.0f, 1.0f);
        }

        public mat3 Scale(float x, float y, float z)
        {
            return new mat3(x, 0.0f, 0.0f,
                            0.0f, y, 0.0f,
                            0.0f, 0.0f, z);
        }

        public static mat3 Identity()
        {
            return new mat3(1.0f, 0.0f, 0.0f,
                            0.0f, 1.0f, 0.0f,
                            0.0f, 0.0f, 1.0f);
        }

        public static vec3 operator *(mat3 a, vec3 b)
        {
            return new vec3(a.m11 * b.x + a.m21 * b.y + a.m31 * b.z,
                            a.m12 * b.x + a.m22 * b.y + a.m32 * b.z,
                            a.m13 * b.x + a.m23 * b.y + a.m33 * b.z);
        }

        public static mat3 operator *(mat3 a, mat3 b)
        {
            return new mat3(a.m11 * b.m11 + a.m21 * b.m12 + a.m31 * b.m13,
                            a.m11 * b.m21 + a.m21 * b.m22 + a.m31 * b.m23,
                            a.m11 * b.m31 + a.m21 * b.m32 + a.m31 * b.m33,
                            a.m12 * b.m11 + a.m22 * b.m12 + a.m32 * b.m13,
                            a.m12 * b.m21 + a.m22 * b.m22 + a.m32 * b.m23,
                            a.m12 * b.m31 + a.m22 * b.m32 + a.m32 * b.m33,
                            a.m13 * b.m11 + a.m23 * b.m12 + a.m33 * b.m13,
                            a.m13 * b.m21 + a.m23 * b.m22 + a.m33 * b.m23,
                            a.m13 * b.m31 + a.m23 * b.m32 + a.m33 * b.m33);

        }

    }
}
