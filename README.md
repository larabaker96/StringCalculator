# StringCalculator

1. Create a simple String calculator with a method <b>int Add(string numbers)</b><br/>
   1.1. The method can take 0,1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example <b>"" or "1" or "1,2"</b><br/>
   1.2. Start with the simplest test case of an empty string and move to 1 and 2 numbers<br/>
   1.3. Remember to solve things as simply as possible so that you force yourself to write tests that you did not think about.<br/>
   1.4. Remember to refactor after each passing test
2. Allow the Add method to handle an unknown amount of numbers
3. Allow the Add method to handle new lines between numbers (instead of commas)<br/>
   3.1. The following input is ok: <b>"1\n2,3"</b> (will equal 6)<br/>
   3.2. The following input is NOT ok: <b>"1,\n"</b> (no need to prove it, just clarifying)
4. Support different delimeters
   4.1. To change a delimeter, the beginning of the string will contain a seperate line that looks like this: <b>"//[delimeter]\n[numbers...]"</b> for example <b> "//;\n1;2"</b> should return 3 where the default delimeter is ';'.
   4.2. The first line is optional, all existing delimeters should still be supported.
5. Calling add with a negative number will throw an exception "negatives not allowed" - and the negative that was passed. If there are multiple negatives, show all of them in the exception message.
6. Numbers bigger than 1000 should be ignored, so adding 2 + 1001 - 2
7. Delimeters can be of any length with the following format: <b>"//[delimeter]\n"</b> for example "//*** \n1*** 2***3" should return 6.
8. Allow multiple delimeters like this: <b>//[delim1][delim2]\n"</b> for example: <b>//[ * ][%]\n1*2%3"</b> should return 6.
9. Make sure you can also have multiple delimeters with length longer than one character.
