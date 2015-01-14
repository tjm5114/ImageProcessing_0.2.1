using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using AForge;
using Accord.Imaging;
using Accord.Imaging.Filters;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AForge.Imaging;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    public class KrischEdgeDetectorParms
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
        [NotifyParentProperty(true)]
        public String messageOut { get; set; }

        public KrischEdgeDetectorParms()
        {
            Channel = Channels.RGB;
            Threshold = 185;
            ConvertToGrayscale = true;
            EdgeColor = Color.Yellow;
            CopyOriginal = true;
            
        }
    }
    public class KrischEdgeDetector : ImageFilter<KrischEdgeDetectorParms>
    {


        private Color grayscale(Color cr)
        {
            return Color.FromArgb(cr.A, (int)(cr.R * .3 + cr.G * .59 + cr.B * 0.11),
                (int)(cr.R * .3 + cr.G * .59 + cr.B * 0.11),
                (int)(cr.R * .3 + cr.G * .59 + cr.B * 0.11));
        }
        private int getD(int cr, int cl, int cu, int cd,
                          int cld, int clu, int cru, int crd, int[,] matrix)
        {
            return Math.Abs(matrix[0, 0] * clu + matrix[0, 1] * cu + matrix[0, 2] * cru
                            + matrix[1, 0] * cl + matrix[1, 2] * cr
                            + matrix[2, 0] * cld + matrix[2, 1] * cd + matrix[2, 2] * crd);
        }


        private int getMaxD(int cr, int cl, int cu, int cd,
                          int cld, int clu, int cru, int crd)
        {
            int max = int.MinValue;
            for (int i = 0; i < templates.Count; i++)
            {
                int newVal = getD(cr, cl, cu, cd, cld, clu, cru, crd, templates[i]);
                if (newVal > max)
                    max = newVal;
            }
            return max;
        }

        private List<int[,]> templates = new List<int[,]> 
        {
            new int[,] {{ -3, -3, 5 }, { -3, 0, 5 }, { -3, -3, 5 } },
            new int[,] {{ -3, 5, 5 }, { -3, 0, 5 }, { -3, -3, -3 } },
            new int[,] {{ 5, 5, 5 }, { -3, 0, -3 }, { -3, -3, -3 } },
            new int[,] {{ 5, 5, -3 }, { 5, 0, -3 }, { -3, -3, -3 } },
            new int[,] {{ 5, -3, -3 }, { 5, 0, -3 }, { 5, -3, -3 } },
            new int[,] {{ -3, -3, -3 }, { 5, 0, -3 }, { 5, 5, -3 } },
            new int[,] {{ -3, -3, -3 }, { -3, 0, -3 }, { 5, 5, 5 } },
            new int[,] {{ -3, -3, -3 }, { -3, 0, 5 }, { -3, 5, 5 } }
        };
        public override Bitmap FilterProcessImage(KrischEdgeDetectorParms parms, Bitmap image)
        {
            Bitmap ret = new Bitmap(image.Width, image.Height);
            //for (int i = 1; i < image.Width - 1; i++)
            //{
            //    for (int j = 1; j < image.Height - 1; j++)
            //    {
            //        Color cr = image.GetPixel(i + 1, j);
            //        Color cl = image.GetPixel(i - 1, j);
            //        Color cu = image.GetPixel(i, j - 1);
            //        Color cd = image.GetPixel(i, j + 1);
            //        Color cld = image.GetPixel(i - 1, j + 1);
            //        Color clu = image.GetPixel(i - 1, j - 1);
            //        Color crd = image.GetPixel(i + 1, j + 1);
            //        Color cru = image.GetPixel(i + 1, j - 1);
            //        int d = 0;
            //        switch (parms.Channel)
            //        {
            //            case Channels.R:
            //                d = getMaxD(cr.R, cl.R, cu.R, cd.R, cld.R, clu.R, cru.R, crd.R);
            //                break;
            //            case Channels.G:
            //                d = getMaxD(cr.G, cl.G, cu.G, cd.G, cld.G, clu.G, cru.G, crd.G);
            //                break;
            //            case Channels.B:
            //                d = getMaxD(cr.B, cl.B, cu.B, cd.B, cld.B, clu.B, cru.B, crd.B);
            //                break;
            //            case Channels.RGB:
            //                d = getMaxD(grayscale(cr).B, grayscale(cl).B, grayscale(cu).B, grayscale(cd).B, grayscale(cld).B, grayscale(clu).B, grayscale(cru).B, grayscale(crd).B);
            //                break;
            //        }
            //        double power = d;
            //        if (power > parms.Threshold)
            //            ret.SetPixel(i, j, parms.EdgeColor);
            //        else
            //        {
            //            if (parms.CopyOriginal)
            //            {
            //                Color c = image.GetPixel(i, j);
            //                if (parms.ConvertToGrayscale)
            //                    ret.SetPixel(i, j, grayscale(c));
            //                else
            //                    ret.SetPixel(i, j, c);
            //            }
            //            else
            //                ret.SetPixel(i, j, Color.White);
            //        }
            //    }
            //}

            // create Edge filter
            //CannyEdgeDetector filter = new CannyEdgeDetector();
            // apply the filter
            //filter.ApplyInPlace(image);

            Bitmap move1Image = new Bitmap("c:\\Users\\Main\\Documents\\myNewimage1.png");
            Bitmap move2Image = new Bitmap("c:\\Users\\Main\\Documents\\myNewimage2.png");
            Bitmap background = new Bitmap("C:\\Users\\Main\\Documents\\Image Processing\\ImageProcessing_0.2.1\\Pictures\\background.jpg");
           

            /*
            
            for (int i = 0; i < image.Size.Width; i++)
			{
                for (int j = 0; j < image.Size.Height; j++)
			    {
                    if( background.GetPixel = move1Image)
                   
                }
			}
              
            */ 

            // Create a new Corners Detector using the given parameters
            HarrisCornersDetector fast = new HarrisCornersDetector();

            //create an arry of those pixel deemed to be corners of the image
            System.Collections.Generic.List<AForge.IntPoint> corners1 = fast.ProcessImage(move1Image);
            System.Collections.Generic.List<AForge.IntPoint> corners2 = fast.ProcessImage(move2Image);

        for (int i = 0; i < image.Size.Height; i++)
			        {
			 
			        }

            float a = corners1[2].X / corners1[2].Y;
            float r = 30;
            float rPrime = 50;
            float q = 10;
            float f = 5;
            float distanceP = (a * (r + rPrime) + r) * q / ((a + 1) * f); 
            float move1 = corners2[0].DistanceTo(corners1[0]);
            float move2 = corners2[1].DistanceTo(corners1[1]);
            float move3 = corners2[2].DistanceTo(corners1[2]);
                

            int[] dimensions = new int[5];
            double[] scaled = new double[5];

            AForge.IntPoint first = corners1[0];
            AForge.IntPoint second = corners2[0];
            float differenceX = second.X - first.X ;
            float differenceY = second.Y -first.Y ;
            

            System.Console.WriteLine(first);
            System.Console.WriteLine(second);
            System.Console.WriteLine(differenceX);
            
            double scale = 0.528;
            //Measure distance between two points in the corners matrix
            for (int i = 0; i < 4; i++)
            {
                
                
                //if the array element integer is even measure the x distance between itself and the next point in the array
                if (i % 2 == 0)
                {
                    int xDist = corners1[i + 1].X - corners1[i].X;
                    dimensions[i] = xDist;
                    scaled[i] = xDist * scale;                   
                    System.Console.WriteLine("From the For-loop: The X  Distance Between the Point ({0}) and Point ({1}) is {2}", corners1[i], corners1[i + 1], xDist);
                   //textBox1.Text = "From the For-loop: The X  Distance Between the Point" + corners1[i] + " and Point " + corners1[i + 1] + " is " + xDist;
                }
                //if the element is the last element in the array measure between itself and the first point
                else if (i == 3)
                {

                    int yDist = corners1[i].Y - corners1[0].Y;
                    scaled[i] = yDist * scale;
                    dimensions[i] = yDist;

                    System.Console.WriteLine("From the For-loop: The Y Line Distance Between the Point ({0}) and Point ({1}) is {2}", corners1[i], corners1[0], yDist);
                }
                //if the array element integer is odd measure the y distance between itself and the next point in the array
                else
                {

                    int yDist = corners1[i + 1].Y - corners1[i].Y;
                    dimensions[i] = yDist;
                    scaled[i] = yDist * scale;
                    System.Console.WriteLine("From the For-loop: The Y Line Distance Between the Point ({0}) and Point ({1}) is {2}", corners1[i], corners1[i + 1], yDist);
                }

               
                
                

                System.Console.WriteLine("The dimension of side {0} is {1} unscaled", i + 1, dimensions[i]);
                System.Console.WriteLine("The dimension of side {0} is {1} inches scaled", i + 1, scaled[i]);
            }

            //create a green label for each corner in image
            PointsMarker marker = new PointsMarker(corners1, System.Drawing.Color.Green, 4);

            // Apply the corner-marking filter
            Bitmap markers = marker.Apply(image);

            //save the image after it has mask applied to it
            markers.Save(@"C:\Users\Main\Documents\Image Processing\ImageProcessing_0.2.1\Pictures\testResult.png", System.Drawing.Imaging.ImageFormat.Png);
           
            string messageOut = "\t Hello, This is meZtech \n \n";
            messageOut += Environment.NewLine;
            for (int i = 0; i < scaled.Length - 1; i++)
            {
                int j = i + 1;
                messageOut += "The dimesnion for side " + j + " is " + scaled[i] + " inches \n";
                messageOut += Environment.NewLine;
               
            }
            messageOut += "\n Your Part has passed inspection!!!";
            messageOut += Environment.NewLine; 

            messageOut += "\n The Distance Moved in the X Direction is: " + differenceX;
            messageOut += Environment.NewLine; 
            messageOut += "\n The Distance Moved in the Y Direction is: " + differenceY;
            messageOut += Environment.NewLine;
            messageOut += "\n The Distance Moved in the 3 corner is: " + distanceP;
            messageOut += Environment.NewLine;
            messageOut += "\n The Amount of points in the matrix: " + corners1.Count;
            messageOut += Environment.NewLine; 
            MessageBox.Show(messageOut);
            ret.Tag = messageOut;

            
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter
            Bitmap grayImage = filter.Apply(image);
            System.Collections.Generic.List<AForge.IntPoint> grayCornerMatrix = fast.ProcessImage(grayImage);

            grayImage.Save(@"C:\Users\Main\Documents\Image Processing\ImageProcessing_0.2.1\Pictures\grayResult.png", System.Drawing.Imaging.ImageFormat.Png);


            PointsMarker grayMarkers = new PointsMarker(grayCornerMatrix, System.Drawing.Color.Red, 4);

            // Apply the corner-marking filter
            Bitmap grayProcessedImage = grayMarkers.Apply(grayImage);
            grayProcessedImage.Save(@"C:\Users\Main\Documents\Image Processing\ImageProcessing_0.2.1\Pictures\grayCornerResult.png", System.Drawing.Imaging.ImageFormat.Png);

            //Call out to the message log
            messageOut += "\n The Number of points in the grey matrix: " + grayCornerMatrix.Count;
            messageOut += Environment.NewLine; 

            MessageBox.Show(messageOut);
            ret.Tag = messageOut;
            
            
            
            return ret;



           
        }
        public override System.Windows.Forms.Control GetParameterWindow()
        {
            return new KrischEdgeDetectorParmForm();
        }
         
        
    }
}
