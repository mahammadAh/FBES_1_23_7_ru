students = {}
students_marks = {}
student_id = 1



def print_variables():
    print("Student --> " ,students)
    print("Student Marks --> ",students_marks)

def add_student():
    global students
    global student_id
    global students_marks
    marks = {}
    name = input("Student Name : ")
    surname = input("Student Surname : ")
    students.setdefault(student_id,name+" "+surname)
    students_marks.setdefault(student_id,marks)
    student_id+=1
    print_variables()


def add_mark_to_student():
    global students
    for key,value in students.items():
        print(key , " => ",value)
    selected_id = int(input("Student ID : "))
    while True:
     subject= input("Subject : ")
     mark = input("Mark : ")
     students_marks[selected_id].setdefault(subject,mark)
     state = int(input("1.Add Mark\n2.Exit\n"))
     print_variables()
     if state == 2:
         break


def show_students_marks():
    global students_marks
    global students
    for key,value in students.items():
        print("Student => ", value)
        for subject,mark in students_marks[key].items():
            print(subject," => ",mark)


def show_students_gpa():
    global students_marks
    global students
    for key, value in students.items():
        sum = 0
        count = 0
        print("Student => ", value)
        for subject, mark in students_marks[key].items():
            sum += int(mark)
            count+=1
        print("GPA => ",sum/count)


while True:
 selected = int(input('''1.Добавлять учеников
 2.Выставлять оценки ученикам
 3.Просматривать оценки учеников
 4.Выводить GPA (Среднеарифметическое)\n Select : '''))

 if selected==1:
    add_student()
 elif selected==2:
    add_mark_to_student()
 elif selected==3:
    show_students_marks()
 elif selected==4:
    show_students_gpa()

