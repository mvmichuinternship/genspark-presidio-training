# Basic if else

num=1
if num%2==0:
    print("Even")
else:
    print("Odd")

# if - elif - else

var = 10
if var>0:
    print("Positive")
elif var<0:
    print("Negative")
else:
    print("Zero")

# nested conditionals
number = 21

if number%7==0:
    if number%3==0:
        print("Number is divisible by both 3 and 7")
    else:
        print("Number is divisible only by 7")
else:
    if number%3==0:
        print("Number is divisible only by 3")
    else:
        print("Number is not divisible by both 3 and 7")

