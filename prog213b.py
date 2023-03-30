def main():
  try:
    ages = []
    with open("data/prog213b.txt", 'r') as f: 
      for i in range(15):
        num = int(f.readline())
        cost = 0
        value = 0
        if num <= 99:
          cost = 5.95
        if num >= 100 and num <= 199:
          cost = 5.75
        if num >= 200 and num <= 299:
          cost = 5.40
        if num >= 300:
          cost = 5.15
        value = num * cost
        print(f"Quantity:{num}  Price:{cost}  Amount Due:{round(value, 2)}")
        
    
  except Exception as e:
    print("Error:", e)
    
    
      
      

if __name__ == "__main__":
  main()