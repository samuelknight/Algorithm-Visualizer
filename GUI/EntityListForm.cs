using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmVisualizer.GUI
{
    public partial class EntityListForm : Form
    {
        public EntityListForm()
        {
            InitializeComponent();
        }

        DataTable dt;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("X index", typeof(int)));
            dt.Columns.Add(new DataColumn("Y index", typeof(int)));
            dt.Columns.Add(new DataColumn("Clicks", typeof(int)));

            dataGridView.DataSource = dt;
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
                dt.Rows.Add(e.X, e.Y, e.Clicks);
        }
    }
}
