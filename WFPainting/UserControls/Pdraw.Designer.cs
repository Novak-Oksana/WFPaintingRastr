namespace WFPainting
{
    partial class Pdraw
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.SystemColors.Info;
            this.pbox.Location = new System.Drawing.Point(3, 3);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(536, 453);
            this.pbox.TabIndex = 0;
            this.pbox.TabStop = false;
            this.pbox.Paint += new System.Windows.Forms.PaintEventHandler(this.pbox_Paint);
            this.pbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbox_MouseDown);
            this.pbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbox_MouseMove);
            this.pbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbox_MouseUp);
            // 
            // Pdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbox);
            this.Name = "Pdraw";
            this.Size = new System.Drawing.Size(542, 459);
            this.Load += new System.EventHandler(this.Pdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbox;
      
    }
}
