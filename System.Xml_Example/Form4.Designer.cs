namespace System.Xml_Example
{
    partial class Form4
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(324, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(12, 22);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(179, 20);
            this.txtBusca.TabIndex = 1;
            // 
            // cmbCampo
            // 
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Nome",
            "Telefone"});
            this.cmbCampo.Location = new System.Drawing.Point(197, 22);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 65);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Button btnBuscar;
        private Windows.Forms.TextBox txtBusca;
        private Windows.Forms.ComboBox cmbCampo;
    }
}