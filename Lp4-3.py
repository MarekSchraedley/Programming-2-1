copies = int(input("enter number of eggs"))
copies = copies / 12
price = 0.0
if copies > 0 and copies < 4:
  price = 0.50
elif copies >= 4 and copies < 6:
  price = 0.45
elif copies >= 6 and copies < 11:
  price = 0.40
elif copies >= 11:
  price = 0.35
else:
  print("the number of eggs is invalid")

print("Price per dozen is: $" + str(price))
print("Total cost is: $" + str(round(price * copies, 2)))