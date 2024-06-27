# 5) Add validation the entered  name, age, date of birth and phone print details in proper format
print("Enter your name")
name = input()
while(len(name)<2 or len(name)>30):
    print("Please enter valid name")
    name=input()
print("Please enter age")
age= int(input())
while(age<5 or age>80):
    print("Please enter valid age")
    age= int(input())
print("Please enter dob")
dob=input()

print("Please enter phone")
phone=input()
while(len(phone)<10 or len(phone)>10):
    print("Phone needs to have 10 digits")
    phone=input()

print("Name\tAge\tDOB\t\tPhone\t")
print(name,"\t",age,"\t",dob,"\t",phone)
