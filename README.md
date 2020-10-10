# Katas
A repository to hold my Kata implementations.  
These Katas are used to practice design patterns and utilise TDD.  
Take each step in turn and don't look ahead.  
  
For each kata, remember to:  
- Start with the simplest test case  
- Solve things as simply as possible so that you force yourself to write tests you did not think about  
- Refactor after each passing test  
  
## String Calculator
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
  
## Greeter
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
  
## Prime Factors
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
