#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <sstream>
#include <algorithm>

using namespace std;

class Question
{
public:
    string category;
    string subcategory;
    string questionText;

    vector<string> answers;
    int correctAnswer;

    void displayQuestion() const
    {
        cout << "[" << category << ", " << subcategory << "] " << questionText << endl;

        for (int i = 0; i < answers.size(); i++)
        {
            cout << i + 1 << ". " << answers[i] << endl;
        }
    }

    bool isCorrect(int userAnswer) const
    {
        return (userAnswer - 1) == correctAnswer;
    }
};



class Test
{
public:
    vector<Question> questions;

    void loadQuestionsFromFile(const string& filename)
    {
        ifstream file(filename);
        if (!file.is_open())
        {
            cout << "error opening file: " << filename << endl;
            return;
        }

        Question currentQuestion;
        string line;

        while (getline(file, line))
        {
            string token;
            istringstream stream(line);

            getline(stream, currentQuestion.category, ',');
            getline(stream, currentQuestion.subcategory, ',');
            getline(stream, currentQuestion.questionText, ',');

            for (int i = 0; i < 4; ++i)
            {
                getline(stream, token, ',');
                currentQuestion.answers.push_back(token);
            }

            getline(stream, token, ',');
            currentQuestion.correctAnswer = stoi(token) - 1;

            questions.push_back(currentQuestion);
            currentQuestion = Question();
        }
        file.close();
    }

    void createTest(int& correctAnswers, int& incorrectAnswers) const
    {
        for (int i = 0; i < questions.size(); ++i)
        {
            questions[i].displayQuestion();

            int userAnswer;
            cout << "your answer (1-4): ";
            cin >> userAnswer;

            while (userAnswer < 1 || userAnswer > 4)
            {
                cout << "please enter a number between 1 and 4" << endl;
                cout << "your answer (1-4): ";
                cin >> userAnswer;
            }

            if (questions[i].isCorrect(userAnswer)) correctAnswers++;
            else incorrectAnswers++;
        }
    }

};

class Admin
{
public:
    string username;
    string encryptedPassword;

    static Admin readAdminFromFile(const string& filename)
    {
        Admin admin;
        ifstream file(filename);
        if (!file.is_open())
        {
            cerr << "error opening file: " << filename << endl;
            return admin;
        }

        getline(file, admin.username, ',');
        getline(file, admin.encryptedPassword, '\n');

        file.close();
        return admin;
    }

    static bool authenticateAdmin(const Admin& admin, const string& enteredPassword)
    {
        return admin.encryptedPassword == encryptPassword(enteredPassword);
    }

    void viewResults(const string& filename) const
    {
        ifstream file(filename);
        if (!file.is_open())
        {
            cout << "error opening file: " << filename << endl;
            return;
        }

        cout << "results:" << endl;
        string line;
        while (getline(file, line))
        {
            cout << line << endl;
        }

        file.close();
    }

    void addQuestion(const string& question, const string& filename) const
    {
        ofstream file(filename, ios::app); //ios::app - append in the end of file
        if (!file.is_open())
        {
            cout << "error opening file: " << filename << endl;
            return;
        }

        file << question << endl;

        file.close();
    }


private:
    static string encryptPassword(const string& password)
    {
        string encrypted = password;

        for (char& c : encrypted)
        {
            if (isdigit(c))
            {
                c = char(((c - '0' + 4) % 10) + '0');
            }
        }
        return encrypted;
    }

    string decryptPassword(const string& encryptedPassword) const
    {
        string decrypted = encryptedPassword;

        for (char& c : decrypted)
        {
            if (isdigit(c))
            {
                c = char(((c - '0' + 6) % 10) + '0');
            }
        }
        return decrypted;
    }

};


class User
{
public:
    string username;
    string encryptedPassword;
    string fullName;
    string address;
    string phoneNumber;
    vector<double> testResults;

