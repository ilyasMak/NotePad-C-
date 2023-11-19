namespace NotePad
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.Labeldate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.Bedit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitre.Location = new System.Drawing.Point(12, 38);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(235, 40);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Titre de Note";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNote.Location = new System.Drawing.Point(52, 79);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(190, 35);
            this.labelNote.TabIndex = 1;
            this.labelNote.Text = "contenu de note...";
            // 
            // Labeldate
            // 
            this.Labeldate.AutoSize = true;
            this.Labeldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labeldate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Labeldate.Location = new System.Drawing.Point(181, 0);
            this.Labeldate.Name = "Labeldate";
            this.Labeldate.Size = new System.Drawing.Size(188, 25);
            this.Labeldate.TabIndex = 2;
            this.Labeldate.Text = "Date de modification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(32, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "______________________________________";
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Red;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.del.Image = global::NotePad.Properties.Resources.icons8_supprimer_100;
            this.del.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.del.Location = new System.Drawing.Point(266, 79);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(81, 33);
            this.del.TabIndex = 5;
            this.del.Text = "Delete";
            this.del.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Bedit
            // 
            this.Bedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Bedit.FlatAppearance.BorderSize = 0;
            this.Bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bedit.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bedit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bedit.Image = global::NotePad.Properties.Resources.icons8_modifier_483;
            this.Bedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bedit.Location = new System.Drawing.Point(266, 35);
            this.Bedit.Name = "Bedit";
            this.Bedit.Size = new System.Drawing.Size(81, 38);
            this.Bedit.TabIndex = 3;
            this.Bedit.Text = "edit";
            this.Bedit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bedit.UseVisualStyleBackColor = false;
            this.Bedit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last modifcation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.del);
            this.Controls.Add(this.Bedit);
            this.Controls.Add(this.Labeldate);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelTitre);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(372, 150);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label Labeldate;
        private System.Windows.Forms.Button Bedit;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
