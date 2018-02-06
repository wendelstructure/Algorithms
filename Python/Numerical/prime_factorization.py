# Find the prime factors of a number

number = int(input("Enter a number:  "))
factors = []

while number % 2 == 0:
    factors.append(2)
    number /= 2

factor = 3

while factor * factor <= number:
    if number % factor != 0:
        factor += 2
        continue

    factors.append(factor)
    number /= factor

# number will now equal to the final prime factor as the square
# of the current factor is greater than number.  So we add the
# number to the list of factors.
factors.append(int(number))

print(f"Result:  {factors}")
