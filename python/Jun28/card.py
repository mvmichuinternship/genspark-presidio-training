def isValid(cardNo):
    sum = 0
    is_second = False

    for i in range(len(cardNo) - 1, -1, -1 ):
        d = int(cardNo[i])
        if (is_second == True):
            d = d * 2
        sum += d // 10
        sum += d % 10
        is_second = not is_second
    return sum % 10 == 0

cardNo = input("Enter credit card number: ")

if (isValid(cardNo)):
    print("This is a valid card")
else:
    print("This is not a valid card")