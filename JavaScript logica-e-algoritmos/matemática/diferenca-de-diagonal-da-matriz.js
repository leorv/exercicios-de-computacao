function diagonalDifference(arr) {
    let leftDiagonal = 0;
    let rightDiagonal = 0;
    
    let arrSize = arr.length - 1;
    let length = arr.length;
    
    console.log('length: ', length);
    console.log('size: ', arrSize);
    
    for (let i = 0; i < length; i++) {
        leftDiagonal += arr[i][i];
        rightDiagonal += arr[i][arrSize -i];
    }
    
    return Math.abs(leftDiagonal - rightDiagonal);

}

console.log(diagonalDifference([[11, 2, 4], [4, 5, 6], [10, 8, -12]]));