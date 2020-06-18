namespace RegistroEstudianteForms
{
    public sealed partial  class FrmListadoEstudiantes
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
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.LboxEstudiantes = new System.Windows.Forms.ListBox();
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.TlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.TlpPrincipal.SuspendLayout();
            this.TlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 3;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.31266F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.95349F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.73385F));
            this.TlpPrincipal.Controls.Add(this.LboxEstudiantes, 1, 1);
            this.TlpPrincipal.Controls.Add(this.BtnAddStudent, 1, 0);
            this.TlpPrincipal.Controls.Add(this.TlpBotones, 1, 2);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 3;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20067F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.39465F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.23746F));
            this.TlpPrincipal.Size = new System.Drawing.Size(774, 643);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // LboxEstudiantes
            // 
            this.LboxEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LboxEstudiantes.FormattingEnabled = true;
            this.LboxEstudiantes.Location = new System.Drawing.Point(136, 68);
            this.LboxEstudiantes.Name = "LboxEstudiantes";
            this.LboxEstudiantes.Size = new System.Drawing.Size(489, 434);
            this.LboxEstudiantes.TabIndex = 0;
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddStudent.Location = new System.Drawing.Point(454, 24);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(171, 38);
            this.BtnAddStudent.TabIndex = 1;
            this.BtnAddStudent.Text = "+ Agregar nuevo estudiante";
            this.BtnAddStudent.UseVisualStyleBackColor = true;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // TlpBotones
            // 
            this.TlpBotones.ColumnCount = 2;
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.Controls.Add(this.BtnEditar, 0, 0);
            this.TlpBotones.Controls.Add(this.BtnBorrar, 1, 0);
            this.TlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpBotones.Location = new System.Drawing.Point(136, 508);
            this.TlpBotones.Name = "TlpBotones";
            this.TlpBotones.RowCount = 1;
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.Size = new System.Drawing.Size(489, 132);
            this.TlpBotones.TabIndex = 2;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEditar.Location = new System.Drawing.Point(3, 3);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(238, 37);
            this.BtnEditar.TabIndex = 0;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBorrar.Location = new System.Drawing.Point(247, 3);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(239, 37);
            this.BtnBorrar.TabIndex = 1;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // FrmListadoEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 643);
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "FrmListadoEstudiantes";
            this.Text = "Listado de estudiantes";
            this.Load += new System.EventHandler(this.FrmListadoEstudiantes_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmListadoEstudiantes_VisibleChanged);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.ListBox LboxEstudiantes;
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.TableLayoutPanel TlpBotones;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnBorrar;
    }
}

