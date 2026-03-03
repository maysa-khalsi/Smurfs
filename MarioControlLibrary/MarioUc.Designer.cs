namespace MarioControlLibrary
{
    partial class MarioUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarioUc));
            pBBas = new PictureBox();
            pBDroite = new PictureBox();
            pBGauche = new PictureBox();
            pBHaut = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBBas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBDroite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBGauche).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBHaut).BeginInit();
            SuspendLayout();
            // 
            // pBBas
            // 
            pBBas.Image = (Image)resources.GetObject("pBBas.Image");
            pBBas.Location = new Point(-1, -2);
            pBBas.Name = "pBBas";
            pBBas.Size = new Size(175, 125);
            pBBas.SizeMode = PictureBoxSizeMode.StretchImage;
            pBBas.TabIndex = 0;
            pBBas.TabStop = false;
            // 
            // pBDroite
            // 
            pBDroite.Image = (Image)resources.GetObject("pBDroite.Image");
            pBDroite.Location = new Point(0, -2);
            pBDroite.Name = "pBDroite";
            pBDroite.Size = new Size(175, 125);
            pBDroite.SizeMode = PictureBoxSizeMode.StretchImage;
            pBDroite.TabIndex = 1;
            pBDroite.TabStop = false;
            // 
            // pBGauche
            // 
            pBGauche.Image = (Image)resources.GetObject("pBGauche.Image");
            pBGauche.Location = new Point(0, 0);
            pBGauche.Name = "pBGauche";
            pBGauche.Size = new Size(178, 125);
            pBGauche.SizeMode = PictureBoxSizeMode.StretchImage;
            pBGauche.TabIndex = 2;
            pBGauche.TabStop = false;
            // 
            // pBHaut
            // 
            pBHaut.Image = (Image)resources.GetObject("pBHaut.Image");
            pBHaut.Location = new Point(3, 3);
            pBHaut.Name = "pBHaut";
            pBHaut.Size = new Size(177, 126);
            pBHaut.SizeMode = PictureBoxSizeMode.StretchImage;
            pBHaut.TabIndex = 3;
            pBHaut.TabStop = false;
            // 
            // MarioUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pBHaut);
            Controls.Add(pBGauche);
            Controls.Add(pBDroite);
            Controls.Add(pBBas);
            Name = "MarioUc";
            Size = new Size(177, 126);
            ((System.ComponentModel.ISupportInitialize)pBBas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBDroite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBGauche).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBHaut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pBBas;
        private PictureBox pBDroite;
        private PictureBox pBGauche;
        private PictureBox pBHaut;
    }
}
