namespace Microsell_Lite.Utilitarios
{
    partial class Frm_SiNo
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
            this.btn_Si = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_No = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.lbl_Nomaalgo = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Si)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Nomaalgo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Si
            // 
            this.btn_Si.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Si.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Si.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Si.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Si.Location = new System.Drawing.Point(39, 90);
            this.btn_Si.Name = "btn_Si";
            this.btn_Si.Size = new System.Drawing.Size(75, 23);
            this.btn_Si.TabIndex = 0;
            this.btn_Si.TextStyle.Text = "Si";
            this.btn_Si.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Si.Click += new System.EventHandler(this.btn_Si_Click);
            // 
            // btn_No
            // 
            this.btn_No.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_No.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_No.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_No.Location = new System.Drawing.Point(183, 90);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(75, 23);
            this.btn_No.TabIndex = 1;
            this.btn_No.TextStyle.Text = "No";
            this.btn_No.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // lbl_Nomaalgo
            // 
            paintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle1.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.lbl_Nomaalgo.FlashStyle = paintStyle1;
            this.lbl_Nomaalgo.Location = new System.Drawing.Point(39, 38);
            this.lbl_Nomaalgo.Name = "lbl_Nomaalgo";
            this.lbl_Nomaalgo.Size = new System.Drawing.Size(219, 23);
            this.lbl_Nomaalgo.TabIndex = 2;
            this.lbl_Nomaalgo.TabStop = false;
            this.lbl_Nomaalgo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Nomaalgo_MouseMove);
            // 
            // Frm_SiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 161);
            this.Controls.Add(this.lbl_Nomaalgo);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Si);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SiNo";
            this.Text = "Frm_SiNo";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Si)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Nomaalgo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Si;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_No;
        public Klik.Windows.Forms.v1.EntryLib.ELLabel lbl_Nomaalgo;
        public Klik.Windows.Forms.v1.EntryLib.ELLabel Lbl_msm1;
    }
}