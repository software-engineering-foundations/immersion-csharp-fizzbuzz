# FizzBuzz

FizzBuzz is a simple exercise that involves counting upwards and replacing certain numbers with words.

## Starting steps

Start by writing a program that prints the numbers from 1 to 100, each on their own line.

## The problem
Now we're going to replace certain numbers with words! Try implementing the following rules one at a time:

1. If a number is a multiple of three, print "Fizz" instead of the number.
1. If the number is a multiple of five, print "Buzz" instead of the number. For numbers which are multiples of both three and five, print "FizzBuzz" instead of the number.

Once you're happy with your program, show it to a trainer for some quick feedback.
   
## Going further

FizzBuzz is pretty simple as programs go. But it's interesting to see what happens if you try adding new rules. While working through these next few rules, think about:

- How easy is it?
- How neat and tidy is the resulting code?
- Can you make changes to your program to make these sorts of enhancements easier, or cleaner?

> You will obviously need to display more than 100 numbers in order to test out some of the later cases.

Work through the following extra rules, one at a time:

1. If a number is a multiple of 7, print "Bang" instead of the number. For any number which is both a multiple of 7 and a multiple of 3 or 5, append Bang to what you'd have printed anyway (e.g. 3 * 7 = 21: "FizzBang").
1. If a number is a multiple of 11, print "Bong" instead of the number. Do not print anything else in these cases (e.g. 3 * 11 = 33: "Bong").
1. If a number is a multiple of 13, print "Fezz" instead of the number. If the number is both a multiple of 13 and another number, the "Fezz" goes immediately in front of the first word beginning with B (if there is one), or at the end if there are none (e.g. 5 * 13 = 65: "FezzBuzz", 3 * 5 * 13 = 195: "FizzFezzBuzz"). Note that Fezz should be printed even if Bong is also present (e.g. 11 * 13 = 143: "FezzBong").
1. If a number is a multiple of 17, reverse the order in which any Fizzes, Buzzes, Bangs etc. are printed (e.g. 3 * 5 * 17 = 255: "BuzzFizz").

Now that you've reached the end, look over your code again. How much of a mess has it become? How can you make it clear what's supposed to be happening in the face of so many rules?

## Stretch goals

- Prompt the user for a maximum number. Read a value in from the console, then print output up to that number rather than 100.
- Allow the user to specify rule options. Let the user pass in which rules to implement by reading in their choices from the console (e.g. the user might choose 3, 5, and 13 – the "Fizz", "Buzz", and "Fezz" rules – but no "Bang" or "Bong").
- If you wanted to go wild and let the user define their own rules, how would you do that?
