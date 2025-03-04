// Given an array arr, find element pairs whose sum equal the second argument arg and return the sum of their indices.

// You may use multiple pairs that have the same numeric elements but different indices. Each pair should use the lowest possible available indices. Once an element has been used it cannot be reused to pair with another element. For instance, pairwise([1, 1, 2], 3) creates a pair [2, 1] using the 1 at index 0 rather than the 1 at index 1, because 0+2 < 1+2.

function pairwise(arr, arg) {
    sumIndex = 0;
    usedIndex = [];

    for (let i = 0; i < (arr.length - 1); i++) {
        if (usedIndex.includes(i)) {
            continue;
        }
        for (let j = i + 1; j < arr.length; j++) {
            if (usedIndex.includes(j)) {
                continue;
            }
            sum = arr[i] + arr[j]
            if (sum == arg) {
                sumIndex += i + j;
                usedIndex.push(i, j);
                break;
            }
        }
    }
    return sumIndex;
}


pairwise([1, 4, 2, 3, 0, 5], 7);