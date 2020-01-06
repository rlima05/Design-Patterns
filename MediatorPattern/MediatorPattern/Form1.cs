using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediatorPattern
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Mediator _mediator = new Mediator();
        public Form()
        {
            InitializeComponent();
        }

        private void buttonAddLabel_Click(object sender, EventArgs e)
        {
            var plane = _mediator.CreateNewPlane();
            Controls.Add(plane);
        }
    }
}
