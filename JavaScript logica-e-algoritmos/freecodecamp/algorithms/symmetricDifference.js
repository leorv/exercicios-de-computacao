function sym(...args) {
    let result = args[0];
    const symDiff = (arr1, arr2) => {
        const set1 = new Set(arr1);
        const set2 = new Set(arr2);
        const result = new Set();

        for (const num of set1) {
            if (!set2.has(num)) {
                result.add(num);
            }
        }

        for (const num of set2) {
            if (!set1.has(num)) {
                result.add(num);
            }
        }

        return [...result];
    };

    for (let i = 1; i < args.length; i++) {
        result = symDiff(result, args[i]);
    }

    return [...new Set(result)].sort((a, b) => a - b);
}