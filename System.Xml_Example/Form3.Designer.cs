namespace System.Xml_Example
{
    partial class Form3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefoneResidencial = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.pnlIncluir = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlAlterar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSAlterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefoneComercial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefoneCelular = new System.Windows.Forms.TextBox();
            this.pnlIncluir.SuspendLayout();
            this.pnlAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(295, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 340);
            this.listBox1.TabIndex = 13;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Residencial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // txtTelefoneResidencial
            // 
            this.txtTelefoneResidencial.Location = new System.Drawing.Point(12, 76);
            this.txtTelefoneResidencial.Name = "txtTelefoneResidencial";
            this.txtTelefoneResidencial.Size = new System.Drawing.Size(86, 20);
            this.txtTelefoneResidencial.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 20);
            this.txtNome.TabIndex = 8;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(447, 357);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(129, 23);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(295, 357);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(129, 23);
            this.btnSelecionar.TabIndex = 16;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // pnlIncluir
            // 
            this.pnlIncluir.Controls.Add(this.button1);
            this.pnlIncluir.Location = new System.Drawing.Point(12, 203);
            this.pnlIncluir.Name = "pnlIncluir";
            this.pnlIncluir.Size = new System.Drawing.Size(136, 36);
            this.pnlIncluir.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.Controls.Add(this.btnCancelar);
            this.pnlAlterar.Controls.Add(this.btnSAlterar);
            this.pnlAlterar.Location = new System.Drawing.Point(12, 245);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(136, 36);
            this.pnlAlterar.TabIndex = 19;
            this.pnlAlterar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(67, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(58, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSAlterar
            // 
            this.btnSAlterar.Location = new System.Drawing.Point(3, 3);
            this.btnSAlterar.Name = "btnSAlterar";
            this.btnSAlterar.Size = new System.Drawing.Size(58, 23);
            this.btnSAlterar.TabIndex = 0;
            this.btnSAlterar.Text = "Alterar";
            this.btnSAlterar.UseVisualStyleBackColor = true;
            this.btnSAlterar.Click += new System.EventHandler(this.btnSAlterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Obs.";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 123);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(270, 74);
            this.txtObs.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(591, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(278, 339);
            this.dataGridView1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Comercial";
            // 
            // txtTelefoneComercial
            // 
            this.txtTelefoneComercial.Location = new System.Drawing.Point(104, 76);
            this.txtTelefoneComercial.Name = "txtTelefoneComercial";
            this.txtTelefoneComercial.Size = new System.Drawing.Size(86, 20);
            this.txtTelefoneComercial.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Celular";
            // 
            // txtTelefoneCelular
            // 
            this.txtTelefoneCelular.Location = new System.Drawing.Point(196, 76);
            this.txtTelefoneCelular.Name = "txtTelefoneCelular";
            this.txtTelefoneCelular.Size = new System.Drawing.Size(86, 20);
            this.txtTelefoneCelular.TabIndex = 25;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefoneCelular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefoneComercial);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.pnlAlterar);
            this.Controls.Add(this.pnlIncluir);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefoneResidencial);
            this.Controls.Add(this.txtNome);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlIncluir.ResumeLayout(false);
            this.pnlAlterar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.ListBox listBox1;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label label1;
        private Windows.Forms.TextBox txtTelefoneResidencial;
        private Windows.Forms.TextBox txtNome;
        private Windows.Forms.Button btnDeletar;
        private Windows.Forms.OpenFileDialog openFileDialog1;
        private Windows.Forms.Button btnSelecionar;
        private Windows.Forms.Panel pnlIncluir;
        private Windows.Forms.Button button1;
        private Windows.Forms.Panel pnlAlterar;
        private Windows.Forms.Button btnSAlterar;
        private Windows.Forms.Button btnCancelar;
        private Windows.Forms.Label label3;
        private Windows.Forms.TextBox txtObs;
        private Windows.Forms.DataGridView dataGridView1;
        private Windows.Forms.Label label4;
        private Windows.Forms.TextBox txtTelefoneComercial;
        private Windows.Forms.Label label5;
        private Windows.Forms.TextBox txtTelefoneCelular;
    }
}