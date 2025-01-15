namespace App17
{
    public abstract class Shape
    {
        public abstract float GetArea();
        public abstract float GetPerimeter();
    }

    public class Square : Shape
    {
        public float Length;

        public Square(float length)
        {
            Length = length;
        }

        public override float GetArea()
        {
            return Length * Length;
        }

        public override float GetPerimeter()
        {
            return 4f * Length;
        }
    }

    public class Rectangle : Shape
    {
        public float Length;
        public float Width;

        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }

        public override float GetArea()
        {
            return Length * Width;
        }

        public override float GetPerimeter()
        {
            return 2f * (Length + Width);
        }
    }
}
