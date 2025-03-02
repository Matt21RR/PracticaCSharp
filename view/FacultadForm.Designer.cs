namespace Actividad.view
{
    partial class FacultadForm
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
            nombreInput = new TextBox();
            label3 = new Label();
            guardarFacultad = new Button();
            decanoCombo = new ComboBox();
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
            tableLayoutPanel1.Controls.Add(nombreInput, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(guardarFacultad, 2, 2);
            tableLayoutPanel1.Controls.Add(decanoCombo, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 37);
            tableLayoutPanel1.MinimumSize = new Size(600, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(894, 150);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(291, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombreInput
            // 
            nombreInput.Dock = DockStyle.Fill;
            nombreInput.Location = new Point(3, 18);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(291, 23);
            nombreInput.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(300, 0);
            label3.Name = "label3";
            label3.Size = new Size(292, 15);
            label3.TabIndex = 4;
            label3.Text = "Decano";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guardarFacultad
            // 
            guardarFacultad.Dock = DockStyle.Top;
            guardarFacultad.Location = new Point(598, 54);
            guardarFacultad.Margin = new Padding(3, 10, 3, 3);
            guardarFacultad.MaximumSize = new Size(0, 50);
            guardarFacultad.Name = "guardarFacultad";
            guardarFacultad.Size = new Size(293, 50);
            guardarFacultad.TabIndex = 5;
            guardarFacultad.Text = "Guardar facultad";
            guardarFacultad.UseVisualStyleBackColor = true;
            // 
            // decanoCombo
            // 
            decanoCombo.Dock = DockStyle.Fill;
            decanoCombo.FormattingEnabled = true;
            decanoCombo.Location = new Point(300, 18);
            decanoCombo.Name = "decanoCombo";
            decanoCombo.Size = new Size(292, 23);
            decanoCombo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 37);
            label1.TabIndex = 6;
            label1.Text = "Facultad";
            // 
            // FacultadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "FacultadForm";
            Size = new Size(894, 597);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox nombreInput;
        private Label label3;
        private Button guardarFacultad;
        private ComboBox decanoCombo;
        private Label label1;
    }
}
