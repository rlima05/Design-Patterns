using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MediatorPattern
{
    public class Mediator
    {
        private List<Plane> _planes = new List<Plane>();

        public Plane CreateNewPlane()
        {
            var plane = new Plane();
            plane.SetMediator(this);
            _planes.Add(plane);
            return plane;
        }

        public void Send(Point location, Plane plane)
        {
            _planes.Where(c => c != plane).ToList().ForEach(c => c.ReceiveLocation(location));
        }
    }
}
