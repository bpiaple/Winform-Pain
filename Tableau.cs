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

        public void ModifierEpaisseur(float epaisseur)
        {
            this.epaisseurTrait = epaisseur;
        }
        
        public void Dessiner(Graphics graphics)
        {
            foreach (FormeAbstraite forme in formes)
            {
                forme.Dessiner(graphics);
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

        public void EnregistrerDessin()
        {
            SaveFileDialog fenetreEnregistrement = new()
            {
                Filter = "Image PNG (*.png)|*.png|Image JPEG (*.jpg)|*.jpg|Tous les fichiers (*.*)|*.*",
                Title = "Enregistrer le dessin",
                DefaultExt = "png"
            };

            if (fenetreEnregistrement.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap imageEnregistree = new(tableau.Width, tableau.Height);

                    using (Graphics g = Graphics.FromImage(imageEnregistree))
                    {
                        g.Clear(Color.White);

                        foreach (FormeAbstraite forme in formes)
                        {
                            forme.Dessiner(g);
                        }
                    }

                    string extension = Path.GetExtension(fenetreEnregistrement.FileName).ToLower();

                    if (extension == ".jpg" || extension == ".jpeg")
                    {
                        imageEnregistree.Save(fenetreEnregistrement.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else
                    {
                        imageEnregistree.Save(fenetreEnregistrement.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    MessageBox.Show("Dessin enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}