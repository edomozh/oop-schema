using System.ComponentModel;
using System.Drawing;

namespace OOP
{
    public partial class Line : Component
    {
        public Detail From { get; set; }
        public Detail To { get; set; }
        
        public Line() { InitializeComponent(); }
        public Line(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public void Draw(Graphics g)
        {
            Point from = From.Center;
            Point to = To.Center;

            Pen p = new Pen(Color.Black); 
            g.DrawLine(p, from, new Point(from.X, to.Y));
            g.DrawLine(p, new Point(from.X, to.Y), new Point(to.X, to.Y));
        }
    }
}
