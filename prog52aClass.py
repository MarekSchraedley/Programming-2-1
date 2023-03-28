class Shape:
  #constructor: set up class data
  def __init__(self, length, width):
    self.length = length
    self.width = width
    self._area = 0 # _ prefix means private, so it should only
    self._perim = 0 #  be called in the class.

  def calculate(self):
    self._area = self.length * self.width
    self._perim = 2 * self.length + 2 * self.width
  #acessor/getters: return class data
  def getArea(self):
    return self.area

  def getPerimiter(self):
    return self.perim

def main():
  len = int(input("Enter Length: "))
  wid = int(input("Enter Width: "))
  shape = Shape(len, wid) #call shape data
  #shape.setLength(5)
  shape.calculate()
  print("Area:", shape.getArea())
  print("Perimiter:", shape.getPerimiter())

if __name__ == "__main__":
  main()
    
    