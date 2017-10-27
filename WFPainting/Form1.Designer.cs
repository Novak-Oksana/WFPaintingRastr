namespace WFPainting
{
    partial class Form1
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
            this.pOpen1 = new WFPainting.POpen();
            this.pSave1 = new WFPainting.PSave();
            this.pFigure1 = new WFPainting.select_figure();
            this.pWidth1 = new WFPainting.PWidth();
            this.pColor1 = new WFPainting.PColor();
            this.pdraw2 = new WFPainting.Pdraw();
            this.SuspendLayout();
            // 
            // pOpen1
            // 
            this.pOpen1.Location = new System.Drawing.Point(5, 376);
            this.pOpen1.Name = "pOpen1";
            this.pOpen1.Size = new System.Drawing.Size(113, 58);
            this.pOpen1.TabIndex = 6;
            // 
            // pSave1
            // 
            this.pSave1.Location = new System.Drawing.Point(5, 329);
            this.pSave1.Name = "pSave1";
            this.pSave1.Size = new System.Drawing.Size(107, 121);
            this.pSave1.TabIndex = 5;
            // 
            // pFigure1
            // 
            this.pFigure1.Location = new System.Drawing.Point(-1, 53);
            this.pFigure1.Name = "pFigure1";
            this.pFigure1.Size = new System.Drawing.Size(107, 31);
            this.pFigure1.TabIndex = 4;
            // 
            // pWidth1
            // 
            this.pWidth1.Location = new System.Drawing.Point(-1, 27);
            this.pWidth1.Name = "pWidth1";
            this.pWidth1.Size = new System.Drawing.Size(107, 41);
            this.pWidth1.TabIndex = 3;
            // 
            // pColor1
            // 
            this.pColor1.Location = new System.Drawing.Point(-1, 0);
            this.pColor1.Name = "pColor1";
            this.pColor1.Size = new System.Drawing.Size(107, 35);
            this.pColor1.TabIndex = 2;
            // 
            // pdraw2
            // 
            this.pdraw2.Location = new System.Drawing.Point(124, 0);
            this.pdraw2.Name = "pdraw2";
            this.pdraw2.Size = new System.Drawing.Size(552, 464);
            this.pdraw2.TabIndex = 1;
            this.pdraw2.Load += new System.EventHandler(this.pdraw2_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 484);
            this.Controls.Add(this.pOpen1);
            this.Controls.Add(this.pSave1);
            this.Controls.Add(this.pFigure1);
            this.Controls.Add(this.pWidth1);
            this.Controls.Add(this.pColor1);
            this.Controls.Add(this.pdraw2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private PColor pColor1;
        private PWidth pWidth1;
        private select_figure pFigure1;
        private PSave pSave1;
        private POpen pOpen1;
        private Pdraw pdraw2;
    }
}

