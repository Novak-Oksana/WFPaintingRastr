namespace WFPainting
{
    partial class POpen
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
            this.btnopen = new System.Windows.Forms.Button();
            this.dgOpen = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(0, 3);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(102, 40);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // dgOpen
            // 
            this.dgOpen.FileName = "openFileDialog1";
            // 
            // POpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnopen);
            this.Name = "POpen";
            this.Size = new System.Drawing.Size(172, 107);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.OpenFileDialog dgOpen;
    }
}
