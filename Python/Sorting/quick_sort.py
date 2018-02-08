def quick_sort(array: list, left: int, right: int):
    if left >= right:
        return

    pivot_value = array[(left + right) // 2]
    pivot_index = partition(array, left, right, pivot_value)

    quick_sort(array, left, pivot_index - 1)
    quick_sort(array, pivot_index, right)

def partition(array: list, left: int, right: int, pivot_value: int) -> int:
    while left <= right:
        while array[left] < pivot_value:
            left += 1

        while array[right] > pivot_value:
            right -= 1

        if left > right:
            continue

        array[left], array[right] = array[right], array[left]
        left += 1
        right -= 1

    return left

def main():
    str_seq = "7 8 5 1 6 5 8 3 5 1 6 8 7 3 1 2 6 7 6 4 1 6 5 4 6 4 6 5 4"
    seq = list(map(int, str_seq.split()))

    quick_sort(seq, 0, len(seq) - 1)

    print(f"Input:  {str_seq}")
    print(f"Result:  {' '.join(str(x) for x in seq)}")

if __name__ == "__main__": 
    main()