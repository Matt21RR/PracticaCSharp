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
            comboBox1 = new ComboBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            numericUpDown1 = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            splitContainer1 = new SplitContainer();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Facultad", "Programa", "Persona", "Estudiante", "Profesor", "Curso", "Inscripcion", "Curso con profesor" });
            comboBox1.Location = new Point(65, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(661, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Facultad";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Nuevo/a:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(732, 3);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 2;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(915, 499);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(907, 471);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(234, 251);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(915, 38);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(915, 538);
            splitContainer1.SplitterDistance = 499;
            splitContainer1.SplitterIncrement = 2;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 538);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Actividad";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private FlowLayoutPanel flowLayoutPanel1;
        private SplitContainer splitContainer1;
        private NumericUpDown numericUpDown1;
    }
}
