"""

    Первое задание

Есть некоторый текст. Разработайте приложение, которое должно произвести поиск
слова. В результате работы приложения нужно отобразить количество раз, сколько
слово встречается в тексте.
При поиске необходимо учитывать следующие факторы:
■ поиск вне зависимости от регистра букв слова;
■ слово может быть отделено от других слов – пробелом, знаками препинания;
■ если слово есть в тексте, но в перевернутом виде, его надо учитывать в статистике поиска.

"""
print('\n\t', '-' * 43,
      '\n\t Введите "1" для выполнения пер-го задания\n\t'
      ' Введите "2" для выполнения вто-го задания\n\t'
      ' Введите "3" для выполнения тре-го задания\n\t Введите "4" для выполнения чет-го задания\n\t '
      'Введите "5" для выполнения пят-го задания\n\t', '-' * 43)
choice = int(input('\n\t Ваш выбор : '))

text = 'Good afternoon, would you like to drink a cup of tea aet?'
processed_text = text.lower()
word_list = []


def adding_words_from_text_in_list(txt):
    symbol = 0
    while symbol < len(txt):
        if txt[symbol].isalnum():
            symbol += 1
        else:
            if txt[:symbol].isalnum():
                word_list.append(txt[:symbol])
            txt = txt[symbol + 1:]
            symbol = 0
    return word_list


def replace_words(string, find_word, reserve_word):
    i = 0
    while i < len(find_word):
        string = string.replace(find_word[i], reserve_word[i])
        i += 1
    return string


def common_elements(list_1, list_2):
    index = 0
    list_1_index = 0
    list_2_index = 0
    general_list = []
    while list_1_index < len(list_1):
        while list_2_index < len(list_2):
            if list_1[list_1_index] == list_2[list_2_index]:
                general_list.append(list_2[list_2_index])
            list_2_index += 1
        list_1_index += 1
        list_2_index = 0

    while index < len(general_list):
        if general_list.count(general_list[index]) > 1:
            general_list.pop(index)
            index = 0
        else:
            index += 1
    return general_list


def is_prime(number):
    i = 2
    counter = 0
    while i < number:
        if number % i != 0:
            counter += 1
        i += 1
    return counter == number - 2


def task_1():
    research_of_word = input('\n\t Введите искомое слово : ').lower().strip()
    adding_words_from_text_in_list(processed_text)

    reversed_word = ''

    letter = len(research_of_word) - 1
    while letter >= 0:
        reversed_word += research_of_word[letter]
        letter -= 1

    counter = 0
    for word in word_list:
        if research_of_word == word or reversed_word == word:
            counter += 1
    print('\n\t Количество повторений слова в тексте : ', counter)


"""

    Второе задание

Добавить к первому заданию возможность поиска набора слов. Искомые слова нужно
хранить в списке.

"""


def task_2():
    words_list = ['', 'GOOD', 'Afternoon', 'tea']
    processed_words_list = []

    for words in words_list:
        processed_words_list.append(words.lower().strip())

    adding_words_from_text_in_list(processed_text)

    reversed_list_of_words = []

    for word in processed_words_list:

        reversed_word = ''
        letter = len(word) - 1
        while letter >= 0:
            reversed_word += word[letter]
            letter -= 1
        reversed_list_of_words.append(reversed_word)

    counter = 0
    for word in word_list:
        for words in processed_words_list:
            if words == word:
                counter += 1
        for reversed_words in reversed_list_of_words:
            if reversed_words == word:
                counter += 1

    print('\n\t Количество повторений слова в тексте : ',counter)
    return counter


