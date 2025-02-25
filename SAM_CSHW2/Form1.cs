using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SAM_CSHW2
{

    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(0);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start(); 

        }
        private void DisplayWebcam()
        {
            while(_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();
                

                int newHeight = (frame.Size.Height * PictureBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(PictureBox.Size.Width, newHeight);
               
                CvInvoke.Resize(frame, frame, newSize);


                PictureBox.Image = frame.ToBitmap();

                int newgrayHeight = (frame.Size.Height * GrayPictureBox.Size.Width) / frame.Size.Width;
                Size newgraySize = new Size(GrayPictureBox.Size.Width, newgrayHeight);

                CvInvoke.Resize(frame, frame, newgraySize);


                Mat grayFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);

                // Apply binary thresholding
                Mat binaryFrame = new Mat();
                CvInvoke.Threshold(grayFrame, binaryFrame, 127, 255, ThresholdType.Binary | ThresholdType.Otsu);



                GrayPictureBox.Image = binaryFrame.ToBitmap();

                //Code for a grayscale and binary-threshholding GrayPictureBox



            }



        }
        private void Form1_FromClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }





       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GrayPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
