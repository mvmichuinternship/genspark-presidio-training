
def extract_digits(number):
    return [int(digit) for digit in str(number)]

def has_unique_digits(number):
    digits = extract_digits(number)
    return len(digits) == len(set(digits))


def calculate_bulls_cows(secret_number, user_guess):
    bulls = 0
    cows = 0
    secret_digits = extract_digits(secret_number)
    guess_digits = extract_digits(user_guess)

    secret_count = {}
    guess_count = {}

    for s, g in zip(secret_digits, guess_digits):
        if s == g:
            bulls += 1
        else:
            secret_count[s] = secret_count.get(s, 0) + 1
            guess_count[g] = guess_count.get(g, 0) + 1

    for digit in guess_count:
        if digit in secret_count:
            cows += min(secret_count[digit], guess_count[digit])

    return [bulls, cows]

secret_number = int(input("Enter secret number: "))
attempts = int(input('Enter number of attempts: '))

while attempts > 0:
    user_guess = int(input("Enter your guess: "))

    if not has_unique_digits(user_guess):
        print("Number should not have repeated digits. Try again.")
        continue
    if user_guess < 1000 or user_guess > 9999:
        print("Enter a 4-digit number only. Try again.")
        continue

    bulls, cows = calculate_bulls_cows(secret_number, user_guess)
    print(f"{bulls} bulls, {cows} cows")
    attempts -= 1

    if bulls == 4:
        print("You guessed right!")
        break
else:
    print(f"You ran out of attempts. The number was {secret_number}")