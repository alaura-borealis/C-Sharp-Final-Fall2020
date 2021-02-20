using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_FamousComposers
{
    public partial class EditComposer : Form
    {
        private Composer editComposer;
        private bool nameError = false;
        private bool titleError = false;
        private bool yearError = false;
        private bool locationError = false;
        private bool synopsisError = false;
        private bool linkError = false;
        public string name, title, year, location, synopsis, link = String.Empty;
        public List<Composer> temp = null;

        public EditComposer(List<Composer> composers, Composer composer)
        {
            InitializeComponent();
            txtName.Text = composer.Name;
            txtTitle.Text = composer.Title;
            txtYear.Text = composer.Year;
            txtLocation.Text = composer.Location;
            txtSynopsis.Text = composer.Synopsis;
            txtLink.Text = composer.Link;
            txtName.Focus();

            // Save composers list to temp list
            temp = new List<Composer>(composers);
            // Remove current composer for validation rules
            temp.Remove(composer);
        }
        public Composer getComposer()
        {
            return editComposer;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            name = txtName.Text;
            nameError = Utils.ValidateName(temp, name);
            ttpEdit.SetToolTip(txtName, Utils.nameErrorMessage);

            if (nameError)
                txtName.BackColor = Color.Salmon;
            else
                txtName.BackColor = Color.Linen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int errorCount = 0;
            string errorString = "";

            // Perform validation for all fields

            // Validate name
            name = txtName.Text;
            nameError = Utils.ValidateName(temp, name);
            ttpEdit.SetToolTip(txtName, Utils.nameErrorMessage);

            if (nameError)
            {
                txtName.BackColor = Color.Salmon;
                errorCount += 1;
                errorString += Environment.NewLine + Utils.nameErrorMessage;
            }
            else
            {
                txtName.BackColor = Color.Linen;
            }

            // Validate title
            title = txtTitle.Text;
            titleError = Utils.ValidateTitle(temp, title);
            ttpEdit.SetToolTip(txtTitle, Utils.titleErrorMessage);

            if (titleError)
            {
                txtTitle.BackColor = Color.Salmon;
                errorCount += 1;
                errorString += Environment.NewLine + Utils.titleErrorMessage;

            }
            else
            {
                txtTitle.BackColor = Color.Linen;
            }

            // Validate year
            year = txtYear.Text;
            yearError = Utils.ValidateYear(year);
            ttpEdit.SetToolTip(txtYear, Utils.yearErrorMessage);

            if (yearError)
            {
                txtYear.BackColor = Color.Salmon;
                errorCount += 1;
                errorString += Environment.NewLine + Utils.yearErrorMessage;

            }
            else
            {
                txtYear.BackColor = Color.Linen;
            }

            // Validate location
            location = txtLocation.Text;
            locationError = Utils.ValidateLocation(location);
            ttpEdit.SetToolTip(txtLocation, Utils.locationErrorMessage);

            if (locationError)
            {
                txtLocation.BackColor = Color.Salmon;
                errorCount += 1;
                errorString += Environment.NewLine + Utils.locationErrorMessage;

            }
            else
            {
                txtLocation.BackColor = Color.Linen;
            }

            // Validate synopsis
            synopsis = txtSynopsis.Text;
            synopsisError = Utils.ValidateSynopsis(synopsis);
            ttpEdit.SetToolTip(txtSynopsis, Utils.synopsisErrorMessage);

            if (synopsisError)
            {
                txtSynopsis.BackColor = Color.Salmon;
                errorCount += 1;
                errorString += Environment.NewLine + Utils.synopsisErrorMessage;

            }
            else
            {
                txtSynopsis.BackColor = Color.Linen;
            }

            // Validate link
            link = txtLink.Text;
            linkError = Utils.ValidateLink(link);
            ttpEdit.SetToolTip(txtLink, Utils.linkErrorMessage);

            if (linkError)
            {
                txtLink.BackColor = Color.Salmon;
                errorCount += 1;
                errorString += Environment.NewLine + Utils.linkErrorMessage;

            }
            else
            {
                txtLink.BackColor = Color.Linen;
            }

            if (errorCount == 0)
            {
                editComposer = new Composer(name, title, year, location, synopsis, link);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Composer entry cannot be saved. Please correct the following errors:" + errorString, "Edit Composer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            title = txtTitle.Text;
            titleError = Utils.ValidateTitle(temp, title);
            ttpEdit.SetToolTip(txtTitle, Utils.titleErrorMessage);

            if (titleError)
                txtTitle.BackColor = Color.Salmon;
            else
                txtTitle.BackColor = Color.Linen;
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            year = txtYear.Text;
            yearError = Utils.ValidateYear(year);
            ttpEdit.SetToolTip(txtYear, Utils.yearErrorMessage);

            if (yearError)
                txtYear.BackColor = Color.Salmon;
            else
                txtYear.BackColor = Color.Linen;
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            location = txtLocation.Text;
            locationError = Utils.ValidateLocation(location);
            ttpEdit.SetToolTip(txtLocation, Utils.locationErrorMessage);

            if (locationError)
                txtLocation.BackColor = Color.Salmon;
            else
                txtLocation.BackColor = Color.Linen;

        }

        private void txtSynopsis_Leave(object sender, EventArgs e)
        {
            synopsis = txtSynopsis.Text;
            synopsisError = Utils.ValidateSynopsis(synopsis);
            ttpEdit.SetToolTip(txtSynopsis, Utils.synopsisErrorMessage);

            if (synopsisError)
                txtSynopsis.BackColor = Color.Salmon;
            else
                txtSynopsis.BackColor = Color.Linen;
        }

        private void txtLink_Leave(object sender, EventArgs e)
        {
            link = txtLink.Text;
            linkError = Utils.ValidateLink(link);
            ttpEdit.SetToolTip(txtLink, Utils.linkErrorMessage);

            if (linkError)
                txtLink.BackColor = Color.Salmon;
            else
                txtLink.BackColor = Color.Linen;
        }
    }
}
