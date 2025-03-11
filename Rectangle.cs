namespace TP1
{
    public class Rectangle : FormeAbstraite
    {
        public Rectangle(Pen stylo, int x, int y, int width, int height) : base(stylo, x, y, width, height)
        {
        }
        public override void Dessiner(Graphics tableau)
        {
            tableau.DrawRectangle(stylo, x, y, width, height);
        }
    }
}