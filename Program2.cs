#include <stdio.h>

int fibonacci_memoization(int n, int* memo) {
    if (memo[n] != -1)
        return memo[n];

    if (n == 0)
        memo[n] = 0;
    else if (n == 1)
        memo[n] = 1;
    else if (n == 2)
        memo[n] = 2;
    else
        memo[n] = fibonacci_memoization(n - 3, memo) + fibonacci_memoization(n - 2, memo);

    return memo[n];
}

int main() {
    int n = 10; // Example value for n

    int memo[100]; // Initialize an array to store memoized values
    for (int i = 0; i < 100; i++)
        memo[i] = -1;

    printf("F(%d) = %d\n", n, fibonacci_memoization(n, memo));

    return 0;
}
