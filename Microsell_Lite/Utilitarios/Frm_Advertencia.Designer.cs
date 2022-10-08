namespace Microsell_Lite.Utilitarios
{
    partial class Frm_Advertencia
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
            this.lbl_msjl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_msjl
            // 
            this.lbl_msjl.AutoSize = true;
            this.lbl_msjl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msjl.Location = new System.Drawing.Point(38, 68);
            this.lbl_msjl.Name = "lbl_msjl";
            this.lbl_msjl.Size = new System.Drawing.Size(51, 20);
            this.lbl_msjl.TabIndex = 0;
            this.lbl_msjl.Text = "label1";
            // 
            // Frm_Advertencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 221);
            this.Controls.Add(this.lbl_msjl);
            this.Name = "Frm_Advertencia";
            this.Text = "Frm_Advertencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_msjl;
    }
}