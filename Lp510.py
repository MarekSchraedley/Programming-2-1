num1 = float(input("input a number: "))
num2 = float(input("input a second number: "))
while num2 > 0:
  temp = num1 % num2
  num1 = num2
  num2 = temp
print("the gcd is " + str(num1))
# python Lp510.py
#ASK for help tmrw