# Syntax

# class ClassName:
#     id=100

#     def function1(self):
#         return 'Hello World'
    
# Operations supported by class objects
    ## Instantiation --> objName = className() 
    ##               --> automatically invokes __self__ method (constructor)
    ##               --> objName = className(parameter1, parameter2,...parameterN)
    ##               --> invokes __self__ method that has corresponding paramters

    ## Attribute reference --> objName.attribute1       --(1)
    ##                     --> objName.attribute2()     --(2)
    ##                     --> className.attribute2(objName)     --(3)
        ## Types of valid attributes
        ##      --> data attributes
        ##      --> methods

# Example

class Person:
  def __init__(self, name, age):
    self.name = name
    self.age = age
  def __str__ (self):                       ## returns directly to obj instance so method call not required
    return f"{self.name}({self.age})"       
  def functionPerson(self):
    return f"{self.name}({self.age})"
p1 = Person("John", 36)
print(p1.functionPerson())

print(p1)


