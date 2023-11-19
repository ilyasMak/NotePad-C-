namespace NotePad
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TBnote = new System.Windows.Forms.TextBox();
            this.TBtitre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.Button();
            this.Arreter = new System.Windows.Forms.Button();
            this.NewNote = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.userControl11 = new NotePad.UserControl1();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.flowLayoutPanel1.Controls.Add(this.userControl11);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 680);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // TBnote
            // 
            this.TBnote.BackColor = System.Drawing.SystemColors.InfoText;
            this.TBnote.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnote.ForeColor = System.Drawing.SystemColors.Info;
            this.TBnote.Location = new System.Drawing.Point(466, 160);
            this.TBnote.Multiline = true;
            this.TBnote.Name = "TBnote";
            this.TBnote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBnote.Size = new System.Drawing.Size(805, 532);
            this.TBnote.TabIndex = 1;
            this.TBnote.TextChanged += new System.EventHandler(this.TBnote_TextChanged);
            // 
            // TBtitre
            // 
            this.TBtitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBtitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtitre.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TBtitre.Location = new System.Drawing.Point(466, 74);
            this.TBtitre.Name = "TBtitre";
            this.TBtitre.Size = new System.Drawing.Size(314, 41);
            this.TBtitre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(466, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(466, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note Content";
            // 
            // red
            // 
            this.red.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.red.FlatAppearance.BorderSize = 0;
            this.red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.red.Image = global::NotePad.Properties.Resources.red;
            this.red.Location = new System.Drawing.Point(1169, -2);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(48, 47);
            this.red.TabIndex = 8;
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // Arreter
            // 
            this.Arreter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.Arreter.FlatAppearance.BorderSize = 0;
            this.Arreter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arreter.Image = global::NotePad.Properties.Resources.aa1;
            this.Arreter.Location = new System.Drawing.Point(1223, -2);
            this.Arreter.Name = "Arreter";
            this.Arreter.Size = new System.Drawing.Size(48, 47);
            this.Arreter.TabIndex = 7;
            this.Arreter.UseVisualStyleBackColor = true;
            this.Arreter.Click += new System.EventHandler(this.Arreter_Click);
            // 
            // NewNote
            // 
            this.NewNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.NewNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewNote.Font = new System.Drawing.Font("Snap ITC", 7.8F);
            this.NewNote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewNote.Image = global::NotePad.Properties.Resources.note;
            this.NewNote.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewNote.Location = new System.Drawing.Point(1096, 49);
            this.NewNote.Name = "NewNote";
            this.NewNote.Size = new System.Drawing.Size(148, 40);
            this.NewNote.TabIndex = 3;
            this.NewNote.Text = "New Note";
            this.NewNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewNote.UseVisualStyleBackColor = false;
            this.NewNote.Click += new System.EventHandler(this.NewNote_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Snap ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Save.Image = global::NotePad.Properties.Resources.save;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.Location = new System.Drawing.Point(899, 49);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(160, 40);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save Edits";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.userControl11.DateModification = new System.DateTime(((long)(0)));
            this.userControl11.Location = new System.Drawing.Point(3, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Note = null;
            this.userControl11.Size = new System.Drawing.Size(395, 150);
            this.userControl11.TabIndex = 0;
            this.userControl11.Titre = null;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1273, 695);
            this.ControlBox = false;
            this.Controls.Add(this.red);
            this.Controls.Add(this.Arreter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBtitre);
            this.Controls.Add(this.NewNote);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TBnote);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControl1 userControl11;
        private System.Windows.Forms.TextBox TBnote;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button NewNote;
        private System.Windows.Forms.TextBox TBtitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Arreter;
        private System.Windows.Forms.Button red;
    }
}

