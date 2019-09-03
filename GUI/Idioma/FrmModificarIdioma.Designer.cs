namespace GUI.Idioma
{
    partial class FrmModificarIdioma
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
            this.gbxDatos = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cboIdioma = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDescripcion = new DevComponents.DotNetBar.LabelX();
            this.lblIdioma = new DevComponents.DotNetBar.LabelX();
            this.btnVolver = new DevComponents.DotNetBar.ButtonX();
            this.btnModificar = new DevComponents.DotNetBar.ButtonX();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatos
            // 
            this.gbxDatos.CanvasColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gbxDatos.Controls.Add(this.cboIdioma);
            this.gbxDatos.Controls.Add(this.txtDescripcion);
            this.gbxDatos.Controls.Add(this.lblDescripcion);
            this.gbxDatos.Controls.Add(this.lblIdioma);
            this.gbxDatos.Location = new System.Drawing.Point(13, 13);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(378, 148);
            // 
            // 
            // 
            this.gbxDatos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gbxDatos.Style.BackColorGradientAngle = 90;
            this.gbxDatos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gbxDatos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gbxDatos.Style.BorderBottomWidth = 1;
            this.gbxDatos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gbxDatos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gbxDatos.Style.BorderLeftWidth = 1;
            this.gbxDatos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gbxDatos.Style.BorderRightWidth = 1;
            this.gbxDatos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gbxDatos.Style.BorderTopWidth = 1;
            this.gbxDatos.Style.CornerDiameter = 4;
            this.gbxDatos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gbxDatos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gbxDatos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gbxDatos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gbxDatos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gbxDatos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.Text = "Seleccione un Idioma";
            // 
            // cboIdioma
            // 
            this.cboIdioma.DisplayMember = "Text";
            this.cboIdioma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.ItemHeight = 14;
            this.cboIdioma.Location = new System.Drawing.Point(171, 19);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(121, 20);
            this.cboIdioma.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdioma.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Location = new System.Drawing.Point(171, 90);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            // 
            // 
            // 
            this.lblDescripcion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 88);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 23);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "labelX2";
            // 
            // lblIdioma
            // 
            // 
            // 
            // 
            this.lblIdioma.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblIdioma.Location = new System.Drawing.Point(17, 18);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(75, 23);
            this.lblIdioma.TabIndex = 0;
            this.lblIdioma.Text = "labelX1";
            // 
            // btnVolver
            // 
            this.btnVolver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVolver.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVolver.Location = new System.Drawing.Point(13, 192);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnModificar.Location = new System.Drawing.Point(316, 192);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            // 
            // FrmModificarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 243);
            this.ControlBox = false;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbxDatos);
            this.Name = "FrmModificarIdioma";
            this.Text = "Idioma - Modificar";
            this.Load += new System.EventHandler(this.FrmModificarIdioma_Load);
            this.gbxDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gbxDatos;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdioma;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.LabelX lblDescripcion;
        private DevComponents.DotNetBar.LabelX lblIdioma;
        private DevComponents.DotNetBar.ButtonX btnVolver;
        private DevComponents.DotNetBar.ButtonX btnModificar;
    }
}