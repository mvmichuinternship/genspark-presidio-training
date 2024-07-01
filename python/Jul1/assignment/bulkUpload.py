import csv
def bulkUpload(userData):
    text_file = '../files/bulkUpload.txt'
    try:
        with open(userData, 'r') as file:
            reader = csv.DictReader(file)
            with open(text_file, 'w') as output_file:
                for row in reader:
                    output_file.write(f"Name: {row['Name']}\n")
                    output_file.write(f"DOB: {row['DOB']}\n")
                    output_file.write(f"Age: {row['Age']}\n")
                    output_file.write(f"Email: {row['Email']}\n")
                    output_file.write(f"Phone: {row['Phone']}\n")
                    output_file.write("-" * 20 + "\n")  # Separator for each user
        print(f"Data from {userData} has been written to {text_file}")
    except Exception as e:
        print(f"Error occurred while processing {userData}: {e}")


userData = 'users.csv'
bulkUpload(userData)
