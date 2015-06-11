namespace theaterTicket
{
    partial class admin
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.gridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSpeqtakli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridName,
            this.gridLast,
            this.gridSpeqtakli,
            this.gridType,
            this.gridQuantity,
            this.gridDate});
            this.gridView.Location = new System.Drawing.Point(12, 59);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(691, 150);
            this.gridView.TabIndex = 0;
            // 
            // gridName
            // 
            this.gridName.HeaderText = "სახელი";
            this.gridName.Name = "gridName";
            // 
            // gridLast
            // 
            this.gridLast.HeaderText = "გვარი";
            this.gridLast.Name = "gridLast";
            // 
            // gridSpeqtakli
            // 
            this.gridSpeqtakli.HeaderText = "სპექტაკლი";
            this.gridSpeqtakli.Name = "gridSpeqtakli";
            // 
            // gridType
            // 
            this.gridType.HeaderText = "ბილეთი";
            this.gridType.Name = "gridType";
            // 
            // gridQuantity
            // 
            this.gridQuantity.HeaderText = "რაოდენობა";
            this.gridQuantity.Name = "gridQuantity";
            // 
            // gridDate
            // 
            this.gridDate.HeaderText = "თარიღი";
            this.gridDate.Name = "gridDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "გაყიდული ბილეთები";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridView);
            this.Name = "admin";
            this.Text = "admin";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridSpeqtakli;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDate;
        private System.Windows.Forms.Label label1;
    }
}