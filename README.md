## Fibonacci Sequence - C Implementation

This program demonstrates three different implementations of the Fibonacci sequence in C: recursive, memoization, and iterative. The Fibonacci sequence is a series of numbers in which each number is the sum of the two preceding ones.

### How the Program Works

1. **Recursive Implementation:**
   - The Fibonacci sequence is implemented using a recursive function, `fibonacci_recursive()`.
   - The function takes an integer `n` as input and recursively calculates the Fibonacci value using the given recurrence relation: `F(n) = F(n-3) + F(n-2)`.
   - The base cases for `n=0`, `n=1`, and `n=2` are handled explicitly.
   - The function returns the Fibonacci value for the given `n`.

2. **Memoization Implementation:**
   - The Fibonacci sequence is implemented using a memoization technique to avoid redundant calculations.
   - A recursive function, `fibonacci_memoization()`, is used, which takes an integer `n` and an array `memo` as input.
   - The `memo` array is used to store the memoized values.
   - Before calculating the Fibonacci value for `n`, the function checks if the value is already memoized in the `memo` array. If found, the stored value is returned.
   - If the value is not memoized, the function recursively calculates it using the recurrence relation and stores the result in the `memo` array for future use.
   - The function returns the Fibonacci value for the given `n`.

3. **Iterative Implementation:**
   - The Fibonacci sequence is implemented using an iterative approach.
   - The function `fibonacci_iterative()` takes an integer `n` as input.
   - It initializes three variables `prev1`, `prev2`, and `prev3` with the initial values of `0`, `1`, and `2`, respectively.
   - It uses a loop to iteratively calculate the Fibonacci value for `n` by updating the variables based on the recurrence relation: `F(n) = F(n-3) + F(n-2)`.
   - The loop continues until `n` is reached, and the final Fibonacci value is stored in the variable `result`.
   - The function returns the Fibonacci value for the given `n`.

### How to Implement

1. Clone the repository or download the source code files to your local machine.

2. Compile the C program using a C compiler:
