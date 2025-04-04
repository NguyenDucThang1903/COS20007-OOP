using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Clock
{
    private Counter _hour;
    private Counter _min;
    private Counter _sec;

    public Clock()
    {
        _hour = new Counter("Hour");
        _min = new Counter("Minute");
        _sec = new Counter("Second");
    }

    public void Tick()
    {
        if (_sec.Ticks <59)
        {
            _sec.Increment();
        }
        else
        {
            _sec.Reset();
            if(_min.Ticks <59)
            {
                _min.Increment();
            }
            else
            {
                _min.Reset();
                if(_hour.Ticks <11)
                {
                    _hour.Increment();
                }
                else
                {
                    _hour.Reset();
                }
            }
        }
    }

    public void Reset()
    {
        _hour.Reset();
        _min.Reset();
        _sec.Reset();
    }

    public string ClockTime
    {
        get
        {
            return $"{_hour.Ticks:D2}:{_min.Ticks:D2}:{_sec.Ticks:D2}";
        }
    }
}

