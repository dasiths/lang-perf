# lang-perf

#### Steps for conducting test

**Dotnet:**

- Build
    ``` dotnet build ./dotnet/HelloWorld -c relase ```
- Run test 
    ``` for i in {1..4}; do time ./dotnet/HelloWorld/bin/relase/net8.0/HelloWorld; done ```

**Rust:**
- Build
    ``` cd ./rust/ && cargo build --release  -o ./target/hello_world && cd -```
- Run test 
    ``` for i in {1..4}; do time ./rust/target/release/hello_world; done ```

**Python**
- Run test 
    ``` for i in {1..4}; do time python ./pytho/main.py; done ```