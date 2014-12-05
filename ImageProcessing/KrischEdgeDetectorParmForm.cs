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
    public partial class KrischEdgeDetectorParmForm : ParmFormBase
    {
        private KrischEdgeDetectorParms mParms = new KrischEdgeDetectorParms();
        public KrischEdgeDetectorParmForm()
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


        public KrischEdgeDetectorParms Parms
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t;
           
            t = mParms.meZtech;
            textBox1.Text = t.ToString();
        {
            
        }  
        }

        //void KrischEdgeDetector(object sender, EventArgs e)
        //{

        //}  
    }
}
