#include <stdio.h>

int fibonacci_iterative(int n) {
    if (n == 0)
        return 0;
    else if (n == 1)
        return 1;
    else if (n == 2)
        return 2;

    int prev1 = 0, prev2 = 1, prev3 = 2, result;

    for (int i = 3; i <= n; i++) {
        result = prev3 + prev2;
        prev1 = prev2;
        prev2 = prev3;
        prev3 = result;
    }

    return result;
}

int main() {
    int n = 10; // Example value for n

    printf("F(%d) = %d\n", n, fibonacci_iterative(n));

    return 0;
}
