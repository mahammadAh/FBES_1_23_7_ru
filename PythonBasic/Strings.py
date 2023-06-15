# срезы

# str =  "I love Python . Python is the best !"
# str_code = "Iqwe ifolgkiojdfvplde"
# print(str[2:6])
# print(str_code[::4])
# print(str[10:])
# print(str[:10])

# name = "Jhon"
# surname = "Travolta"
#
#print("My name is {} My Surname is {}".format(name,surname))
#
# str_1 = "My name is {} My Surname is {}".format(name,surname)
#
# str_1 = "My name is {1} My Surname is {0}".format(name,surname)
#
# str_1 = "My name is {person_name} My Surname is {person_surname}".format(person_surname=surname,person_name= name)
#
# print(str_1)


str_2 = R"I love Python  Python is the best !" # экранизация строки
print(str_2)

# методы строк

print(str_2.capitalize())

print(str_2.center(45,"*"))
car_name = "I"
print(str_2.startswith("{}".format(car_name)))
print(str_2.endswith(""))

str_2 = "KorogluRehimov70"
print(str_2.isalnum()) # true - если только буквы и цифры
str_2 = "70"
print(str_2.isdigit())
str_2 = "KorogluRehimov"
print(str_2.isalpha())

str_2 = "  Hello World   "
print(str_2.strip())  # удалить с начала и конца подстроку



