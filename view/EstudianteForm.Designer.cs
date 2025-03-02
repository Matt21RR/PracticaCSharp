namespace Actividad.view
{
    partial class EstudianteForm
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label2 = new Label();
            apellidoInput = new TextBox();
            nombreInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            correoElectronicoInput = new TextBox();
            guardarEstudiante = new Button();
            label7 = new Label();
            programaCombo = new ComboBox();
            activoCheckBox = new CheckBox();
            promedioInput = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)promedioInput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 37);
            label1.TabIndex = 0;
            label1.Text = "Estudiante";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(apellidoInput, 1, 1);
            tableLayoutPanel1.Controls.Add(nombreInput, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(correoElectronicoInput, 2, 1);
            tableLayoutPanel1.Controls.Add(guardarEstudiante, 2, 6);
            tableLayoutPanel1.Controls.Add(label7, 1, 3);
            tableLayoutPanel1.Controls.Add(programaCombo, 0, 4);
            tableLayoutPanel1.Controls.Add(activoCheckBox, 2, 2);
            tableLayoutPanel1.Controls.Add(promedioInput, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 37);
            tableLayoutPanel1.MinimumSize = new Size(600, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(955, 177);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 54);
            label5.Margin = new Padding(3, 10, 3, 5);
            label5.Name = "label5";
            label5.Size = new Size(312, 15);
            label5.TabIndex = 5;
            label5.Text = "Programa";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(312, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // apellidoInput
            // 
            apellidoInput.Dock = DockStyle.Fill;
            apellidoInput.Location = new Point(321, 18);
            apellidoInput.Name = "apellidoInput";
            apellidoInput.Size = new Size(312, 23);
            apellidoInput.TabIndex = 1;
            // 
            // nombreInput
            // 
            nombreInput.Dock = DockStyle.Fill;
            nombreInput.Location = new Point(3, 18);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(312, 23);
            nombreInput.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(321, 0);
            label3.Name = "label3";
            label3.Size = new Size(312, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(639, 0);
            label4.Name = "label4";
            label4.Size = new Size(313, 15);
            label4.TabIndex = 4;
            label4.Text = "Correo Electronico";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // correoElectronicoInput
            // 
            correoElectronicoInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            correoElectronicoInput.Location = new Point(639, 18);
            correoElectronicoInput.Name = "correoElectronicoInput";
            correoElectronicoInput.Size = new Size(313, 23);
            correoElectronicoInput.TabIndex = 1;
            // 
            // guardarEstudiante
            // 
            guardarEstudiante.Dock = DockStyle.Top;
            guardarEstudiante.Location = new Point(639, 133);
            guardarEstudiante.Margin = new Padding(3, 30, 3, 3);
            guardarEstudiante.MaximumSize = new Size(0, 50);
            guardarEstudiante.Name = "guardarEstudiante";
            guardarEstudiante.Size = new Size(313, 41);
            guardarEstudiante.TabIndex = 5;
            guardarEstudiante.Text = "Guardar estudiante";
            guardarEstudiante.UseVisualStyleBackColor = true;
            guardarEstudiante.Click += guardarEstudiante_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(321, 54);
            label7.Margin = new Padding(3, 10, 3, 5);
            label7.Name = "label7";
            label7.Size = new Size(312, 15);
            label7.TabIndex = 5;
            label7.Text = "Promedio";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // programaCombo
            // 
            programaCombo.Dock = DockStyle.Fill;
            programaCombo.FormattingEnabled = true;
            programaCombo.Location = new Point(3, 77);
            programaCombo.Name = "programaCombo";
            programaCombo.Size = new Size(312, 23);
            programaCombo.TabIndex = 9;
            // 
            // activoCheckBox
            // 
            activoCheckBox.AutoSize = true;
            activoCheckBox.Dock = DockStyle.Fill;
            activoCheckBox.Location = new Point(639, 47);
            activoCheckBox.Name = "activoCheckBox";
            tableLayoutPanel1.SetRowSpan(activoCheckBox, 3);
            activoCheckBox.Size = new Size(313, 53);
            activoCheckBox.TabIndex = 10;
            activoCheckBox.Text = "Esta activo";
            activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // promedioInput
            // 
            promedioInput.DecimalPlaces = 2;
            promedioInput.Dock = DockStyle.Fill;
            promedioInput.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            promedioInput.Location = new Point(321, 77);
            promedioInput.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            promedioInput.Name = "promedioInput";
            promedioInput.Size = new Size(312, 23);
            promedioInput.TabIndex = 11;
            // 
            // EstudianteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "EstudianteForm";
            Size = new Size(955, 498);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)promedioInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox nombreInput;
        private TextBox apellidoInput;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox correoElectronicoInput;
        private Button guardarEstudiante;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox checkBox1;
        private ComboBox programaCombo;
        private CheckBox activoCheckBox;
        private NumericUpDown promedioInput;
    }
}
