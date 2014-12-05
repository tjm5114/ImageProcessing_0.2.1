using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class ParmFormBase : UserControl
    {
        public event EventHandler<EventArgs> ParmsChanged;
        
        public ParmFormBase()
        {
            InitializeComponent();
        }
        protected void raiseParmChangedEvent()
        {
            if (ParmsChanged != null)
                ParmsChanged(this, new EventArgs());
        }
    }
}
