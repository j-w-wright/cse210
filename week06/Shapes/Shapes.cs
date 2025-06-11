using System;
using System.Reflection.Metadata;


public class Shapes
{
    private string _color;

    public Shapes(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea() // This method can be overridden in derived classes
    {
        return 0;
    }
}