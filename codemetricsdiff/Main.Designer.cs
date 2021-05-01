
namespace codemetricsdiff
{
    partial class CodeMetricsDiff
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstXML = new System.Windows.Forms.ListBox();
            this.btnDiff = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lstXML
            // 
            this.lstXML.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstXML.FormattingEnabled = true;
            this.lstXML.ItemHeight = 12;
            this.lstXML.Location = new System.Drawing.Point(8, 8);
            this.lstXML.Name = "lstXML";
            this.lstXML.Size = new System.Drawing.Size(190, 434);
            this.lstXML.TabIndex = 0;
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(205, 12);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(75, 23);
            this.btnDiff.TabIndex = 1;
            this.btnDiff.Text = "Diff";
            this.btnDiff.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(205, 41);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 21;
            this.dgv.Size = new System.Drawing.Size(584, 398);
            this.dgv.TabIndex = 2;
            // 
            // CodeMetricsDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.lstXML);
            this.Name = "CodeMetricsDiff";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "CodeMetricsDiff";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstXML;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.DataGridView dgv;
    }
}

