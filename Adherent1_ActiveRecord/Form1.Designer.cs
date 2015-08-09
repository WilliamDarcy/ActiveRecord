namespace Adherent1_ActiveRecord
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
            this.listViewAdherents = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodePostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewAdherents
            // 
            this.listViewAdherents.AutoArrange = false;
            this.listViewAdherents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prenom,
            this.Ville,
            this.CodePostal,
            this.Naissance});
            this.listViewAdherents.FullRowSelect = true;
            this.listViewAdherents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAdherents.Location = new System.Drawing.Point(39, 61);
            this.listViewAdherents.Name = "listViewAdherents";
            this.listViewAdherents.Size = new System.Drawing.Size(524, 190);
            this.listViewAdherents.TabIndex = 0;
            this.listViewAdherents.UseCompatibleStateImageBehavior = false;
            this.listViewAdherents.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 113;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prénom";
            this.Prenom.Width = 97;
            // 
            // Ville
            // 
            this.Ville.Text = "Ville";
            this.Ville.Width = 86;
            // 
            // CodePostal
            // 
            this.CodePostal.Text = "Code postal";
            this.CodePostal.Width = 101;
            // 
            // Naissance
            // 
            this.Naissance.Text = "Année de naissance";
            this.Naissance.Width = 118;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 334);
            this.Controls.Add(this.listViewAdherents);
            this.Name = "Form1";
            this.Text = "Liste des adhérents";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAdherents;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.ColumnHeader CodePostal;
        private System.Windows.Forms.ColumnHeader Naissance;
    }
}

