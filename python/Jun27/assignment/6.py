# 6) Find if the given number is prime

num = int(input())
flag=0
for i in range(2,num):
    if(num%i==0):
        flag=0
        break
    else:
        flag=1
        
if(flag==1):
    print("Prime")
elif(num==2):
    print("Prime")
else:
    print("Not Prime")