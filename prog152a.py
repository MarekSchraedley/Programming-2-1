import sys
sys.setrecursionlimit(5000)
def fact(s, f, inc):
  if f == s: return s
  return s + fact(s+inc, f, inc)

def main():
  factn = fact(3, 9669, 3)
  print(factn)
if __name__ == "__main__":
  main()