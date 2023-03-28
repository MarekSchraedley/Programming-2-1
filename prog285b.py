from cl285b import Salesperson
#does not work,
def main():
  try:
    with open("data/prog285b.dat", 'r') as f:
      for line in f:
        ldata = line.split(" ")
        id = int(ldata[0])
        code = int(ldata[1])
        sales = float(ldata[2])

        #option 2
        id, code, sales = [float(x) for x in line.split(" ")]

        seller = Salesperson(id, code, sales)
        seller.setComm() 
        print(str(seller))
        
  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()