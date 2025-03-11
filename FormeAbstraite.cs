namespace TP1
{
    public abstract class FormeAbstraite : IForme
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected Pen stylo;
        
        public FormeAbstraite(Pen stylo, int x, int y, int width, int height)
        {
            this.stylo = stylo;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public abstract void Dessiner(Graphics tableau);

        public virtual void Ecrire(StreamWriter ecrivain) {
            ecrivain.WriteLine($"{GetType().Name} {x} {y} {width} {height} {stylo.Color.ToArgb()} {stylo.Width}");
        }
    }

}