namespace Actividad.view
{
    partial class PersonaForm
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
            crearPersona = new Button();
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
            tableLayoutPanel1.Controls.Add(crearPersona, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 37);
            tableLayoutPanel1.MinimumSize = new Size(600, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(970, 156);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(317, 51);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // apellidoInput
            // 
            apellidoInput.Dock = DockStyle.Fill;
            apellidoInput.Location = new Point(326, 54);
            apellidoInput.Name = "apellidoInput";
            apellidoInput.Size = new Size(317, 23);
            apellidoInput.TabIndex = 1;
            // 
            // nombreInput
            // 
            nombreInput.Dock = DockStyle.Fill;
            nombreInput.Location = new Point(3, 54);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(317, 23);
            nombreInput.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(326, 0);
            label3.Name = "label3";
            label3.Size = new Size(317, 51);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(649, 0);
            label4.Name = "label4";
            label4.Size = new Size(318, 51);
            label4.TabIndex = 4;
            label4.Text = "Correo Electronico";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // correoElectronicoInput
            // 
            correoElectronicoInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            correoElectronicoInput.Location = new Point(649, 54);
            correoElectronicoInput.Name = "correoElectronicoInput";
            correoElectronicoInput.Size = new Size(318, 23);
            correoElectronicoInput.TabIndex = 1;
            // 
            // crearPersona
            // 
            crearPersona.Dock = DockStyle.Fill;
            crearPersona.Location = new Point(649, 106);
            crearPersona.Name = "crearPersona";
            crearPersona.Size = new Size(318, 47);
            crearPersona.TabIndex = 5;
            crearPersona.Text = "Crear";
            crearPersona.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 4;
            label1.Text = "Persona";
            // 
            // PersonaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "PersonaForm";
            Size = new Size(970, 645);
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
        private Button crearPersona;
        private Label label1;
    }
}
