# Array Data Structure


<strong>Dynamic Programming</strong> is a method used in mathematics and computer science to solve complex problems by breaking them down into simpler subproblems.
By solving each subproblem only once and storing the results, it avoids redundant computations, leading to more efficient solutions for a wide range of problems. 
This article provides a detailed exploration of dynamic programming concepts, illustrated with examples.
    ![My Image](Assets/Dynamic.png)

## What is Dynamic Programming (DP)?
<strong>Dynamic Programming (DP)</strong> is a method used in mathematics and computer science to solve complex problems by breaking them down into simpler subproblems. 
By solving each subproblem only once and storing the results, it avoids redundant computations, leading to more efficient solutions for a wide range of problems.

## How Does Dynamic Programming (DP) Work?
- <strong>Identify Subproblems:</strong> Divide the main problem into smaller, independent subproblems.
- <strong>Store Solutions:</strong> Solve each subproblem and store the solution in a table or array.
- <strong>Build Up Solutions:</strong> Use the stored solutions to build up the solution to the main problem.
- <strong>Avoid Redundancy:</strong> By storing solutions, DP ensures that each subproblem is solved only once, reducing computation time.

## Examples of Dynamic Programming (DP)
<strong>Example 1:</strong> Consider the problem of finding the Fibonacci sequence:
```
Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, …
```
<strong>Brute Force Approach:</strong>
To find the nth Fibonacci number using a brute force approach, you would simply add the <strong>(n-1)th</strong> and <strong>(n-2)th</strong> Fibonacci numbers.
This would work, but it would be inefficient for large values of n, as it would require calculating all the previous Fibonacci numbers.
<strong>Dynamic Programming Approach:</strong>
                                Nth Term of Fibonacci Series
Here Fn denotes Nth Term of the Fibonacci
                                            F4
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

- <strong>Subproblems:</strong> F(0), F(1), F(2), F(3), …
- <strong>Store Solutions:</strong> Create a table to store the values of F(n) as they are calculated.
- <strong>Build Up Solutions:</strong> For F(n), look up F(n-1) and F(n-2) in the table and add them.
- <strong>Avoid Redundancy:</strong> The table ensures that each subproblem (e.g., F(2)) is solved only once.

By using DP, we can efficiently calculate the Fibonacci sequence without having to recompute subproblems.
<strong>Example 2:</strong> Longest common subsequence (finding the longest subsequence that is common to two strings)
<strong>Example 3:</strong> Shortest path in a graph (finding the shortest path between two nodes in a graph)
<strong>Example 4:</strong> Knapsack problem (finding the maximum value of items that can be placed in a knapsack with a given capacity)

## When to Use Dynamic Programming (DP)?
Dynamic programming is an optimization technique used when solving problems that consists of the following characteristics:
1. Optimal Substructure:
Optimal substructure means that we combine the optimal results of subproblems to achieve the optimal result of the bigger problem.
<strong>Example:</strong>
```
Consider the problem of finding the minimum cost path in a weighted graph from a source node to a destination node. We can break this problem down into smaller subproblems:
- Find the minimum cost path from the source node to each intermediate node.
- Find the minimum cost path from each intermediate node to the destination node.
The solution to the larger problem (finding the minimum cost path from the source node to the destination node) can be constructed from the solutions to these smaller subproblems.
```
2. Overlapping Subproblems:
The same subproblems are solved repeatedly in different parts of the problem.
<strong>Example:</strong>
```
Consider the problem of computing the Fibonacci series.
To compute the Fibonacci number at index n, we need to compute the Fibonacci numbers at indices n-1 and n-2.
This means that the subproblem of computing the Fibonacci number at index n-1 is used twice in the solution to the larger problem of computing the Fibonacci number at index n.
```

## Approaches of Dynamic Programming (DP)
Dynamic programming can be achieved using two approaches:
<strong>1. Top-Down Approach (Memoization):</strong>
In the top-down approach, also known as <strong>memoization</strong>, we start with the final solution and recursively break it down into smaller subproblems.
To avoid redundant calculations, we store the results of solved subproblems in a memoization table.
Let’s breakdown Top down approach:
- Starts with the final solution and recursively breaks it down into smaller subproblems.
- Stores the solutions to subproblems in a table to avoid redundant calculations.
- Suitable when the number of subproblems is large and many of them are reused.

<strong>2. Bottom-Up Approach (Tabulation):</strong>
In the bottom-up approach, also known as <strong>tabulation</strong>, we start with the smallest subproblems and gradually build up to the final solution.
We store the results of solved subproblems in a table to avoid redundant calculations.
Let’s breakdown Bottom-up approach:

- Starts with the smallest subproblems and gradually builds up to the final solution.
- Fills a table with solutions to subproblems in a bottom-up manner.
- Suitable when the number of subproblems is small and the optimal solution can be directly computed from the solutions to smaller subproblems.

## Dynamic Programming (DP) Algorithm
Dynamic programming is a algorithmic technique that solves complex problems by breaking them down into smaller subproblems and storing their solutions for future use.
It is particularly effective for problems that contains overlapping subproblems and <strong>optimal substructure.</strong>
<strong>Common Algorithms that Use Dynamic Programming:</strong>

- <strong>Longest Common Subsequence (LCS):</strong> Finds the longest common subsequence between two strings.
- <strong>Shortest Path in a Graph:</strong> Finds the shortest path between two nodes in a graph.
- <strong>Knapsack Problem:</strong> Determines the maximum value of items that can be placed in a knapsack with a given capacity.
- <strong>Matrix Chain Multiplication:</strong> Optimizes the order of matrix multiplication to minimize the number of operations.
- <strong>Fibonacci Sequence:</strong> Calculates the nth Fibonacci number.

## Advantages of Dynamic Programming (DP)
Dynamic programming has a wide range of advantages, including:
- Avoids recomputing the same subproblems multiple times, leading to significant time savings.
- Ensures that the optimal solution is found by considering all possible combinations.
- Breaks down complex problems into smaller, more manageable subproblems.

## Applications of Dynamic Programming (DP)
Dynamic programming has a wide range of applications, including:

- <strong>Optimization:</strong> Knapsack problem, shortest path problem, maximum subarray problem
- <strong>Computer Science:</strong> Longest common subsequence, edit distance, string matching
- <strong>Operations Research:</strong> Inventory management, scheduling, resource allocation

For more explanation check out this info:
https://www.geeksforgeeks.org/dynamic-programming/