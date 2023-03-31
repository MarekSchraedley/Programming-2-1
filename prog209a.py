def main():
  try:
    with open("data/prog215a.txt", 'r') as f: 
      less500 = 0
      more500 = 0
      for i in range(400):
        num = int(f.readline())
        
        if num < 500:
          less500 += 1
        if num >= 500:
          more500 += 1
      print(f"Numbers less than 500: {less500}  Greater than or equal to 500: {more500}  Total numbers: 400")
        
    
  except Exception as e:
    print("Error:", e)

if __name__ == "__main__":
  main()
    