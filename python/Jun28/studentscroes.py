playerslist= []
n = int(input("Enter number of scores: "))
for i in range(n):
    score= int(input("Score: "))
    name= input("Name: ")
    playerslist.append((score, name))
playerslist.sort(reverse=True, key= lambda x: x[0])
for i in range(n if n<10 else 10):
    print(f"{i+1}. Score: {playerslist[i][0]} Name: {playerslist[i][1]}")