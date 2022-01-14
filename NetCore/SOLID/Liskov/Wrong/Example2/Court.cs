namespace SOLID.Liskov.Wrong.Example2
{
    public class Court
    {

        public int Widht { get => widht; set => widht = value; }
        public int Height { get => height; set => height = value; }
        public string Grass { get => grass; set => grass = value; }
        public virtual void CutGrass(){}

        private int widht;
        private int height;
        private string grass;
    }
}