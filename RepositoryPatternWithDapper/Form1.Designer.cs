
namespace RepositoryPatternWithDapper
{
    partial class prdFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prdDtGrd = new System.Windows.Forms.DataGridView();
            this.lblTotalRec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prdDtGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // prdDtGrd
            // 
            this.prdDtGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prdDtGrd.Location = new System.Drawing.Point(12, 12);
            this.prdDtGrd.Name = "prdDtGrd";
            this.prdDtGrd.RowTemplate.Height = 25;
            this.prdDtGrd.Size = new System.Drawing.Size(776, 401);
            this.prdDtGrd.TabIndex = 0;
            // 
            // lblTotalRec
            // 
            this.lblTotalRec.AutoSize = true;
            this.lblTotalRec.Location = new System.Drawing.Point(25, 423);
            this.lblTotalRec.Name = "lblTotalRec";
            this.lblTotalRec.Size = new System.Drawing.Size(98, 15);
            this.lblTotalRec.TabIndex = 1;
            this.lblTotalRec.Text = "Total Records: ???";
            // 
            // prdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalRec);
            this.Controls.Add(this.prdDtGrd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "prdFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind";
            this.Load += new System.EventHandler(this.prdFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prdDtGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView prdDtGrd;
        private System.Windows.Forms.Label lblTotalRec;
    }
}

