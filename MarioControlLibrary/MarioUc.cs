using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarioControlLibrary
{
    public partial class MarioUc : UserControl
    {
        private int vitesseDeplacement = 10;
        private Direction directionActuelle = Direction.Bas;

        public enum Direction
        {
            Haut,
            Bas,
            Gauche,
            Droite
        }

        public MarioUc()
        {
            InitializeComponent();
        }

        // Cache toutes les PictureBox (comme dans le PDF)
        private void CacherToutesLesPictureBox()
        {
            pBHaut.Visible = false;
            pBBas.Visible = false;
            pBDroite.Visible = false;
            pBGauche.Visible = false;
        }

        // AfficherDirection (identique au PDF)
        private void AfficherDirection(Direction direction)
        {
            CacherToutesLesPictureBox();  // Utilise la méthode séparée
            switch (direction)
            {
                case Direction.Haut: pBHaut.Visible = true; break;
                case Direction.Bas: pBBas.Visible = true; break;
                case Direction.Gauche: pBGauche.Visible = true; break;
                case Direction.Droite: pBDroite.Visible = true; break;
            }
            directionActuelle = direction;
        }

        // SynchroniserPositions (identique)
        private void SynchroniserPositions()
        {
            pBHaut.Location = new Point(0, 0);
            pBBas.Location = new Point(0, 0);
            pBDroite.Location = new Point(0, 0);
            pBGauche.Location = new Point(0, 0);
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            SynchroniserPositions();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up: DeplacerHaut(); return true;
                case Keys.Down: DeplacerBas(); return true;
                case Keys.Left: DeplacerGauche(); return true;
                case Keys.Right: DeplacerDroite(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void DeplacerHaut()
        {
            CacherToutesLesPictureBox();  // Étape 1 du PDF
            pBHaut.Visible = true;  // Étape 2
            pBHaut.Top -= vitesseDeplacement;  // Étape 3 (déplacement PB)
            this.Top -= vitesseDeplacement;  // Étape 4 (déplacement UC)
            // Étape 5 (sync)
            pBBas.Location = pBHaut.Location;
            pBDroite.Location = pBHaut.Location;
            pBGauche.Location = pBHaut.Location;
            directionActuelle = Direction.Haut;  // Étape 6
        }

        // Similaire pour les autres directions (adapte Top/Left en conséquence)
        public void DeplacerBas()
        {
            CacherToutesLesPictureBox();
            pBBas.Visible = true;
            pBBas.Top += vitesseDeplacement;
            this.Top += vitesseDeplacement;
            pBHaut.Location = pBBas.Location;
            pBDroite.Location = pBBas.Location;
            pBGauche.Location = pBBas.Location;
            directionActuelle = Direction.Bas;
        }

        public void DeplacerGauche()
        {
            CacherToutesLesPictureBox();
            pBGauche.Visible = true;
            pBGauche.Left -= vitesseDeplacement;
            this.Left -= vitesseDeplacement;
            pBHaut.Location = pBGauche.Location;
            pBBas.Location = pBGauche.Location;
            pBDroite.Location = pBGauche.Location;
            directionActuelle = Direction.Gauche;
        }

        public void DeplacerDroite()
        {
            CacherToutesLesPictureBox();
            pBDroite.Visible = true;
            pBDroite.Left += vitesseDeplacement;
            this.Left += vitesseDeplacement;
            pBHaut.Location = pBDroite.Location;
            pBBas.Location = pBDroite.Location;
            pBGauche.Location = pBDroite.Location;
            directionActuelle = Direction.Droite;
        }
    }
}