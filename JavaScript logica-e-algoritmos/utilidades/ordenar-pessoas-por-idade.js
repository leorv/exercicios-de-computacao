const friends = [
    { name: 'john', age: 30},
    { name: 'ana', age: 25},
    { name: 'chris', age: 20}
]

function compareByAge(a, b) {
    if (a.age < b.age) {
        return -1;
    }
    if (a.age > b.age) {
        return 1;
    }
    return 0;
}

console.log(friends.sort(compareByAge));