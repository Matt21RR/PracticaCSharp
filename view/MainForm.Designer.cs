namespace Actividad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nuevaClaseCombo = new ComboBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            button2 = new Button();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // nuevaClaseCombo
            // 
            nuevaClaseCombo.Dock = DockStyle.Fill;
            nuevaClaseCombo.FormattingEnabled = true;
            nuevaClaseCombo.Items.AddRange(new object[] { "Facultad", "Programa", "Persona", "Estudiante", "Profesor", "Curso", "Inscripcion", "Curso con profesor" });
            nuevaClaseCombo.Location = new Point(98, 461);
            nuevaClaseCombo.MinimumSize = new Size(100, 0);
            nuevaClaseCombo.Name = "nuevaClaseCombo";
            nuevaClaseCombo.Size = new Size(663, 23);
            nuevaClaseCombo.TabIndex = 0;
            nuevaClaseCombo.Text = "Facultad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 458);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 1;
            label1.Text = "Nueva Pestaña:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(767, 461);
            button1.Name = "button1";
            button1.Size = new Size(89, 24);
            button1.TabIndex = 2;
            button1.Text = "Agregar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 1);
            tableLayoutPanel1.Controls.Add(nuevaClaseCombo, 1, 1);
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 4, 1);
            tableLayoutPanel1.Controls.Add(label2, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(500, 300);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(972, 488);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            tableLayoutPanel1.SetColumnSpan(tabControl1, 5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(966, 452);
            tabControl1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(878, 461);
            button2.Name = "button2";
            button2.Size = new Size(91, 24);
            button2.TabIndex = 5;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(862, 458);
            label2.Name = "label2";
            label2.Size = new Size(10, 30);
            label2.TabIndex = 6;
            label2.Text = "|";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 488);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(600, 500);
            Name = "Form1";
            ShowIcon = false;
            Text = "Actividad";
            FormClosing += Form1_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox nuevaClaseCombo;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private Button button2;
        private Label label2;
    }
}
