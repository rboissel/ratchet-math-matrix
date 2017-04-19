using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Math
{
    public struct mat4
    {
        public float m11;
        public float m12;
        public float m13;
        public float m14;

        public float m21;
        public float m22;
        public float m23;
        public float m24;


        public float m31;
        public float m32;
        public float m33;
        public float m34;

        public float m41;
        public float m42;
        public float m43;
        public float m44;


        public mat4(float m11, float m21, float m31, float m41,
                    float m12, float m22, float m32, float m42,
                    float m13, float m23, float m33, float m43,
                    float m14, float m24, float m34, float m44)
        {
            this.m11 = m11; this.m21 = m21; this.m31 = m31; this.m41 = m41;
            this.m12 = m12; this.m22 = m22; this.m32 = m32; this.m42 = m42;
            this.m13 = m13; this.m23 = m23; this.m33 = m33; this.m43 = m43;
            this.m14 = m14; this.m24 = m24; this.m34 = m34; this.m44 = m44;

        }

        public mat4 Transpose() { return new mat4(m11, m12, m13, m14, m21, m22, m23, m24, m31, m32, m33, m34, m41, m42, m43, m44); }

        public static mat4 Identity()
        {
            return new mat4(1.0f, 0.0f, 0.0f, 0.0f,
                            0.0f, 1.0f, 0.0f, 0.0f,
                            0.0f, 0.0f, 1.0f, 0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static mat4 Translation(float x, float y, float z)
        {
            return new mat4(1.0f, 0.0f, 0.0f, x,
                            0.0f, 1.0f, 0.0f, y,
                            0.0f, 0.0f, 1.0f, z,
                            0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static mat4 Translation(vec3 v)
        {
            return new mat4(1.0f, 0.0f, 0.0f, v.x,
                            0.0f, 1.0f, 0.0f, v.y,
                            0.0f, 0.0f, 1.0f, v.z,
                            0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static mat4 Scale(float x, float y, float z, float w)
        {
            return new mat4(x, 0.0f, 0.0f, 0.0f,
                            0.0f, y, 0.0f, 0.0f,
                            0.0f, 0.0f, z, 0.0f,
                            0.0f, 0.0f, 0.0f, w);
        }

        public static mat4 LookAt(vec3 eye, vec3 center, vec3 up)
        {
            vec3 f = (center - eye).Normalize();
            vec3 w = up.Normalize();
            vec3 s = vec3.Cross(f, w);
            vec3 u = vec3.Cross(s, f);
            return new mat4(s.x, s.y, s.z, 0.0f,
                            u.x, u.y, u.z, 0.0f,
                            -f.x, -f.y, -f.z, 0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f) * mat4.Translation(-eye);

        }

        public static mat4 Perspective(float fovy, float aspect, float zNear, float zFar)
        {
            float f = (float)(System.Math.Cos(fovy / 2) / System.Math.Sin(fovy / 2));
            return new mat4(f / aspect, 0.0f, 0.0f, 0.0f,
                            0.0f, f, 0.0f, 0.0f,
                            0.0f, 0.0f, (zFar + zNear) / (zNear - zFar), (2 * zFar * zNear) / (zNear - zFar),
                            0.0f, 0.0f, -1.0f, 0.0f);

        }

        public static vec4 operator *(mat4 a, vec4 b)
        {
            return new vec4(a.m11 * b.x + a.m21 * b.y + a.m31 * b.z + a.m41 * b.w,
                            a.m12 * b.x + a.m22 * b.y + a.m32 * b.z + a.m42 * b.w,
                            a.m13 * b.x + a.m23 * b.y + a.m33 * b.z + a.m43 * b.w,
                            a.m14 * b.x + a.m24 * b.y + a.m34 * b.z + a.m44 * b.w);
        }


        public static mat4 operator *(mat4 a, mat4 b)
        {
            return new mat4(a.m11 * b.m11 + a.m21 * b.m12 + a.m31 * b.m13 + a.m41 * b.m14,
                            a.m11 * b.m21 + a.m21 * b.m22 + a.m31 * b.m23 + a.m41 * b.m24,
                            a.m11 * b.m31 + a.m21 * b.m32 + a.m31 * b.m33 + a.m41 * b.m34,
                            a.m11 * b.m41 + a.m21 * b.m42 + a.m31 * b.m43 + a.m41 * b.m44,
                            a.m12 * b.m11 + a.m22 * b.m12 + a.m32 * b.m13 + a.m42 * b.m14,
                            a.m12 * b.m21 + a.m22 * b.m22 + a.m32 * b.m23 + a.m42 * b.m24,
                            a.m12 * b.m31 + a.m22 * b.m32 + a.m32 * b.m33 + a.m42 * b.m34,
                            a.m12 * b.m41 + a.m22 * b.m42 + a.m32 * b.m43 + a.m42 * b.m44,
                            a.m13 * b.m11 + a.m23 * b.m12 + a.m33 * b.m13 + a.m43 * b.m14,
                            a.m13 * b.m21 + a.m23 * b.m22 + a.m33 * b.m23 + a.m43 * b.m24,
                            a.m13 * b.m31 + a.m23 * b.m32 + a.m33 * b.m33 + a.m43 * b.m34,
                            a.m13 * b.m41 + a.m23 * b.m42 + a.m33 * b.m43 + a.m43 * b.m44,
                            a.m14 * b.m11 + a.m24 * b.m12 + a.m34 * b.m13 + a.m44 * b.m14,
                            a.m14 * b.m21 + a.m24 * b.m22 + a.m34 * b.m23 + a.m44 * b.m24,
                            a.m14 * b.m31 + a.m24 * b.m32 + a.m34 * b.m33 + a.m44 * b.m34,
                            a.m14 * b.m41 + a.m24 * b.m42 + a.m34 * b.m43 + a.m44 * b.m44);
        }
    }
}
