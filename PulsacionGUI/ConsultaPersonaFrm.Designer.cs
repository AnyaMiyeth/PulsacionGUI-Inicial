namespace PulsacionGUI
{
    partial class ConsultaPersonaFrm
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
            this.DtgPersona = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalHombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTotalMujeres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgPersona
            // 
            this.DtgPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPersona.Location = new System.Drawing.Point(37, 118);
            this.DtgPersona.Name = "DtgPersona";
            this.DtgPersona.RowHeadersWidth = 102;
            this.DtgPersona.RowTemplate.Height = 40;
            this.DtgPersona.Size = new System.Drawing.Size(1265, 454);
            this.DtgPersona.TabIndex = 0;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(1043, 29);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(300, 61);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "F",
            "M",
            "Todos"});
            this.CmbFiltro.Location = new System.Drawing.Point(187, 51);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(353, 39);
            this.CmbFiltro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 689);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Personas";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(315, 689);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 38);
            this.TxtTotal.TabIndex = 4;
            // 
            // txtTotalHombres
            // 
            this.txtTotalHombres.Location = new System.Drawing.Point(751, 689);
            this.txtTotalHombres.Name = "txtTotalHombres";
            this.txtTotalHombres.Size = new System.Drawing.Size(100, 38);
            this.txtTotalHombres.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Hombres";
            // 
            // TxtTotalMujeres
            // 
            this.TxtTotalMujeres.Location = new System.Drawing.Point(1187, 689);
            this.TxtTotalMujeres.Name = "TxtTotalMujeres";
            this.TxtTotalMujeres.Size = new System.Drawing.Size(100, 38);
            this.TxtTotalMujeres.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(962, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Mujeres";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(1483, 197);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(294, 38);
            this.TxtFiltro.TabIndex = 9;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.a);
            this.TxtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFiltro_KeyPress);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(1496, 265);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(300, 61);
            this.BtnFiltrar.TabIndex = 10;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // ConsultaPersonaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 887);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.TxtTotalMujeres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalHombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DtgPersona);
            this.Name = "ConsultaPersonaFrm";
            this.Text = "ConsultaPersonaFrm";
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgPersona;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox txtTotalHombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTotalMujeres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Button BtnFiltrar;
    }
}