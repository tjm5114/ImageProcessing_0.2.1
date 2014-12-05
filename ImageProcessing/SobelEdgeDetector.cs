using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace ImageProcessing
{
    public class SobelEdgeDetectorParms
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
        public SobelEdgeDetectorParms()
        {
            Channel = Channels.RGB;
            Threshold = 50;
            ConvertToGrayscale = true;
            EdgeColor = Color.Yellow;
            CopyOriginal = true;
        }
    }
    public class SobelEdgeDetector : ImageFilter<SobelEdgeDetectorParms>
    {
        private Color grayscale(Color cr)
        {
            return Color.FromArgb(cr.A, (int)(cr.R * .3 + cr.G * .59 + cr.B * 0.11),
                (int)(cr.R * .3 + cr.G * .59 + cr.B * 0.11),
                (int)(cr.R * .3 + cr.G * .59 + cr.B * 0.11));
        }
        public override Bitmap FilterProcessImage(SobelEdgeDetectorParms parms, Bitmap image)
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
                    Color cld = image.GetPixel(i - 1, j + 1);
                    Color clu = image.GetPixel(i - 1, j - 1);
                    Color crd = image.GetPixel(i + 1, j + 1);
                    Color cru = image.GetPixel(i + 1, j - 1);
                    int dx = 0, dy = 0;
                    switch (parms.Channel)
                    {
                        case Channels.R:
                            dx = cld.R + 2 * cd.R + crd.R - (clu.R + 2 * cu.R + cru.R);
                            dy = crd.R + 2 * cr.R + cru.R - (cld.R + 2 * cl.R + clu.R);
                            break;
                        case Channels.G:
                            dx = cld.G + 2 * cd.G + crd.G - (clu.G + 2 * cu.G + cru.G);
                            dy = crd.G + 2 * cr.G + cru.G - (cld.G + 2 * cl.G + clu.G);
                            break;
                        case Channels.B:
                            dx = cld.B + 2 * cd.B + crd.B - (clu.B + 2 * cu.B + cru.B);
                            dy = crd.B + 2 * cr.B + cru.B - (cld.B + 2 * cl.B + clu.B);
                            break;
                        case Channels.RGB:
                            dx = grayscale(cld).B + 2 * grayscale(cd).B + grayscale(crd).B - (grayscale(clu).B + 2 * grayscale(cu).B + grayscale(cru).B);
                            dy = grayscale(crd).B + 2 * grayscale(cr).B + grayscale(cru).B - (grayscale(cld).B + 2 * grayscale(cl).B + grayscale(clu).B);
                            break;
                    }
                    double power = Math.Abs(dx) + Math.Abs(dy);
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
            return new SobelEdgeDetectorParmForm();
        }
    }
}
