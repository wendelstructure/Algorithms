# Determines whether a number is prime.
# Pick a random value between 1 and the input.  I've chosen 2.
# If the random value raised to the power of the input minus 1
# is equal to one then the input is a prime number.
# The input must be greater than 2.

value = int(input("Enter a value:  "))
result = False

if value == 2:
    print("2 is a prime number")

for i in range(2, value):
    result = (i ** (value - 1)) % value == 1

    if not result:
        break

if result:
    print(f"{value} is a prime number.")
else:
    print(f"{value} is not a prime number.")
