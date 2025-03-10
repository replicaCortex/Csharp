def Flowerbed(flowerbed, n):
    start, end = 0, 3
    flowerbed = [0] + flowerbed + [0]

    while n > 0 and end <= len(flowerbed):
        subflower = flowerbed[start:end]
        if 1 not in subflower:
            n -= 1
            flowerbed[(end + start) // 2] = 1

        start += 1
        end += 1

    if n == 0:
        return True

    return False


print(Flowerbed([1, 0, 0, 0, 1], 1))
print(Flowerbed([1, 0, 0, 0, 1], 2))
print(Flowerbed([0, 0, 1, 0, 1], 1))
print(Flowerbed([1, 0, 1, 0, 0, 1], 1))
