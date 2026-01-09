public class Triangle
{
    //your code goes here
    int Base, Height;

    public Triangle(int @base,int @height)
    {
        Base = @base; Height = @height;
    }

    public int CalculateArea()
    {
        return (Base * Height)/2;
    }

    public string AsString()
    {
        return $"Base is {Base}, height is {Height}";
    }
}