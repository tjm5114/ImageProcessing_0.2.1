using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing
{
    public abstract class ImageFilter<T>
    {
        Bitmap mOriginalImage;
        T mSetting;
        public Image ProcessImage(T setting, Image image)
        {
            return ProcessImage(setting, new Bitmap(image));
        }
        public Bitmap ProcessImage(T setting, Bitmap image)
        {
            mSetting = setting;
            mOriginalImage = image;
            return FilterProcessImage(setting, image);
        }
       
        public abstract Bitmap FilterProcessImage(T setting, Bitmap image);
       
        public abstract Control GetParameterWindow();

        public Bitmap OriginalImage
        {
            get
            {
                return mOriginalImage;
            }
        }
    }
}
