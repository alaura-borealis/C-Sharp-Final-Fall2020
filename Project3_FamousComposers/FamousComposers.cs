/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Project #3 -- Famous Composers 
' Created by Laura Waite
' Date: 11/24/2020
' Project Name: Famous Composers
' Class: CS 218
' Time: 60 hours, 38 minutes
' Platform: PC, Windows 10, VS 2017
' Version: 1.0.0
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' A form that parses an xml database file of composers and displays their data. 
' Also allows user to manage database by adding, editing, or removing composers, 
' and allows presentation of selected composer in a new form. User can access Edit function 
' by double-clicking listbox. Present button changes based on whether presentation form is open.
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the student:
' Background image ©2020 Shutterstock - Royalty-free stock photo ID: 558325894 (Standard License) 
' Icon file ©2020 icon-icons.com
' Composer images ©2020 Wikimedia Commons
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Project3_FamousComposers.Properties;
using System.Diagnostics;

namespace Project3_FamousComposers
{
    /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ' Name:             FamousComposers : Form
    ' Description:
    ' 
    ' Class for FamousComposers Form application. Contains global variables.
    ' 
    ' Date:             11/24/2020
    ' Author:           Laura Waite
    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
    public partial class FamousComposers : Form
    {
        // Class level variables
        public List<Composer> composers = new List<Composer>();
        public Presentation presentation = new Presentation();
        private string defaultDB = @"..\\..\\Resources\\composers.xml"; // Default DB located in Resources folder
        private string findDefaultDB = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\composers.xml"); // Alternative method for locating default DB
        private string activeDB = String.Empty; // Variable for path to active DB
        private bool isPresenting = false;

        // Print Form
        Bitmap memoryImage;

        public FamousComposers()
        {
            // Show splash screen
            (new SplashScreen()).ShowDialog();

            // Initialize form
            InitializeComponent();

            // Check for composers.xml file
            if (!File.Exists(defaultDB))
            {
                defaultDB = findDefaultDB;
            }
            activeDB = defaultDB;
            composers = LoadXmlDB(activeDB);
            loadComposers();
        }

        public String CreateXmlDB(List<Composer> composers)
        {
            DateTime today = DateTime.Today;
            string fileName = @"..\\..\\Resources\\composers_" + today.ToString("yyyy-MM-dd") + ".xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Composer>), new XmlRootAttribute("Composers"));
            FileStream newXmlDB = new FileStream(fileName, FileMode.CreateNew);
            serializer.Serialize(newXmlDB, composers);
            newXmlDB.Close();
            return fileName;
        }

