namespace Actividad.view
{
    partial class CursoProfesorForm
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            profesorCombo = new ComboBox();
            label5 = new Label();
            semestreInput = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            guardarCursoProfesor = new Button();
            cursoCombo = new ComboBox();
            anioInput = new NumericUpDown();
            programaBindingSource = new BindingSource(components);
            label1 = new Label();
            programaBindingSource1 = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)semestreInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)anioInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)programaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)programaBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(profesorCombo, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(semestreInput, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(guardarCursoProfesor, 2, 4);
            tableLayoutPanel1.Controls.Add(cursoCombo, 0, 1);
            tableLayoutPanel1.Controls.Add(anioInput, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 37);
            tableLayoutPanel1.MinimumSize = new Size(600, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(754, 150);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // profesorCombo
            // 
            profesorCombo.Dock = DockStyle.Fill;
            profesorCombo.FormattingEnabled = true;
            profesorCombo.Location = new Point(3, 72);
            profesorCombo.Name = "profesorCombo";
            profesorCombo.Size = new Size(245, 23);
            profesorCombo.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 54);
            label5.Margin = new Padding(3, 10, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(245, 15);
            label5.TabIndex = 19;
            label5.Text = "Profesor";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // semestreInput
            // 
            semestreInput.Dock = DockStyle.Fill;
            semestreInput.Location = new Point(505, 18);
            semestreInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            semestreInput.Name = "semestreInput";
            semestreInput.Size = new Size(246, 23);
            semestreInput.TabIndex = 18;
            semestreInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(505, 0);
            label4.Name = "label4";
            label4.Size = new Size(246, 15);
            label4.TabIndex = 17;
            label4.Text = "Semestre";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(245, 15);
            label2.TabIndex = 4;
            label2.Text = "Curso";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(254, 0);
            label3.Name = "label3";
            label3.Size = new Size(245, 15);
            label3.TabIndex = 4;
            label3.Text = "Año";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guardarCursoProfesor
            // 
            guardarCursoProfesor.Dock = DockStyle.Top;
            guardarCursoProfesor.Location = new Point(505, 118);
            guardarCursoProfesor.Margin = new Padding(3, 20, 3, 3);
            guardarCursoProfesor.MaximumSize = new Size(0, 50);
            guardarCursoProfesor.Name = "guardarCursoProfesor";
            guardarCursoProfesor.Size = new Size(246, 29);
            guardarCursoProfesor.TabIndex = 5;
            guardarCursoProfesor.Text = "Guardar curso del profesor";
            guardarCursoProfesor.UseVisualStyleBackColor = true;
            guardarCursoProfesor.Click += guardarCursoProfesor_Click;
            // 
            // cursoCombo
            // 
            cursoCombo.Dock = DockStyle.Fill;
            cursoCombo.FormattingEnabled = true;
            cursoCombo.Location = new Point(3, 18);
            cursoCombo.Name = "cursoCombo";
            cursoCombo.Size = new Size(245, 23);
            cursoCombo.TabIndex = 15;
            // 
            // anioInput
            // 
            anioInput.Dock = DockStyle.Fill;
            anioInput.Location = new Point(254, 18);
            anioInput.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            anioInput.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            anioInput.Name = "anioInput";
            anioInput.Size = new Size(245, 23);
            anioInput.TabIndex = 16;
            anioInput.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // programaBindingSource
            // 
            programaBindingSource.DataSource = typeof(Programa);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 37);
            label1.TabIndex = 12;
            label1.Text = "Curso del Profesor";
            // 
            // programaBindingSource1
            // 
            programaBindingSource1.DataSource = typeof(Programa);
            // 
            // CursoProfesorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "CursoProfesorForm";
            Size = new Size(754, 285);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)semestreInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)anioInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)programaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)programaBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox profesorCombo;
        private Label label5;
        private NumericUpDown semestreInput;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button guardarCursoProfesor;
        private ComboBox cursoCombo;
        private NumericUpDown anioInput;
        private BindingSource programaBindingSource;
        private Label label1;
        private BindingSource programaBindingSource1;
    }
}
