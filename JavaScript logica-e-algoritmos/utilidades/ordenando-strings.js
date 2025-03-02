const nomes = ['Ana', 'Jhon', 'ana', 'jhon'];
console.log(nomes.sort());

// Output:
// [ 'Ana', 'Jhon', 'ana', 'jhon' ]

function ordenaStrings(a, b) {
    // Ele compara os códigos ASCII
    if (a.toLowerCase() < b.toLowerCase()) {
        return -1;
    }
    if (a.toLowerCase() > b.toLowerCase()) {
        return 1;
    }
    return 0;
}

console.log(nomes.sort(ordenaStrings));
// [ 'Ana', 'ana', 'Jhon', 'jhon' ]

// Se quiser que as letras minúsculas venha antes:
console.log(names.sort((a, b) => a.localeCompare(b)));