# 10) Print a pyramid of starts for the number of rows specified
n=int(input())
for i in range(1, n + 1):
    for j in range(n - i):
        print(" ", end="")
    for k in range(1, 2*i):
        print("*", end="")
    print()
