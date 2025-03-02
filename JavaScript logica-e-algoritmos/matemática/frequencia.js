const frutas = ['maçã', 'banana', 'maçã', 'laranja', 'banana', 'maçã'];

const frequencia = frutas.reduce((acumulador, valorAtual) => {
  acumulador[valorAtual] = (acumulador[valorAtual] || 0) + 1;
  return acumulador;
}, {});

console.log(frequencia);

// Output: { maçã: 3, banana: 2, laranja: 1 }