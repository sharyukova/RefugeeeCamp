namespace RefugeeeCamp
{
    partial class SecondForm
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
            this.dataGridViewSecF = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecF)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSecF
            // 
            this.dataGridViewSecF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecF.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSecF.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSecF.Name = "dataGridViewSecF";
            this.dataGridViewSecF.RowHeadersWidth = 51;
            this.dataGridViewSecF.RowTemplate.Height = 24;
            this.dataGridViewSecF.Size = new System.Drawing.Size(800, 325);
            this.dataGridViewSecF.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(516, 361);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(206, 57);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewSecF);
            this.Name = "SecondForm";
            this.Text = "Дополнительная информация";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSecF;
        private System.Windows.Forms.Button buttonClose;
    }
}