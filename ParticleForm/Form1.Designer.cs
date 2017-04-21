namespace ParticleForm
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.charge = new System.Windows.Forms.NumericUpDown();
            this.spin = new System.Windows.Forms.NumericUpDown();
            this.type = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.mass = new System.Windows.Forms.NumericUpDown();
            this.Add = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.ReadmeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(45, 37);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(264, 20);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Charge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Spin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Please enter particle information in Hartree atomic units.";
            // 
            // charge
            // 
            this.charge.Location = new System.Drawing.Point(45, 66);
            this.charge.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(86, 20);
            this.charge.TabIndex = 9;
            // 
            // spin
            // 
            this.spin.DecimalPlaces = 1;
            this.spin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.spin.Location = new System.Drawing.Point(188, 94);
            this.spin.Name = "spin";
            this.spin.Size = new System.Drawing.Size(72, 20);
            this.spin.TabIndex = 10;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "fermion",
            "boson"});
            this.type.Location = new System.Drawing.Point(188, 65);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.TabIndex = 12;
            this.type.Text = "fermion";
            this.type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(151, 68);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 13;
            this.typeLabel.Text = "Type";
            // 
            // mass
            // 
            this.mass.DecimalPlaces = 4;
            this.mass.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mass.Location = new System.Drawing.Point(45, 94);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(85, 20);
            this.mass.TabIndex = 14;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(7, 120);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(7, 149);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(418, 231);
            this.GridView.TabIndex = 16;
            // 
            // ReadmeButton
            // 
            this.ReadmeButton.Location = new System.Drawing.Point(234, 120);
            this.ReadmeButton.Name = "ReadmeButton";
            this.ReadmeButton.Size = new System.Drawing.Size(75, 23);
            this.ReadmeButton.TabIndex = 17;
            this.ReadmeButton.Text = "README";
            this.ReadmeButton.UseVisualStyleBackColor = true;
            this.ReadmeButton.Click += new System.EventHandler(this.ReadmeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 393);
            this.Controls.Add(this.ReadmeButton);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.type);
            this.Controls.Add(this.spin);
            this.Controls.Add(this.charge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Particle Information";
            ((System.ComponentModel.ISupportInitialize)(this.charge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown charge;
        private System.Windows.Forms.NumericUpDown spin;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.NumericUpDown mass;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button ReadmeButton;
    }
}

