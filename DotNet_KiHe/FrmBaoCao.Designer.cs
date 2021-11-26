
namespace DotNet_KiHe
{
    partial class FrmBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.ActiveViewIndex = -1;
            this.report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.report.Cursor = System.Windows.Forms.Cursors.Default;
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report.Location = new System.Drawing.Point(0, 0);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(800, 450);
            this.report.TabIndex = 0;
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report);
            this.Name = "FrmBaoCao";
            this.Text = "FrmBaoCao";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer report;
    }
}