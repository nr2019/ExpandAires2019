namespace GUI.Idioma
{
    partial class FrmCrearTextos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxDatos = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgwDestino = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgwModelo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cboDestino = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboModelo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnCopiar = new DevComponents.DotNetBar.ButtonX();
            this.lblDestino = new DevComponents.DotNetBar.LabelX();
            this.lblModelo = new DevComponents.DotNetBar.LabelX();
            this.btnVolver = new DevComponents.DotNetBar.ButtonX();
            this.btnCrear = new DevComponents.DotNetBar.ButtonX();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDatos
            // 
            this.gbxDatos.CanvasColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gbxDatos.Controls.Add(this.dgwDestino);
            this.gbxDatos.Controls.Add(this.dgwModelo);
            this.gbxDatos.Controls.Add(this.cboDestino);
            this.gbxDatos.Controls.Add(this.cboModelo);
            this.gbxDatos.Controls.Add(this.btnCopiar);
            this.gbxDatos.Controls.Add(this.lblDestino);
            this.gbxDatos.Controls.Add(this.lblModelo);
            this.gbxDatos.Location = new System.Drawing.Point(12, 12);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(776, 383);
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
            // dgwDestino
            // 
            this.dgwDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwDestino.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwDestino.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgwDestino.Location = new System.Drawing.Point(399, 55);
            this.dgwDestino.Name = "dgwDestino";
            this.dgwDestino.Size = new System.Drawing.Size(368, 290);
            this.dgwDestino.TabIndex = 6;
            // 
            // dgwModelo
            // 
            this.dgwModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwModelo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwModelo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgwModelo.Location = new System.Drawing.Point(19, 55);
            this.dgwModelo.Name = "dgwModelo";
            this.dgwModelo.Size = new System.Drawing.Size(365, 290);
            this.dgwModelo.TabIndex = 5;
            // 
            // cboDestino
            // 
            this.cboDestino.DisplayMember = "Text";
            this.cboDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.ItemHeight = 14;
            this.cboDestino.Location = new System.Drawing.Point(490, 25);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(163, 20);
            this.cboDestino.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboDestino.TabIndex = 4;
            // 
            // cboModelo
            // 
            this.cboModelo.DisplayMember = "Text";
            this.cboModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.ItemHeight = 14;
            this.cboModelo.Location = new System.Drawing.Point(104, 25);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(151, 20);
            this.cboModelo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboModelo.TabIndex = 3;
            // 
            // btnCopiar
            // 
            this.btnCopiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCopiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCopiar.Location = new System.Drawing.Point(282, 22);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCopiar.TabIndex = 2;
            this.btnCopiar.Text = "Copiar todo";
            // 
            // lblDestino
            // 
            // 
            // 
            // 
            this.lblDestino.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDestino.Location = new System.Drawing.Point(399, 22);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(75, 23);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Idioma Destino";
            // 
            // lblModelo
            // 
            // 
            // 
            // 
            this.lblModelo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblModelo.Location = new System.Drawing.Point(19, 25);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(75, 23);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "IdiomaModelo";
            // 
            // btnVolver
            // 
            this.btnVolver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVolver.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVolver.Location = new System.Drawing.Point(13, 412);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            // 
            // btnCrear
            // 
            this.btnCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCrear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCrear.Location = new System.Drawing.Point(713, 412);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            // 
            // FrmCrearTextos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbxDatos);
            this.Name = "FrmCrearTextos";
            this.Text = "Idioma - Crear Textos";
            this.Load += new System.EventHandler(this.FrmCrearTextos_Load);
            this.gbxDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwModelo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gbxDatos;
        private DevComponents.DotNetBar.ButtonX btnVolver;
        private DevComponents.DotNetBar.ButtonX btnCrear;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgwDestino;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgwModelo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDestino;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboModelo;
        private DevComponents.DotNetBar.ButtonX btnCopiar;
        private DevComponents.DotNetBar.LabelX lblDestino;
        private DevComponents.DotNetBar.LabelX lblModelo;
    }
}