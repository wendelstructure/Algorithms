# Find the lowest common multiple of two numbers.
# The lowest common multiple of two numbers can be found by dividing the product
# of two numbers by their greatest common denominator.

num_1 = int(input("Enter a value for #1:  "))
num_2 = int(input("Enter a value for #2:  "))

product = num_1 * num_2

while num_2 != 0:
    num_1, num_2 = num_2, num_1 % num_2

print(f"Result:  {int(product / num_1)}")