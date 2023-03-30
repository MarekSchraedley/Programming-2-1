class Person:
  def __init__(self, name, tires):
    self._name = name
    self._tires = tires

  def getName(self):
    return self._name

class Car(Person):
  def __init__(self, name, tires, worth):
    super().__init__(name, tires)
    self.worth = worth

class Truck(Person):
  def __init__(self, name, tires, miles):
    super().__init__(name, tires)
    self.miles = miles

class Bus(Person):
  def __init__(self, name, tires, city):
    super().__init__(name, tires)
    self.city = city
  