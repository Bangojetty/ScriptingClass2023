using System;

public class MathManager {
    private float firstNum;
    private float secondNum;
    private string operation;
    private bool isCursed = false;

    // initialize a reusable string variable as to avoid repition in the switch statement at the end of Main()
    string resultText = "The result is: ";

    public void Main() {
        // prompt the user to choose an operation
        Console.WriteLine("Type one of the following and hit enter to choose your operation: " +
                          "\nadd \nsubtract \nmultiply \ndivide");
        operation = Console.ReadLine();
        
        // check to make sure it's one of the four optionn. If not, print message and wait for input again
        while (operation != "add" && operation != "subtract" && operation != "divide" && operation != "multiply") {
            Console.WriteLine("That didn't work, make sure you typed one of the four options! Try again: ");
            operation = Console.ReadLine();
        }

        // prompt the user to choose the first number
        Console.WriteLine("Please type the first number: ");
        // attempt to write the first number to memory by first converting the string to an integer, if this fails, it
        // will print a message and wait for input again
        while(!float.TryParse(Console.ReadLine(), out firstNum)) {
            CurseTheLand();
        }
        
        // do the same for the second number
        Console.WriteLine("Please type the second number: ");
        while(!float.TryParse(Console.ReadLine(), out secondNum)) {
            CurseTheLand();
        }

        // use the "operation" variable in a switch statement to 
        // determine the operation, then use the two numbers to get a 
        // result

        switch(operation) {
            case "add":
                Console.WriteLine(resultText + (firstNum + secondNum));
                break;
            case "subtract":
                Console.WriteLine(resultText + (firstNum - secondNum));
                break;
            case "multiply":
                Console.WriteLine(resultText + (firstNum * secondNum));
                break;
            case "divide":
                Console.WriteLine(resultText + (firstNum / secondNum));
                break;
        }
    }

    public void CurseTheLand() {
        Console.WriteLine("FOOL! You have not entered a number and as a result have CURSED this land! " +
                          "\nJk. but really... please enter a number:");
    }
}