"""
Два списка целых заполняются случайными числами.
Необходимо:
■ Сформировать третий список, содержащий элементы
обоих списков;
■ Сформировать третий список, содержащий элементы
обоих списков без повторений;
■ Сформировать третий список, содержащий элементы
общие для двух списков;
■ Сформировать третий список, содержащий только
уникальные элементы каждого из списков;
■ Сформировать третий список, содержащий только
минимальное и максимальное значение каждого из
списков.
"""
import random

main_list_1 = []
main_list_2 = []
minor_list_1 = []
minor_list_2 = []
minor_list_3 = []
minor_list_4 = []
minor_list_5 = []

lenght = random.randint(10,20)

for i in range(lenght):
    element_1 = random.randint(-30, 30)
    main_list_1.append(element_1)
    element_2 = random.randint(-30, 30)
    main_list_2.append(element_2)
    if element_1 == element_2:
        minor_list_1.append(element_1, element_2)
        minor_list_2.append(element_1)
    if element_1 != element_2:
        minor_list_3.append(element_1)
    if element_2 != element_1:
        minor_list_4.append(element_2)

minor_list_1.append(main_list_1)
minor_list_1.append(main_list_2)
minor_list_5.append(min(main_list_1))
minor_list_5.append(min(main_list_2))
minor_list_5.append(max(main_list_1))
minor_list_5.append(max(main_list_2))

print("Первый список", main_list_1)
print("Второй список", main_list_2)
print("список, содержащий элементы обоих списков", minor_list_1)
print("список, содержащий элементы обоих списков без повторени", minor_list_2)
print(minor_list_3)
print(minor_list_4)
print(minor_list_5)
