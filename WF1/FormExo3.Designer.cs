namespace WF1
{
    partial class FormExo3
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
            this.buttonNoteQtyMoins = new System.Windows.Forms.Button();
            this.textBoxNoteQty = new System.Windows.Forms.TextBox();
            this.buttonNoteQtyPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNotes = new System.Windows.Forms.Panel();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMoy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalcul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNoteQtyMoins
            // 
            this.buttonNoteQtyMoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNoteQtyMoins.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNoteQtyMoins.Location = new System.Drawing.Point(125, 8);
            this.buttonNoteQtyMoins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNoteQtyMoins.Name = "buttonNoteQtyMoins";
            this.buttonNoteQtyMoins.Size = new System.Drawing.Size(28, 24);
            this.buttonNoteQtyMoins.TabIndex = 0;
            this.buttonNoteQtyMoins.Text = "-";
            this.buttonNoteQtyMoins.UseVisualStyleBackColor = true;
            this.buttonNoteQtyMoins.Click += new System.EventHandler(this.buttonNoteQtyMoins_Click);
            // 
            // textBoxNoteQty
            // 
            this.textBoxNoteQty.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNoteQty.Location = new System.Drawing.Point(158, 7);
            this.textBoxNoteQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNoteQty.Name = "textBoxNoteQty";
            this.textBoxNoteQty.ReadOnly = true;
            this.textBoxNoteQty.Size = new System.Drawing.Size(28, 27);
            this.textBoxNoteQty.TabIndex = 1;
            this.textBoxNoteQty.Text = "1";
            this.textBoxNoteQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonNoteQtyPlus
            // 
            this.buttonNoteQtyPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNoteQtyPlus.Location = new System.Drawing.Point(192, 8);
            this.buttonNoteQtyPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNoteQtyPlus.Name = "buttonNoteQtyPlus";
            this.buttonNoteQtyPlus.Size = new System.Drawing.Size(28, 24);
            this.buttonNoteQtyPlus.TabIndex = 2;
            this.buttonNoteQtyPlus.Text = "+";
            this.buttonNoteQtyPlus.UseVisualStyleBackColor = true;
            this.buttonNoteQtyPlus.Click += new System.EventHandler(this.buttonNoteQtyPlus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de notes";
            // 
            // panelNotes
            // 
            this.panelNotes.Location = new System.Drawing.Point(10, 37);
            this.panelNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNotes.Name = "panelNotes";
            this.panelNotes.Size = new System.Drawing.Size(344, 249);
            this.panelNotes.TabIndex = 4;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(434, 62);
            this.textBoxMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(39, 23);
            this.textBoxMin.TabIndex = 5;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(434, 12);
            this.textBoxMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(39, 23);
            this.textBoxMax.TabIndex = 6;
            // 
            // textBoxMoy
            // 
            this.textBoxMoy.Location = new System.Drawing.Point(434, 37);
            this.textBoxMoy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMoy.Name = "textBoxMoy";
            this.textBoxMoy.ReadOnly = true;
            this.textBoxMoy.Size = new System.Drawing.Size(39, 23);
            this.textBoxMoy.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Note min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Note max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Moyenne";
            // 
            // buttonCalcul
            // 
            this.buttonCalcul.Location = new System.Drawing.Point(272, 9);
            this.buttonCalcul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalcul.Name = "buttonCalcul";
            this.buttonCalcul.Size = new System.Drawing.Size(82, 22);
            this.buttonCalcul.TabIndex = 11;
            this.buttonCalcul.Text = "Calculer";
            this.buttonCalcul.UseVisualStyleBackColor = true;
            this.buttonCalcul.Click += new System.EventHandler(this.buttonCalcul_Click);
            // 
            // FormExo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 291);
            this.Controls.Add(this.buttonCalcul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMoy);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.panelNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNoteQtyPlus);
            this.Controls.Add(this.textBoxNoteQty);
            this.Controls.Add(this.buttonNoteQtyMoins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExo3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExo3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonNoteQtyMoins;
        private TextBox textBoxNoteQty;
        private Button buttonNoteQtyPlus;
        private Label label1;
        private Panel panelNotes;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private TextBox textBoxMoy;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCalcul;
    }
}