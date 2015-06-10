namespace theaterTicket
{
    partial class orderTicket
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
            this.combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.buy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(16, 62);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(505, 21);
            this.combo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "აირჩიეთ სპექტაკლი";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ბილეთების რაოდენობა";
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(16, 126);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(134, 20);
            this.textbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ბილეთის ტიპი";
            // 
            // combo2
            // 
            this.combo2.FormattingEnabled = true;
            this.combo2.Items.AddRange(new object[] {
            "ჩვეულებრივი",
            "VIP"});
            this.combo2.Location = new System.Drawing.Point(238, 125);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(121, 21);
            this.combo2.TabIndex = 5;
            this.combo2.ValueMember = "s";
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(16, 186);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(134, 23);
            this.buy.TabIndex = 6;
            this.buy.Text = "ბილეთის ყიდვა";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // orderTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 395);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo);
            this.Name = "orderTicket";
            this.Text = "orderTicket";
            this.Load += new System.EventHandler(this.orderTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.Button buy;
    }
}