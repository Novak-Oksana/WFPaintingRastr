namespace WFPainting
{
    partial class PColor
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
            this.select_color = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // select_color
            // 
            this.select_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_color.DropDownWidth = 100;
            this.select_color.FormattingEnabled = true;
            this.select_color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select_color.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green"});
            this.select_color.Location = new System.Drawing.Point(3, 3);
            this.select_color.Name = "select_color";
            this.select_color.Size = new System.Drawing.Size(101, 21);
            this.select_color.TabIndex = 0;
            this.select_color.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.select_color);
            this.Name = "PColor";
            this.Size = new System.Drawing.Size(107, 28);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox select_color;
    }
}
