const arrays = [[1, 2], [3, 4], [5, 6]];

const arrayAchatado = arrays.reduce((acumulador, valorAtual) => {
    return acumulador.concat(valorAtual);
}, []);

console.log(arrayAchatado); // Output: [1, 2, 3, 4, 5, 6]