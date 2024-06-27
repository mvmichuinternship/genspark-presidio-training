# 7) Take 10 numbers and find the average of all the prime numbers in the collection

count=0
sum=0
c=0
while count<10:
    flag=0
    num=int(input())
    for i in range(2,num):
        if(num%i==0):
            flag=0
            break
        else:
            flag=1
    if num==2:
        flag=1
    if flag==1:
        sum+=num
        c+=1
    count+=1
avg = sum//c
print("Average", avg)