    static User registerUser()
    {
        User newUser;
        cout << "Enter your name: ";
        cin.ignore();
        getline(cin, newUser.fullName);
        cout << "Enter your address: ";
        getline(cin, newUser.address);
        cout << "Enter your phone number: ";
        getline(cin, newUser.phoneNumber);

        do
        {
            cout << "Enter your username: ";
            cin >> newUser.username;

            if (isUsernameTaken(newUser.username))
            {
                cout << "Username is already taken. Choose another one." << endl;
            }

        } while (isUsernameTaken(newUser.username));

        bool validPassword = false;

        while (!validPassword)
        {
            cout << "Enter your password (only digits): ";
            cin >> newUser.encryptedPassword;

            validPassword = true;

            for (char c : newUser.encryptedPassword)
            {
                if (!isdigit(c))
                {
                    cout << "enter password containing only digits: ";
                    validPassword = false;
                    break;
                }
            }
        }

        newUser.encryptedPassword = newUser.encryptPassword(newUser.encryptedPassword);

        return newUser;
    }

    static User loginUser(vector<User>& users)
    {
        User loginUser;
        cout << "enter your username: ";
        cin >> loginUser.username;

        vector<User> existingUsers = readUsersFromFile("users.txt");

        auto userIterator = existingUsers.end();

        for (auto it = existingUsers.begin(); it != existingUsers.end(); ++it)
        {
            if (it->username == loginUser.username)
            {
                userIterator = it;
                break;
            }
        }

        if (userIterator != existingUsers.end())
        {
            cout << "enter your password: ";
            cin >> loginUser.encryptedPassword;

            if (userIterator->encryptedPassword == loginUser.encryptPassword(loginUser.encryptedPassword))
            {
                cout << "login successful" << endl;

                if (!userIterator->testResults.empty())
                {
                    cout << "your previous test result: " << userIterator->testResults.back() << "%" << endl;
                }


                return *userIterator;
            }
            else
            {
                cout << "incorrect password" << endl;
            }
        }
        else
        {
            cout << "user not found" << endl;
        }

        return User();
    }

    static vector<User> readUsersFromFile(const string& filename)
    {
        vector<User> users;
        ifstream file(filename);
        if (!file.is_open())
        {
            cout << "error opening file: " << filename << endl;
            return users;
        }

        User currentUser;
        string line;
        while (getline(file, line))
        {
            istringstream stream(line);
            getline(stream, currentUser.username, ',');
            getline(stream, currentUser.encryptedPassword, ',');
            getline(stream, currentUser.fullName, ',');
            getline(stream, currentUser.address, ',');
            getline(stream, currentUser.phoneNumber, '\n');
            users.push_back(currentUser);
        }

        file.close();
        return users;
    }

    void displayResults(int totalQuestions) const
    {
        if (!testResults.empty())
        {
            double totalScore = 0.0;
            for (double score : testResults)
            {
                totalScore += score;
            }

            double averagePercentage = (totalScore / static_cast<double>(testResults.size())) * 100;

            system("cls");
            cout << "Test results for user " << username << ": " << endl;
            cout << "Average percentage: " << averagePercentage << "%" << endl;
        }
        else
        {
            cout << "No test results available" << endl;
        }
    }

    void takeTest(const Test& test)
    {
        if (username.empty())
        {
            cout << "you need to log in" << endl;
            return;
        }

        int correctAnswers = 0;
        int totalQuestions = test.questions.size();

        for (int i = 0; i < totalQuestions; ++i)
        {
            test.questions[i].displayQuestion();

            int userAnswer;
            cout << "your answer (1-4): ";
            cin >> userAnswer;

            while (userAnswer < 1 || userAnswer > 4)
            {
                cout << "enter number between 1 and 4" << endl;
                cout << "your answer (1-4): ";
                cin >> userAnswer;
            }

            if (test.questions[i].isCorrect(userAnswer)) correctAnswers++;
        }

        double percentage = (correctAnswers / totalQuestions) * 100;

        cout << "test result for user " << username << ":" << endl;
        cout << "correct answers: " << correctAnswers << "/" << totalQuestions << endl;
        cout << "percentage: " << percentage << "%" << endl;

        int grade = (percentage / 100) * 12;
        cout << "grade: " << grade << " points" << endl;

        saveResultsToFile("results.txt", percentage);
    }

