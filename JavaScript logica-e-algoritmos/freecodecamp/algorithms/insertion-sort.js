
function insertionSort(array) {
    for (let i = 1; i < array.length; i++) {
        let numberToInsert = array[i];

        for (let j = i -1; j >= 0; j--) {
            if (array[j] > numberToInsert) {
                array[j+1] = array[j];
                array[j] = numberToInsert;
            } 
            // else {
            //     array[j+1] = numberToInsert;
            //     break;
            // }
        }
        
    }

    return array;

}