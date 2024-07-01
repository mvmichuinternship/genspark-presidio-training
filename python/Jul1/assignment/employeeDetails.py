from datetime import date
import pandas as pd
from fpdf import FPDF

class Employee:
    def __init__(self,name,day,month,year,email, phone):
        self.name = name
        self.dob=date(year, month, day)
        self.age = date.today().year - self.dob.year 
        self.phone=phone
        self.email = email

    
        
    def __str__ (self):                      
        return f"Name\t{self.name}\nAge\t{self.age}\nEmail\t{self.email}\nPhone\t{self.phone}"


def validateEmail(email):
    if len(email) == 0:
        return False
    return True

def validateDay(day):
    if day >31 or day<1:
        return False
    return True

def validateMonth(month):
    if month > 12 or month<1:
        return False
    return True

def validateYear(year):
    if year <= 1900:
        return False
    return True

def validateName(name):
    if len(name) < 2:
        return False
    return True

def validatePhone(phone):
    if len(phone) != 10:
        return False
    return True

def getDetails():

    name = input("Please enter name: ")
    while not validateName(name):
        print("Invalid entry for name")
        name = input("Please enter name: ")

    year = int(input("Please enter Year of Birth: "))
    while not validateYear(year):
        print("Invalid entry for year")
        year = input("Please enter Year of Birth: ")

    month = int(input("Please enter Month of Birth: "))
    while not validateMonth(month):
        print("Invalid entry for month")
        month = input("Please enter Month of Birth: ")

    day = int(input("Please enter Day of Birth: "))
    while not validateDay(day):
        print("Invalid entry for day")
        day = input("Please enter Day of Birth: ")

    email = input("Please enter email: ")
    while not validateEmail(email):
        print("Invalid entry for email")
        email = input("Please enter email: ")

    phone = input("Please enter phone: ")
    while not validatePhone(phone):
        print("Invalid entry for phone")
        phone = input("Please enter phone: ")


    emp1 = Employee(name,day,month,year,email,phone) 
    # print(emp1)
    return emp1

def storeExcel(employee):
    excelFile = './files/data.xlsx'
    try:
        # Try to load existing Excel file, if it exists
        df = pd.read_excel(excelFile)
    except FileNotFoundError:
        # If file doesn't exist, create a new DataFrame
        df = pd.DataFrame(columns=['Name', 'DOB','Age', 'Email', 'Phone'])

    # Append new data to the DataFrame
    new_row = {
        'Name': employee.name,
        'DOB': employee.dob,
        'Age': employee.age,
        'Email': employee.email,
        'Phone': employee.phone
    }
    df = pd.concat([df,pd.DataFrame([new_row])], ignore_index=True)

    # Write DataFrame back to Excel file
    df.to_excel(excelFile, index=False,engine='xlsxwriter')
    print(f"Data for {employee.name} has been appended to {excelFile}")

def storeText(employee):
    textFile = './files/data.txt'
    try:
        # Open the text file in append mode
        with open(textFile, 'a') as file:
            # Write employee data as a formatted string
            file.write(f"Name: {employee.name}\n")
            file.write(f"DOB: {employee.dob}\n")
            file.write(f"Age: {employee.age}\n")
            file.write(f"Email: {employee.email}\n")
            file.write(f"Phone: {employee.phone}\n")
            file.write("-" * 20 + "\n")  # Separator for each employee
        print(f"Data for {employee.name} has been appended to {textFile}")
    except Exception as e:
        print(f"Error occurred while writing to {textFile}: {e}")

def storePdf(employee):
    pdf = FPDF()
    
    pdf.add_page()
    
    pdf.set_font("Arial", size=12)
    
    pdf.cell(200, 10, txt="Employee Information", ln=True, align='C')
    
    pdf.ln(10)
    
    pdf.cell(200, 10, txt=f"Name: {employee.name}", ln=True)
    pdf.cell(200, 10, txt=f"DOB: {employee.dob}", ln=True)
    pdf.cell(200, 10, txt=f"Age: {employee.age}", ln=True)
    pdf.cell(200, 10, txt=f"Email: {employee.email}", ln=True)
    pdf.cell(200, 10, txt=f"Phone: {employee.phone}", ln=True)
    
    pdf.output(f"./files/employee_info.pdf")


choice=1

while(choice!=0):
    choice = int(input("1.\tEnter Employee details\n2.\tStore in text document\n3.\tStore in pdf document\n4.\tStore in excel document\n0.\tExit\n Please Choose a number:"))
    if(choice==0):
        break
    if(choice==1):
        employee=getDetails()
    if(choice==2):
        storeText(employee)
    if(choice==3):
        storeExcel(employee)
    if(choice==4):
        storePdf(employee)
    else:
        print("Invalid entry")
        break