namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Adapter.I
{
    internal class SquareToCircleAdapter : ICircle
    {
        private readonly Square _square;

        public SquareToCircleAdapter(Square square)
        {
            _square = square;
        }
        public double R => _square.A * Math.Sqrt(2) / 2.0;
    }
}
