import random
import numpy as np




def printMatrix(mat):
  for row in mat:
    for num in row:
      print(f"{num:3d} ", end="")
    print()


def main():
  mat1 = []
  for r in range(5):
    row1 = []
    for c in range(5):
      rnd1 = random.randint(-50, 99)
      row1.append(rnd1)
    mat1.append(row1)

  print("Matrix 1:")
  printMatrix(mat1)
  trans1 = []
  for r in range(5):
    trow1 = []
    for c in range(5):
      trow1.append(mat1[c][r])
    trans1.append(trow1)
      
    
  print("\nTransposed Elements:")
  printMatrix(trans1)
  


if __name__ == "__main__":
  main()

