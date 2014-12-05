using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace ImageProcessing
{
    public class BinaryEroderParms
    {
        [NotifyParentProperty(true)]
        public Color ActiveColor { get; set; }
        [NotifyParentProperty(true)]
        public Color BlankColor { get; set; }
        [NotifyParentProperty(true)]
        public Bitmap StructureElement { get; set; }
        [NotifyParentProperty(true)]
        public Color SEActiveColor { get; set; }
        [NotifyParentProperty(true)]
        public int GrayscaleThreshold { get; set; }
        public BinaryEroderParms()
        {
            ActiveColor = Color.Yellow;
            StructureElement = new Bitmap(3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 || j == 1)
                        StructureElement.SetPixel(i, 0, Color.Red);
                    else
                        StructureElement.SetPixel(i, 0, Color.Black);
                }
            }
            SEActiveColor = Color.Red;
            ActiveColor = Color.Yellow;
            BlankColor = Color.Black;
            GrayscaleThreshold = 200;
        }
    }
    public class BinaryEroder : ImageFilter<BinaryEroderParms>
    {

        public override Bitmap FilterProcessImage(BinaryEroderParms parms, Bitmap image)
        {
            Bitmap ret = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    bool keep = true;
                    for (int m = 0; m < parms.StructureElement.Width; m++)
                    {
                        for (int n = 0; n < parms.StructureElement.Height; n++)
                        {
                            Color a = image.GetPixel(Math.Min(Math.Max(0, i + m - parms.StructureElement.Width / 2), image.Width - 1),
                                                     Math.Min(Math.Max(0, j + n - parms.StructureElement.Height / 2), image.Height - 1));
                            Color b = parms.StructureElement.GetPixel(m, n);
                            int grayScale = (int)(a.R * 0.3 + a.G * 0.59 + a.B * 0.11);
                            if (b.R == parms.SEActiveColor.R
                                && b.G == parms.SEActiveColor.G
                                && b.B == parms.SEActiveColor.B
                                && grayScale < parms.GrayscaleThreshold)
                            {
                                keep = false;
                                continue;
                            }
                        }
                    }
                    ret.SetPixel(i, j, keep? parms.ActiveColor: parms.BlankColor);
                }
            }
            return ret;
        }
        public override System.Windows.Forms.Control GetParameterWindow()
        {
            return new BinaryEroderParmForm();
        }
    }
}
