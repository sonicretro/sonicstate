using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SonicState
{
    public partial class frmCopyData : Form
    {
        Savestate source;

        public frmCopyData(Savestate source)
        {
            InitializeComponent();

            this.source = source;
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            tbtnCopy.Enabled = (txtDestination.TextLength > 0);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdDestination.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = ofdDestination.FileName;
            }
        }

        private void tbtnDataTypeArt_Click(object sender, EventArgs e)
        {
            tbtnDataType.Text = tmnuDataTypeArt.Text;

            tmnuDataTypeLevel.Checked = false;
            tmnuDataTypeCustom.Checked = false;

            nudDataStart.Enabled = false;
            nudDataEnd.Enabled = false;
            nudDataStart.Value = 0x12478;
            nudDataEnd.Value = 0x22477;
        }

        private void tmnuDataTypeLevel_Click(object sender, EventArgs e)
        {
            tbtnDataType.Text = tmnuDataTypeLevel.Text;

            tmnuDataTypeArt.Checked = false;
            tmnuDataTypeCustom.Checked = false;

            nudDataStart.Enabled = false;
            nudDataEnd.Enabled = false;
            nudDataStart.Value = 0xA478;
            nudDataEnd.Value = 0xB477;
        }

        private void tmnuDataTypeCustom_Click(object sender, EventArgs e)
        {
            tbtnDataType.Text = tmnuDataTypeCustom.Text;

            tmnuDataTypeLevel.Checked = false;
            tmnuDataTypeArt.Checked = false;

            nudDataStart.Enabled = true;
            nudDataEnd.Enabled = true;
        }

        private void tbtnCopy_Click(object sender, EventArgs e)
        {
            source.CopyRange(ofdDestination.FileName, (int)nudDataStart.Value, (int)nudDataEnd.Value);
        }
    }
}
