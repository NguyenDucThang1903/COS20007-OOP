﻿public class Counter
{
    private int _count;
    private string _name;

    public Counter(string name)
    {
        _name = name;
        _count = 0;
    }

    public void Increment()
    {
        checked
        {
            _count++;
        }
    }

    public void Reset()
    {
        _count = 0;
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public int Ticks
    {
        get
        {
            return _count;
        }
    }

    public void ResetByDefault()
    {
        unchecked
        {
            _count = (int)2147483647473;
        }
        
    }
}