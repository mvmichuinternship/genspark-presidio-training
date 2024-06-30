n=int(input())
primenums= []
def isPrime(k):
    for j in range(2,k//2 +1):
        if(k%j==0):
            return False
    return True

for i in range(2,n+1):
    if(isPrime(i)):
        primenums.append(i)
print(primenums)