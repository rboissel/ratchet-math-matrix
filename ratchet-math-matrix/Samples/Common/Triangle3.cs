using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct Triangle3
    {
        public Ratchet.Math.vec4 p1;
        public Ratchet.Math.vec4 p2;
        public Ratchet.Math.vec4 p3;
        public Triangle3(Ratchet.Math.vec3 p1, Ratchet.Math.vec3 p2, Ratchet.Math.vec3 p3)
        {
            this.p1 = new Ratchet.Math.vec4(p1, 1.0f);
            this.p2 = new Ratchet.Math.vec4(p2, 1.0f);
            this.p3 = new Ratchet.Math.vec4(p3, 1.0f);
        }

        public Triangle3(Ratchet.Math.vec4 p1, Ratchet.Math.vec4 p2, Ratchet.Math.vec4 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public static Triangle3 operator *(Ratchet.Math.mat4 mat4, Triangle3 triangle3)
        {
            return new Triangle3(mat4 * triangle3.p1, mat4 * triangle3.p2, mat4 * triangle3.p3);
        }

        public void Draw(System.Drawing.Graphics g, System.Drawing.Brush b, Ratchet.Math.mat4 model, Ratchet.Math.mat4 view, Ratchet.Math.mat4 projection)
        {
            Triangle3 t = (projection * (view * (model * this)));
            Ratchet.Math.vec2 p1 = new Ratchet.Math.vec2(t.p1.x / t.p1.z, -t.p1.y / t.p1.z);
            Ratchet.Math.vec2 p2 = new Ratchet.Math.vec2(t.p2.x / t.p2.z, -t.p2.y / t.p2.z);
            Ratchet.Math.vec2 p3 = new Ratchet.Math.vec2(t.p3.x / t.p3.z, -t.p3.y / t.p3.z);

            g.FillPolygon(b, new PointF[] { new PointF((p1.x + 1.0f) * (640 / 2), (p1.y + 1.0f) * (480 / 2)), new PointF((p2.x + 1.0f) * (640 / 2), (p2.y + 1.0f) * (480 / 2)), new PointF((p3.x + 1.0f) * (640 / 2), (p3.y + 1.0f) * (480 / 2)) });
           
        }
    }
}
