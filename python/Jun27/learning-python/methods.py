## Function types

# Function without parameters without return

def DisplayName():
    name = "mv"
    print("Hello",name)

# Function with parameters without return

def DisplayNameWithParameters(name):
    print("Hello",name)

# Function with parameters with return

def DisplayNameWithParametersAndReturn(name1):
    variable = "Hello "+ name1
    return variable

# Function without parameters with return

def DisplayNameWithReturn():
    variable = "mv"
    return variable


DisplayName()
name="vk"
DisplayNameWithParameters(name)
name1="mk"
returnedValue =DisplayNameWithParametersAndReturn(name1)
print(returnedValue)
secondReturnValue = DisplayNameWithReturn()
print(secondReturnValue)

