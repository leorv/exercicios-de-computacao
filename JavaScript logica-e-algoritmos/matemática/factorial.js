function factorial(n) {
    if (n < 0) {
        return -1;
    }

    let factorial = 1;
    for (let i = 1; i <= n; i++) {
        factorial *= i;
    }
    return factorial;
}
// O(n)

console.log(factorial(0)); // 1
console.log(factorial(3)); // 6
console.log(factorial(5));  // 120