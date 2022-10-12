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
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle1 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            this.lbl_msjl1 = new System.Windows.Forms.Label();
            this.lbl_msjl = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.btnAceptar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_msjl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_msjl1
            // 
            this.lbl_msjl1.AutoSize = true;
            this.lbl_msjl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msjl1.Location = new System.Drawing.Point(32, 26);
            this.lbl_msjl1.Name = "lbl_msjl1";
            this.lbl_msjl1.Size = new System.Drawing.Size(51, 20);
            this.lbl_msjl1.TabIndex = 0;
            this.lbl_msjl1.Text = "label1";
            // 
            // lbl_msjl
            // 
            paintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle1.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.lbl_msjl.FlashStyle = paintStyle1;
            this.lbl_msjl.Location = new System.Drawing.Point(36, 76);
            this.lbl_msjl.Name = "lbl_msjl";
            this.lbl_msjl.Size = new System.Drawing.Size(291, 23);
            this.lbl_msjl.TabIndex = 1;
            this.lbl_msjl.TabStop = false;
            this.lbl_msjl.TextStyle.Text = "elLabel1";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnAceptar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnAceptar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Location = new System.Drawing.Point(151, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.TextStyle.Text = "Aceptar";
            this.btnAceptar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Frm_Advertencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 221);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbl_msjl);
            this.Controls.Add(this.lbl_msjl1);
            this.Name = "Frm_Advertencia";
            this.Text = "Frm_Advertencia";
            this.Load += new System.EventHandler(this.Frm_Advertencia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Advertencia_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_Advertencia_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_msjl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_msjl1;
        private Klik.Windows.Forms.v1.EntryLib.ELLabel lbl_msjl;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnAceptar;
    }
}