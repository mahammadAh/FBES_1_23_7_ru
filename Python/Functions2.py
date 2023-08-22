# def print_user_data(surname,name,birth_date):
#     print("User name : ",name)
#     print("User Surname : ", surname)
#     print("User Birth Date : ", birth_date)
#
#
#
# print_user_data(surname="Abbasov",birth_date="1996",name="Anar")


# def SignIn(login,pasw=0):
#     if login == "admin" and pasw == "12345":
#      print("Admin - Success")
#     elif login == "guest":
#      print("Guest - Success")
#
#
#
# SignIn("admin","12345")
# print("\n\n\n")
# SignIn("guest")


# def Registration(login,password,username,name="Client"):
#    print("User login : ",login)
#    print("User password : ", password)
#    print("User username : ", username)
#    print("User name : ", name)
#
#
# Registration("namik_02","112235","namik02","Namik")
#
# name = "Ali"
#
#
# def print_user_data():
#     name = "Natiq"
#     print(id(name))
#
# print(name)

counter = 0

def print_data():
    global counter
    print("Counter : ",counter)
    counter += 1
    if counter < 10:
     print_data()

print_data()







