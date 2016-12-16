using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitairesIntegrationBd;

namespace rallyeLecture
{
    public partial class fmIntegrationQuizz : Form
    {
        //Chargement chargement;
        private string sPath = "C:\\";
        private List<string> nomFichier;
        private List<string> lesFichiersSelectionnés;

        public string SPath
        {
            get { return sPath; }
            set { sPath = value; }
        }

        public fmIntegrationQuizz()
        {
            //this.chargement = new Chargement();
            this.nomFichier = new List<string>();
            this.lesFichiersSelectionnés = new List<string>();
            InitializeComponent();
            this.pbChargement.Visible = false;
            tbChemin.Text = "C:\\";
            //this.chargement.ValueChange += chargement_ValueChange;
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            string nomDossier = "C:\\";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                nomDossier = folderBrowserDialog.SelectedPath;
            }
            this.sPath = nomDossier + "\\";
            tbChemin.Text = this.sPath;
        }

        private void btnLancer_Click(object sender, EventArgs e)
        {
            string path = this.sPath;
            btnLancer.Enabled = false;
            //tous les noms de fichiers se trouvent dans la liste nomFichier
            //récupération des fichiers sélectionnés dans la liste lesFichiersSelectionnés
            for (int i = 0; i < nomFichier.Count; i++)
            {
                if (clbQuizz.GetItemChecked(i))
                {
                    lesFichiersSelectionnés.Add(nomFichier[i]);
                }
            }
            //Thread thread = new Thread(this.chargement.traitement);
            //thread.Start();
            if (sPath != "" && tbSolutions.Text != "")
            {
                btnLancer.Enabled = false;
                UtilitairesIntegrationBd.UtilitairesIntegrationBd.IntegrationFiches(this.sPath, lesFichiersSelectionnés);
                UtilitairesIntegrationBd.UtilitairesIntegrationBd.ExtractionSolution(tbSolutions.Text);
                btnLancer.Enabled = true;
            }
            
        }

        private void tbChemin_TextChanged(object sender, EventArgs e)
        {
            clbQuizz.Items.Clear();
            //affichage des noms des fichiers dans la comboListBox
            //le chemin des fichiers est contenu dans sPath
            foreach (string sFileName in System.IO.Directory.GetFiles(sPath))
            {
                if (System.IO.Path.GetExtension(sFileName) == ".docx")
                {
                    char[] splitChar = new char[] { '\\' };
                    string[] leChemin = sFileName.Split(splitChar);
                    int leCheminCount = leChemin.Length;
                    this.nomFichier.Add(leChemin[leCheminCount - 1]);
                    clbQuizz.Items.Add(leChemin[leCheminCount - 1]);
                }
            }
        }

        private void btnCocherDecocher_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (clbQuizz.Items.Count > 0)
            {
                ok = clbQuizz.GetItemChecked(0);
                for (int i = 0; i < clbQuizz.Items.Count; i++)
                {
                    if (ok == false)
                    {
                        clbQuizz.SetItemChecked(i, true);
                    }
                    else
                    {
                        clbQuizz.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void btnSolutions_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSolutions.Text = openFileDialog.FileName;
            }
        }
    }
}
