using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OOP
{
    public partial class Scheme : Control
    {
        bool isPullLine = false;
        Line newLine = new Line();
        List<Line> lines = new List<Line>();

        public Scheme() { InitializeComponent(); }
        public Scheme(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public void AddDetail(Detail d)
        {
            d.WantBind += DetailWantBind;
            d.WantUntie += DetailWantUntie;
            d.Disposed += DetailDisposed;
            d.Click += DetailClick;
            Controls.Add(d);
        }

        private void DetailClick(object sender, System.EventArgs e)
        {
            if (isPullLine)
            {
                newLine.To = (Detail)sender;
                AddLine(newLine);
                MouseMove -= DrawLine;
                newLine = null;
            } 
            isPullLine = false;
            Draw(CreateGraphics());
        }

        private void DetailDisposed(object sender, System.EventArgs e)
        {
            DetailWantUntie(sender, e);
        }

        private void DetailWantUntie(object sender, System.EventArgs e)
        {
            Detail d = (Detail)sender;
            lines.RemoveAll((o) => o.From == d || o.To == d);
            Draw();
        }

        private void DrawLine(object sender, MouseEventArgs e)
        {
            Pen p = new Pen(Color.Red);
            Graphics g = CreateGraphics();
            Draw(g);
            if (newLine != null) g.DrawLine(p, newLine.From.Center, e.Location);
        }

        private void DetailWantBind(object sender, System.EventArgs e)
        {
            isPullLine = true;
            newLine = new Line();
            newLine.From = (Detail)sender;
            MouseMove += DrawLine;
        }

        public void AddLine(Line d)
        {
            lines.Add(d);
        }

        private void Draw(Graphics g = null)
        {
            if (g == null) g = CreateGraphics();
            g.Clear(Color.Gray);
            lines.ForEach((line) => line.Draw(g));
        }
    }
}
