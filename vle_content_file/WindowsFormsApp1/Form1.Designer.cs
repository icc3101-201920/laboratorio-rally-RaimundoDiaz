namespace VistasRally
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
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarPilotoButton = new System.Windows.Forms.Button();
            this.PilotNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgregarNaveganteButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NaveganteCB = new System.Windows.Forms.ComboBox();
            this.PilotoCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TeamNameComboBox = new System.Windows.Forms.ComboBox();
            this.AgregarEquipoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a Rally Manager";
            // 
            // AgregarPilotoButton
            // 
            this.AgregarPilotoButton.Location = new System.Drawing.Point(157, 180);
            this.AgregarPilotoButton.Name = "AgregarPilotoButton";
            this.AgregarPilotoButton.Size = new System.Drawing.Size(124, 23);
            this.AgregarPilotoButton.TabIndex = 1;
            this.AgregarPilotoButton.Text = "Agregar Piloto";
            this.AgregarPilotoButton.UseVisualStyleBackColor = true;
            this.AgregarPilotoButton.Click += new System.EventHandler(this.AgregarPilotoButton_Click);
            // 
            // PilotNameComboBox
            // 
            this.PilotNameComboBox.FormattingEnabled = true;
            this.PilotNameComboBox.Location = new System.Drawing.Point(157, 107);
            this.PilotNameComboBox.Name = "PilotNameComboBox";
            this.PilotNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PilotNameComboBox.Size = new System.Drawing.Size(449, 21);
            this.PilotNameComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(243, 154);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(363, 20);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AgregarNaveganteButton
            // 
            this.AgregarNaveganteButton.Location = new System.Drawing.Point(287, 180);
            this.AgregarNaveganteButton.Name = "AgregarNaveganteButton";
            this.AgregarNaveganteButton.Size = new System.Drawing.Size(124, 23);
            this.AgregarNaveganteButton.TabIndex = 8;
            this.AgregarNaveganteButton.Text = "Agregar Navegante";
            this.AgregarNaveganteButton.UseVisualStyleBackColor = true;
            this.AgregarNaveganteButton.Click += new System.EventHandler(this.btnasd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 386);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PilotNameComboBox);
            this.tabPage1.Controls.Add(this.AgregarNaveganteButton);
            this.tabPage1.Controls.Add(this.AgregarPilotoButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.NameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 360);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Persona";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NaveganteCB);
            this.tabPage2.Controls.Add(this.PilotoCB);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbCC);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbBrand);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TeamNameComboBox);
            this.tabPage2.Controls.Add(this.AgregarEquipoButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 360);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Equipo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NaveganteCB
            // 
            this.NaveganteCB.FormattingEnabled = true;
            this.NaveganteCB.Location = new System.Drawing.Point(378, 192);
            this.NaveganteCB.Name = "NaveganteCB";
            this.NaveganteCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NaveganteCB.Size = new System.Drawing.Size(212, 21);
            this.NaveganteCB.TabIndex = 19;
            this.NaveganteCB.Text = "Navegante";
            // 
            // PilotoCB
            // 
            this.PilotoCB.FormattingEnabled = true;
            this.PilotoCB.Location = new System.Drawing.Point(160, 192);
            this.PilotoCB.Name = "PilotoCB";
            this.PilotoCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PilotoCB.Size = new System.Drawing.Size(212, 21);
            this.PilotoCB.TabIndex = 18;
            this.PilotoCB.Text = "Piloto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cilindrada";
            // 
            // tbCC
            // 
            this.tbCC.Location = new System.Drawing.Point(437, 166);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(91, 20);
            this.tbCC.TabIndex = 16;
            this.tbCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Marca";
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(276, 166);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(91, 20);
            this.tbBrand.TabIndex = 14;
            this.tbBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vehiculo";
            // 
            // TeamNameComboBox
            // 
            this.TeamNameComboBox.FormattingEnabled = true;
            this.TeamNameComboBox.Location = new System.Drawing.Point(147, 88);
            this.TeamNameComboBox.Name = "TeamNameComboBox";
            this.TeamNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TeamNameComboBox.Size = new System.Drawing.Size(449, 21);
            this.TeamNameComboBox.TabIndex = 10;
            // 
            // AgregarEquipoButton
            // 
            this.AgregarEquipoButton.Location = new System.Drawing.Point(320, 219);
            this.AgregarEquipoButton.Name = "AgregarEquipoButton";
            this.AgregarEquipoButton.Size = new System.Drawing.Size(124, 23);
            this.AgregarEquipoButton.TabIndex = 9;
            this.AgregarEquipoButton.Text = "Agregar Equipo";
            this.AgregarEquipoButton.UseVisualStyleBackColor = true;
            this.AgregarEquipoButton.Click += new System.EventHandler(this.AgregarEquipoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(233, 136);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(363, 20);
            this.tbName.TabIndex = 12;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarPilotoButton;
        private System.Windows.Forms.ComboBox PilotNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AgregarNaveganteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox TeamNameComboBox;
        private System.Windows.Forms.Button AgregarEquipoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NaveganteCB;
        private System.Windows.Forms.ComboBox PilotoCB;
    }
}

