namespace Actividad.view
{
    partial class CursoForm
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
            label2 = new Label();
            nombreInput = new TextBox();
            label3 = new Label();
            guardarCurso = new Button();
            programaCombo = new ComboBox();
            programaBindingSource = new BindingSource(components);
            activoCheckBox = new CheckBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)programaBindingSource).BeginInit();
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
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(nombreInput, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(guardarCurso, 2, 2);
            tableLayoutPanel1.Controls.Add(programaCombo, 1, 1);
            tableLayoutPanel1.Controls.Add(activoCheckBox, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 37);
            tableLayoutPanel1.MinimumSize = new Size(600, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(913, 150);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(298, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombreInput
            // 
            nombreInput.Dock = DockStyle.Fill;
            nombreInput.Location = new Point(3, 18);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(298, 23);
            nombreInput.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(307, 0);
            label3.Name = "label3";
            label3.Size = new Size(298, 15);
            label3.TabIndex = 4;
            label3.Text = "Programa";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guardarCurso
            // 
            guardarCurso.Dock = DockStyle.Top;
            guardarCurso.Location = new Point(611, 64);
            guardarCurso.Margin = new Padding(3, 20, 3, 3);
            guardarCurso.MaximumSize = new Size(0, 50);
            guardarCurso.Name = "guardarCurso";
            guardarCurso.Size = new Size(299, 40);
            guardarCurso.TabIndex = 5;
            guardarCurso.Text = "Guardar curso";
            guardarCurso.UseVisualStyleBackColor = true;
            guardarCurso.Click += guardarCurso_Click;
            // 
            // programaCombo
            // 
            programaCombo.DataSource = programaBindingSource;
            programaCombo.Dock = DockStyle.Fill;
            programaCombo.FormattingEnabled = true;
            programaCombo.Location = new Point(307, 18);
            programaCombo.Name = "programaCombo";
            programaCombo.Size = new Size(298, 23);
            programaCombo.TabIndex = 13;
            // 
            // programaBindingSource
            // 
            programaBindingSource.DataSource = typeof(Programa);
            // 
            // activoCheckBox
            // 
            activoCheckBox.AutoSize = true;
            activoCheckBox.Dock = DockStyle.Fill;
            activoCheckBox.Location = new Point(611, 3);
            activoCheckBox.Name = "activoCheckBox";
            tableLayoutPanel1.SetRowSpan(activoCheckBox, 2);
            activoCheckBox.Size = new Size(299, 38);
            activoCheckBox.TabIndex = 14;
            activoCheckBox.Text = "Esta activo";
            activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 8;
            label1.Text = "Curso";
            // 
            // CursoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "CursoForm";
            Size = new Size(913, 444);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)programaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label2;
        private TextBox nombreInput;
        private Label label3;
        private Label label4;
        private DateTimePicker registroDate;
        private ComboBox programaCombo;
        private BindingSource programaBindingSource;
        private Label label1;
        private CheckBox activoCheckBox;
        private Button guardarCurso;
    }
}
