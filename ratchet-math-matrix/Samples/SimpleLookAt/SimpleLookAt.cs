using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLookAt
{
    public partial class SimpleLookAt : Form
    {
        double angle = 0.0f;
        Ratchet.Math.vec3 _CameraPosition = new Ratchet.Math.vec3(0.5f, 2.0f, -1.0f);
        Ratchet.Math.vec3 _CameraLookAt = new Ratchet.Math.vec3(0.5f, 0.5f, 0.5f);

        Common.Cube _Cube = new Common.Cube(new Ratchet.Math.vec3(0.0f, 0.0f, 0.0f), 1.0f);

        public SimpleLookAt()
        {
            InitializeComponent();
        }

        private void SimpleLookAt_Load(object sender, EventArgs e)
        {
        }


        private void SimpleLookAt_Paint(object sender, PaintEventArgs e)
        {
            Ratchet.Math.mat4 screen = Ratchet.Math.mat4.Perspective(2.8f, Width / Height, 0.0f, 1.0f).Transpose();
            Ratchet.Math.mat4 lookAt = Ratchet.Math.mat4.LookAt(_CameraPosition, _CameraLookAt, new Ratchet.Math.vec3(0.0f, 1.0f, 0.0f));

            _Cube.Draw(e.Graphics, Brushes.Red, Ratchet.Math.mat4.Identity(), lookAt, screen);
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void SimpleLookAt_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void update_Tick(object sender, EventArgs e)
        {
            angle += 0.05;
            _CameraPosition = new Ratchet.Math.vec3((float)Math.Cos(angle) * 2.5f, 2.0f, (float)Math.Sin(angle) * 2.5f);
        }

        private void SimpleLookAt_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
