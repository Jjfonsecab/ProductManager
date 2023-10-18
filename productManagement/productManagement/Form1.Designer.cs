namespace productManagement
{
    partial class Form1
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
            this.listCompras = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.lblCodigoDescuento = new System.Windows.Forms.Label();
            this.txtCodigoDescuento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listCompras
            // 
            this.listCompras.FormattingEnabled = true;
            this.listCompras.ItemHeight = 20;
            this.listCompras.Location = new System.Drawing.Point(31, 36);
            this.listCompras.Name = "listCompras";
            this.listCompras.Size = new System.Drawing.Size(193, 324);
            this.listCompras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(317, 143);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 46);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(437, 143);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(181, 46);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Precio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(298, 66);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(335, 28);
            this.cboProductos.TabIndex = 3;
            // 
            // lblCodigoDescuento
            // 
            this.lblCodigoDescuento.AutoSize = true;
            this.lblCodigoDescuento.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodigoDescuento.Location = new System.Drawing.Point(294, 229);
            this.lblCodigoDescuento.Name = "lblCodigoDescuento";
            this.lblCodigoDescuento.Size = new System.Drawing.Size(175, 20);
            this.lblCodigoDescuento.TabIndex = 4;
            this.lblCodigoDescuento.Text = "Codigo de Descuento : ";
            // 
            // txtCodigoDescuento
            // 
            this.txtCodigoDescuento.Location = new System.Drawing.Point(490, 229);
            this.txtCodigoDescuento.Name = "txtCodigoDescuento";
            this.txtCodigoDescuento.Size = new System.Drawing.Size(143, 26);
            this.txtCodigoDescuento.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigoDescuento);
            this.Controls.Add(this.lblCodigoDescuento);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listCompras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCompras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label lblCodigoDescuento;
        private System.Windows.Forms.TextBox txtCodigoDescuento;
    }
}

