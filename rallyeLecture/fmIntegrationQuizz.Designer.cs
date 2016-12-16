namespace rallyeLecture
{
    partial class fmIntegrationQuizz
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
            this.lblRepertoire = new System.Windows.Forms.Label();
            this.lblQuizz = new System.Windows.Forms.Label();
            this.btnLancer = new System.Windows.Forms.Button();
            this.clbQuizz = new System.Windows.Forms.CheckedListBox();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.tbChemin = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCocherDecocher = new System.Windows.Forms.Button();
            this.pbChargement = new System.Windows.Forms.ProgressBar();
            this.lblFichiersSolution = new System.Windows.Forms.Label();
            this.tbSolutions = new System.Windows.Forms.TextBox();
            this.btnSolutions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRepertoire
            // 
            this.lblRepertoire.AutoSize = true;
            this.lblRepertoire.Location = new System.Drawing.Point(12, 28);
            this.lblRepertoire.Name = "lblRepertoire";
            this.lblRepertoire.Size = new System.Drawing.Size(112, 13);
            this.lblRepertoire.TabIndex = 0;
            this.lblRepertoire.Text = "Répertoire des quizz : ";
            // 
            // lblQuizz
            // 
            this.lblQuizz.AutoSize = true;
            this.lblQuizz.Location = new System.Drawing.Point(12, 87);
            this.lblQuizz.Name = "lblQuizz";
            this.lblQuizz.Size = new System.Drawing.Size(86, 13);
            this.lblQuizz.TabIndex = 1;
            this.lblQuizz.Text = "Quizz à intégrer :";
            // 
            // btnLancer
            // 
            this.btnLancer.Location = new System.Drawing.Point(407, 341);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(138, 39);
            this.btnLancer.TabIndex = 2;
            this.btnLancer.Text = "Lancer l\'intégration";
            this.btnLancer.UseVisualStyleBackColor = true;
            this.btnLancer.Click += new System.EventHandler(this.btnLancer_Click);
            // 
            // clbQuizz
            // 
            this.clbQuizz.CheckOnClick = true;
            this.clbQuizz.FormattingEnabled = true;
            this.clbQuizz.Location = new System.Drawing.Point(126, 87);
            this.clbQuizz.Name = "clbQuizz";
            this.clbQuizz.Size = new System.Drawing.Size(419, 199);
            this.clbQuizz.TabIndex = 4;
            // 
            // btnParcourir
            // 
            this.btnParcourir.Location = new System.Drawing.Point(488, 23);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(57, 23);
            this.btnParcourir.TabIndex = 5;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // tbChemin
            // 
            this.tbChemin.Enabled = false;
            this.tbChemin.Location = new System.Drawing.Point(126, 25);
            this.tbChemin.Name = "tbChemin";
            this.tbChemin.Size = new System.Drawing.Size(356, 20);
            this.tbChemin.TabIndex = 6;
            this.tbChemin.TextChanged += new System.EventHandler(this.tbChemin_TextChanged);
            // 
            // btnCocherDecocher
            // 
            this.btnCocherDecocher.Location = new System.Drawing.Point(15, 191);
            this.btnCocherDecocher.Name = "btnCocherDecocher";
            this.btnCocherDecocher.Size = new System.Drawing.Size(105, 23);
            this.btnCocherDecocher.TabIndex = 7;
            this.btnCocherDecocher.Text = "Cocher/Décocher";
            this.btnCocherDecocher.UseVisualStyleBackColor = true;
            this.btnCocherDecocher.Click += new System.EventHandler(this.btnCocherDecocher_Click);
            // 
            // pbChargement
            // 
            this.pbChargement.Location = new System.Drawing.Point(12, 341);
            this.pbChargement.Name = "pbChargement";
            this.pbChargement.Size = new System.Drawing.Size(382, 23);
            this.pbChargement.TabIndex = 8;
            // 
            // lblFichiersSolution
            // 
            this.lblFichiersSolution.AutoSize = true;
            this.lblFichiersSolution.Location = new System.Drawing.Point(12, 297);
            this.lblFichiersSolution.Name = "lblFichiersSolution";
            this.lblFichiersSolution.Size = new System.Drawing.Size(108, 13);
            this.lblFichiersSolution.TabIndex = 9;
            this.lblFichiersSolution.Text = "Fichier des solutions :";
            // 
            // tbSolutions
            // 
            this.tbSolutions.Enabled = false;
            this.tbSolutions.Location = new System.Drawing.Point(126, 294);
            this.tbSolutions.Name = "tbSolutions";
            this.tbSolutions.Size = new System.Drawing.Size(356, 20);
            this.tbSolutions.TabIndex = 10;
            // 
            // btnSolutions
            // 
            this.btnSolutions.Location = new System.Drawing.Point(488, 292);
            this.btnSolutions.Name = "btnSolutions";
            this.btnSolutions.Size = new System.Drawing.Size(57, 23);
            this.btnSolutions.TabIndex = 11;
            this.btnSolutions.Text = "Parcourir";
            this.btnSolutions.UseVisualStyleBackColor = true;
            this.btnSolutions.Click += new System.EventHandler(this.btnSolutions_Click);
            // 
            // fmIntegrationQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 393);
            this.Controls.Add(this.btnSolutions);
            this.Controls.Add(this.tbSolutions);
            this.Controls.Add(this.lblFichiersSolution);
            this.Controls.Add(this.pbChargement);
            this.Controls.Add(this.btnCocherDecocher);
            this.Controls.Add(this.tbChemin);
            this.Controls.Add(this.btnParcourir);
            this.Controls.Add(this.clbQuizz);
            this.Controls.Add(this.btnLancer);
            this.Controls.Add(this.lblQuizz);
            this.Controls.Add(this.lblRepertoire);
            this.Name = "fmIntegrationQuizz";
            this.ShowIcon = false;
            this.Text = "Alimentation de la base de données : Livres & Quizz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepertoire;
        private System.Windows.Forms.Label lblQuizz;
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.CheckedListBox clbQuizz;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.TextBox tbChemin;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnCocherDecocher;
        private System.Windows.Forms.ProgressBar pbChargement;
        private System.Windows.Forms.Label lblFichiersSolution;
        private System.Windows.Forms.TextBox tbSolutions;
        private System.Windows.Forms.Button btnSolutions;
    }
}

