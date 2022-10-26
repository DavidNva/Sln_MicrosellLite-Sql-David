namespace Microsell_Lite.Proveedor
{
    partial class Frm_ListadoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListadoProveedor));
            this.pnl_titu = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsv_ListaProveedores = new System.Windows.Forms.ListView();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_titu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titu
            // 
            this.pnl_titu.BackColor = System.Drawing.Color.DimGray;
            this.pnl_titu.Controls.Add(this.btn_cerrar);
            this.pnl_titu.Controls.Add(this.label1);
            this.pnl_titu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titu.Location = new System.Drawing.Point(0, 0);
            this.pnl_titu.Name = "pnl_titu";
            this.pnl_titu.Size = new System.Drawing.Size(430, 43);
            this.pnl_titu.TabIndex = 10;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(388, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(32, 32);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Proveedores";
            // 
            // lsv_ListaProveedores
            // 
            this.lsv_ListaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_ListaProveedores.ForeColor = System.Drawing.Color.DimGray;
            this.lsv_ListaProveedores.HideSelection = false;
            this.lsv_ListaProveedores.Location = new System.Drawing.Point(10, 49);
            this.lsv_ListaProveedores.Name = "lsv_ListaProveedores";
            this.lsv_ListaProveedores.Size = new System.Drawing.Size(300, 339);
            this.lsv_ListaProveedores.TabIndex = 14;
            this.lsv_ListaProveedores.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Image = global::Microsell_Lite.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782__1_;
            this.btn_Edit.Location = new System.Drawing.Point(320, 49);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(37, 42);
            this.btn_Edit.TabIndex = 13;
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::Microsell_Lite.Properties.Resources.plus_icon_icons_com_69322__1_;
            this.btn_Add.Location = new System.Drawing.Point(377, 49);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(33, 42);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // Frm_ListadoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 400);
            this.Controls.Add(this.pnl_titu);
            this.Controls.Add(this.lsv_ListaProveedores);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListadoProveedor";
            this.Text = "Frm_ListadoProveedor";
            this.pnl_titu.ResumeLayout(false);
            this.pnl_titu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titu;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsv_ListaProveedores;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
    }
}