namespace TP1
{
    public abstract class FormeAbstraite : IForme
    {
        private int xOrigine;
        private int yOrigine;
        private int width;
        private int height;
        private Pen stylo;
        
        protected FormeAbstraite(Pen stylo, int xOrigine, int yOrigine, int width, int height)
        {
            this.stylo = stylo;
            this.xOrigine = xOrigine;
            this.yOrigine = yOrigine;
            this.width = width;
            this.height = height;
        }

        public abstract void Dessiner(Graphics tableau);

        public virtual void Enregistrer(IFluxEcriture fluxEcriture)
        {
            fluxEcriture.Ecrire(GetType().Name);
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(xOrigine);
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(yOrigine);
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(width);
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(height);
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(getStylo().Color.ToArgb());
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(getStylo().Width);
            fluxEcriture.Ecrire("\n");
        }

        protected int getX() { return this.xOrigine; }
        protected int getY() { return this.yOrigine; }
        protected int getWidth() { return this.width; }
        protected int getHeight() { return this.height; }
        protected Pen getStylo() { return this.stylo; }
    }

}