namespace TP1
{
    public class Ellipse : FormeAbstraite
    {
        public Ellipse(Pen pen, int x, int y, int width, int height) : base(pen, x, y, width, height)
        {
        }
        public override void Dessiner(Graphics graphics)
        {
            graphics.DrawEllipse(stylo, x, y, width, height);
        }
    }
}