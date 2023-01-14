const recursiveSum = (array, itemCount, index = 0) => {
    console.log(`index ${index}`);

    if (index + 1 > itemCount) {
        return 0;
    }

    const toAdd = array[index];
    const recursiveResult = recursiveSum(array, itemCount, index + 1);

    console.log(`toAdd ${toAdd}`);
    console.log(`recursiveResult ${recursiveResult}`);

    return toAdd + recursiveResult;
};

const array = [2, 3, 4, 5, 6];
const itemCount = 3;
const result = recursiveSum(array, itemCount);
console.log(result);
