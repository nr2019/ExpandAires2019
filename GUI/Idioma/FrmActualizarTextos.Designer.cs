namespace GUI.Idioma
{
    partial class FrmActualizarTextos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxDatos = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblDestino = new DevComponents.DotNetBar.LabelX();
            this.cboDestino = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnVolver = new DevComponents.DotNetBar.ButtonX();
            this.btnModif = new DevComponents.DotNetBar.ButtonX();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDatos
            // 
            this.gbxDatos.CanvasColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gbxDatos.Controls.Add(this.dataGridViewX1);
            this.gbxDatos.Controls.Add(this.lblDestino);
            this.gbxDatos.Controls.Add(this.cboDestino);
            this.gbxDatos.Location = new System.Drawing.Point(12, 12);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(383, 426);
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
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(15, 47);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(346, 342);
            this.dataGridViewX1.TabIndex = 2;
            // 
            // lblDestino
            // 
            // 
            // 
            // 
            this.lblDestino.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDestino.Location = new System.Drawing.Point(15, 18);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(75, 23);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Idioma Destino";
            // 
            // cboDestino
            // 
            this.cboDestino.DisplayMember = "Text";
            this.cboDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.ItemHeight = 14;
            this.cboDestino.Location = new System.Drawing.Point(229, 21);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(121, 20);
            this.cboDestino.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboDestino.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVolver.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVolver.Location = new System.Drawing.Point(13, 465);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            // 
            // btnModif
            // 
            this.btnModif.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModif.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnModif.Enabled = false;
            this.btnModif.Location = new System.Drawing.Point(320, 465);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modificar";
            // 
            // FrmActualizarTextos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 500);
            this.ControlBox = false;
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbxDatos);
            this.Name = "FrmActualizarTextos";
            this.Text = "Idioma - Actualizar Textos";
            this.Load += new System.EventHandler(this.FrmActualizarTextos_Load);
            this.gbxDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gbxDatos;
        private DevComponents.DotNetBar.ButtonX btnVolver;
        private DevComponents.DotNetBar.ButtonX btnModif;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.LabelX lblDestino;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDestino;
    }
}