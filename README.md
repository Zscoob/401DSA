# 401DSA
401 .NET Core, React DSA
# Problem 4: Sum of Rows
Problem Statement
Given a matrix of integers. Return the sum of each row in a single dimensional array.

Input Format
a multidimensional array with the dimensions of m x n (m = rows, n = columns).

duplicate integers are possible.
Negative numbers are possible
both m and n can vary in length
The user should specify the length and the width of the array within the console. To populate the numbers, you may randomly generate them, or have the user input one by one.

The method should take in the multidimensional array and return the single dimensional array with the sums

Sample Input
int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
^^ The actual input would just be myArray, but the above code shows the pre-initialization before the method is called.

Sample Output
{15,40,65} <– an integer array

HINTS
for loops are your best friend
GetLength() is a method you should look into
i.e. in the array above myArray.GetLength(0) is equal to 3
myArray.GetLength(1) is equal to 5
Readme
A section of your readme should contain basic information outlining the requirements for the challenge

Name of Challenge
Instructions of Challenge
Screen capture of successful output.