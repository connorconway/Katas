# Katas
A repository to hold my Kata implementations.  
These Katas are used to practice design patterns and utilise TDD.  
Take each step in turn and don't look ahead.  
  
For each kata, remember to:  
- Start with the simplest test case  
- Solve things as simply as possible so that you force yourself to write tests you did not think about  
- Refactor after each passing test  
  
## String Calculator Kata
### Steps
1. Create a simple String calculator with a method signature: `int Add(string numbers)`  
  1.1. The method can take up to two numbers, separated by commas, and will return their sum.   
  1.2. For example “” or “1” or “1,2” as inputs.  
  1.3. For an empty string it will return 0.  
2. Allow the Add method to handle an unknown amount of numbers  
3. Allow the Add method to handle new lines between numbers (instead of commas).  
  3.1. The following input is ok: “1\n2,3” (will equal 6)  
  3.2. The following input is NOT ok: “1,\n” (no need to prove it - just clarifying)  
4. Support different delimiters  
  4.1. To change a delimiter, the beginning of the string will contain a separate line that looks like this: `“//[delimiter]\n[numbers…]”`  
  4.2. For example “//;\n1;2” should return three where the default delimiter is ‘;’.  
  4.3. The first line is optional. all existing scenarios should still be supported  
5. Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed.  
6. If there are multiple negatives, show all of them in the exception message.  
7. Numbers bigger than 1000 should be ignored, so adding 2 + 1001 = 2  
8. Delimiters can be of any length with the following format: `“//[delimiter]\n”`  
  8.1. For example: `“//[***]\n1***2***3”` should return 6  
9. Allow multiple delimiters like this: `“//[delim1][delim2]\n”`  
  9.1. For example `“//[*][%]\n1*2%3”` should return 6.  
  9.2. Make sure you can also handle multiple delimiters with length longer than one char  
  
## Greeter Kata
### Steps
1. Create a Greeter class with a method signature `string Greet(string name)`  
  1.1. The method should return `Hello <name>`  
  1.2. The signature of greet should not change throughout the kata.  
2. Greet trims the input  
3. Greet capitalizes the first letter of the name  
4. Greet returns `Good morning <name>` when the time is 06:00-12:00  
5. Greet returns `Good evening <name>` when the time is 18:00-22:00  
6. Greet returns `Good night <name>` when the time is 22:00-06:00  
7. Greet logs into console each time it is called  
  
## Prime Factors Kata
### Steps
1. Create a PrimeFactors class with a method signature `IEnumerable<int> Generate(int number)`  
	1.1. The method should return the prime factors in numerical sequence.  
2. 1 should return []  
3. 2 should return [2]  
4. 3 should return [3]  
5. 4 should return [2,2]  
6. 5 should return [5]  
7. 6 should return [2,3]  
8. 7 should return [7]  
9. 8 should return [2,2,2]  
10. 9 should return [3,3]  
11. 4620 should return [2,2,3,5,7,11]  
  
## Rock, Paper, Scissors Kata
### Steps
1. Create a game of Rock, Paper, Scissors with two players.  
	1.1. Rock beats Scissors  
	1.2. Scissors beats Paper  
	1.3. Paper beats Rock  
2. If both players play the same shape then no player gets the win  
3. The amount of rounds played can be configurable  
	3.1. The winner is the player who has the most amount of round wins  
4. If there is no way for the other player to win by continuing to play, end the game  
	4.1. For example, in a 3 round game if player one has 2 wins then end the game  
5. Extend the game to also allow for Lizard and Spock.  
	5.1. Scissors cut Paper  
	5.2. Paper covers Rock  
	5.3. Rock crushes Lizard  
	5.4. Lizard poisons Spock  
	5.5. Spock smashes Scissors  
	5.6. Scissors decapitate Lizard  
	5.7. Lizard eats Paper  
	5.8. Paper disproves Spock  
	5.9. Spock vaporizes Rock  
	5.10. Rock crushes Scissors  
  
## Args Kata
### Steps
1. Create a parser which takes in arguments with flags and values.  
	1.1. Flags should be one character, preceded by a minus sign.  
	1.2. Each flag should have zero, or one value associated with it.  
	1.3. For example, `-l -p 8080 -d /usr` indicates:  
		1.3.1. 3 flags: l, p, and d  
		1.3.2. The l flag has no value associated with it and so is a boolean  
		1.3.3. The p flag has an integer value of 8080  
		1.3.4. The d flag has a string value of /usr  
2. Handle negative integers  
	2.1. For example, `-n -6` indicates:  
		2.1.1. The n flag has an integer value of `-6`  
2. The parser should take a schema detailing what arguments the program expects.  
	1.1. The schema specifies the number and types of flags and values the program expects.  
3. If a flag mentioned in the schema is missing in the arguments, a suitable default value should be returned.  
	3.1. For example, `False` for a boolean, `0` for a number, and `“”` for a string.  
4. Extend your code to support lists  
	4.1. For example, `-g this,is,a,list -d 1,2,-3,5` indicates:  
		4.1.1. The g flag is a list of strings `[“this”, “is”, “a”, “list”]`  
		4.1.2. The d flag is a list of integers `[1, 2, -3, 5]`  
  
## Word Wrap Kata
### Steps
1. Create a Wrapper class with a static method named `Wrap` that takes 2 arguments; a string and a column number.  
2. The function returns the string, but with line breaks inserted at just the right places to make sure that no line is longer than the column number.  
	2.1. For example, `Wrapper.Wrap("one two three", 5)` should return `one t\r\nwo th\r\nree`  
3. Break lines at word boundaries where possible.  
	3.1. For example, `Wrapper.Wrap("one two three four", 7)` should return `one two\r\n three\r\n four`  
4. Don't start or end a line with a space character  
	4.1. For example, `Wrapper.Wrap("one two three four", 7)` should return `one two\r\nthree\r\nfour`  
  
## Birthday Greetings Kata
### Steps
1. 
