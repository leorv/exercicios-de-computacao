

// Return the number of total permutations of the provided string that don't have repeated consecutive letters. Assume that all characters in the provided string are each unique.

// For example, aab should return 2 because it has 6 total permutations (aab, aab, aba, aba, baa, baa), but only 2 of them (aba and aba) don't have the same letter (in this case a) repeating.


function permAlone(str) {
    const arr = str.split('');
    const permutacoes = [];
    const length = arr.length;
    let tmp;
    let quant = 0;

    function troca(index1, index2) {
        tmp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = tmp;
    }

    function generate(n) {
        // console.log('N = ', n);
        if (n === 1) {
            // console.log('gerou: ', arr.join(''))
            permutacoes.push(arr.join(''));
        }
        else {
            for (let i = 0; i < n; i++) {
                generate(n - 1);
                // console.log(`troca ${n % 2 == 0 ? i : 0} por ${n - 1}`)
                troca(n % 2 == 0 ? i : 0, n - 1);
            }
        }
    }

    generate(length);

    for (let j = 0; j < permutacoes.length; j++) {

        let Rep = false;


        for (let i = 0; i < permutacoes[j].length; i++) {

            if (permutacoes[j].charAt(i) == permutacoes[j].charAt(i + 1)) {
                Rep = true;
            }
        }
        if (Rep == false) {
            quant += 1;
        }
    }

    return quant;

}

console.log(permAlone('aab'));
