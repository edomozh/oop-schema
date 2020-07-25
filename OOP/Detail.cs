using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP
{
    public partial class Detail : Button
    {
        public bool IsPressed { get; private set; }

        public Point Center
        {
            get { return new Point(Location.X + Width / 2, Location.Y + Height / 2); }
        }

        public event EventHandler WantBind;
        public event EventHandler WantUntie;

        public Detail(Point location)
        {
            InitializeComponent();
            Location = new Point(location.X - Width / 2, location.Y - Height / 2);

            MouseDown += (s, e) => IsPressed = true;
            MouseUp += (s, e) => IsPressed = false;
            TextChanged += (s, e) => Width = Text.Length * 6 + 20;

            ContextMenu = new ContextMenu(
                new MenuItem[] {
                new MenuItem("Удалить", new EventHandler((s, e) => Dispose())),
                new MenuItem("Связать", new EventHandler((s, e) => WantBind(this, new EventArgs()))),
                new MenuItem("Удалить связи", new EventHandler((s, e) => WantUntie(this, new EventArgs())))
                });
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (IsPressed) Run(e.Location);
        }

        private void Run(Point newLocation)
        {
            Point p = Location;
            p.Offset(newLocation.X - Width / 2, newLocation.Y - Height / 2);
            Location = p;
        }

    }
}
