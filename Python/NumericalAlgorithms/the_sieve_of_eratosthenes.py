# Generates a list of prime numbers

value = int(input("Enter a value:  "))
values = list(range(2, value + 1))

print(f"Input:  {values}")

for i in values:
    for j in values:
        if j > i and j % i == 0:
            values.remove(j)

print(f"Result:  {values}")