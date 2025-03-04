function bubbleSort(array) {
    let isSorted;

    do {
        isSorted = true;
        for( let i = 0; i < array.length; i++) {
            if (array[i] > array[i + 1]) {
                [array[i], array[i+1]] = [array[i+1], array[i]];
                isSorted = false;
            }
        }
    } while(!isSorted)
    
    return array;
}
// n2 + n + 2

bubbleSort([1,4,2,8,345,123,43,32,5643,63,123,43,2,55,1,234,92]);