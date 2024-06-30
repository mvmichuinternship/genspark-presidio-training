string = input()
dict1= {}
currentstr= ""
longestSubString= ""
for i in string:
    if i in dict1:
        dict1={}
        currentstr= ""
    dict1[i]=1
    currentstr+=i
    longestSubString = currentstr if len(currentstr)>len(longestSubString) else longestSubString

print(longestSubString)