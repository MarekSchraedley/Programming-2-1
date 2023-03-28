lines = ["hello, ", "World", "!"]

with open("data/myfile.txt", 'w') as f:
  f.write("Hieee \n")
  f.writelines(lines)

with open("data/myfile.txt", 'r') as f:
  print(f.read())