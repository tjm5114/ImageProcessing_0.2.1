using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class frmMain : Form
    {
       
        public frmMain()
        {
            InitializeComponent();
           
           
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofDialog.FileName))
            {
                picViewer view1 = new picViewer();
                view1.MdiParent = this;
                view1.WindowState = FormWindowState.Normal;
                view1.Image = Image.FromFile(ofDialog.FileName);
                view1.Show();
                Bitmap move1 = view1.Bitmap;
                move1.Save("c:\\Users\\Main\\Documents\\myNewimage1.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void dervivativeEdgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DerivativeEdgeDetector filter = new DerivativeEdgeDetector();
            picViewer view = new picViewer();
            view.ParmControl = filter.GetParameterWindow();
            Image image = filter.ProcessImage(
                ((DerivativeEdgeDetectorParmForm)view.ParmControl).Parms,
                ((picViewer)this.ActiveMdiChild).Image );
            view.MdiParent = this;
            view.WindowState = FormWindowState.Normal;
            view.Image = image;
            view.ParmControl = filter.GetParameterWindow();
            ((DerivativeEdgeDetectorParmForm)view.ParmControl).ParmsChanged += new EventHandler<EventArgs>((obj,target)=>
                {
                    view.Image = filter.ProcessImage(
                        ((DerivativeEdgeDetectorParmForm)view.ParmControl).Parms,
                        filter.OriginalImage);
                });
            view.Show();
        }

        private void sobelEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SobelEdgeDetector filter = new SobelEdgeDetector();
            picViewer view = new picViewer();
            view.ParmControl = filter.GetParameterWindow();
            Image image = filter.ProcessImage(
                ((SobelEdgeDetectorParmForm)view.ParmControl).Parms,
                ((picViewer)this.ActiveMdiChild).Image);
            view.MdiParent = this;
            view.WindowState = FormWindowState.Normal;
            view.Image = image;
            view.ParmControl = filter.GetParameterWindow();
            ((SobelEdgeDetectorParmForm)view.ParmControl).ParmsChanged += new EventHandler<EventArgs>((obj, target) =>
            {
                view.Image = filter.ProcessImage(
                    ((SobelEdgeDetectorParmForm)view.ParmControl).Parms,
                    filter.OriginalImage);
            });
            view.Show();
        }

        private void binaryErosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            BinaryEroder filter = new BinaryEroder();
            picViewer view = new picViewer();
            view.ParmControl = filter.GetParameterWindow();
            Image image = filter.ProcessImage(
                ((BinaryEroderParmForm)view.ParmControl).Parms,
                ((picViewer)this.ActiveMdiChild).Image);
            view.MdiParent = this;
            view.WindowState = FormWindowState.Normal;
            view.Image = image;
            view.ParmControl = filter.GetParameterWindow();
            ((BinaryEroderParmForm)view.ParmControl).ParmsChanged += new EventHandler<EventArgs>((obj, target) =>
            {
                view.Image = filter.ProcessImage(
                    ((BinaryEroderParmForm)view.ParmControl).Parms,
                    filter.OriginalImage);
            });
            view.Show();
        }

        private void krischEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            KrischEdgeDetector filter = new KrischEdgeDetector();
            
            picViewer view = new picViewer();
            view.ParmControl = filter.GetParameterWindow();
            Image image = filter.ProcessImage(
                ((KrischEdgeDetectorParmForm)view.ParmControl).Parms,
                ((picViewer)this.ActiveMdiChild).Image );
            view.MdiParent = this;
            view.StartPosition = FormStartPosition.CenterScreen; 
            view.WindowState = FormWindowState.Normal;
            view.Image = image;
            view.ParmControl = filter.GetParameterWindow();
            ((KrischEdgeDetectorParmForm)view.ParmControl).ParmsChanged += new EventHandler<EventArgs>((obj, target) =>
            {
                view.Image = filter.ProcessImage(
                    ((KrischEdgeDetectorParmForm)view.ParmControl).Parms,
                    filter.OriginalImage);
            });

           // messageOutput = image.Tag.ToString();
            
            view.Show();

           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String messageOutput = "";
            KrischEdgeDetector filter = new KrischEdgeDetector();

            picViewer view = new picViewer();
            view.ParmControl = filter.GetParameterWindow();

            

            Image image = filter.ProcessImage(
                ((KrischEdgeDetectorParmForm)view.ParmControl).Parms,
                ((picViewer)this.ActiveMdiChild).Image);
           

            view.StartPosition = FormStartPosition.CenterScreen;
            view.WindowState = FormWindowState.Normal;
            view.Image = image;
            view.ParmControl = filter.GetParameterWindow();
            ((KrischEdgeDetectorParmForm)view.ParmControl).ParmsChanged += new EventHandler<EventArgs>((obj, target) =>
            {
                view.Image = filter.ProcessImage(
                    ((KrischEdgeDetectorParmForm)view.ParmControl).Parms,
                    filter.OriginalImage);
            });

            
            messageOutput = image.Tag.ToString();
            textBox1.Text += messageOutput; 
            

        }

        private void toolStripButtonMove_Click(object sender, EventArgs e)
        {
            if (ofDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofDialog.FileName))
            {
                picViewer view2 = new picViewer();
                view2.MdiParent = this;
                view2.StartPosition = FormStartPosition.CenterScreen;
                view2.WindowState = FormWindowState.Normal;
                view2.Image = Image.FromFile(ofDialog.FileName);
                view2.Show();
                Bitmap move2 = view2.Bitmap;
                move2.Save("c:\\Users\\Main\\Documents\\myNewimage2.png", System.Drawing.Imaging.ImageFormat.Png);
            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

      
    }
}