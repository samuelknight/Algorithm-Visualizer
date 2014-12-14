using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AlgorithmVisualizer.GUI
{
    public partial class MainForm : Form
    {
        EntityListForm elf;

        public MainForm()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            consolePanelHeight = this.Height - splitContainer.SplitterDistance;
            //Sandbox.startRendering();
        }

        private void entitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (elf == null || elf.IsDisposed)
                elf = new EntityListForm();
            
            elf.Show();
        }

        #region Split Container behavior control
        int consolePanelHeight;
        bool ignoreSplitterEvent = false;

        protected override void OnResizeBegin(EventArgs e)
        {
            ignoreSplitterEvent = true;
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            ignoreSplitterEvent = false;
        }

        private void splitContainer_Resize(object sender, EventArgs e)
        {
            splitContainer.SplitterDistance = this.Height - consolePanelHeight;
        }

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (!ignoreSplitterEvent)
                consolePanelHeight = this.Height - splitContainer.SplitterDistance;
        }
        #endregion

        private void Sandbox_Click(object sender, EventArgs e)
        {

        }
          
    }
}