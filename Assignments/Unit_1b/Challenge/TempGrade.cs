using System;

public class TempGrade {
	// references for class instances
	public TempAdvisor tempAdvisor;
	public ExamGrader examGrader;

	public void Main() {
		tempAdvisor = new TempAdvisor();
		examGrader = new ExamGrader();


		tempAdvisor.Advise();
		examGrader.Grade();
		examGrader.GiveSubjectFeedback();
	}
}
public class TempAdvisor {
	
	public void Advise() {
		Console.WriteLine("Please input a temperature in Celsius:");
		string temp = Console.ReadLine();

		float tempF = float.Parse(temp);
		if(tempF > 50) {
			Console.WriteLine("EXTREME DANGER! Please seek a cooler environment!");
		} else if(tempF > 40) {
			Console.WriteLine("Wow! That's really hot! Please avoid staying in the sun for very long");
		} else if(tempF > 30) {
			Console.WriteLine("Definitely on the warm side. Enjoy the good weather!");
		} else if(tempF > 20) {
			Console.WriteLine("Consider wearing a long sleeve or light jacket");
		} else if(tempF > 10) {
			Console.WriteLine("It's pretty chilly, consider a thick jacket or coat");
		} else if(tempF > 0) {
			Console.WriteLine("that's cold! bundle up!");
		} else {
			Console.WriteLine("Caution! very cold weather! For your safety, please wear warm clothes");
		}
	}
}

public class ExamGrader {
	
	public void Grade() {
		Console.WriteLine("Please enter your grade percentage: ");
		string grade = Console.ReadLine();
		float gradeF = float.Parse(grade);


		if(gradeF >= 90) {
			Console.WriteLine("You got an A.");
		} else if(gradeF >= 80) {
			Console.WriteLine("You got an B.");		
		} else if(gradeF >= 70) {
			Console.WriteLine("You got an C.");		
		} else if(gradeF >= 60) {
			Console.WriteLine("You got an D.");		
		} else {
			Console.WriteLine("You got an F. :(");		
		}
	}

	public void GiveSubjectFeedback() {
		Console.WriteLine("Please enter your favorite subject - \nThe options are as follows: \nmath \nhistory \nscience \nenglish");
		string subject = Console.ReadLine();



		switch (subject) {
			case "math":
				Console.WriteLine("That's great! Math is a very useful subject. Keep learning!");
				break;
			case "history":
				Console.WriteLine("Nice! History is a great way to learn about the world and it's past.");
				break;
			case "science":
				Console.WriteLine("Science is very fascinating! understanding science allows you to better understand the way the world works.");
				break;
			case "english":
				Console.WriteLine("Very nice! you can use language to tell stories or express your own ideas with more accuracy and detail");
				break;

		}


	}
}