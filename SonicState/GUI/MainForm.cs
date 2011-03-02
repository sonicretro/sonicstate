using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SonicState
{
    public partial class frmMain : Form
    {
        private Savestate savestate;
        private bool fileLoaded = false;
        private string savestateFile;

        public frmMain()
        {
            InitializeComponent();

            savestate = new Sonic1Savestate();
            propertyGrid1.SelectedObject = savestate;

            RefreshWindowTitle();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuGameSonic1_Click(object sender, EventArgs e)
        {
            savestate = new Sonic1Savestate();

            if (fileLoaded)
                savestate.Load(savestateFile);

            propertyGrid1.SelectedObject = savestate;

            mnuGameSonic1.Checked = true;
            mnuGameSonic2.Checked = false;
            mnuGameSonic3.Checked = false;

            RefreshWindowTitle();
        }

        private void mnuGameSonic2_Click(object sender, EventArgs e)
        {
            savestate = new Sonic2Savestate();

            if (fileLoaded)
                savestate.Load(savestateFile);

            propertyGrid1.SelectedObject = savestate;

            mnuGameSonic1.Checked = false;
            mnuGameSonic2.Checked = true;
            mnuGameSonic3.Checked = false;

            RefreshWindowTitle();
        }
        
        private void mnuGameSonic3_Click(object sender, EventArgs e)
        {
            savestate = new Sonic3Savestate();

            if (fileLoaded)
                savestate.Load(savestateFile);

            propertyGrid1.SelectedObject = savestate;

            mnuGameSonic1.Checked = false;
            mnuGameSonic2.Checked = false;
            mnuGameSonic3.Checked = true;

            RefreshWindowTitle();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            if (ofdSavestate.ShowDialog() == DialogResult.OK)
            {
                savestateFile = ofdSavestate.FileName;
                savestate.Load(savestateFile);
                fileLoaded = true;

                propertyGrid1.SelectedObject = savestate;
                propertyGrid1.Enabled = true;

                mnuFileClose.Enabled = true;
                mnuFileSave.Enabled = true;
                mnuFileSaveAs.Enabled = true;

                mnuTools.Enabled = true;

                tlblStatus.Text = "Savestate Loaded";
                RefreshWindowTitle();
            }
        }

        private void RefreshWindowTitle()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SonicState - ");

            if (mnuGameSonic1.Checked)
                sb.Append("Sonic 1");
            else if (mnuGameSonic2.Checked)
                sb.Append("Sonic 2");
            else if (mnuGameSonic3.Checked)
                sb.Append("Sonic 3");

            if (fileLoaded)
            {
                sb.Append(" - ");
                sb.Append(System.IO.Path.GetFileName(savestateFile));
            }

            this.Text = sb.ToString();
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            savestateFile = string.Empty;
            fileLoaded = false;

            if (mnuGameSonic1.Checked)
                savestate = new Sonic1Savestate();
            else if (mnuGameSonic2.Checked)
                savestate = new Sonic2Savestate();
            else if (mnuGameSonic3.Checked)
                savestate = new Sonic3Savestate();

            propertyGrid1.SelectedObject = savestate;
            propertyGrid1.Enabled = false;

            mnuFileClose.Enabled = false;
            mnuFileSave.Enabled = false;
            mnuFileSaveAs.Enabled = false;

            mnuTools.Enabled = false;

            tlblStatus.Text = "Ready";
            RefreshWindowTitle();
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            savestate.Save(savestateFile);
            tlblStatus.Text = "Savestate Saved";
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            if (sfdSavestate.ShowDialog() == DialogResult.OK)
            {
                savestateFile = sfdSavestate.FileName;
                savestate.Save(savestateFile);
                tlblStatus.Text = "Savestate Saved";

                RefreshWindowTitle();
            }
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            (new frmAbout()).ShowDialog();
        }

        private void mnuToolsCopyData_Click(object sender, EventArgs e)
        {
            (new frmCopyData(savestate)).ShowDialog();
        }
    }
}
