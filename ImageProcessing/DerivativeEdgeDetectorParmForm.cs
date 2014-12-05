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
    public partial class DerivativeEdgeDetectorParmForm : ParmFormBase
    {
        private DerivateiveEdgeDetectorParms mParms = new DerivateiveEdgeDetectorParms();
        public DerivativeEdgeDetectorParmForm()
        {
            InitializeComponent();
            derivateiveEdgeDetectorParmsBindingSource.DataSource = mParms;
        }

        void mParms_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            raiseParmChangedEvent();
        }



        private void DerivativeEdgeDetectorParmForm_Load(object sender, EventArgs e)
        {
            cbChannels.Items.Clear();
            cbChannels.Items.Add(Channels.R);
            cbChannels.Items.Add(Channels.G);
            cbChannels.Items.Add(Channels.B);
            cbChannels.Items.Add(Channels.RGB);
            
        }

        
        public DerivateiveEdgeDetectorParms Parms
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

        private void panelBorderColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                panelBorderColor.BackColor = colorDialog1.Color;
        }

        
    }
}
