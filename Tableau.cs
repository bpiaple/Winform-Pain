namespace TP1
{
    public class Tableau
    {
        readonly List<IForme> formes = [];
        readonly PictureBox tableau;
        public bool dessinEnCours = false;
        public float epaisseurTrait = 2; 

        public Tableau(PictureBox tableau)
        {
            this.tableau = tableau;
        }

        public void ModifierEpaisseur(float epaisseurTrait)
        {
            this.epaisseurTrait = epaisseurTrait;
        }
        
        public void Dessiner(Graphics tableau)
        {
            foreach (IForme forme in formes)
            {
                forme.Dessiner(tableau);
            }
        }

        public void AjouterForme(IForme forme)
        {
            formes.Add(forme);
        }

        public void EffacerDessins()
        {
            formes.Clear();
            tableau.Invalidate();
        }

        public void EnregistrerDessin() {
            SaveFileDialog fenetreEnregistrement = new()
            {
                Filter = "Fichier Texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*",
                Title = "Enregistrer le dessin",
                DefaultExt = "txt"
            };

            if (fenetreEnregistrement.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter ecrivain = new(fenetreEnregistrement.FileName))
                    {
                        foreach (IForme forme in formes)
                        {
                            forme.Ecrire(ecrivain);
                        }
                    }

                    MessageBox.Show("Dessin enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void OuvrirDessin() {
            OpenFileDialog fenetreOuverture = new()
            {
                Filter = "Image Texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*",
                Title = "Ouvrir un dessin"
            };

            if (fenetreOuverture.ShowDialog() == DialogResult.OK)
            {
                this.EffacerDessins();
                using StreamReader reader = new(fenetreOuverture.FileName);
                string ligne;
                while ((ligne = reader.ReadLine()) != null)
                {
                    string[] elements = ligne.Split(' ');
                    TypeForme typeForme = (TypeForme)Enum.Parse(typeof(TypeForme), elements[0]);
                    int x = int.Parse(elements[1]);
                    int y = int.Parse(elements[2]);
                    int width = int.Parse(elements[3]);
                    int height = int.Parse(elements[4]);
                    Color couleur = Color.FromArgb(int.Parse(elements[5]));
                    float epaisseur = float.Parse(elements[6]);

                    IForme forme;

                    switch (typeForme)
                    {
                        case TypeForme.Ligne:
                            forme = new Ligne(new Pen(couleur, epaisseur), x, y, width, height);
                            this.AjouterForme(forme);
                            break;
                        case TypeForme.Rectangle:
                            forme = new Rectangle(new Pen(couleur, epaisseur), x, y, width, height);
                            this.AjouterForme(forme);
                            break;
                        case TypeForme.Ellipse:
                            forme = new Ellipse(new Pen(couleur, epaisseur), x, y, width, height);
                            this.AjouterForme(forme);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}