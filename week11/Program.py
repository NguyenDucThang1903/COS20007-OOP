import os
import tracemalloc
from Counter import Counter
from Clock import Clock

def main():
    tracemalloc.start()
    myclock= Clock()
    for i in range(473):  # 43200
        print(myclock.clock_time)
        myclock.tick()

    current_memory, peak_memory= tracemalloc.get_traced_memory()
    tracemalloc.stop()

    print(f"Current process:{os.getpid()}")
    print(f"Current memory usage:{current_memory} bytes")
    print(f"Peak memory usage:{peak_memory} bytes")

if __name__ == "__main__":
    main()
