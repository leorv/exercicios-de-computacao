// Compare and update the inventory stored in a 2D array against a second 2D array of a fresh delivery. Update the current existing inventory item quantities (in arr1). If an item cannot be found, add the new item and quantity into the inventory array. The returned inventory array should be in alphabetical order by item.

// passa em todos os testes.
function updateInventory(arr1, arr2) {
    let inventory = arr1;

    for (let i = 0; i < arr2.length; i++) {
        let itemExists = false;

        for (let j = 0; j < inventory.length; j++) {
            if (arr2[i][1] == inventory[j][1]) {
                itemExists = true;

                const quant = inventory[j][0] + arr2[i][0];
                inventory[j][0] = quant;
            }
        }
        if (!itemExists) {
            inventory.push(arr2[i]);
        }
    }
    inventory.sort((a, b) => a[1].localeCompare(b[1]));

    return inventory;
    
}

// A correção, parece melhor:
function updateInventory2(arr1, arr2) {
    const inventory = {};

    // Adiciona o inventário atual ao objeto
    for (const [quantity, item] of arr1) {
        inventory[item] = quantity;
    }

    // Atualiza o inventário com os novos itens
    for (const [quantity, item] of arr2) {
        inventory[item] = (inventory[item] || 0) + quantity;
    }

    // Converte o objeto de volta para um array e ordena
    const result = Object.entries(inventory)
        .map(([item, quantity]) => [quantity, item])
        .sort((a, b) => a[1].localeCompare(b[1]));

    return result;
}

// Example inventory lists
var curInv = [
    [21, "Bowling Ball"],
    [2, "Dirty Sock"],
    [1, "Hair Pin"],
    [5, "Microphone"]
];

var newInv = [
    [2, "Hair Pin"],
    [3, "Half-Eaten Apple"],
    [67, "Bowling Ball"],
    [7, "Toothpaste"]
];

updateInventory(curInv, newInv);