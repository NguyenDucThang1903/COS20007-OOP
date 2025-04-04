from Counter import Counter
class Clock:
    def __init__(self):
        self._hour=Counter("Hour")
        self._min=Counter("Minute")
        self._sec=Counter("Second")

    def tick(self):
        if self._sec.ticks<59:
            self._sec.increment()
        else:
            self._sec.reset()
            if self._min.ticks<59:
                self._min.increment()
            else:
                self._min.reset()
                if self._hour.ticks<11:
                    self._hour.increment()
                else:
                    self._hour.reset()

    def reset(self):
        self._hour.reset()
        self._min.reset()
        self._sec.reset()

    @property
    def clock_time(self):
        return f"{self._hour.ticks:02}:{self._min.ticks:02}:{self._sec.ticks:02}"
