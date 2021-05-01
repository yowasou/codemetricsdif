using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
            List<string> lstXmllst = new List<string>();
            foreach(string s in System.IO.Directory.GetFiles(
                Properties.Settings.Default.metrics_output_path, "*.xml", System.IO.SearchOption.AllDirectories))
            {
                lstXmllst.Add(Path.GetFileName(s));
            }
            lstXmllst.Sort((a, b) => b.CompareTo(a));
            lstXML.Items.AddRange(lstXmllst.ToArray());

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
            if (lstXML.SelectedItems == null)
            {
                MessageBox.Show("XMLを2つ選択してください");
                return;
            }
            if (lstXML.SelectedItems.Count != 2)
            {
                MessageBox.Show("XMLを2つ選択してください");
                return;
            }
            string fromXmlFile = Convert.ToString(lstXML.SelectedItems[0]);
            string toXmlFile = Convert.ToString(lstXML.SelectedItems[1]);
            if (fromXmlFile.CompareTo(toXmlFile) > 0)
            {
                string temp = fromXmlFile;
                fromXmlFile = toXmlFile;
                toXmlFile = temp;
            }
            DataTable dt1 = LoadXmlToDataTable(fromXmlFile);
            DataTable dt2 = LoadXmlToDataTable(toXmlFile);
            DataTable dt = new DataTable("data");
            dt.Columns.Add("FileName", typeof(string));
            dt.Columns.Add("MethodName", typeof(string));
            dt.Columns.Add("CyclomaticComplexity1", typeof(int));
            dt.Columns.Add("CyclomaticComplexity2", typeof(int));
            dt.Columns.Add("ExecutableLines1", typeof(int));
            dt.Columns.Add("ExecutableLines2", typeof(int));
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0], dt.Columns[1] };
            
            foreach(DataRow dr1 in dt1.Rows)
            {
                DataRow dr2 = dt2.Rows.Find(new object[] { dr1["FileName"], dr1["MethodName"] });
                if (dr2 != null)
                {
                    //fromにもtoにもあるものについて行追加していく

                }
                else
                {
                    //fromにだけあるもの
                }
            }



            dgv.DataSource = dt1;
            dgv.Columns[0].HeaderText = "ファイル名";
            dgv.Columns[1].HeaderText = "メソッド名";
            dgv.Columns[2].HeaderText = "循環的複雑度";
            dgv.Columns[3].HeaderText = "ステップ数";

            return;
            dgv.Columns[0].HeaderText = "ファイル名";
            dgv.Columns[1].HeaderText = "メソッド名";
            dgv.Columns[2].HeaderText = "循環的複雑度1";
            dgv.Columns[3].HeaderText = "循環的複雑度2";
            dgv.Columns[4].HeaderText = "ステップ数1";
            dgv.Columns[5].HeaderText = "ステップ数2";
        }

        protected virtual DataTable LoadXmlToDataTable(string fromXmlFile)
        {
            DataTable dt = new DataTable("fromdata");
            dt.Columns.Add("FileName", typeof(string));
            dt.Columns.Add("MethodName", typeof(string));
            dt.Columns.Add("CyclomaticComplexity", typeof(int));
            dt.Columns.Add("ExecutableLines", typeof(int));
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0], dt.Columns[1] };

            //XmlSerializerオブジェクトを作成
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(xmlMetrics.CodeMetricsReport));
            //読み込むファイルを開く
            System.IO.StreamReader sr = new System.IO.StreamReader(
                Properties.Settings.Default.metrics_output_path + "\\" + fromXmlFile,
                new System.Text.UTF8Encoding(false));
            //XMLファイルから読み込み、逆シリアル化する
            xmlMetrics.CodeMetricsReport crt =
                (xmlMetrics.CodeMetricsReport)serializer.Deserialize(sr);
            foreach (var n in crt.Targets.Target.Assembly.Namespaces)
            {
                foreach (var t in n.Types)
                {
                    if (t.Members is null)
                    {
                        continue;
                    }
                    foreach (var mem in t.Members.Items)
                    {
                        if (mem is xmlMetrics.CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersMethod)
                        {
                            xmlMetrics.CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersMethod x
                                = (xmlMetrics.CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersMethod)mem;
                            DataRow drNew = dt.NewRow();
                            drNew["FileName"] = Path.GetFileName(x.File);
                            drNew["MethodName"] = x.Name;
                            drNew["CyclomaticComplexity"] = GetMatricsValue(x.Metrics, "CyclomaticComplexity");
                            drNew["ExecutableLines"] = GetMatricsValue(x.Metrics, "ExecutableLines");
                            dt.Rows.Add(drNew);
                        }
                    }
                }
            }

            return dt;
        }

        protected virtual int GetMatricsValue(xmlMetrics.CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersMethodMetric[] xs 
            , string name)
        {
            int ret = 0;
            foreach(var x in xs)
            {
                if (x.Name == name)
                {
                    ret = x.Value;
                }
            }
            return ret;
        }


        private void diffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diff();
        }
    }
}
