namespace Actividad.view
{
    partial class ProfesorForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            apellidoInput = new TextBox();
            nombreInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            correoElectronicoInput = new TextBox();
            guardarProfesor = new Button();
            tipoContratoInput = new TextBox();
            label7 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(apellidoInput, 1, 1);
            tableLayoutPanel1.Controls.Add(nombreInput, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(correoElectronicoInput, 2, 1);
            tableLayoutPanel1.Controls.Add(guardarProfesor, 2, 5);
            tableLayoutPanel1.Controls.Add(tipoContratoInput, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 37);
            tableLayoutPanel1.MinimumSize = new Size(600, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(875, 150);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(285, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // apellidoInput
            // 
            apellidoInput.Dock = DockStyle.Fill;
            apellidoInput.Location = new Point(294, 18);
            apellidoInput.Name = "apellidoInput";
            apellidoInput.Size = new Size(285, 23);
            apellidoInput.TabIndex = 1;
            // 
            // nombreInput
            // 
            nombreInput.Dock = DockStyle.Fill;
            nombreInput.Location = new Point(3, 18);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(285, 23);
            nombreInput.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(294, 0);
            label3.Name = "label3";
            label3.Size = new Size(285, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(585, 0);
            label4.Name = "label4";
            label4.Size = new Size(287, 15);
            label4.TabIndex = 4;
            label4.Text = "Correo Electronico";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // correoElectronicoInput
            // 
            correoElectronicoInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            correoElectronicoInput.Location = new Point(585, 18);
            correoElectronicoInput.Name = "correoElectronicoInput";
            correoElectronicoInput.Size = new Size(287, 23);
            correoElectronicoInput.TabIndex = 1;
            // 
            // guardarProfesor
            // 
            guardarProfesor.Dock = DockStyle.Fill;
            guardarProfesor.Location = new Point(585, 106);
            guardarProfesor.Name = "guardarProfesor";
            guardarProfesor.Size = new Size(287, 41);
            guardarProfesor.TabIndex = 5;
            guardarProfesor.Text = "Guardar profesor";
            guardarProfesor.UseVisualStyleBackColor = true;
            // 
            // tipoContratoInput
            // 
            tipoContratoInput.Dock = DockStyle.Fill;
            tipoContratoInput.Location = new Point(3, 77);
            tipoContratoInput.Name = "tipoContratoInput";
            tipoContratoInput.Size = new Size(285, 23);
            tipoContratoInput.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 59);
            label7.Margin = new Padding(3, 15, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(285, 15);
            label7.TabIndex = 5;
            label7.Text = "Tipo de Contrato";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 37);
            label1.TabIndex = 4;
            label1.Text = "Profesor";
            // 
            // ProfesorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "ProfesorForm";
            Size = new Size(875, 375);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox apellidoInput;
        private TextBox nombreInput;
        private Label label3;
        private Label label4;
        private TextBox correoElectronicoInput;
        private Button guardarProfesor;
        private TextBox tipoContratoInput;
        private Label label7;
        private Label label1;
    }
}
