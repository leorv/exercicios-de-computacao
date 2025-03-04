const isPowerOfTwo = (n) => {
    if (n < 1) {
        return false;
    }
    return (n & (n -1)) === 0; // boolean
}

// const isPowerOfTwo = (n) => {
//     if (n < 1) {
//         return false;
//     }
//     for (let i = 1; i < n; i++) {
//         if (n % 2 != 0) {
//             return false;
//         }
//         n /= 2;
//     }
//     return true;
// }


// const isPowerOfTwo = (n) => {
//     for (let i = 0; i < n; i++) {
//         if ((2**i)==n) {
//             return true;
//         }
//     }
//     return false;
// }

console.log(isPowerOfTwo(1));   
console.log(isPowerOfTwo(2));
console.log(isPowerOfTwo(5));


// O operador & compara os bits de n e n - 1.
// Se n é uma potência de 2, n & (n - 1) sempre resultará em 0. Por quê? Porque o único bit 1 em n se tornará 0 em n - 1, e todos os outros bits serão 0 em n. Portanto, não haverá bits 1 correspondentes em ambos os números.
// Caso o número não seja uma potência de 2, haverá mais de um bit 1, e o resultado do AND bitwise não será 0.
// Exemplos Detalhados

// isPowerOfTwo(8):
// 8 (1000)
// 7 (0111)
// 1000 & 0111 = 0000 (0)
// A função retorna true.

// isPowerOfTwo(5):
// 5 (0101)
// 4 (0100)
// 0101 & 0100 = 0100 (4)
// A função retorna false.

// isPowerOfTwo(1):
// 1 (0001)
// 0 (0000)
// 0001 & 0000 = 0000 (0)
// A função retorna true.