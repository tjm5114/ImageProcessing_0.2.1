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
    public partial class BinaryEroderParmForm : ParmFormBase
    {
        private BinaryEroderParms mParms = new BinaryEroderParms();
        public BinaryEroderParmForm()
        {
            InitializeComponent();
            binaryEroderParmsBindingSource.DataSource = mParms;
        }

        void mParms_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            raiseParmChangedEvent();
        }



        private void BinaryEroderParmForm_Load(object sender, EventArgs e)
        {
        }


        public BinaryEroderParms Parms
        {
            get
            {
                return mParms;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            raiseParmChangedEvent();
        }

        private void panelStructureColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                panelStructureColor.BackColor = colorDialog1.Color;
        }

        private void panelBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                panelBackColor.BackColor = colorDialog1.Color;

        }

        private void panelActiveColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                panelActiveColor.BackColor = colorDialog1.Color;
        }


        private void btnElementReference_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picElement.Load(openFileDialog1.FileName);
                    mParms.StructureElement = (Bitmap)picElement.Image;
                }
                catch
                {
                    MessageBox.Show("Can't load selected image file.");
                }
            }
        }

        private void binaryEroderParmsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            lblElementSize.Text = "Size:" + (picElement.Image == null ? "(null)" : "(" + picElement.Image.Width.ToString() + " X " + picElement.Image.Height.ToString() + ")");
        }
        
    }
}
