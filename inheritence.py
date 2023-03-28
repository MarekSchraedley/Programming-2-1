class Animal:
  def __init__(self, name, age):
    self.name = name
    self.age = age

  def sayHi(self):
    print("Hi")

class Cat(Animal):
  def __init__(self, name, age, sound):
    #Animal.__init__(name, age)
    super().__init__(name, age)
    self.sound = sound

def saySound(self):
  print(self.sound)

cat = Cat("Billy", 5, "Meow")
cat.sayHi()
cat.saySound()