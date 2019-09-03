namespace GUI.BD
{
    partial class FrmRestoreBKP
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
            this.txtRuta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDescripcion = new DevComponents.DotNetBar.LabelX();
            this.btnValidar = new DevComponents.DotNetBar.ButtonX();
            this.btnVolver = new DevComponents.DotNetBar.ButtonX();
            this.btnRestaurar = new DevComponents.DotNetBar.ButtonX();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatos
            // 
            this.gbxDatos.CanvasColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gbxDatos.Controls.Add(this.txtRuta);
            this.gbxDatos.Controls.Add(this.lblDescripcion);
            this.gbxDatos.Controls.Add(this.btnValidar);
            this.gbxDatos.Location = new System.Drawing.Point(12, 12);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(590, 101);
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
            this.gbxDatos.Text = "Fuente";
            // 
            // txtRuta
            // 
            // 
            // 
            // 
            this.txtRuta.Border.Class = "TextBoxBorder";
            this.txtRuta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRuta.Location = new System.Drawing.Point(63, 26);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(460, 20);
            this.txtRuta.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            // 
            // 
            // 
            this.lblDescripcion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 23);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(42, 23);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Ruta";
            // 
            // btnValidar
            // 
            this.btnValidar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnValidar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnValidar.Location = new System.Drawing.Point(529, 23);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(38, 23);
            this.btnValidar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnValidar.TabIndex = 0;
            this.btnValidar.Text = "...";
            // 
            // btnVolver
            // 
            this.btnVolver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVolver.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVolver.Location = new System.Drawing.Point(12, 128);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRestaurar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRestaurar.Location = new System.Drawing.Point(527, 128);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.Text = "Restaurar";
            // 
            // FrmRestoreBKP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 189);
            this.ControlBox = false;
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbxDatos);
            this.Name = "FrmRestoreBKP";
            this.Text = "BackUp - Restaurar";
            this.Load += new System.EventHandler(this.FrmRestoreBKP_Load);
            this.gbxDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gbxDatos;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRuta;
        private DevComponents.DotNetBar.LabelX lblDescripcion;
        private DevComponents.DotNetBar.ButtonX btnValidar;
        private DevComponents.DotNetBar.ButtonX btnVolver;
        private DevComponents.DotNetBar.ButtonX btnRestaurar;
    }
}