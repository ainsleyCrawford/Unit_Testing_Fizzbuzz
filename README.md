# Unit-Testing-Fizzbuzz
To write a Fizzbuzz program and an accompanying test case

What is Fizzbuzz?
A fizzbuzz program counts upwards from 1, outputting whole numbers except multiples of 3, which are replaced by "Fizz", and multiples of 5, replaced by "Buzz". Common multiples output the hybrid "FizzBuzz". To demonstrate: 1, 2, "Fizz", 4, "Buzz", "Fizz", 7, 8, "Fizz", "Buzz", 11, "Fizz", 13, 14, "Fizzbuzz", 16, ad infinitum.

How to code FizzBuzz? (Step 1)
A single if-else statement sufficiently filters every number to generate the correct sequence. The if-statement first vefifies the input (an integer) is a multiple of both 3 and 5. Two statements which may achieve this are 'if (value % 3 == 0 & value % 5 ==0)' and, more simply, if '(value % 15 == 0)'. If this condition is not met then the input is verified as a multiple of 3 and 5 individually. If none of these conditions are met, then the input itself is returned as an output.

How th test Fizzbuzz?
