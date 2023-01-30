import random
number = random.randint(1, 20)
x = input("Pick a number between 1 and 20 inclusive")
print("Your Number: " + str(x))
print("Random Number: " + str(number))
if x == number:
  print("You Won!")
else:
  print("You Lost.")
