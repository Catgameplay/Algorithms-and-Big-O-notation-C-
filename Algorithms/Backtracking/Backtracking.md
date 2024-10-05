# Array Data Structure


Dynamic Programming is a method used in mathematics and computer science to solve complex problems by breaking them down into simpler subproblems.
By solving each subproblem only once and storing the results, it avoids redundant computations, leading to more efficient solutions for a wide range of problems. 
This article provides a detailed exploration of dynamic programming concepts, illustrated with examples.
    ![My Image](Assets/Dynamic.png)

## What is Dynamic Programming (DP)?
Dynamic Programming (DP) is a method used in mathematics and computer science to solve complex problems by breaking them down into simpler subproblems. 
By solving each subproblem only once and storing the results, it avoids redundant computations, leading to more efficient solutions for a wide range of problems.

## How Does Dynamic Programming (DP) Work?
- Identify Subproblems: Divide the main problem into smaller, independent subproblems.
- Store Solutions: Solve each subproblem and store the solution in a table or array.
- Build Up Solutions: Use the stored solutions to build up the solution to the main problem.
- Avoid Redundancy: By storing solutions, DP ensures that each subproblem is solved only once, reducing computation time.

## Examples of Dynamic Programming (DP)
Example 1: Consider the problem of finding the Fibonacci sequence:
```
Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, …
```
Brute Force Approach:
To find the nth Fibonacci number using a brute force approach, you would simply add the (n-1)th and (n-2)th Fibonacci numbers.
This would work, but it would be inefficient for large values of n, as it would require calculating all the previous Fibonacci numbers.
Dynamic Programming Approach:
                                Nth Term of Fibonacci Series
Here Fn denotes Nth Term of the Fibonacci
                                            <span style="color:green;">F4</span>
                                           /  \
                                          /    \
                                         /      \
                                       F3        F2
                                      /  \      /  \
                                     /    \    /    \
                                    F2    F1   F1   F0
                                   /  \                
                                 F1    F0                

Fibonacci Series using Dynamic Programming

