# httpMath

Simple project to demonstrate GET method capabilities.

It can;

add
subtract
multiply
divide and
calculate modulus for firstName and secondName and operation as query and does according operations.

Usage:
localhost/?firstNumber={first number input here}&secondNumber={second number input here}&operation={operation here}

It accepts; "add","-","*","%","/" as operations. "+" acts as a space character and browsers dont interpret it as a "+" operator so I switched it to "add".

Example:

localhost/?firstNumber=4&secondNumber=2&operation=-

Output:
first num is: 4
second num is: 2
The result is: 2
