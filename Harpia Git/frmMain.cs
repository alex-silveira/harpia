using Harpia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harpia
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            returnDefaultColorNav(NavHome);
        }

        Forms frm = new Forms();
        string currentPath = Directory.GetCurrentDirectory();

        private void returnDefaultColorNav(ToolStripMenuItem name)
        {
            name.BackColor = Color.FromArgb(244, 81, 30);
            name.ForeColor = Color.White;
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            tlpMain.Controls.Clear();
            Home home = new Home();
            tlpMain.Controls.Add(home);
        }

        private void FrmGitCommands_Load(object sender, EventArgs e)
        {
            this.menuStrip1.Renderer = new ToolStripProfessionalRenderer(new NavColor());
        }
    }
}
