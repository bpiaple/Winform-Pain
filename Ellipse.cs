namespace TP1
{
    public class Ellipse : FormeAbstraite
    {
        public Ellipse(Pen stylo, int x, int y, int width, int height) : base(stylo, x, y, width, height)
        {
        }
        public override void Dessiner(Graphics tableau)
        {
            tableau.DrawEllipse(stylo, x, y, width, height);
        }
    }
}