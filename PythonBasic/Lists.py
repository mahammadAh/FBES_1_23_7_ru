# num = 10
# num_1:int= 5
#
# print(num_1)
#
# names = ['Anar','Ali','Lala']
# print(type(names))
# surnames = list(('Mamedova','Abbasov','Aliyev'))
# print(type(surnames))
# print(names)
#
#
# # перебор списка при помощи цикла
# for name in names:
#     print(name)
#
# # проверка на вхождение заданного значения в список
# if 'Ali' in names:
#     print("YES!")
#
#
# # длина списка
# print(len(names))
#
# numbers = [10,15,20,44,32]
#
# # min,max,sum
# print(min(numbers))
# print(max(numbers))
# print(sum(numbers))
#
# products = ["Pen","Notebook",783495,"Razer"]
# for item in products:
#     print(item)
#
#
# new_products = products
#
# print(products)
# print(new_products)
#
# new_products[1] = 'Book'
# print("NEW_PRODUCTS : ",new_products)
# print("PRODUCTS : ",products)


# fruits = []
# print(fruits)
#
# # append
# fruits.append("Cherry")
# fruits.append("Apple")
# fruits.append("Watermelon")
# fruits.append("Apple")
# print(fruits)
#
# print(fruits[1])
# # возвращает индекс или ValueError
# print(fruits.index("Apple"))
#
# # возвращает количество вхождений
# print(fruits.count("Apple"))
#
# # удаляет указанное значение
# fruits.remove("Watermelon")
# print(fruits)
#
# #fruits.clear()
# #print(fruits)
#
# # добавляет по заданному индексу
# fruits.insert(1,"Melon")
# print(fruits)
#
# fruits.reverse()
# print(fruits)
#
# fruits.sort()
# print(fruits)
#
# fruits_new = fruits.copy()
#
#
#
# print(fruits)
# print(fruits_new)
#
# fruits[2]= "Berry"
#
# print(fruits)
# print(fruits_new)

# генератор списков
i=0
numbers = [i*i for i in range(10) if i%2==0]
print(numbers)

numbers_1 = []
for i in range(10):
    if i%2==0:
        numbers_1.append(i*i)
print(numbers_1)


matrix = [["Ali",9,11,10],["Sevinc",7,8,11,12],["Anar",7,8,3,4]]

for list in matrix:
    for el in list:
        print(el,end=" ")
    print("Max Mark : ",max(list[1:]))
    print()


names = ["Ali","Anar"]
print(id(names))
names.append("Vuqar")
print(id(names))
