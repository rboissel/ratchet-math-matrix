using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRotation
{
    public partial class SimpleRotation : Form
    {
        public SimpleRotation()
        {
            InitializeComponent();
        }

        double _Angle = 0.0;

        private void SimpleRotation_Paint(object sender, PaintEventArgs e)
        {
            Common.Triangle2 triangle = new Common.Triangle2(new Ratchet.Math.vec2(0.0f, 0.0f), new Ratchet.Math.vec2(30.0f, 0.0f), new Ratchet.Math.vec2(15.0f, 30.0f));
            Ratchet.Math.mat2 rotation = Ratchet.Math.mat2.Rotation(_Angle);
            triangle = rotation * triangle;
            e.Graphics.FillPolygon(Brushes.Red, new PointF[] { new PointF(triangle.p1.x + Width / 2, triangle.p1.y + Height / 2), new PointF(triangle.p2.x + Width / 2, triangle.p2.y + Height / 2), new PointF(triangle.p3.x + Width / 2, triangle.p3.y + Height / 2) });
        }

        private void SimpleRotation_Load(object sender, EventArgs e)
        {
            
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            _Angle += 0.05;
            Invalidate();
        }
    }
}
