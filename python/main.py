import time
import statistics

def main():
    loop_count = 100000
    times = []
    
    start_time = time.time()
    for _ in range(loop_count):
        loop_start = time.time()
        print("Hello, World!")
        loop_end = time.time()
        times.append(loop_end - loop_start)
    end_time = time.time()
    
    total_time = end_time - start_time
    avg_time = total_time / loop_count
    median_time = statistics.median(times)
    
    print(f"\nTotal Time: {total_time:.6f} seconds")
    print(f"Average Time per Loop: {avg_time:.6f} seconds")
    print(f"Median Time per Loop: {median_time:.6f} seconds")

if __name__ == "__main__":
    main()
