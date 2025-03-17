namespace TP1
{
    public class Ligne : FormeAbstraite
    {
        private int x2;
        private int y2;

        public Ligne(Pen stylo, int x1, int y1, int x2, int y2) : base(stylo, x1, y1, 0, 0)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Dessiner(Graphics tableau)
        {
            tableau.DrawLine(getStylo(), getX(), getY(), x2, y2);
        }

        public override void Enregistrer(IFluxEcriture fluxEcriture)
        {
            fluxEcriture.Ecrire(GetType().Name);
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(getX());
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(getY());
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(x2);
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(y2);
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(getStylo().Color.ToArgb());
            fluxEcriture.Ecrire(" ");
            fluxEcriture.Ecrire(getStylo().Width);
            fluxEcriture.Ecrire("\n");
        }
    }
}