from cl311 import *

#ask coding techer debug problem
def main():
  try:
      des = (float(input("enter design time: ")))
      cod = (float(input("enter coding time: ")))
      deb = (float(input("enter debugging time: ")))
      test = (float(input("enter testing time: ")))
      thing = cl311(des, cod, deb, test)
      thing.calc()
      print(thing)
  except Exception as e:
    print("Error:", e)
    

if __name__ == "__main__":
  main()