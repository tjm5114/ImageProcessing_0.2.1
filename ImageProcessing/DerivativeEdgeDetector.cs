using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace ImageProcessing
{
    public class DerivateiveEdgeDetectorParms
    {
        [NotifyParentProperty(true)]
        public Channels Channel { get; set; }
        [NotifyParentProperty(true)]
        public int Threshold { get; set; }
        [NotifyParentProperty(true)]
        public bool ConvertToGrayscale { get; set; }
        [NotifyParentProperty(true)]
        public Color EdgeColor { get; set; }
        [NotifyParentProperty(true)]
        public bool CopyOriginal { get; set; }
        public DerivateiveEdgeDetectorParms()
        {
            Channel = Channels.RGB;
            Threshold = 50;
            ConvertToGrayscale = true;
            EdgeColor = Color.Yellow;
            CopyOriginal = true;
        }
    }
    public class DerivativeEdgeDetector: ImageFilter<DerivateiveEdgeDetectorParms>
    {
       
        public override Bitmap FilterProcessImage(DerivateiveEdgeDetectorParms parms, Bitmap image)
        {
            Bitmap ret = new Bitmap(image.Width, image.Height);
            for (int i = 1; i < image.Width - 1; i++)
            {
                for (int j = 1; j < image.Height - 1; j++)
                {
                    Color cr = image.GetPixel(i + 1, j);
                    Color cl = image.GetPixel(i - 1, j);
                    Color cu = image.GetPixel(i, j - 1);
                    Color cd = image.GetPixel(i, j + 1);
                    int dx = 0, dy = 0;
                    switch (parms.Channel)
                    {
                        case Channels.R:
                            dx = cr.R - cl.R;
                            dy = cd.R - cu.R;
                            break;
                        case Channels.G:
                            dx = cr.G - cl.G;
                            dy = cd.G - cu.G;
                            break;
                        case Channels.B:
                            dx = cr.B - cl.B;
                            dy = cd.B - cu.B;
                            break;
                        case Channels.RGB:
                            dx = (int)(cr.R * .3 + cr.G * .59 + cr.B * 0.11 - (cl.R * .3 + cl.G * .59 + cl.B * 0.11));
                            dy = (int)(cd.R * .3 + cd.G * .59 + cd.B * 0.11 - (cu.R * .3 + cu.G * .59 + cu.B * 0.11));
                            break;
                    }
                    double power = Math.Sqrt(dx * dx / 4 + dy * dy / 4);
                    if (power > parms.Threshold)
                        ret.SetPixel(i, j, parms.EdgeColor);
                    else
                    {
                        if (parms.CopyOriginal)
                        {
                            Color c = image.GetPixel(i, j);
                            if (parms.ConvertToGrayscale)
                            {
                                ret.SetPixel(i, j,
                                    Color.FromArgb(255,
                                    (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11),
                                    (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11),
                                    (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11)));
                            }
                            else
                                ret.SetPixel(i, j, c);
                        }
                        else
                            ret.SetPixel(i, j, Color.White);
                    }
                }
            }
            return ret;
        }
        public override System.Windows.Forms.Control GetParameterWindow()
        {
            return new DerivativeEdgeDetectorParmForm();
        }
    }
}
