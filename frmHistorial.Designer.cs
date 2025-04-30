namespace PedidosApp_WalterBenitez
{
    partial class frmHistorial
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
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblTipoEntrega = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(318, 24);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(85, 13);
            this.lblHistorial.TabIndex = 0;
            this.lblHistorial.Text = "Historial Pedidos";
            this.lblHistorial.Click += new System.EventHandler(this.lblHistorial_Click);
            // 
            // lblTipoEntrega
            // 
            this.lblTipoEntrega.AutoSize = true;
            this.lblTipoEntrega.Location = new System.Drawing.Point(336, 123);
            this.lblTipoEntrega.Name = "lblTipoEntrega";
            this.lblTipoEntrega.Size = new System.Drawing.Size(67, 13);
            this.lblTipoEntrega.TabIndex = 1;
            this.lblTipoEntrega.Text = "Tipo entrega";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(309, 139);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 2;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(12, 166);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(746, 150);
            this.dgvHistorial.TabIndex = 3;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.lblTipoEntrega);
            this.Controls.Add(this.lblHistorial);
            this.Name = "frmHistorial";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblTipoEntrega;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.DataGridView dgvHistorial;
    }
}