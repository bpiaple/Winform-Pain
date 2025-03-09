namespace TP1
{
    public class Rectangle : FormeAbstraite
    {
        public Rectangle(Pen pen, int x, int y, int width, int height) : base(pen, x, y, width, height)
        {
        }
        public override void Dessiner(Graphics graphics)
        {
            graphics.DrawRectangle(stylo, x, y, width, height);
        }
    }
}