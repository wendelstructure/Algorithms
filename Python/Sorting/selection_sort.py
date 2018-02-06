input_sequence = "7 5 8 3 2 1"

def convert_sequence_to_list(str_sequence):
    return list(map(int, str_sequence.split()))

def default():
    sequence = convert_sequence_to_list(input_sequence)
    sorted_sequence = []
    i = 0

    while len(sequence) > 0:
        lowest = sequence[i]
        lowest_index = i
        j = 1

        while j < len(sequence):
            if lowest > sequence[j]:
                lowest = sequence[j]
                lowest_index = j

            j += 1

        sorted_sequence.append(lowest)
        del sequence[lowest_index]
        i = 0

    print("Selection Sort(Default)")
    print(f"Input:  {input_sequence}")
    print(f"Result:  {' '.join(str(x) for x in sorted_sequence)}")

def in_place():
    sequence = convert_sequence_to_list(input_sequence)
    length = len(sequence)
    i = 0

    while i < length:
        lowest = sequence[i]
        lowest_index = i
        j = i + 1

        while j < length:
            if lowest > sequence[j]:
                lowest = sequence[j]
                lowest_index = j

            j += 1

        sequence[i], sequence[lowest_index] = sequence[lowest_index], sequence[i]
        i += 1

    print("Selection Sort(In-Place)")
    print(f"Input:  {input_sequence}")
    print(f"Result:  {' '.join(str(x) for x in sequence)}")

default()
print()
in_place()

