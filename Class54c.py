class Class54c:
  def __init__(self, rad):
    self.radius = rad
    self.area = 0.0
    self.circum = 0.0
    self.pi = 3.14159
  def calc(self):
    self.area = self.pi * self.radius ** 2
    self.circum = 2 * self.pi * self.radius
    
  def __str__(self):
    return f"Radius: {self.radius} Area: {self.area} Circumference: {self.circum}"
    
    