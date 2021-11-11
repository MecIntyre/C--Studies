/* The projectName variable will be used twice in the desired output.
   The russianMessage variable contains the message "View Russian output" in Russian. 
   You must use this variable in your code that prints the message.
   You may not change these two lines of code, but you can add code above and below each line. 
   You must use these two lines of code to form the desired output.
   string projectName = "ACME";
   string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 
                            \u0432\u044b\u0432\u043e\u0434";
   View English output:
		c:\Exercise\ACME\data.txt
   Посмотреть русский вывод:
		c:\Exercise\ACME\ru-RU\data.txt         */


// One possible solution
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
        c:\Exercise\{projectName}\data.txt");
Console.WriteLine($@"{russianMessage}:
        c:\Exercise\{projectName}\ru-RU\data.txt");


// Second solution
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
            
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");