from calcfunctions import *
def hw():
  print("hello world")
def printNums():
  x=0
  while x < 10:
    print("x:", x)
    x += 1

def main():
  hw()
  q, r = divmod2(5, 10)
  print(q, r)

if __name__ == "__main__":
  main()