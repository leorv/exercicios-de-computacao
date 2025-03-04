function selectionSort(array) {

    for (let i = 0; i < array.length; i++) {
        let num = array[i];
        let position = i;
        for (let j = i+1; j < array.length; j++) {
            if (array[j] < num) {
                num = array[j];
                position = j;
            }
        }
        let tmp = array[i];
        array[i] = num;
        array[position] = tmp;
    }

    return array;
}