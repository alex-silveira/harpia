namespace Harpia
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NavHome = new System.Windows.Forms.ToolStripMenuItem();
            this.startAWorkingAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnInfos = new System.Windows.Forms.Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NavHome,
            this.startAWorkingAreaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(130, 729);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NavHome
            // 
            this.NavHome.Name = "NavHome";
            this.NavHome.Padding = new System.Windows.Forms.Padding(4, 20, 10, 10);
            this.NavHome.Size = new System.Drawing.Size(129, 49);
            this.NavHome.Text = "Quick Start";
            this.NavHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NavHome.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // startAWorkingAreaToolStripMenuItem
            // 
            this.startAWorkingAreaToolStripMenuItem.Name = "startAWorkingAreaToolStripMenuItem";
            this.startAWorkingAreaToolStripMenuItem.Size = new System.Drawing.Size(129, 4);
            // 
            // pnInfos
            // 
            this.pnInfos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnInfos.BackgroundImage")));
            this.pnInfos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnInfos.Location = new System.Drawing.Point(132, 22);
            this.pnInfos.Name = "pnInfos";
            this.pnInfos.Size = new System.Drawing.Size(127, 38);
            this.pnInfos.TabIndex = 0;
            this.pnInfos.Visible = false;
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Location = new System.Drawing.Point(132, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(876, 729);
            this.tlpMain.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnInfos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HARPIA - GIT";
            this.Load += new System.EventHandler(this.FrmGitCommands_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startAWorkingAreaToolStripMenuItem;
        private System.Windows.Forms.Panel pnInfos;
        private System.Windows.Forms.ToolStripMenuItem NavHome;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
    }
}

