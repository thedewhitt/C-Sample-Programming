/* File: A290 Final - main form
 * Created by: Erik Gonzalez-DeWhitt
 * Created on: 12/9/13
 * Modified by: Erik Gonzalez-DeWhitt
 * Modified on: 12/13/13
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;

namespace A290___Final___Marksman
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void tbUrl_Leave(object sender, EventArgs e)
        {
            /*
             * With help from Andrew Poclu "Taking Webiste Screenshots with the WebBrowser Control"
             * 
             * 
             */

            Uri url = new Uri(tbUrl.Text); // makes a url from the user's entry in tbUrl
            WebBrowser brow = new WebBrowser(); //have to create a webbrowser to be able to snapshot a webpage from one
            brow.ScrollBarsEnabled = false; 
            brow.ScriptErrorsSuppressed = true;
            brow.Navigate(url); // opens the url in the webbrowser

            while (brow.Document == null || brow.Document.Body == null) // need for page to be fully loaded before doing things
                Application.DoEvents();

            Rectangle websiteSize = brow.Document.Body.ScrollRectangle;
            brow.Size = new Size(websiteSize.Width, websiteSize.Height);

            Bitmap bmp = new Bitmap(websiteSize.Width, websiteSize.Height); //need a bitmap to draw to

            brow.DrawToBitmap(bmp, new Rectangle(0, 0, websiteSize.Width, websiteSize.Height));

            System.Drawing.Image reSized = new Bitmap(177, 177, bmp.PixelFormat); //resizing bitmap to fit window

            Graphics graph = Graphics.FromImage(reSized);
            graph.CompositingQuality = CompositingQuality.HighQuality;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.InterpolationMode = InterpolationMode.HighQualityBicubic;
            Rectangle rect = new Rectangle(0, 0, 177, 177);
            graph.DrawImage(bmp, rect);

            pbDisplay.Image = reSized;
            brow.Dispose(); // closes the webbrowser


            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbUrl.Text != "")
            {
                //have to assign the entered information to all aspects of object, add to bookmark list
                bookmarks newEntry = new bookmarks(); 
                newEntry.description = tbBanner.Text;
                newEntry.url = tbUrl.Text;
                newEntry.comments = tbComment.Text;
                newEntry.screenshot = pbDisplay.Image;
                bookmarks.quiver.Add(newEntry);
                this.Close();

            }
        }
    }
}