def task_3():

    string = "Cat runs. Dog runs. CAT jumps."
    find_string = "cat, dog"
    reserve_string = "bird, fish"
    print("text: ", string)
    print("Search List: ", find_string)
    print("Replacement list: ", reserve_string)

    find_arr1 = find_string.lower()
    find_arr2 = find_string.title()
    find_arr3 = find_string.upper()

    find_arr1 = find_arr1.split(", ")
    find_arr2 = find_arr2.split(", ")
    find_arr3 = find_arr3.split(", ")

    reserve_arr1 = reserve_string.lower()
    reserve_arr2 = reserve_string.title()
    reserve_arr3 = reserve_string.upper()

    reserve_arr1 = reserve_arr1.split(", ")
    reserve_arr2 = reserve_arr2.split(", ")
    reserve_arr3 = reserve_arr3.split(", ")

    your_lower_str = string.lower()
    counter_arr = {}
    i = 0
    while i < len(find_arr1):
        counter_arr[i] = your_lower_str.count(find_arr1[i])
        i += 1

    i = 0
    while i < len(find_arr2):
        print(find_arr2[i], "/", reserve_arr2[i], ":", counter_arr.get(i))
        i += 1
    string = replace_words(string, find_arr1, reserve_arr1)
    string = replace_words(string, find_arr2, reserve_arr2)
    string = replace_words(string, find_arr3, reserve_arr3)

    print("Text after replacement: ", string)


def task_4():
    list_1 = [1, 2, 5, 4]
    list_2 = [2, 5]
    list_3 = [5, 6, 7, 1, 2]
    list_4 = [8, 2, 5]
    list_5 = []

    for element in list_1:
        list_5.append(element)
    for element in list_2:
        list_5.append(element)
    for element in list_3:
        list_5.append(element)
    for element in list_4:
        list_5.append(element)

    sorted_list = []

    print('\n\t 1)\n\t Список с элементами всех списков :', list_5)
    while len(list_5) != 0:
        sorted_list.append(max(list_5))
        list_5.remove(max(list_5))

    print('\t В отсортированном по убыванию виде :', sorted_list)

    list_1_2 = common_elements(list_1, list_2)
    list_1_2_3 = common_elements(list_1_2, list_3)
    list_1_2_3_4 = common_elements(list_1_2_3, list_4)

    for element in common_elements(list_1, list_2):
        try:
            while True:
                sorted_list.remove(element)
        except ValueError:
            pass
    for element in common_elements(list_1, list_3):
        try:
            while True:
                sorted_list.remove(element)
        except ValueError:
            pass
    for element in common_elements(list_1, list_4):
        try:
            while True:
                sorted_list.remove(element)
        except ValueError:
            pass
    for element in common_elements(list_2, list_3):
        try:
            while True:
                sorted_list.remove(element)
        except ValueError:
            pass
    for element in common_elements(list_2, list_4):
        try:
            while True:
                sorted_list.remove(element)
        except ValueError:
            pass
    for element in common_elements(list_3, list_4):
        try:
            while True:
                sorted_list.remove(element)
        except ValueError:
            pass

    print('\n\t 2)\n\t Уникальные элементы для всех четырех списков :', sorted_list)
    print('\n\t 3)\n\t Общие элементы для всех четырех списков :', list_1_2_3_4)

    for element in list_1:
        if is_prime(element):
            list_5.append(element)
    for element in list_2:
        if is_prime(element):
            list_5.append(element)
    for element in list_3:
        if is_prime(element):
            list_5.append(element)
    for element in list_4:
        if is_prime(element):
            list_5.append(element)

    print('\n\t 4)\n\t Список, состоящий из уникальных простых элементов :', common_elements(list_5, list_5))


def task_5():

    string = '12 + 4 - 5 - 3'.strip()

    num_str = []
    num_int = []
    operators = []

    for index in string:
        if index == '+' or index == '-':
            operators += [index]

    symbol = 0

    while symbol < len(string):
        if string[symbol].isalnum():
            if symbol == len(string) - 1:
                num_str.append(string[symbol])
            symbol += 1
        else:
            if string[:symbol].isalnum():
                num_str.append(string[:symbol])
            string = string[symbol + 1:]
            symbol = 0

    for number in num_str:
        num_int += [int(number)]

    result = num_int[0]

    for element in range(len(operators)):
        if operators[element] == '+':
            result += num_int[element + 1]
        elif operators[element] == '-':
            result -= num_int[element + 1]

    print("\n\t Результат :", result)


if choice == 1:
    task_1()
elif choice == 2:
    task_2()
elif choice == 3:
    task_3()
elif choice == 4:
    task_4()
elif choice == 5:
    task_5()
