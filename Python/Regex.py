import re
import string
import random
# \d  \d\d\d

# search - ищет по указанному паттерну во всей строке до первого вхождения
# findall - ищет все вхождения по указанному паттерну без перекрытия
# match
# str_1 = "123New 256Bytes8657"
#
# result = re.search(r'\d\d\d',str_1)
# print(result)
# print(result.group())




#
# result = re.findall(r'\d\d\d',str_1)
# print(result)
# print(result[0])
#
# result = re.match(r'\d\d\d',str_1)
# print(result)


# str_2 = "www.dotnet123.org"
# pattern = r'\d{3}'
#
# result = re.search(pattern,str_2)
# print(result)
#
# pattern = r'\w{3}'
# result = re.match(pattern,str_2)
# print(result)
#
# str_2 = "bbb?78333"
# str_3 = "hvd!912"
#
# pattern = r'\w{3}\W\d{2,5}'
# result = re.match(pattern,str_2)
# print(result)
# result = re.match(pattern,str_3)
# print(result)
#
# str_2 = "abcdas"
# pattern = r'[a-z]{4,7}\W'
# result = re.match(pattern,str_2)
# print(result)
#
# print(string.ascii_letters)
# print(string.ascii_lowercase)
# print(string.ascii_uppercase)
# print(string.digits)
# print(string.punctuation)
#
# # 9 символов букв в нижнем регистре , цифры и знаки
#
# symbs = string.ascii_lowercase+string.digits + string.punctuation
# print(symbs)
# password_1 = "".join(random.sample(symbs,9))
# password_2 = random.sample(symbs,9)
#
# print("\n\n\n\n\nPassword 1 : ",password_1)
# print("Password 2 : ",password_2)

