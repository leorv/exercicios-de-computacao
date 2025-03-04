const fibonacci = (n) => {
    let fibonacci = [0, 1];
    for(let i = 2; i < n; i++) {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    return fibonacci;
}

console.log(fibonacci(10))


// 20 primeiros números da sequência de fibonacci.

// const fibonacci = [];
// fibonacci[1] = 1;
// fibonacci[2] = 1;

// for (let i = 3; i <= 20; i++) {
//     fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
// }

// for (let i = 1; i < fibonacci.length; i++) {
//     console.log(fibonacci[i]);
//   }