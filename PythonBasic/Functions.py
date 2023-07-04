# print("1.Admin\n2.Manager\n3.Teacher")
# selected = int(input("Your position : "))
#
# login_list = ['admin','teacher','manager']
#
#
# if selected == 1:
#     login = input(' : ')
#     if login in login_list:
#         print("Success ( Admin )")
#         # Functional for Admin
# elif selected == 2:
#     login = input('Login : ')
#     if login in login_list:
#         print("Success ( Manager )")
#         # Functional for Admin
# elif selected == 3:
#     login = input('Login : ')
#     if login in login_list:
#         print("Success ( Teacher )")
#         # Functional for Admin
#
#
# list_len = len(login_list)
#
# print(list_len)


#def - для создания функций



# def printMessage():
#     print("Hello STEP IT")
#     print("Hello BAKU")
#     print("Hello AZERBAIJAN")
#
#
#
#
# printMessage()
#
# printMessage()
#
# printMessage()

# import math
#
# num = 2.5434
# print(round(num))
#
# print(math.ceil(num)) # округление числа к верхней границе
# print(math.floor(num))  # округление числа к нижней границе
# print(math.modf(num)) # отдельно дробную часть и отдельно целочисленную
# print(math.factorial(5))
# print(math.fabs(-4))
#
# import random
#
# print(random.randint(2,10)) # 2,3,4,5,6,7,8,9,10
# print(random.randrange(2,10,2))  # 2 4 6 8 10


# def UserData(username,name,surname,birthdate):
#     print("Username : ",username)
#     print("Name : ",name)
#     print("Surname : ",surname)
#     print("BirthDate : ",birthdate)
#
#
# UserData("admin","Ali","Aliyev","19.09.1998")



# def checkSalary(salary_list):
#     salary_result = 0
#     for salary in salary_list:
#         salary_result +=salary
#
#     if salary_result < 8000:
#         return False
#     elif salary_result > 8000:
#         return True
#
#
# list = [2000,5000,2000]
# isOver8000 = checkSalary(list)
#
#
# if isOver8000:
#     print("36%")
# else:
#     print("5%")



# def carNames():
#     return "Kia","Hyundai"
#
#
# car1 , car2 = carNames()
#
# print("Car 1  : ",car1)
# print("Car 2  : ",car2)


# def checkAge(age):
#     if age > 18:
#         return "Student"
#     else:
#         return "Child"
#     print("Your age : ",age)
#
#
# print(checkAge(20))


# def summ (*args):
#   print(args)
#
#
# summ(2,4,5,6,7)


# DRY - Don't repeat yourself

