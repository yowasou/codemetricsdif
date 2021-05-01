using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codemetricsdiff
{
    public partial class CodeMetricsDiff : Form
    {
        public CodeMetricsDiff()
        {
            InitializeComponent();
        }

        private void LoadXMLList()
        {
            lstXML.Items.Clear();
            foreach(string s in System.IO.Directory.GetFiles(
                Properties.Settings.Default.metrics_output_path, "*.xml", System.IO.SearchOption.AllDirectories))
            {
                lstXML.Items.Add(System.IO.Path.GetFileName(s));
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadXMLList();
        }

        private void CodeMetricsDiff_Activated(object sender, EventArgs e)
        {
            LoadXMLList();
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            Diff();
        }

        private void Diff()
        {
            throw new NotImplementedException();
        }

        private void diffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diff();
        }
    }
}
