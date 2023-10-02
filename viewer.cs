using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
namespace _winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseDown += picturebox1_MouseDown;
            pictureBox1.MouseUp += picturebox1_MouseUp;
            pictureBox1.MouseMove += picturebox1_MouseMove;
            pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            pictureBox2.MouseMove += picturebox2_MouseMove;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseUp += panel2_MouseUp;
            panel2.MouseMove += panel2_MouseMove;
   
        }
        public System.Drawing.Point mouseDownPoint;
        public bool ismove = false;
        public Bitmap graybitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Mat img = Cv2.ImRead(openFileDialog1.FileName);
                Mat grayimg = new Mat();
                Cv2.CvtColor(img, grayimg, ColorConversionCodes.BGR2GRAY);
                graybitmap = grayimg.ToBitmap();
                pictureBox1.Image = graybitmap;
            }
        }

        private void picturebox1_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left && pictureBox1.Image != null)
            {
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                ismove = true;
                pictureBox1.Focus();
            }
        }
        private void picturebox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left ) ismove = false;
        }

        private void picturebox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Focus();
            pic1X.Text = $"X: {e.X}";
            pic1Y.Text = $"Y: {e.Y}";
            if (ismove)
            {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = pictureBox1.Location.X + moveX;
                y = pictureBox1.Location.Y + moveY;
                pictureBox1.Location = new System.Drawing.Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
            if (!ismove)
            {
                if (pictureBox1.Image == null) return;

                byte gs = GetCurrentPixelGrayScale(e.Location, pictureBox1);
                GS.Text = $"GrayScale: {gs}";

            }
        }
        private void picturebox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox2 == null) return;
           
            byte gs = GetCurrentPixelGrayScale(e.Location, pictureBox2);
            GS.Text = $"Grayscale: {gs}";

        }
        private byte GetCurrentPixelGrayScale(System.Drawing.Point position, PictureBox pictureBox)
        {
            if (pictureBox.Image == null) return 0;

            Bitmap image = (Bitmap)pictureBox.Image;
            if (image == null) return 0;

            Rectangle imageRect = GetImageDisplayRectangle(pictureBox);
            if (!imageRect.Contains(position)) return 0;

            int x = (int)((position.X - imageRect.X) / (float)imageRect.Width * image.Width);
            int y = (int)((position.Y - imageRect.Y) / (float)imageRect.Height * image.Height);

            if (x < 0 || x >= image.Width || y < 0 || y >= image.Height) return 0;

            byte grayScale = image.ToMat().At<byte>(y, x);

            return grayScale;
        }

        private Rectangle GetImageDisplayRectangle(PictureBox pictureBox)
        {
            if (pictureBox.Image == null) return Rectangle.Empty;

            System.Drawing.Size imageSize = pictureBox.Image.Size;
            System.Drawing.Size displaySize = pictureBox.ClientSize;
            float imageRatio = imageSize.Width / (float)imageSize.Height;
            float displayRatio = displaySize.Width / (float)displaySize.Height;

            int x, y, width, height;

            if (imageRatio > displayRatio)
            {
                width = displaySize.Width;
                height = (int)(displaySize.Width / imageRatio);
                x = 0;
                y = (displaySize.Height - height) / 2;
            }
            else
            {
                width = (int)(displaySize.Height * imageRatio);
                height = displaySize.Height;
                x = (displaySize.Width - width) / 2;
                y = 0;
            }

            return new Rectangle(x, y, width, height);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && pictureBox1.Image != null)
            {
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                ismove = true;
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && pictureBox1.Image != null) ismove = false;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.Focus();
            if (ismove)
            {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = pictureBox1.Location.X + moveX;
                y = pictureBox1.Location.Y + moveY;
                pictureBox1.Location = new System.Drawing.Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
           
        }

        public int zoomStep = 25;
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            int ow = pictureBox1.Width;
            int oh = pictureBox1.Height;
            int VX, VY;  //因縮放產生的位移向量
            if (e.Delta > 0 && pictureBox1.Image != null) //放大
            {
                //第①步
                pictureBox1.Width += zoomStep;
                pictureBox1.Height += zoomStep;
                if (pictureBox1.Width > graybitmap.Width * 10) return;
                //第②步
                PropertyInfo pInfo = pictureBox1.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(pictureBox1, null);
                //第③步
                pictureBox1.Width = rect.Width;
                pictureBox1.Height = rect.Height;
            }
            if (e.Delta < 0 && pictureBox1.Image != null) //縮小
            {
               
                if (pictureBox1.Width < graybitmap.Width/10)return;

                pictureBox1.Width -= zoomStep;
                pictureBox1.Height -= zoomStep;
                PropertyInfo pInfo = pictureBox1.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(pictureBox1, null);
                pictureBox1.Width = rect.Width;
                pictureBox1.Height = rect.Height;
            }
            VX = (int)((double)x * (ow - pictureBox1.Width) / ow);
            VY = (int)((double)y * (oh - pictureBox1.Height) / oh);
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X + VX, pictureBox1.Location.Y + VY);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
            if (save.FileName != string.Empty)
            {
                pictureBox1.Image.Save(save.FileName);
            }
        }

        public Mat pic2;
        public Bitmap visiblearea; 
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            visiblearea = CaptureVisible();
            pic2 = visiblearea.ToMat();
            pictureBox2.Image = visiblearea;
        }

        private Bitmap CaptureVisible()
        {
            Rectangle panelVisibleBounds = panel2.RectangleToScreen(panel2.ClientRectangle);
            Bitmap visiblearea = new Bitmap(panelVisibleBounds.Width, panelVisibleBounds.Height);
            using (Graphics graphic = Graphics.FromImage(visiblearea))
            {
                graphic.CopyFromScreen(panelVisibleBounds.Location, System.Drawing.Point.Empty, panelVisibleBounds.Size);
            }
            return visiblearea;
        }
        

        private void ROI_Open_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null) return;
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect,
                new OpenCvSharp.Size((int)OpenKernelSize.Value, (int)OpenKernelSize.Value));
            Bitmap tmp = (Bitmap)pictureBox2.Image.Clone();
            Mat open = new Mat(pic2.Size(), pic2.Depth());
            Cv2.MorphologyEx(tmp.ToMat(), open, MorphTypes.Open, kernel);
            pictureBox2.Image = null;
            pictureBox2.Image = open.ToBitmap();
        }

        private void ROI_Close_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null) return;
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect,
                new OpenCvSharp.Size((int)CloseKernelSize.Value, (int)CloseKernelSize.Value));
            Bitmap tmp = (Bitmap)pictureBox2.Image.Clone();
            Mat close = new Mat(pic2.Size(), pic2.Depth());
            Cv2.MorphologyEx(tmp.ToMat(), close, MorphTypes.Close, kernel);
            pictureBox2.Image = null;
            pictureBox2.Image = close.ToBitmap();
        }

        private void ROI_Rotate_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null) return;

            double angle = (double)AngleValue.Value;
            OpenCvSharp.Point2f center = new OpenCvSharp.Point2f(pic2.Width / 2f, pic2.Height / 2f);
            Mat rotatedImg = Cv2.GetRotationMatrix2D(center, angle, 1.0);
            Cv2.WarpAffine(pic2, pic2, rotatedImg, pic2.Size());
            OpenCvSharp.Rect rect = new OpenCvSharp.Rect(0, 0, pic2.Width, pic2.Height);
            Mat croppedImg = new Mat(pic2, rect);
            pictureBox2.Image = croppedImg.ToBitmap();
        }

        private void GainValue_ValueChanged(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null) return;

            double gain = (double)GainValue.Value;
            Mat change = new Mat(pic2.Size(), pic2.Depth());
            for (int i = 0; i < pic2.Rows; i++)
            {
                for (int j = 0; j < pic2.Cols; j++)
                {
                    byte after;
                    if ((pic2.At<byte>(i, j) * gain) > 255) after = 255;
                    else after = (byte)(pic2.At<byte>(i, j) * gain);

                    change.Set<byte>(i, j, after);
                }
            }
            pictureBox2.Image = change.ToBitmap();
        }

        private void ROI_Original_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null) return;
            pictureBox2.Image = visiblearea;
        }

        public OpenCvSharp.ThresholdTypes type = new ThresholdTypes();
        private void Thres_Hold_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null) return;
            int thresHold = (int)ThrseHoldValue.Value;
            Bitmap tmp = (Bitmap)pictureBox2.Image.Clone();
            Mat change = tmp.ToMat().Threshold(thresHold, 255,type);
            pictureBox2.Image = change.ToBitmap();
            pictureBox2.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Binary") type = ThresholdTypes.Binary;
            else if (comboBox1.Text == "BinaryINV") type = ThresholdTypes.BinaryInv;
            else if (comboBox1.Text == "Tozero") type = ThresholdTypes.Tozero;
            else if (comboBox1.Text == "TozeroINV") type = ThresholdTypes.TozeroInv;
            else type = ThresholdTypes.Binary;
        }
    }
}
