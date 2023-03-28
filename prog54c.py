from Class54c import *
#finish
def main():
  try:
      rad = float(input("enter radius: "))
      circle = Class54c(rad)
      circle.calc()
      print(circle)
  except Exception as e:
    print("Error:", e)
    

if __name__ == "__main__":
  main()
  