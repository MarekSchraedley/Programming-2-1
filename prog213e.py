def main():
  try:
    ages = []
    with open("data/prog213e.dat", 'r') as f:
      for i in range(23):
        age = f.readline()
        age = int(age)
        ages.append(age)
        pass
    less20 = 0
    num20t39 = 0
    num40t59 = 0
    num60t79 = 0
    great79 = 0
    for age in ages:
      if age < 20:
        less20 += 1
      if age >= 20 and age <= 39:
        num20t39 += 1
      if age >= 40 and age <= 59:
        num40t59 += 1
      if age >= 60 and age <= 79:
        num60t79 += 1
      if age > 79:
        great79 += 1
    sum = less20 + num20t39 + num40t59 + num60t79 + great79
    print(f"<20\t\t{less20}\t{round(less20/sum, 2)}")
    print(f"20-39\t{num20t39}\t{round(num20t39/sum, 2)}")
    print(f"40-59\t{num40t59}\t{round(num40t59/sum, 2)}")
    print(f"60-79\t{num60t79}\t{round(num60t79/sum, 2)}")
    print(f">79\t\t{great79}\t{round(great79/sum, 2)}")
        
  except Exception as e:
    print("Error:", e)
    
    
      
      

if __name__ == "__main__":
  main()