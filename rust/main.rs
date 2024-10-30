use std::time::Instant;

fn main() {
    let loop_count = 100000;
    let mut times: Vec<f64> = Vec::new();
    
    let total_start = Instant::now();
    
    for _ in 0..loop_count {
        let loop_start = Instant::now();
        println!("Hello, World!");
        let loop_duration = loop_start.elapsed().as_secs_f64();
        times.push(loop_duration);
    }
    
    let total_time = total_start.elapsed().as_secs_f64();
    let avg_time = total_time / loop_count as f64;
    
    times.sort_by(|a, b| a.partial_cmp(b).unwrap());
    let median_time = times[loop_count / 2];
    
    println!("\nTotal Time: {:.6} seconds", total_time);
    println!("Average Time per Loop: {:.6} seconds", avg_time);
    println!("Median Time per Loop: {:.6} seconds", median_time);
}