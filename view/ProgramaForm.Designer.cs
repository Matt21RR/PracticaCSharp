namespace Actividad.view
{
    partial class ProgramaForm
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
            label5 = new Label();
            label2 = new Label();
            nombreInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            crearPrograma = new Button();
            registroDate = new DateTimePicker();
            duracionInput = new NumericUpDown();
            facultadCombo = new ComboBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)duracionInput).BeginInit();
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
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(nombreInput, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(crearPrograma, 2, 4);
            tableLayoutPanel1.Controls.Add(registroDate, 2, 1);
            tableLayoutPanel1.Controls.Add(duracionInput, 1, 1);
            tableLayoutPanel1.Controls.Add(facultadCombo, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 37);
            tableLayoutPanel1.MinimumSize = new Size(600, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(802, 167);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 59);
            label5.Margin = new Padding(3, 15, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(261, 15);
            label5.TabIndex = 14;
            label5.Text = "Facultad";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(261, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombreInput
            // 
            nombreInput.Dock = DockStyle.Fill;
            nombreInput.Location = new Point(3, 18);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(261, 23);
            nombreInput.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(270, 0);
            label3.Name = "label3";
            label3.Size = new Size(261, 15);
            label3.TabIndex = 4;
            label3.Text = "Duracion";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(537, 0);
            label4.Name = "label4";
            label4.Size = new Size(262, 15);
            label4.TabIndex = 4;
            label4.Text = "Registro";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // crearPrograma
            // 
            crearPrograma.Dock = DockStyle.Fill;
            crearPrograma.Location = new Point(537, 123);
            crearPrograma.Margin = new Padding(3, 20, 3, 3);
            crearPrograma.Name = "crearPrograma";
            crearPrograma.Size = new Size(262, 41);
            crearPrograma.TabIndex = 5;
            crearPrograma.Text = "Crear programa";
            crearPrograma.UseVisualStyleBackColor = true;
            crearPrograma.Click += crearPrograma_Click;
            // 
            // registroDate
            // 
            registroDate.Dock = DockStyle.Fill;
            registroDate.Location = new Point(537, 18);
            registroDate.Name = "registroDate";
            registroDate.Size = new Size(262, 23);
            registroDate.TabIndex = 9;
            // 
            // duracionInput
            // 
            duracionInput.Location = new Point(270, 18);
            duracionInput.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            duracionInput.Name = "duracionInput";
            duracionInput.Size = new Size(261, 23);
            duracionInput.TabIndex = 12;
            // 
            // facultadCombo
            // 
            facultadCombo.Dock = DockStyle.Fill;
            facultadCombo.FormattingEnabled = true;
            facultadCombo.Location = new Point(3, 77);
            facultadCombo.Name = "facultadCombo";
            facultadCombo.Size = new Size(261, 23);
            facultadCombo.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 6;
            label1.Text = "Programa";
            // 
            // ProgramaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "ProgramaForm";
            Size = new Size(802, 397);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)duracionInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button crearPrograma;
        private TextBox tipoContratoInput;
        private Label label7;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox facultadCombo;
        private TextBox nombreInput;
        private DateTimePicker registroDate;
        private NumericUpDown duracionInput;
    }
}
