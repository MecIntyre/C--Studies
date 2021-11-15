/* Use the foreach statement to iterate through each element in an array, 
   executing the associated code block once for each element in the array.
   The foreach statement sets the value of the current element in the array to a temporary variable,
   which you can use in the body of the code block.
   Use the ++ increment operator to add 1 to the current value of a variable. */


int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");


/* Output:
   Bin 1 = 200 items (Running total: 200)
   Bin 2 = 450 items (Running total: 650)
   Bin 3 = 700 items (Running total: 1350)
   Bin 4 = 175 items (Running total: 1525)
   Bin 5 = 250 items (Running total: 1775)
   We have 1775 items in inventory. */