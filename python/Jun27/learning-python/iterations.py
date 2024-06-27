#Iterators can be used on any iterables : strins, lists, tuples

# for loop : Entry control

name = "Mridula"

for i in name:
    print(i)

## range function 
# Syntax : range(start, stop, step)
for i in range(1,5,1):
    print(i)
## Using len and range with strings
length = len(name)
for i in range(1,length,2):
    print(name[i])


# while loop : Exit Control

num = 5
while num>0:
    print(num)
    num-=1




