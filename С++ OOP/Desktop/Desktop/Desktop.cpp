#include <iostream>
#include <vector>
#include <fstream>

using namespace std;


class Encryption {
public:
	static string Encrypt(string inputData) {
		string outputData = "";
		for (auto sym : inputData) {
			sym = sym + 11 ;
			outputData += sym;
		}
		return outputData;
	}

	static string Dencrypt(string inputData) {
		string outputData = "";
		for (auto sym : inputData) {
			sym = sym - 11;
			outputData += sym;
		}
		return outputData;
	}
};  

class User {
	string login;
	string password;
public:
	User(){}
	User(string login, string password) : login(login)  {
		this->password = password;
	}

	void setLogin(string login) {
		this->login = login;
	}

	
	string getLogin() {
		return login;
	}

	void setPassword(string password) {
		this->password = password;
	}

	string getPassword() {
		return password;
	}




};


ostream& operator << (ostream& out, User& user) {
	out << user.getLogin() << endl << Encryption::Encrypt(user.getPassword());
	return out;
}

istream& operator >> (istream& in, User& user) {
	string login;
	string password;

	in >> login >> password;
	user.setLogin(login);
	user.setPassword(Encryption::Dencrypt(password));
	return in;
}


class UserManegment  {
	vector<User> users;
public:
	void addUser(User& user) {
		users.push_back(user);
	}

	int usersCount() {
		return users.size();
	}

	User& getUser(int index) {
		return users.at(index);
	}

	bool isSignUp(string login,string password) {
		for (auto user : users) {
			if (user.getLogin() == login && user.getPassword() == password)  return true;
		}
		return false;
	}

};

class ConsoleUI {
	UserManegment* userManagment = NULL;
public:
	ConsoleUI(UserManegment* userManagment) : userManagment(userManagment) {}


	void signUp() {
		system("cls");
		string login;
		string password;
		string repeatedPassword;
		cout << "Enter login : " ;
		cin >> login;
		do {
			cout << "Enter Password : " ;
			cin >> password;
			cout << "Repeat Password : ";
			cin >> repeatedPassword;
		} while (password != repeatedPassword);
		User* user = new User(login, password);
		(*userManagment).addUser(*user);
	};

	void signIn() {
		system("cls");
		string login;
		string password;
		cout << "Enter login : ";
		cin >> login;
		cout << "Enter Password : " ;
		cin >> password;
		if ((*userManagment).isSignUp(login, password)) {
			cout << "Success Sign Up " << endl;
		}
		else {
			cout << "Fatal Sign Up " << endl;
		}
	}


};


class WorkWithFile {
public:
	void WriteUsersToFile(UserManegment* userManagment) {
		ofstream fout("users.txt");
		for (int i = 0; i < (*userManagment).usersCount(); i++)
		{
			fout << (*userManagment).getUser(i);
			if (i < ((*userManagment).usersCount() - 1)) fout << endl;

		}
	}

	void ReadUsersFromFile(UserManegment* userManagment) {
		ifstream fin("users.txt");
		string login;
		string password;
		if (fin.peek() != std::ifstream::traits_type::eof()) {
			while (!fin.eof()) {
				User user;
				fin >> user;
				(*userManagment).addUser(user);
			}
		}
	}
};





int main()
{
	int selected;
	bool isEnd = false;
	UserManegment* userManegment = new UserManegment();
	ConsoleUI consoleUI(userManegment);
	WorkWithFile workWithFile;
	workWithFile.ReadUsersFromFile(userManegment);
	while (!isEnd) {
		cout << "1.SignUp\n2.SingIn\n3.Exit\n";
		cin >> selected;
		switch (selected) {
		case 1:
			consoleUI.signUp();
			break;
		case 2:
			consoleUI.signIn();
			break;
		case 3:
			isEnd = true;
			break;
		default:
			break;
		}
	}
	workWithFile.WriteUsersToFile(userManegment);
}


