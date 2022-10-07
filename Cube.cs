using System;
public class Cube
{
    private float volume;
    private float surfacearea;
    private float height;
    private float width;
    private float length;

    public Cube()
    {
        height = 0f;
        width = 0f;
        length = 0f;
    }
    public float GetVolume()
    {
        return length * height * width;
    }

    public float GetSurfaceArea()
    {
        return 2 * (height * width) + 2 * (length * height) + 2 * (length * width);
    }

    public float GetHeight()
    {
        return height;
    }

    public void SetHeight(float newHeight)
    {
        height = newHeight;
    }

    public float GetWidth()
    {
        return width;
    }

    public void SetWidth(float newWidth)
    {
        width = newWidth;
    }

    public float GetLength()
    {
        return length;
    }

    public void SetLength(float newLength)
    {
        length = newLength;
    }

}



