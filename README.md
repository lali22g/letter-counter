## Problem 
If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
- Example: If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3+3+5+4+4=19 letters used in total.

### Answer✨
```
21124
```

## Approach
### Summary
The `LetterCounter` class models a counter that counts the total number of letters used to write out numbers from `start` to `end` in words. You can get the number of letters by instantiating an object of the class and then calling the method `GetCount()` on it:
```
LetterCounter letterCounter = new LetterCounter(1, 1000);
int totalLetters = letterCounter.GetCount();
```
### Details
1. Loop over the numbers from `start` to `end` (inclusive)
2. For each number in the loop create the text representation of that number. I did not add spaces because those won't be part of the calculations but if needed those could be added
    ```
    E.g. 974 becomes ninehunderedandseventyfour
    ```
3. For creating the text version of the number check `GetTextRepresentation()` method in `LetterCounter`. We break down the given number into it's thousands, hundreds, tens and ones digits so that we can solve smaller problem set. For each of these digits we calculate the corresponding text representation. Thousands and hundereds are easy to calculate. Tens and ones have some exception cases that need to be handled. Once these smaller text representations are calculated we combine those back to get the full text representation of the original number. 
4. Once the text representation is ready, simply calculate the length of the string and add it to the running total

## Complexity
The runtime complexity of this solution would be `BigO(n)` because we are looping over each of the numbers from `start` to `end`. The practical performance can be improved using cached results for the tens and ones because for sets of hundred numbers the tens and ones repeat. As an example in `223` and `523` the portion of the number `23` repeats which equates to `twentythree` for both the cases. So if it is computed once we don't need to calculate it again. Similarly as you scale the solution up more cached results can be used at a higher level for hundreds, thousands and so on. Also we should reconsider the approach when scaling up, definitely there are better ways to solve the problem.

## Rationale
Since this is a computational problem rather than i/o I chose C#/.NET to solve it but again it depends on the requirements, like are the calculations happening on server side or client side?, if it is on the server side what's the usage like - via an api or embedded in the page render? Again if an api how many calculations per second/hour/day etc. needed to be handled.

### Todos 😉
- Validations
- Unit tests

## Locally testing the solution🤞
I used `.NET 6` and VS Code to develop the solution. To run it locally open terminal and navigate to the project root and run:
```
dotnet build
```
if successful then run
```
dotnet run
```

You should see the output in console. Any feedback appreciated!
