using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageDock
{
    public partial class mainFrm : Form
    {
        //Variable Declaration
        String imagePath;
        String folderPath;
        String locationOfSave;
        private static Random random = new Random();

        public mainFrm()
        {
            InitializeComponent();
        }


        //Runs when main resize button clicked
        public Image selectImage()
        {
            //Dialog filter to only show the listed image formats
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.eps;*.bmp;*.tif;*.tiff";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image to upload";
            Image selImage = null;


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName;
                folderPath = Path.GetDirectoryName(imagePath);

                //Save selected image
                selImage = Image.FromFile(imagePath);

                //Convert and round width and height set by user
                int width = Convert.ToInt32(Math.Round(widthTxt.Value, 0));
                int height = Convert.ToInt32(Math.Round(heightTxt.Value, 0));

                //Save image as bitmap with width and height details
                Bitmap resizedImage = ResizeImage(selImage, width, height);

                //Save image to selected location and rename it to a random name
                try
                {
                    resizedImage.Save(locationOfSave + "\\" + RandomString() + "." + formatTxt.Text, ImageFormat.Png);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please make sure you filled out all the details requested", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                //User dialog to open file location
                DialogResult dialogResult = MessageBox.Show("Complete." + Environment.NewLine + "Do you want to open the image location?", "Complete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Directory.Exists(locationOfSave))
                    {
                        Process.Start("explorer.exe", locationOfSave);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }

            return selImage;
        }

        //Folder dialog to set image save location
        private void selectLocationToSave()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    locationOfSave = dialog.SelectedPath;
                }
            }
        }

        //Generate random string - used for resized image file names
        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }




        //On main button click
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if (widthTxt.Text == "" || widthTxt.Text == "0" || heightTxt.Text == "" || heightTxt.Text == "0" || formatTxt.Text == "" || String.IsNullOrEmpty(locationOfSave))
            {
                MessageBox.Show("Please enter a valid width, height, image format and location to save the new image", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                selectImage();
            }
        }



        //Resizes image to the given width and height
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void saveLocBtn_Click(object sender, EventArgs e)
        {
            selectLocationToSave();
        }
    }
}
