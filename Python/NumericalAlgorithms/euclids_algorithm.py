#Calculate the greatest common denominator of two numbers.

first = int(input("Enter a value for the first number:  "))
second = int(input("Enter a value for the second number:  "))

while second != 0:
    first, second = second, first % second

print(f"Result:  {first}")