        public void EditXmlDB(List<Composer> composers, String filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Composer>), new XmlRootAttribute("Composers"));
            FileStream xmlDB = new FileStream(filename, FileMode.Create);
            serializer.Serialize(xmlDB, composers);
            xmlDB.Close();
        }

        public List<Composer> LoadXmlDB(String filename)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Composer>), new XmlRootAttribute("Composers"));
                FileStream xmlDB = new FileStream(filename, FileMode.Open);
                List<Composer> composers;
                composers = (List<Composer>)deserializer.Deserialize(xmlDB);
                xmlDB.Close();
                return composers;
            }
            catch
            {
                MessageBox.Show("Unable to load XML.", "XML Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Call Load menu event to load xml database
                mnuFileLoad.PerformClick();
                return composers;
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             loadComposers()
        ' Description:
        ' 
        ' Method for loading composer names from List object to listbox
        ' 
        ' Return:           void
        ' Date:             11/27/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void loadComposers()
        {
            // Clear instance of listbox
            lstComposers.Items.Clear();

            // Create temporary string array for entries
            string[] composerEntry = new string[composers.Count];
            
            // Determine display order by sort selection
            if (mnuPresentSortName.Checked)
            {
                // Sort entries by composer name only (default sort)
                string prop = "Name";
                Utils.insertionSort(composers, prop);
                for (int i = 0; i < composers.Count; i++)
                {
                    composerEntry[i] = composers[i].Name;
                }
            }
            else if (mnuPresentSortYear.Checked)
            {
                // Sort entries by year of debut performance and composition name
                Utils.selectionSort(composers);
                for (int i = 0; i < composers.Count; i++)
                {
                    composerEntry[i] = composers[i].Year + " - " + composers[i].Title;
                }
            }
            else
            {
                // Sort entries by order of appearance in DB
                for (int i = 0; i < composers.Count; i++)
                {
                    composerEntry[i] = composers[i].Name;
                }
            }

            // Loop through string array, add item to listbox
            for (int i = 0; i < composers.Count; i++)
            {
                lstComposers.Items.Add(composerEntry[i]);
            }
            if (this.lstComposers.Items.Count > 0)
                this.lstComposers.SelectedIndex = 0; // highlight first entry
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuFileQuit_Click(object sender, EventArgs e)
        {
            btnQuit.PerformClick();
        }

        private void mnuPresentSortName_Click(object sender, EventArgs e)
        {
            if (mnuPresentSortName.Checked)
            {
                mnuPresentSortYear.Checked = false;
                mnuPresentSortName.Checked = true;
            }
            else
            {
                mnuPresentSortYear.Checked = true;
                mnuPresentSortName.Checked = false;
            }
            loadComposers();
        }

        private void mnuPresentSortYear_Click(object sender, EventArgs e)
        {
            if (mnuPresentSortYear.Checked)
            {
                mnuPresentSortYear.Checked = true;
                mnuPresentSortName.Checked = false;
            }
            else
            {
                mnuPresentSortYear.Checked = false;
                mnuPresentSortName.Checked = true;
            }
            loadComposers();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            // Clear default DB list and listbox
            composers.RemoveRange(0, composers.Count);
            lstComposers.Items.Clear();
            
            // Show Add Composer form to create at least one item for new list
            AddComposer addComposer = new AddComposer(composers);
            addComposer.ShowDialog();
            Composer newComposer = addComposer.getComposer();
            if (newComposer != null)
            {
                composers.Add(newComposer);
                loadComposers();
                searchComposer(newComposer.Name);
                activeDB = CreateXmlDB(composers);
            }
        }

        private void lstComposers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstComposers.SelectedIndex;
            if (index >= 0)
                showComposerData(index);

            if (isPresenting)
            {
                string fileName = @"..\\..\\Resources\\ComposerImages\\" + composers[index].Name + ".jpg";
                try
                {
                    presentation.picComposer.BackgroundImage = Image.FromFile(fileName);

                }
                catch
                {
                    try
                    {
                        fileName = @"..\\..\\Resources\\ComposerImages\\" + composers[index].Name + ".jpeg";
                        presentation.picComposer.BackgroundImage = Image.FromFile(fileName);

                    }
                    catch
                    {
                        presentation.picComposer.BackgroundImage = null;
                    }
                }
                presentation.lblName.Text = composers[index].Name;
                presentation.lblCompTitle.Text = composers[index].Title;
                presentation.lblYearLocation.Text = composers[index].Year + ", " + composers[index].Location;
                presentation.txtSynopsis.Text = composers[index].Synopsis;
                presentation.lnkLink.Text = composers[index].Link;
            }
        }

        private void showComposerData(int index)
        {
            // Display Composer data in labels/textbox
            if (index >= 0 && index < composers.Count)
            {
                lblCompName.Text = composers[index].Name;
                lblCompTitle.Text = composers[index].Title;
                lblCompYear.Text = composers[index].Year;
                lblCompLocation.Text = composers[index].Location;
                txtSynopsis.Text = composers[index].Synopsis;
                lnkLink.Text = composers[index].Link;
            }
        }

        private void mnuManageSearchName_Click(object sender, EventArgs e)
        {
            string output = "";
            DialogResult result = DialogResult.None;

            result = InputBox.Show("Search Composers by Name", "Please enter name of composer.", "Value", out output);

            if (result != DialogResult.OK)
            {
                return;
            }
            searchComposer(output);
        }

        private void searchComposer(String composerName)
        {
            if ((composerName != null) && (composerName.Length > 0))
            {
                // Sort list of composers by name
                mnuPresentSortName.Select();
                loadComposers();

                // Find index of composer
                int index = Utils.LinearSearch(composers, composerName.ToLower());

                if (index < 0)
                {
                    MessageBox.Show("Composer " + composerName + " not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstComposers.Refresh();
                }
                else
                {
                    lstComposers.SelectedIndex = index;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string output = "";
            DialogResult result = DialogResult.None;
            int selected = lstComposers.SelectedIndex;

            result = InputBox.Show("Delete Selected Composer", "The following entry will be deleted:" 
                + Environment.NewLine + " "
                + Environment.NewLine + composers[selected].ToString("S"), "Value", out output);

            if (result != DialogResult.OK)
            {
                return;
            }
            confirmDelete(output, selected);
        }

        private void confirmDelete(String input, int selected)
        {
            string deleteConfirm = "delete";
            if (input.ToLower().Equals(deleteConfirm))
            {
                composers.Remove(composers[selected]);
                EditXmlDB(composers, activeDB);
                loadComposers();
            }
            else
            {
                MessageBox.Show("Composer could not be deleted.","Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mnuFileLoad_Click(object sender, EventArgs e)
        {
            // Open file dialog to get composers file
            activeDB = string.Empty;
            composers = null;
            ofdComposers.Title = "Select Composers Database";
            ofdComposers.DefaultExt = "xml";
            ofdComposers.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            ofdComposers.FilterIndex = 1;
            ofdComposers.ReadOnlyChecked = true;
            ofdComposers.ShowReadOnly = true;
            if (ofdComposers.ShowDialog() == DialogResult.OK)
            {
                activeDB = ofdComposers.FileName;
                composers = LoadXmlDB(activeDB);
                loadComposers();
            }
        }

        private void mnuManageDelete_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selected = lstComposers.SelectedIndex;
            Composer thisComposer = composers[selected];
            EditComposer editComposer = new EditComposer(composers, thisComposer);
            editComposer.ShowDialog();
            Composer newComposer = editComposer.getComposer();
            if (newComposer != null)
            {
                composers.Insert(composers.IndexOf(thisComposer), newComposer);
                composers.Remove(thisComposer);
                loadComposers();
                searchComposer(newComposer.Name);
                EditXmlDB(composers, activeDB);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddComposer addComposer = new AddComposer(composers);
            addComposer.ShowDialog();
            Composer newComposer = addComposer.getComposer();
            if (newComposer != null)
            {
                composers.Add(newComposer);
                loadComposers();
                searchComposer(newComposer.Name);
                EditXmlDB(composers, activeDB);
            }
        }

        private void mnuManageAdd_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void mnuManageEdit_Click(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            if (btnPresent.Text == "Start Presentation")
            {
                mnuPresentStart.PerformClick();
                btnPresent.Text = "End Presentation";
            }
            else
            {
                mnuPresentEnd.PerformClick();
                btnPresent.Text = "Start Presentation";
            }


        }

        private void mnuPresentStart_Click(object sender, EventArgs e)
        {
            int selected = lstComposers.SelectedIndex;
            Composer thisComposer = composers[selected];
            if (!isPresenting)
            {
                //Presentation presentation = new Presentation();
                presentation.Show();
                string fileName = @"..\\..\\Resources\\ComposerImages\\" + thisComposer.Name + ".jpg";
                try
                {
                    presentation.picComposer.BackgroundImage = Image.FromFile(fileName);

                }
                catch
                {
                    try
                    {
                        fileName = @"..\\..\\Resources\\ComposerImages\\" + thisComposer.Name + ".jpeg";
                        presentation.picComposer.BackgroundImage = Image.FromFile(fileName);

                    }
                    catch
                    {
                        presentation.picComposer.BackgroundImage = null;
                    }
                }
                presentation.lblName.Text = thisComposer.Name;
                presentation.lblCompTitle.Text = thisComposer.Title;
                presentation.lblYearLocation.Text = thisComposer.Year + ", " + thisComposer.Location;
                presentation.txtSynopsis.Text = thisComposer.Synopsis;
                presentation.lnkLink.Text = thisComposer.Link;
                isPresenting = true;
            }
            btnPresent.Text = "End Presentation";
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void mnuPresentEnd_Click(object sender, EventArgs e)
        {
            if (isPresenting)
                presentation.Hide();
            isPresenting = false;
            btnPresent.Text = "Start Presentation";
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            // Show About form
            (new About()).ShowDialog();
        }

        private void mnuFilePrintForm_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            ppdComposers.StartPosition = FormStartPosition.CenterParent;
            ppdComposers.ClientSize = new Size(700, 700);
            ppdComposers.PrintPreviewControl.Zoom = 1.0;
            ppdComposers.Document = pdForm;
            ppdComposers.ShowDialog();
        }

        private void pdForm_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Create print document
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             CaptureScreen()
        ' Description:
        ' 
        ' Method that mimics the screenshot function in windows to create a
        ' bitmap image that will act as the document to be printed.
        ' 
        ' Parameter:        null
        ' Return:           void
        ' Date:             11/30/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void CaptureScreen()
        {
            // Capture screen image for printing
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

        }

        private void lstComposers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstComposers.SelectedIndex != -1)
                btnEdit.PerformClick();
        }

        private void pdSelection_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Calibri", 12);
            var myBrush = Brushes.Black;
            int selected = lstComposers.SelectedIndex;
            Composer thisComposer = composers[selected];
            Image imgComposer;
            string fileName = @"..\\..\\Resources\\ComposerImages\\" + thisComposer.Name + ".jpg";
            try
            {
                imgComposer = Image.FromFile(fileName);

            }
            catch
            {
                try
                {
                    fileName = @"..\\..\\Resources\\ComposerImages\\" + thisComposer.Name + ".jpeg";
                    imgComposer = Image.FromFile(fileName);

                }
                catch
                {
                    imgComposer = Resources.shutterstock_558325894;

                }
            }
            // Draw document for printing
            e.Graphics.DrawImage(imgComposer, 72, 72);
            e.Graphics.DrawString(thisComposer.ToString(), myFont, myBrush, 72, 300);
        }

        private void mnuFilePrintSelection_Click(object sender, EventArgs e)
        {
            ppdComposers.StartPosition = FormStartPosition.CenterParent;
            ppdComposers.ClientSize = new Size(700, 700);
            ppdComposers.PrintPreviewControl.Zoom = 0.75;
            ppdComposers.Document = pdSelection;
            ppdComposers.ShowDialog();
        }

        private void lnkLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = lnkLink.Text;
            ProcessStartInfo sInfo = new ProcessStartInfo(url);
            Process.Start(sInfo);
        }
    }
}
