namespace TP1
{
    public partial class Form1 : Form
    {
        private Point pointCourant;
        public Point pointDebut;

        private Tableau monTableau;
        private TypeForme formeActive = TypeForme.Ligne;

        public Form1()
        {
            InitializeComponent();
            monTableau = new Tableau(tableau);

        }

        private void ChangerEpaisseur(object sender, EventArgs e)
        {
            FormulaireEpaisseur formulaireEpaisseur = new();

            formulaireEpaisseur.ValeurEpaisseur = monTableau.epaisseurTrait;

            if (formulaireEpaisseur.ShowDialog() == DialogResult.OK)
            {
                monTableau.ModifierEpaisseur(formulaireEpaisseur.ValeurEpaisseur);
                epaisseur.Text = formulaireEpaisseur.ValeurEpaisseur.ToString();
            }
        }

        private void OuvrirPanelCouleur(object sender, EventArgs e)
        {
            ColorDialog boiteCouleur = new();
            if (boiteCouleur.ShowDialog() == DialogResult.OK)
            {
                choixCouleur.BackColor = boiteCouleur.Color;
            }
        }

        private void SourisBas(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                monTableau.dessinEnCours = true;
                pointDebut = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                menuClickDroit.Show(tableau, e.Location);


                tableau.Invalidate();
            }
        }

        private void SourisDeplace(object sender, MouseEventArgs e)
        {
            if (!monTableau.dessinEnCours)
            {
                return;
            }

            pointCourant = e.Location;

            tableau.Invalidate();
        }

        private void SourisHaut(object sender, MouseEventArgs e)
        {
            if (monTableau.dessinEnCours)
            {
                int x = Math.Min(pointDebut.X, e.Location.X);
                int y = Math.Min(pointDebut.Y, e.Location.Y);
                int width = Math.Abs(pointDebut.X - e.Location.X);
                int height = Math.Abs(pointDebut.Y - e.Location.Y);

                IForme forme;

                Pen stylo = new(choixCouleur.BackColor, monTableau.epaisseurTrait);

                switch (formeActive)
                {
                    case TypeForme.Rectangle:
                        forme = new Rectangle(stylo, x, y, width, height);
                        monTableau.AjouterForme(forme);
                        break;
                    case TypeForme.Ellipse:
                        forme = new Ellipse(stylo, x, y, width, height);
                        monTableau.AjouterForme(forme);
                        break;
                    case TypeForme.Ligne:
                        forme = new Ligne(stylo, pointDebut.X, pointDebut.Y, e.Location.X, e.Location.Y);
                        monTableau.AjouterForme(forme);
                        break;
                    default:
                        break;
                }

                tableau.Invalidate();

                monTableau.dessinEnCours = false;
            }
        }

        private void DessinerTableau(object sender, PaintEventArgs e)
        {
            monTableau.Dessiner(e.Graphics);
            if (monTableau.dessinEnCours)
            {
                int x = Math.Min(pointDebut.X, pointCourant.X);
                int y = Math.Min(pointDebut.Y, pointCourant.Y);
                int width = Math.Abs(pointDebut.X - pointCourant.X);
                int height = Math.Abs(pointDebut.Y - pointCourant.Y);

                IForme forme;

                switch (formeActive)
                {
                    case TypeForme.Rectangle:
                        forme = new Rectangle(new Pen(choixCouleur.BackColor, monTableau.epaisseurTrait), x, y, width, height);
                        break;
                    case TypeForme.Ellipse:
                        forme = new Ellipse(new Pen(choixCouleur.BackColor, monTableau.epaisseurTrait), x, y, width, height);
                        break;
                    case TypeForme.Ligne:
                        forme = new Ligne(new Pen(choixCouleur.BackColor, monTableau.epaisseurTrait), pointDebut.X, pointDebut.Y, pointCourant.X, pointCourant.Y);
                        break;
                    default:
                        forme = new Ellipse(new Pen(choixCouleur.BackColor, monTableau.epaisseurTrait), x, y, width, height);
                        break;
                }

                forme.Dessiner(e.Graphics);
            }
        }

        private void EnregistrerDessin(object sender, EventArgs e)
        {
            monTableau.EnregistrerDessin();
        }

        private void SelectionnerLigne(object sender, EventArgs e)
        {
            formeActive = TypeForme.Ligne;
            outil.Text = "Ligne";
        }

        private void SelectionnerRectangle(object sender, EventArgs e)
        {
            formeActive = TypeForme.Rectangle;
            outil.Text = "Rectangle";
        }

        private void SelectionnerEllipse(object sender, EventArgs e)
        {
            formeActive = TypeForme.Ellipse;
            outil.Text = "Ellipse";
        }

        private void augmenterTraiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monTableau.epaisseurTrait++;
            epaisseur.Text = monTableau.epaisseurTrait.ToString();
        }

        private void diminuerTraitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (monTableau.epaisseurTrait > 1)
            {
                monTableau.epaisseurTrait--;
                epaisseur.Text = monTableau.epaisseurTrait.ToString();
            }
        }

        private void effacerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monTableau.EffacerDessins();
        }
    }
}
