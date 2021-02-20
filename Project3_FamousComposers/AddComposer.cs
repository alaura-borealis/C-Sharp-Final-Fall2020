using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project3_FamousComposers
{
    public partial class AddComposer : Form
    {
        private Composer newComposer;
        private bool nameError = false;
        private bool titleError = false;
        private bool yearError = false;
        private bool locationError = false;
        private bool synopsisError = false;
        private bool linkError = false;
        public string name, title, year, location, synopsis, link = String.Empty;
        public List<Composer> composers = null;

        public AddComposer()
        {
            InitializeComponent();
            txtName.Focus();
            newComposer = null;
        }

        public AddComposer(List<Composer> composers)
        {
            InitializeComponent();
            txtName.Focus();
            newComposer = null;
            this.composers = composers;
        }

        public Composer getComposer()
        {
            return newComposer;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int errorCount = 0;
            string errorString = "";
            // Perform validation for all fields

            // Validate name
            name = txtName.Text;
            nameError = Utils.ValidateName(composers, name);
            ttpAdd.SetToolTip(txtName, Utils.nameErrorMessage);

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
            titleError = Utils.ValidateTitle(composers, title);
            ttpAdd.SetToolTip(txtTitle, Utils.titleErrorMessage);

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
            ttpAdd.SetToolTip(txtYear, Utils.yearErrorMessage);

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
            ttpAdd.SetToolTip(txtLocation, Utils.locationErrorMessage);

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
            ttpAdd.SetToolTip(txtSynopsis, Utils.synopsisErrorMessage);

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
            ttpAdd.SetToolTip(txtLink, Utils.linkErrorMessage);

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
                newComposer = new Composer(name, title, year, location, synopsis, link);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Composer entry cannot be saved. Please correct the following errors:" + errorString, "Add Composer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            name = txtName.Text;
            nameError = Utils.ValidateName(composers, name);
            ttpAdd.SetToolTip(txtName, Utils.nameErrorMessage);

            if (nameError)
                txtName.BackColor = Color.Salmon;
            else
                txtName.BackColor = Color.Linen;
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            title = txtTitle.Text;
            titleError = Utils.ValidateTitle(composers, title);
            ttpAdd.SetToolTip(txtTitle, Utils.titleErrorMessage);

            if (titleError)
                txtTitle.BackColor = Color.Salmon;
            else
                txtTitle.BackColor = Color.Linen;
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            year = txtYear.Text;
            yearError = Utils.ValidateYear(year);
            ttpAdd.SetToolTip(txtYear, Utils.yearErrorMessage);

            if (yearError)
                txtYear.BackColor = Color.Salmon;
            else
                txtYear.BackColor = Color.Linen;
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            location = txtLocation.Text;
            locationError = Utils.ValidateLocation(location);
            ttpAdd.SetToolTip(txtLocation, Utils.locationErrorMessage);

            if (locationError)
                txtLocation.BackColor = Color.Salmon;
            else
                txtLocation.BackColor = Color.Linen;

        }

        private void txtSynopsis_Leave(object sender, EventArgs e)
        {
            synopsis = txtSynopsis.Text;
            synopsisError = Utils.ValidateSynopsis(synopsis);
            ttpAdd.SetToolTip(txtSynopsis, Utils.synopsisErrorMessage);

            if (synopsisError)
                txtSynopsis.BackColor = Color.Salmon;
            else
                txtSynopsis.BackColor = Color.Linen;
        }

        private void txtLink_Leave(object sender, EventArgs e)
        {
            link = txtLink.Text;
            linkError = Utils.ValidateLink(link);
            ttpAdd.SetToolTip(txtLink, Utils.linkErrorMessage);

            if (linkError)
                txtLink.BackColor = Color.Salmon;
            else
                txtLink.BackColor = Color.Linen;
        }

    }
}
