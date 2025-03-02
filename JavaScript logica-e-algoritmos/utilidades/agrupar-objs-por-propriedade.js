const pessoas = [
    { nome: 'Alice', idade: 25 },
    { nome: 'Bob', idade: 30 },
    { nome: 'Carol', idade: 25 },
];

const pessoasAgrupadasPorIdade = pessoas.reduce((acumulador, pessoa) => {
    const idade = pessoa.idade;
    if (!acumulador[idade]) {
        acumulador[idade] = [];
    }
    acumulador[idade].push(pessoa);
    return acumulador;
}, {});

console.log(pessoasAgrupadasPorIdade);
// Output: { 25: [{ nome: 'Alice', idade: 25 }, { nome: 'Carol', idade: 25 }], 30: [{ nome: 'Bob', idade: 30 }] }