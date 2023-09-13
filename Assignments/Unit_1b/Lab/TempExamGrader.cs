using System;

public class TempExamGrader {
    // creating references to classes
    public TemperatureAdvisor tempAdvisor;
    public ExamGrader examGrader;
    
    public void Main() {
        // instantiating new classes to use
        tempAdvisor = new TemperatureAdvisor();
        examGrader = new ExamGrader();
        // using functions from instantiated classes
        tempAdvisor.AdviseOnTemp();
        examGrader.ConvertGrade();
    }
}

public class TemperatureAdvisor {

    public void AdviseOnTemp() {
        // ask for temp and wait for imput
        Console.WriteLine("Please enter a temperature in Celsius: ");
        string temp = Console.ReadLine();
        // convert string to float for comparison logic
        var tempF = float.Parse(temp);
        // compare input temp with 30 and print appropriately
        if (tempF >= 30) {
            Console.WriteLine("That's pretty warm! Don't forget to stay hydrated and avoid prolonged sun exposure.");
        }
        else {
            Console.WriteLine("Enjoy the nice weather!");
        }
    }
}

public class ExamGrader {
    public void ConvertGrade() {
        // ask for grade and wait for input
        Console.WriteLine("Please enter your percentage grade(without a percent symbol)");
        string grade = Console.ReadLine();
        // convert string to float for comparison
        var gradeF = float.Parse(grade);
        // check for negatives and print error message if necessary
        if (gradeF < 0) {
            Console.WriteLine("must be a positive number, please enter again: ");
            // repeat above steps after error message
            grade = Console.ReadLine();
            gradeF = float.Parse(grade);
        }
        // check grade percent and print appropriate message
        // the else ifs are used to avoid multiple messages
        // the else on the end should only be true if it's from 0 up to 60
        if (gradeF >= 90) { Console.WriteLine("You got an A!"); }
        else if (gradeF >= 80) { Console.WriteLine("You got a B!"); }
        else if (gradeF >= 70) { Console.WriteLine("You got a C!"); }
        else if (gradeF >= 60) { Console.WriteLine("You got a D!"); }
        else { Console.WriteLine("You got a F! very sad :("); }
    }
}