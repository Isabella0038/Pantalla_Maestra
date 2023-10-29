namespace Pantalla_Maestra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnUltimoRegistro = new System.Windows.Forms.Button();
            this.BtnSgiuienteRegistro = new System.Windows.Forms.Button();
            this.BtnAnteriorRegistro = new System.Windows.Forms.Button();
            this.BtnPrimerRegistro = new System.Windows.Forms.Button();
            this.BtnEliminarRegistro = new System.Windows.Forms.Button();
            this.BtnActualizarRegistro = new System.Windows.Forms.Button();
            this.BtnGuardarRegistro = new System.Windows.Forms.Button();
            this.BtnNuevoRegistro = new System.Windows.Forms.Button();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registrosDataSet = new Pantalla_Maestra.RegistrosDataSet();
            this.registroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroTableAdapter = new Pantalla_Maestra.RegistrosDataSetTableAdapters.RegistroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUltimoRegistro
            // 
            this.BtnUltimoRegistro.Location = new System.Drawing.Point(950, 525);
            this.BtnUltimoRegistro.Name = "BtnUltimoRegistro";
            this.BtnUltimoRegistro.Size = new System.Drawing.Size(152, 34);
            this.BtnUltimoRegistro.TabIndex = 63;
            this.BtnUltimoRegistro.Text = "Ultimo Registro";
            this.BtnUltimoRegistro.UseVisualStyleBackColor = true;
            this.BtnUltimoRegistro.Click += new System.EventHandler(this.BtnUltimoRegistr);
            // 
            // BtnSgiuienteRegistro
            // 
            this.BtnSgiuienteRegistro.Location = new System.Drawing.Point(598, 525);
            this.BtnSgiuienteRegistro.Name = "BtnSgiuienteRegistro";
            this.BtnSgiuienteRegistro.Size = new System.Drawing.Size(151, 34);
            this.BtnSgiuienteRegistro.TabIndex = 62;
            this.BtnSgiuienteRegistro.Text = "Siguiente Registro";
            this.BtnSgiuienteRegistro.UseVisualStyleBackColor = true;
            this.BtnSgiuienteRegistro.Click += new System.EventHandler(this.BtnSiguienteRegistr);
            // 
            // BtnAnteriorRegistro
            // 
            this.BtnAnteriorRegistro.Location = new System.Drawing.Point(776, 525);
            this.BtnAnteriorRegistro.Name = "BtnAnteriorRegistro";
            this.BtnAnteriorRegistro.Size = new System.Drawing.Size(140, 34);
            this.BtnAnteriorRegistro.TabIndex = 61;
            this.BtnAnteriorRegistro.Text = "Anterior Registro";
            this.BtnAnteriorRegistro.UseVisualStyleBackColor = true;
            this.BtnAnteriorRegistro.Click += new System.EventHandler(this.BtnAnteriorRegistr);
            // 
            // BtnPrimerRegistro
            // 
            this.BtnPrimerRegistro.Location = new System.Drawing.Point(442, 525);
            this.BtnPrimerRegistro.Name = "BtnPrimerRegistro";
            this.BtnPrimerRegistro.Size = new System.Drawing.Size(140, 34);
            this.BtnPrimerRegistro.TabIndex = 60;
            this.BtnPrimerRegistro.Text = "Primer Registro";
            this.BtnPrimerRegistro.UseVisualStyleBackColor = true;
            this.BtnPrimerRegistro.Click += new System.EventHandler(this.BtnPrimerRegistr);
            // 
            // BtnEliminarRegistro
            // 
            this.BtnEliminarRegistro.Location = new System.Drawing.Point(776, 53);
            this.BtnEliminarRegistro.Name = "BtnEliminarRegistro";
            this.BtnEliminarRegistro.Size = new System.Drawing.Size(140, 34);
            this.BtnEliminarRegistro.TabIndex = 59;
            this.BtnEliminarRegistro.Text = "Eliminar Registro";
            this.BtnEliminarRegistro.UseVisualStyleBackColor = true;
            this.BtnEliminarRegistro.Click += new System.EventHandler(this.BtnEliminarRegistr);
            // 
            // BtnActualizarRegistro
            // 
            this.BtnActualizarRegistro.Location = new System.Drawing.Point(944, 53);
            this.BtnActualizarRegistro.Name = "BtnActualizarRegistro";
            this.BtnActualizarRegistro.Size = new System.Drawing.Size(158, 34);
            this.BtnActualizarRegistro.TabIndex = 58;
            this.BtnActualizarRegistro.Text = "Actualizar Registro";
            this.BtnActualizarRegistro.UseVisualStyleBackColor = true;
            this.BtnActualizarRegistro.Click += new System.EventHandler(this.BtnActualizarRegistr);
            // 
            // BtnGuardarRegistro
            // 
            this.BtnGuardarRegistro.Location = new System.Drawing.Point(607, 53);
            this.BtnGuardarRegistro.Name = "BtnGuardarRegistro";
            this.BtnGuardarRegistro.Size = new System.Drawing.Size(140, 34);
            this.BtnGuardarRegistro.TabIndex = 57;
            this.BtnGuardarRegistro.Text = "Guardar Registro";
            this.BtnGuardarRegistro.UseVisualStyleBackColor = true;
            this.BtnGuardarRegistro.Click += new System.EventHandler(this.BtnGuardarRegistr);
            // 
            // BtnNuevoRegistro
            // 
            this.BtnNuevoRegistro.Location = new System.Drawing.Point(442, 53);
            this.BtnNuevoRegistro.Name = "BtnNuevoRegistro";
            this.BtnNuevoRegistro.Size = new System.Drawing.Size(140, 34);
            this.BtnNuevoRegistro.TabIndex = 56;
            this.BtnNuevoRegistro.Text = "Nuevo Registro";
            this.BtnNuevoRegistro.UseVisualStyleBackColor = true;
            this.BtnNuevoRegistro.Click += new System.EventHandler(this.BtnNuevoRegistr);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(187, 413);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(150, 26);
            this.textBoxTelefono.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = ".";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(181, 291);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(156, 26);
            this.textBoxApellido.TabIndex = 53;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(213, 357);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(124, 26);
            this.textBoxContraseña.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Contraseña :";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.BackColor = System.Drawing.Color.Transparent;
            this.Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(62, 288);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(114, 29);
            this.Apellido.TabIndex = 50;
            this.Apellido.Text = "Apellido :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(826, 379);
            this.dataGridView1.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre :";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(68, 170);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(51, 29);
            this.Nombre.TabIndex = 47;
            this.Nombre.Text = "Id : ";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(125, 174);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(212, 26);
            this.textBoxID.TabIndex = 46;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(181, 233);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(156, 26);
            this.textBoxNombre.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "Telefono :";
            // 
            // registrosDataSet
            // 
            this.registrosDataSet.DataSetName = "RegistrosDataSet";
            this.registrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroBindingSource
            // 
            this.registroBindingSource.DataMember = "Registro";
            this.registroBindingSource.DataSource = this.registrosDataSet;
            // 
            // registroTableAdapter
            // 
            this.registroTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_Maestra.Properties.Resources.verde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 606);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnUltimoRegistro);
            this.Controls.Add(this.BtnSgiuienteRegistro);
            this.Controls.Add(this.BtnAnteriorRegistro);
            this.Controls.Add(this.BtnPrimerRegistro);
            this.Controls.Add(this.BtnEliminarRegistro);
            this.Controls.Add(this.BtnActualizarRegistro);
            this.Controls.Add(this.BtnGuardarRegistro);
            this.Controls.Add(this.BtnNuevoRegistro);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxNombre);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUltimoRegistro;
        private System.Windows.Forms.Button BtnSgiuienteRegistro;
        private System.Windows.Forms.Button BtnAnteriorRegistro;
        private System.Windows.Forms.Button BtnPrimerRegistro;
        private System.Windows.Forms.Button BtnEliminarRegistro;
        private System.Windows.Forms.Button BtnActualizarRegistro;
        private System.Windows.Forms.Button BtnGuardarRegistro;
        private System.Windows.Forms.Button BtnNuevoRegistro;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label4;
        private RegistrosDataSet registrosDataSet;
        private System.Windows.Forms.BindingSource registroBindingSource;
        private RegistrosDataSetTableAdapters.RegistroTableAdapter registroTableAdapter;
    }
}

