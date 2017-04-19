using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct Cube
    {
        Quad3 _1;
        Quad3 _2;
        Quad3 _3;
        Quad3 _4;
        Quad3 _5;
        Quad3 _6;

        public Cube(Ratchet.Math.vec3 Position, float Size)
        {
            _1 = new Quad3(new Ratchet.Math.vec3(Position.x, Position.y, Position.z), new Ratchet.Math.vec3(Position.x + Size, Position.y, Position.z), new Ratchet.Math.vec3(Position.x + Size, Position.y, Position.z + Size), new Ratchet.Math.vec3(Position.x, Position.y, Position.z + Size));
            _2 = new Quad3(new Ratchet.Math.vec3(Position.x, Position.y + Size, Position.z), new Ratchet.Math.vec3(Position.x + Size, Position.y + Size, Position.z), new Ratchet.Math.vec3(Position.x + Size, Position.y + Size, Position.z + Size), new Ratchet.Math.vec3(Position.x, Position.y + Size, Position.z + Size));
            _3 = new Quad3(new Ratchet.Math.vec3(Position.x, Position.y, Position.z), new Ratchet.Math.vec3(Position.x, Position.y + Size, Position.z), new Ratchet.Math.vec3(Position.x + Size, Position.y + Size, Position.z), new Ratchet.Math.vec3(Position.x + Size, Position.y, Position.z));
            _4 = new Quad3(new Ratchet.Math.vec3(Position.x, Position.y, Position.z + Size), new Ratchet.Math.vec3(Position.x, Position.y, Position.z + Size), new Ratchet.Math.vec3(Position.x + Size, Position.y + Size, Position.z + Size), new Ratchet.Math.vec3(Position.x + Size, Position.y, Position.z + Size));
            _5 = new Quad3(new Ratchet.Math.vec3(Position.x, Position.y, Position.z), new Ratchet.Math.vec3(Position.x, Position.y + Size, Position.z), new Ratchet.Math.vec3(Position.x, Position.y + Size, Position.z + Size), new Ratchet.Math.vec3(Position.x, Position.y, Position.z + Size));
            _6 = new Quad3(new Ratchet.Math.vec3(Position.x + Size, Position.y, Position.z), new Ratchet.Math.vec3(Position.x + Size, Position.y + Size, Position.z), new Ratchet.Math.vec3(Position.x + Size, Position.y + Size, Position.z + Size), new Ratchet.Math.vec3(Position.x + Size, Position.y, Position.z + Size));

        }

        public void Draw(System.Drawing.Graphics g, System.Drawing.Brush b, Ratchet.Math.mat4 model, Ratchet.Math.mat4 view, Ratchet.Math.mat4 projection)
        {
            _1.Draw(g, b, model, view, projection);
            _2.Draw(g, b, model, view, projection);
            _3.Draw(g, b, model, view, projection);
            _4.Draw(g, b, model, view, projection);
            _5.Draw(g, b, model, view, projection);
            _6.Draw(g, b, model, view, projection);
        }
    }
}
