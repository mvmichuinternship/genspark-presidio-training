# Inheritance Syntax
# class DerivedClassName(BaseClassName):
#     <statement-1>
#     .
#     .
#     .
#     <statement-N>

# Involves at least two classes
    ## Parent class or Base class --> derived from
    ## Child class or Derived class --> derived by

# Supports a form of multiple inheritance
    ## Two or more base class have same method name, then METHOD RESOLUTION ORDER is followed
    ## Leftmost base class method is called.

    #Example
class SuperClass1:
    def info(self):
        print("Super Class 1 method called")

class SuperClass2:
    def info(self):
        print("Super Class 2 method called")

class Derived(SuperClass1, SuperClass2):
    pass

d1 = Derived()
d1.info()  

# Example 
class Person:
  def __init__(self, fname, lname):
    self.firstname = fname
    self.lastname = lname

  def printname(self):
    print(self.firstname, self.lastname)

class Student(Person):
  def __init__(self, fname, lname):
    super().__init__(fname, lname)

x = Student("Mridula", "Vinod")
x.printname()