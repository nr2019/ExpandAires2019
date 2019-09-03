namespace GUI.Idioma
{
    partial class FrmCambioIdioma
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
            this.lbldestino = new DevComponents.DotNetBar.LabelX();
            this.btnTomar = new DevComponents.DotNetBar.ButtonX();
            this.btnVolver = new DevComponents.DotNetBar.ButtonX();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatos
            // 
            this.gbxDatos.CanvasColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gbxDatos.Controls.Add(this.cboIdioma);
            this.gbxDatos.Controls.Add(this.lbldestino);
            this.gbxDatos.Location = new System.Drawing.Point(12, 12);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(298, 79);
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
            this.gbxDatos.Text = "Seleccione un idioma";
            // 
            // cboIdioma
            // 
            this.cboIdioma.DisplayMember = "Text";
            this.cboIdioma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.ItemHeight = 14;
            this.cboIdioma.Location = new System.Drawing.Point(122, 21);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(159, 20);
            this.cboIdioma.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdioma.TabIndex = 1;
            // 
            // lbldestino
            // 
            // 
            // 
            // 
            this.lbldestino.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbldestino.Location = new System.Drawing.Point(16, 20);
            this.lbldestino.Name = "lbldestino";
            this.lbldestino.Size = new System.Drawing.Size(100, 23);
            this.lbldestino.TabIndex = 0;
            this.lbldestino.Text = "Cambiar a idioma";
            // 
            // btnTomar
            // 
            this.btnTomar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTomar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTomar.Location = new System.Drawing.Point(235, 110);
            this.btnTomar.Name = "btnTomar";
            this.btnTomar.Size = new System.Drawing.Size(75, 23);
            this.btnTomar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTomar.TabIndex = 2;
            this.btnTomar.Text = "Tomar";
            // 
            // btnVolver
            // 
            this.btnVolver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVolver.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVolver.Location = new System.Drawing.Point(13, 109);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Vovler";
            // 
            // FrmCambioIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 179);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnTomar);
            this.Controls.Add(this.gbxDatos);
            this.Name = "FrmCambioIdioma";
            this.Text = "Idioma - Cambiar";
            this.Load += new System.EventHandler(this.FrmCambioIdioma_Load);
            this.gbxDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gbxDatos;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdioma;
        private DevComponents.DotNetBar.LabelX lbldestino;
        private DevComponents.DotNetBar.ButtonX btnTomar;
        private DevComponents.DotNetBar.ButtonX btnVolver;
    }
}