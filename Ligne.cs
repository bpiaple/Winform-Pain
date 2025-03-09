namespace TP1
{
    public class Ligne : FormeAbstraite
    {
        private int x2;
        private int y2;
        public Ligne(Pen pen, int x1, int y1, int x2, int y2) : base(pen, x1, y1, 0, 0)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
        public override void Dessiner(Graphics graphics)
        {
            graphics.DrawLine(stylo, x, y, x2, y2);
        }
    }
}