class cl311:

  def __init__(self, design, code, debug, test):
    self.design = design
    self.code = code
    self.debug = debug
    self.test = test
    self.total = 0.0

  def calc(self):
    self.total = self.design + self.code + self.debug + self.test
    self.design = 100 * (self.design / self.total)
    self.code = 100 * (self.code / self.total)
    self.debug = 100 * (self.debug / self.total)
    self.test = 100 * (self.test / self.total)

  def __str__(self):
    return f"Design: {self.design}% Code: {self.code}% Debug: {self.debug}% Test: {self.test}%"
