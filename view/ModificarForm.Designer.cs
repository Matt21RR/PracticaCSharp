namespace Actividad.view
{
    partial class ModificarForm
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
            tipoCombo = new ComboBox();
            eliminarButton = new Button();
            label2 = new Label();
            label3 = new Label();
            editarElementos = new Button();
            elementoCombo = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(tipoCombo, 0, 1);
            tableLayoutPanel1.Controls.Add(eliminarButton, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(editarElementos, 2, 2);
            tableLayoutPanel1.Controls.Add(elementoCombo, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 75);
            tableLayoutPanel1.MinimumSize = new Size(600, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(968, 150);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tipoCombo
            // 
            tipoCombo.Dock = DockStyle.Fill;
            tipoCombo.FormattingEnabled = true;
            tipoCombo.Items.AddRange(new object[] { "Facultad", "Programa", "Persona", "Estudiante", "Profesor", "Curso", "Inscripcion", "Curso con profesor" });
            tipoCombo.Location = new Point(3, 18);
            tipoCombo.Margin = new Padding(3, 3, 20, 3);
            tipoCombo.MinimumSize = new Size(100, 0);
            tipoCombo.Name = "tipoCombo";
            tipoCombo.Size = new Size(299, 23);
            tipoCombo.TabIndex = 10;
            tipoCombo.Text = "Facultad";
            tipoCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // eliminarButton
            // 
            eliminarButton.BackColor = Color.FromArgb(255, 192, 192);
            eliminarButton.Dock = DockStyle.Top;
            eliminarButton.Location = new Point(325, 64);
            eliminarButton.Margin = new Padding(3, 20, 3, 3);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(316, 50);
            eliminarButton.TabIndex = 6;
            eliminarButton.Text = "❌ Eliminar elemento";
            eliminarButton.UseVisualStyleBackColor = false;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(316, 15);
            label2.TabIndex = 4;
            label2.Text = "Tipo";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(325, 0);
            label3.Name = "label3";
            label3.Size = new Size(316, 15);
            label3.TabIndex = 4;
            label3.Text = "Elemento";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editarElementos
            // 
            editarElementos.Dock = DockStyle.Top;
            editarElementos.Location = new Point(647, 64);
            editarElementos.Margin = new Padding(3, 20, 3, 3);
            editarElementos.Name = "editarElementos";
            editarElementos.Size = new Size(318, 50);
            editarElementos.TabIndex = 5;
            editarElementos.Text = "Editar elemento";
            editarElementos.UseVisualStyleBackColor = true;
            editarElementos.Click += guardarElementos_Click;
            // 
            // elementoCombo
            // 
            tableLayoutPanel1.SetColumnSpan(elementoCombo, 2);
            elementoCombo.Dock = DockStyle.Fill;
            elementoCombo.FormattingEnabled = true;
            elementoCombo.Location = new Point(325, 18);
            elementoCombo.Name = "elementoCombo";
            elementoCombo.Size = new Size(640, 23);
            elementoCombo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 37);
            label1.TabIndex = 6;
            label1.Text = "Modificar elemento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 47);
            label5.Margin = new Padding(3, 10, 3, 10);
            label5.Name = "label5";
            label5.Size = new Size(442, 15);
            label5.TabIndex = 8;
            label5.Text = "Selecciona el tipo que deseas modificar, despues selecciona el elemento particular.";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(974, 483);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // Modificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "Modificar";
            Size = new Size(974, 483);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Button editarElementos;
        private Label label1;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Button eliminarButton;
        private ComboBox elementoCombo;
        private ComboBox tipoCombo;
    }
}
