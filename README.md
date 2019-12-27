# Unit_Testing_Fizzbuzz
To write a Fizzbuzz program and an accompanying test case

### What is Fizzbuzz?
A fizzbuzz program counts upwards from 1, outputting whole numbers except multiples of 3, which are replaced by "Fizz", and multiples of 5, replaced by "Buzz". Common multiples output the hybrid "FizzBuzz". To demonstrate: 1, 2, "Fizz", 4, "Buzz", "Fizz", 7, 8, "Fizz", "Buzz", 11, "Fizz", 13, 14, "Fizzbuzz", 16, ad infinitum.

### How to code FizzBuzz?
A single if-else statement sufficiently filters every number to generate the correct sequence. The if-statement first vefifies the input (an integer) is a multiple of both 3 and 5. Two statements which may achieve this are `if (value % 3 == 0 & value % 5 == 0)` and, more simply, `if (value % 15 == 0)`. If this condition is not met then the input is verified as a multiple of 3 and 5 individually. If none of these conditions are met, then the input itself is returned as an output.

### How to test Fizzbuzz?
As there are 4 general outputs to expect—Fizz, Buzz, FizzBuzz and the returned input—the minimum number of unit tests is four. Fizz is tested by inputting any multiple of three; Buzz, any multiple of five; and FizzBuzz, any multiple of 15.

There are various ways to create unit tests. This particular solution involves adding a reference to a C# unit test project. This project-type automatically generates a `[TestClass]` attribute above a class and similar metadata, `[TestMethod]`, above a method. After producing an object of `FizzBuzzClass` the expected outputs (eg. "Fizz") can be verified against given inputs (eg. 42) using `Assert.AreEqual`.

### Test Case
Project Name: Fizzbuzz  
Created By: Ainsley  
Creation Date: 27/12/19  
Test Scenario ID: FB-1  
Test Scenario Description: Verify that the fizzbuzz program returns the correct string: "Fizz", "Buzz", "FizzBuzz" or the equivalent string of the inputter integer.

|Test Case ID|Test Case Description|Test Data|Expected Outcome|Actual Outcome|Status|
|:----------:|:-------------------:|:-------:|:--------------:|:------------:|:----:|
|FB-1-01     |Input is divisible by 3, but not 5.|42       |"Fizz"          |"Fizz"        |Passed|
|FB-1-02     |Input is divisible by 5, but not 3.|20       |"Buzz"          |"Buzz"        |Passed|
|FB-1-03     |Input is divisible by 3 and 5.|60       |"FizzBuzz"      |"FizzBuzz"    |Passed|
|FB-1-04     |Input is neither divisible by 3 nor 5.|11       |"11"            |"11"          |Passed|