    void saveResultsToFile(const string& filename, double percentage) const
    {
        if (username.empty())
        {
            cout << "you need to log in" << endl;
            return;
        }

        ofstream file(filename, ios::app);

        if (!file.is_open())
        {
            cout << "error opening file: " << filename << endl;
            return;
        }

        file << "results for user " << username << ":" << endl;
        file << "test: " << percentage << "%" << endl;

        file.close();
        cout << "results saved to file" << endl;
    }


    void displayPreviousResults() const
    {
        if (testResults.empty()) cout << "no previous test results in file" << endl;
        else
        {
            cout << "previous test result for user " << username << ":" << endl;
            for (size_t i = 0; i < testResults.size(); ++i)
            {
                double percentage = testResults[i];

                cout << "test " << i + 1 << ": " << percentage << "%" << endl;
            }
        }
    }

private:
    static bool isUsernameTaken(const string& username)
    {
        ifstream file("users.txt");
        if (!file.is_open())
        {
            cerr << "error opening file: users.txt" << endl;
            return false;
        }

        string line;
        while (getline(file, line, ','))
        {
            if (line == username)
            {
                file.close();
                return true;
            }
            getline(file, line);
        }

        file.close();
        return false;
    }

    string encryptPassword(const string& password) const
    {
        string encrypted = password;

        for (char& c : encrypted)
        {
            if (isdigit(c)) c = char(((c - '0' + 4) % 10) + '0'); // '0' - helps to turn digit symbol to digit
        }
        return encrypted;
    }

    string decryptPassword(const string& encryptedPassword) const
    {
        string decrypted = encryptedPassword;

        for (char& c : decrypted)
        {
            if (isdigit(c))
            {
                c = char(((c - '0' + 6) % 10) + '0');
            }
        }
        return decrypted;
    }
};

int main()
{
    vector<User> users;
    int select;

    Admin admin = Admin::readAdminFromFile("admin.txt");

    do
    {
        cout << "1. Login" << endl;
        cout << "2. Register" << endl;
        cout << "3. Admin Login" << endl;
        cout << "4. Exit" << endl;
        cout << "enter your choice: ";
        cin >> select;

        switch (select)
        {
        case 1:
        {
            User currentUser = User::loginUser(users);

            if (!currentUser.username.empty())
            {
                system("cls");

                Test test;
                test.loadQuestionsFromFile("tests.txt");
                currentUser.takeTest(test);
            }
        }
        break;

        case 2:
        {
            User newUser = User::registerUser();
            users.push_back(newUser);
            ofstream usersOutputFile("users.txt", ios::app); //open file and write to this file

            if (!usersOutputFile.is_open())
            {
                cout << "error opening file users.txt" << endl;
                return 1;
            }

            usersOutputFile << newUser.username << ',' << newUser.encryptedPassword << ',' << newUser.fullName
                << ',' << newUser.address << ',' << newUser.phoneNumber << '\n';

            usersOutputFile.close();
        }
        break;

        case 3:
        {
            string adminPassword;
            cout << "Enter admin password: ";
            cin >> adminPassword;

            if (Admin::authenticateAdmin(admin, adminPassword))
            {
                cout << "admin login successful!" << endl;
                int adminSelect;

                do
                {
                    cout << "1. View Results" << endl;
                    cout << "2. Add Question" << endl;
                    cout << "3. Logout" << endl;
                    cout << "enter your choice: ";
                    cin >> adminSelect;

                    switch (adminSelect)
                    {
                    case 1:
                        admin.viewResults("results.txt");
                        break;

                    case 2:
                    {
                        string newQuestion;

                        cout << "enter new question(category,subcategory,question,1-4 answers,correct answer): ";

                        cin.ignore(); //clear symbols in buffer (\n)
                        getline(cin, newQuestion);
                        admin.addQuestion(newQuestion, "tests.txt");
                        cout << "question added successfully" << endl;
                    }
                    break;

                    case 3:
                        cout << "admin logout" << endl;
                        break;
                    default:
                        cout << "invalid choice, try again" << endl;
                    }
                } while (adminSelect != 3);
            }
            else  cout << "admin login failed, incorrect password" << endl;
        }
        break;
        case 4:
            cout << "goodbye!" << endl;
            break;
        default:
            cout << "invalid choice, try again" << endl;
        }

    } while (select != '4');

    return 0;
}