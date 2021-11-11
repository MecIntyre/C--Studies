/* Previously, we set out to write code that would store Order IDs belonging to potentially fraudulent orders. 
   Our hope is to find fraudulent orders as early as possible and flag them for deeper analysis.

   Our team found a pattern. Orders that start with the letter "B" encounter fraud 25 times the normal rate. 
   We will write new code that will output the Order ID of new orders where the Order ID starts with the letter "B". 
   This will be used by our fraud team to investigate further. 

   Here's the fake Order ID data that you should use to initialize your array: B123 C234 A345 C15 B177 G3003 C235 B179

   Output: B123
           B177
           B179 */


string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
