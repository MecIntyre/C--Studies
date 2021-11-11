/* 
   A variable is a data item that may change its value during its lifetime. 
   You use variables to temporarily store values that you intend to use later in your code. 
   A variable is a friendly label that we can assign to a computer memory address. 
   When we want to temporarily store a value in that memory address, 
   or whenever we want to retrieve the value that is stored in the memory address, we just use the variable name we created. */


/* Declaration of variables
   To create a new variable, you must first declare the data type of the variable, then give it a name.
   A few examples of variable declarations using the data types we learned about previously. */
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

/* Declaration of a variable and assigning a value
   Assignment happens from right to left.
   You use a single equals character as the assignment operator. */
string firstName;
firstName = "Bob";

/* Declaration of a variable, assign and retrieving a value
   You must assign (set) a value to a variable before you can retrieve (get) a value from a variable. */
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

// You can initialize a variable by assigning a value to the variable at the point of declaration.
int firstName;
firstName = "Bob";

/* Reassigning of the variable
   To retrieve the value from the variable, you merely use the variable's name. */
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Beth";
Console.WriteLine(firstName);
firstName = "Conrad";
Console.WriteLine(firstName);
firstName = "Grant";
Console.WriteLine(firstName);