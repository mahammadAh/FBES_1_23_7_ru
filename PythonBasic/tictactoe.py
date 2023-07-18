player = "0"
matrix = [["_","_","_"],["_","_","_"],["_","_","_"]]
end_game = False

def print_matrix():
    for row in matrix:
        for col in row:
            print(col+" ",end="")
        print()


def set_symbol(row,col):
    global player
    matrix[row][col] = player
    print_matrix()
    if player == "0":
      player = "X"
    elif  player == "X":
     player = "0"


def check_winner():
    global end_game
    if matrix[0][0] !="_" and matrix[0][0] == matrix[0][1] and  matrix[0][1] == matrix[0][2]:
        print("Player [" + matrix[0][0] + "] Win !")
        end_game = True
    elif  matrix[1][0] !="_" and matrix[1][0] == matrix[1][1] and  matrix[1][1] == matrix[1][2]:
        print("Player [" + matrix[1][0] + "] Win !")
        end_game = True
    elif  matrix[2][0] !="_" and matrix[2][0] == matrix[2][1] and  matrix[2][1] == matrix[2][2]:
        print("Player [" + matrix[2][0] + "] Win !")
        end_game = True
    elif  matrix[0][0] !="_" and matrix[0][0] == matrix[1][0] and  matrix[1][0] == matrix[2][0]:
        print("Player [" + matrix[0][0] + "] Win !")
        end_game = True
    elif  matrix[0][1] !="_" and matrix[0][1] == matrix[1][1] and  matrix[1][1] == matrix[2][1]:
        print("Player [" + matrix[0][1] + "] Win !")
        end_game = True
    elif  matrix[0][2] !="_" and matrix[0][2] == matrix[1][2] and  matrix[1][2] == matrix[2][2]:
        print("Player [" + matrix[0][2] + "] Win !")
        end_game = True
    elif  matrix[0][0] !="_" and matrix[0][0] == matrix[1][1] and  matrix[1][1] == matrix[2][2]:
        print("Player [" + matrix[0][0] + "] Win !")
        end_game = True
    elif  matrix[0][2] !="_" and matrix[0][2] == matrix[1][1] and  matrix[1][1] == matrix[2][0]:
        print("Player [" + matrix[0][2] + "] Win !")
        end_game = True




#
# while True:
#     matrix_row = int(input("Vvedite Stoku : "))
#     matrix_col = int(input("Vvedite Stolbec : "))
#     if matrix[matrix_row][matrix_col] != "_":
#         print("Eta posticiya zanata")
#         continue
#     set_symbol(matrix_row,matrix_col)
#     check_winner()
#     if end_game==True:
#         break



def rek_sum(num):
    if num == 1:
        return 1
    return num+rek_sum(num-1)


result = rek_sum(5)
print(result)