using PEPlugin;
using PEPlugin.Pmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VertexGatherer
{
    public partial class CtrlForm : Form
    {
        IPERunArgs args;
        IPXPmx currentPmx;

        public CtrlForm(IPERunArgs input)
        {
            InitializeComponent();
            args = input;
            currentPmx = args.Host.Connector.Pmx.GetCurrentState();
        }

        private void CtrlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Visible = false;
            }
        }
    }
}