using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct Triangle2
    {
        public Ratchet.Math.vec2 p1;
        public Ratchet.Math.vec2 p2;
        public Ratchet.Math.vec2 p3;
        public Triangle2(Ratchet.Math.vec2 p1, Ratchet.Math.vec2 p2, Ratchet.Math.vec2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public static Triangle2 operator*(Ratchet.Math.mat2 mat2, Triangle2 triangle2)
        {
            return new Triangle2(mat2 * triangle2.p1, mat2 * triangle2.p2, mat2 * triangle2.p3);
        }
    }
}
