# 9) Find All Permutations of a given string

def permutation(string, i=0):

    if i == len(string):   	 
        print("".join(string))

    for j in range(i, len(string)):

        words = list(string)
   
        words[i], words[j] = words[j], words[i]
   	 
        permutation(words, i + 1)

msg = input()
print(permutation(msg))