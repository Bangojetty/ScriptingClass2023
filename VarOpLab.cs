using System;

public class VarOpLab {
    // Variables
    public int numberA = 5;
    public int numberB = 3;
    public float floatA = 3.5f;
    public string name = "Ethan";
    public bool isAlive = true;
    
    // Variables changed by operators
    public int newNumber;
    
    // Main Method
    public void Main() {
        // Using different operators on the created variables to deomonstrate my understanding.
        
        // This should be 8 because NumberA is 5 and NumberB is 3.
        newNumber = numberA + numberB;
        Console.WriteLine("NumberA + NumberB = " + newNumber);
        
        // This should add 1 to 8 which will be 9.
        newNumber++;
        Console.WriteLine("The new number after using the ++ operator: " + newNumber);
        
        // This adds numberA to 9. This should equal 14.
        newNumber += numberA;
        Console.WriteLine("The new number after using the += operator: " + newNumber);
        
        // This checks if 14 is greater than 10. It should be true.
        Console.WriteLine("The new number is greater than 10: " + (newNumber > 10));
        
        // This checks if 14 is greater than 0 and also less than 50. This should also be true.
        Console.WriteLine("The new number is greater than 0 AND less than 50: " + 
                          (newNumber > 0 && newNumber < 50));
    }
}