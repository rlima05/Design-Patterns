using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MediatorPattern
{
    public class Plane : Label
    {
        private Mediator _mediator;
        private Point _mouseDownLocation;

        public Plane()
        {
            Text = "Drag me to fly";
            TextAlign = ContentAlignment.MiddleCenter;
            MouseDown += OnMouseDown;
            MouseMove += OnMouseMove;
        }

        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = e.Location;
            }
        }

        public void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Text = Location.ToString();
                Left = e.X + Left - _mouseDownLocation.X;
                Top = e.Y + Top - _mouseDownLocation.Y;
                _mediator.Send(Location, this);
            }
        }

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void ReceiveLocation(Point location)
        {
            var distance = CalculateDistance(location);
            if(distance < 100 && BackColor != Color.Red)
            {
                BackColor = Color.Red;
                Text = "Be careful!!!";
            }
            else if (distance >= 100 && BackColor != Color.Green)
            {
                BackColor = Color.Green;
                Text = Location.ToString();
            }
        }

        double CalculateDistance(Point point) =>
            Math.Sqrt(Math.Pow(point.X - Location.X, 2) + Math.Pow(point.Y - Location.Y, 2));
    }
}
