using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace multimedia_finalProject
{
    public partial class Form1 : Form
    {
        private Bitmap loadedImage; // Variable to store the loaded image
        private Color currentColor = Color.Red; // Variable to hold the current color for updating pixels

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                // Check if the selected file is an image
                string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
                string extension = Path.GetExtension(filePath);
                bool isImage = imageExtensions.Contains(extension.ToLower());

                if (isImage)
                {
                    // Load the image
                    loadedImage = new Bitmap(filePath);

                    // Set the image to the PictureBox and adjust its size mode
                    XRayPictureBox.Image = loadedImage;
                    XRayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Stretch the image to fit the PictureBox
                    XRayPictureBox.Refresh(); // Refresh the PictureBox to display the image
                }
                else
                {
                    MessageBox.Show("Invalid file format. Please select a photo.");
                }
            }
        }

        private void XRayPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadedImage != null)
            {
                // Calculate the scaling factors to map PictureBox coordinates to image coordinates
                float scaleX = (float)loadedImage.Width / XRayPictureBox.Width;
                float scaleY = (float)loadedImage.Height / XRayPictureBox.Height;

                // Calculate the coordinates of the mouse click relative to the loaded image
                int imageX = (int)(e.X * scaleX);
                int imageY = (int)(e.Y * scaleY);

                // Perform flood fill with the specified radius
                int radius = 5; // Example radius, you can change it as needed

                for (int x = imageX - radius; x <= imageX + radius; x++)
                {
                    for (int y = imageY - radius; y <= imageY + radius; y++)
                    {
                        // Calculate the distance between the current pixel and the center of the circle
                        double distance = Math.Sqrt((x - imageX) * (x - imageX) + (y - imageY) * (y - imageY));

                        // Check if the distance is within the specified radius
                        if (distance <= radius)
                        {
                            // Check if the current pixel is within the bounds of the image
                            if (x >= 0 && x < loadedImage.Width && y >= 0 && y < loadedImage.Height)
                            {
                                // Change the color of the pixel at the current location to the current color
                                loadedImage.SetPixel(x, y, currentColor);
                            }
                        }
                    }
                }

                // Update the PictureBox to display the updated image
                XRayPictureBox.Image = loadedImage;
                XRayPictureBox.Refresh(); // Refresh the PictureBox to display the updated image
            }
        }




        // Event handler for changing the color
        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }


       
 
        private void XRayPictureBox_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (loadedImage != null && e.Button == MouseButtons.Left)
            {
                // Calculate the scaling factors to map PictureBox coordinates to image coordinates
                float scaleX = (float)loadedImage.Width / XRayPictureBox.Width;
                float scaleY = (float)loadedImage.Height / XRayPictureBox.Height;

                // Calculate the coordinates of the mouse position relative to the loaded image
                int imageX = (int)(e.X * scaleX);
                int imageY = (int)(e.Y * scaleY);

                // Perform flood fill with the specified radius at the current mouse position
                int radius = 5; // Example radius, you can change it as needed

                for (int x = imageX - radius; x <= imageX + radius; x++)
                {
                    for (int y = imageY - radius; y <= imageY + radius; y++)
                    {
                        // Calculate the distance between the current pixel and the center of the circle
                        double distance = Math.Sqrt((x - imageX) * (x - imageX) + (y - imageY) * (y - imageY));

                        // Check if the distance is within the specified radius
                        if (distance <= radius)
                        {
                            // Check if the current pixel is within the bounds of the image
                            if (x >= 0 && x < loadedImage.Width && y >= 0 && y < loadedImage.Height)
                            {
                                // Change the color of the pixel at the current location to the current color
                                loadedImage.SetPixel(x, y, currentColor);
                            }
                        }
                    }
                }

                // Update the PictureBox to display the updated image
                XRayPictureBox.Image = loadedImage;
                XRayPictureBox.Refresh(); // Refresh the PictureBox to display the updated image
            }
        }
    }
}
