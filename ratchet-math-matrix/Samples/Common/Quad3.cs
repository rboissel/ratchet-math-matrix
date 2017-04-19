using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct Quad3
    {
        public Triangle3 t1;
        public Triangle3 t2;
        public Quad3(Ratchet.Math.vec3 p1, Ratchet.Math.vec3 p2, Ratchet.Math.vec3 p3, Ratchet.Math.vec3 p4)
        {
            t1 = new Triangle3(p1, p2, p3);
            t2 = new Triangle3(p1, p3, p4);
        }
        public Quad3(Triangle3 t1, Triangle3 t2)
        {
            this.t1 = t1;
            this.t2 = t2;
        }

        public static Quad3 operator *(Ratchet.Math.mat4 mat4, Quad3 quad3)
        {
            return new Quad3(mat4 * quad3.t1, mat4 * quad3.t2);
        }

        public void Draw(System.Drawing.Graphics g, System.Drawing.Brush b, Ratchet.Math.mat4 model, Ratchet.Math.mat4 view, Ratchet.Math.mat4 projection)
        {
            t1.Draw(g, b, model, view, projection);
            t2.Draw(g, b, model, view, projection);
        }
    }
}
