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

namespace A290___Final___Marksman
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            // if the dialog box is satisfied, adds the string after the last "\" in the path name
            if (ofdAddBrowser.ShowDialog() == DialogResult.OK) {
                browse entry = new browse(); // create browser
                entry.name = ofdAddBrowser.FileName.Substring(ofdAddBrowser.FileName.LastIndexOf(@"\") + 1); //add characteristics to entry object
                entry.filepath = ofdAddBrowser.FileName;
                browse.browsers.Add(entry);

                // needs to clear same text if there have not been any additions (will keep indices of lists the same)
                if (lbBrowser.Items[0].Equals("(none)"))
                {
                    lbBrowser.Items[0] = entry.name;
                }
                else
                {
                    lbBrowser.Items.Add(entry.name);
                }
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //because browser listbox is meant to visually represent browser list, can delete objects at same index
            string curItem = lbBrowser.SelectedItem.ToString();
            int curItemIndex = lbBrowser.FindString(curItem);
            lbBrowser.Items.RemoveAt(curItemIndex);
            browse.browsers.RemoveAt(curItemIndex);
        }


        private void lbBookmarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for when different bookmarks are selected, image should be shown in picture box
            //after object deleted from bookamrks, index will change
            try
            {
                //find corresponding snapshot from bookmarks list based on selected item in listbox
                int i; int end = bookmarks.quiver.Count;
                for (i = 0; i < end; i++)
                {
                    if (lbBookmarks.SelectedItem.Equals(bookmarks.quiver[i].description))
                    {
                        pbDisplay.Image = bookmarks.quiver[i].screenshot;
                        break;
                    }
                }
            }
            catch (NullReferenceException)
            {
                //when object is deleted, catch the exception and reset image to black bitmap
                pbDisplay.Image = pbDisplay.InitialImage;

            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!lbBookmarks.SelectedItem.Equals("(none)"))
            {
             //because listbox is meant to visually represent the object of bookmarks list, can delete objects at the same indexed location   
                string curItem = lbBookmarks.SelectedItem.ToString();
                int curItemIndex = lbBookmarks.FindString(curItem);
                lbBookmarks.Items.RemoveAt(curItemIndex);
                bookmarks.quiver.RemoveAt(curItemIndex);

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lbBrowser.SelectedItem.Equals("(none)"))
            {
                MessageBox.Show("No browser entry selected."); //prompt user to select browser from listbox
            }
            else
            {
                if (lbBookmarks.SelectedItem.Equals("(none)"))
                {
                    MessageBox.Show("No bookmark entry selected."); //prompt user to select bookmark from listbox
                }
                else
                {

                    for (int i = 0; i < bookmarks.quiver.Count; i++)
                    {
                        //have to find selected bookmark from bookmarks object list, which has url saved in it
                        if (lbBookmarks.SelectedItem.Equals(bookmarks.quiver[i].description))
                        {
                            System.Diagnostics.Process.Start(lbBrowser.SelectedItem.ToString(), bookmarks.quiver[i].url);

                        }

                    }

                }

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int before = bookmarks.quiver.Count;

            //open editor window and user can enter information
            frmEditor frmEditorDialog = new frmEditor();
            frmEditorDialog.ShowDialog();

            int after = bookmarks.quiver.Count;

            if (before < after)
            {
                //add new bookmarks to lbBookmarks, deleting sample text if it is there
                if (lbBookmarks.Items[0].Equals("(none)"))
                {
                    int end = bookmarks.quiver.Count;
                    lbBookmarks.Items[0] = bookmarks.quiver[end - 1].description;
                }
                else
                {
                    int end = bookmarks.quiver.Count;
                    lbBookmarks.Items.Add(bookmarks.quiver[end - 1].description);
                }
            }
        }
    }
    
    public class browse
    {
        public string name, filepath;

        //global-like list that can be accessed later, hold all browsers
        public static List<browse> browsers = new List<browse>();
    }

    public class bookmarks
    {
        public string description, url, comments;
        public Image screenshot;

        //global-like list that can be accessed later, hold all my bookmarks
        public static List<bookmarks> quiver = new List<bookmarks>();
    }


}
