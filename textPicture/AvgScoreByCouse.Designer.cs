namespace textPicture
{
    partial class AvgScoreByCouse
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
            this.dgv_DataAvg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataAvg)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DataAvg
            // 
            this.dgv_DataAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataAvg.Location = new System.Drawing.Point(52, 34);
            this.dgv_DataAvg.Name = "dgv_DataAvg";
            this.dgv_DataAvg.RowHeadersWidth = 51;
            this.dgv_DataAvg.RowTemplate.Height = 24;
            this.dgv_DataAvg.Size = new System.Drawing.Size(465, 385);
            this.dgv_DataAvg.TabIndex = 0;
            // 
            // AvgScoreByCouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 501);
            this.Controls.Add(this.dgv_DataAvg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AvgScoreByCouse";
            this.Text = "AvgScoreByCouse";
            this.Load += new System.EventHandler(this.AvgScoreByCouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataAvg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DataAvg;
    }
}