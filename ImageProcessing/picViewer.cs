using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class picViewer : Form
    {
        public Image Image
        {
            set
            {
                picture.Image = value;
            }
            get
            {
                return picture.Image;
            }
        }
        public Bitmap Bitmap
        {
            set
            {
                picture.Image = value;
            }
            get
            {
                return new Bitmap(picture.Image);
            }
        }
        public Control ParmControl
        {
            set
            {
                if (value != null)
                {
                    splitMain.Panel1.Controls.Clear();
                    splitMain.Panel1.Controls.Add(value);
                    splitMain.SplitterDistance = value.Height;
                    splitMain.Panel1Collapsed = false;
                }
                else
                    splitMain.Panel1Collapsed = true;
            }
            get
            {
                if (splitMain.Panel1.Controls.Count > 0)
                    return splitMain.Panel1.Controls[0];
                else
                    return null;
            }
        }
        public picViewer()
        {
            InitializeComponent();
        }

        private void picViewer_Load(object sender, EventArgs e)
        {
        }
    }
}
