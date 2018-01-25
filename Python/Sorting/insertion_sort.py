sequence = [5, 4, 3, 2, 1]

print(f"Input:  {sequence}")

for index in range(1, len(sequence)):
    swapIndex = index

    while swapIndex >= 1 and sequence[swapIndex] < sequence[swapIndex - 1]:
        sequence[swapIndex], sequence[swapIndex - 1] = sequence[swapIndex - 1], sequence[swapIndex]
        swapIndex -= 1

print(f"Result:  {sequence}")