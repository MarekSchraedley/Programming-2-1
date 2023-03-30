#ask coding teacher about error
from cl702q import *
def main():
  try:
    people = []
    with open("data/prog702q.txt", 'r') as f:
      num = int(f.readline())
      for i in range(52):
        name = f.readline()
        tires = int(f.readline())
        if num == 1:
          worth = float(f.readline())
          p = Car(name, tires, worth)
          people.append(p)
        elif num == 2:
          miles = int(f.readline())
          p = Truck(name, tires, miles)
          people.append(p)
        elif num == 3:
          city = f.readline().strip()
          p = Bus(name, tires, city)
          people.append(p)
        num = int(f.readline())
      storetruck = 0
      mountbus = 0
      totpeep = 0
      tot = 0.0
      cnt = 0
      totstus = 0
      large = ""
      tottire = 0
      sm ="gfffddsdgsfgfggffgfdfeeeeeeerffdsfgfdssfgsdfgdgfbaarbbebrergrbgbarabgabardarbdbragrbrarradrfrnrrgenerrrrrrrgbgrnneggsbnrnttyynnynysnyynsensrnyrn"
      smnum = 10000000000000
        #Finish reskinning from this point on and test
      for person in people:
        totpeep += 1
        if isinstance(person):
          tottire += person._tires 
        if isinstance(person, Car):
          tot += person.worth
        if isinstance(person, Truck):
          if 50000 - (person.miles * 0.25) < len(smnum):
            smnum = 50000 - (person.miles * 0.25)
          storetruck += 50000 - (person.miles * 0.25)
        if isinstance(person, Bus):
          mountbus += 1
          favW = person.city
          if len(favW) > len(large):
            large = favW
          if len(favW) < len(sm):
            sm = favW

    print("Total number of vehicles:", totpeep)
    print("total amount the cars are worth", tot)
    print("Total amount the vehicles are worth:", (mountbus*50000) + storetruck + tot)
    print("Largest home destination:", large)
    print("Least valued truck:", smnum)
    print("Tota number of tires:", tottire)
  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()