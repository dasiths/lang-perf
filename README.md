# lang-perf

#### Steps for conducting the test

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


Once you've the result for each language, caluclate average for the real value. 

Here is an example excel sheet with calcualte values and chart for the tests
![image](https://github.com/user-attachments/assets/9cd56016-a45e-4ea2-918f-b5689a15457d)
