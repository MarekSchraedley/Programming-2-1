class Cl213f:
  def __init__(self, kwh):
    self.kwh = kwh
    self.cost = 0.0
    self.rate = 0.0
  def calc(self):
    if self.kwh <= 2000:
      self.rate = 0.07
    if self.kwh > 2000 and self.kwh <= 10000:
      self.rate = 0.05
    if self.kwh > 10000:
      self.rate = 0.04
    self.cost = round(self.kwh * self.rate, 2)
    pass

  def __str__(self):
    return f"The cost of {self.kwh} is {self.cost}"