#include <iostream>


using namespace std;


template <class T>
class TreeNode {
public:
    TreeNode<T>* parent{nullptr};
    T value;
    TreeNode<T>* leftNode{nullptr};
    TreeNode<T>* rightNode{nullptr};
};

template <class T>
class BinaryTree {

public:
    TreeNode<T>* root{ nullptr };

    TreeNode<T>* search(T value) {
        TreeNode<T>* temp = root;

        while (true) {
            if (temp == nullptr) {
                return nullptr;
            }
            else if (temp->value == value) {
                return temp;
            }
            else if (temp->value > value) {
                temp = temp->leftNode;
            }
            else if (temp->value < value) {
                temp = temp->rightNode;
            }
        }

   
    }


    void insert(T value) {
        if (root == nullptr) {
            TreeNode<T>* newNode = new  TreeNode<T>();
            newNode->value = value;
            root = newNode;
            return;
        }
        
        TreeNode<T>* temp = root;
        
        while (true) {
            if (temp->value == value) {
                return;
            }
            if (temp->value > value) {
                if (temp->leftNode == nullptr) {
                    TreeNode<T>* newNode = new  TreeNode<T>();
                    newNode->value = value;
                    newNode->parent = temp;
                    temp->leftNode = newNode;
                    return;
                }
                else {
                    temp = temp->leftNode;
                }
               

            }
            else if (temp->value < value) {
                if (temp->rightNode == nullptr) {
                    TreeNode<T>* newNode = new  TreeNode<T>();
                    newNode->value = value;
                    newNode->parent = temp;
                    temp->rightNode = newNode;
                    return;
                }
                else {
                    temp = temp->rightNode;
                }
            }

        }

    }

    void print(TreeNode<T>* node) {
        if (node == nullptr) return;
        print(node->leftNode);
        cout << node->value << " ";
        print(node->rightNode);
    }

    bool hasLeftNode(TreeNode<T>* node) {
        if (node->leftNode != nullptr) return true;
        else return false;
    }

    bool hasRightNode(TreeNode<T>* node) {
        if (node->rightNode != nullptr) return true;
        else return false;
    }

    bool isLeftNode(TreeNode<T>* node) {
        if (node->parent->value > node->value) {
            return true;
        }
        return false;
    }

    bool isRightNode(TreeNode<T>* node) {
        if (node->parent->value < node->value) {
            return true;
        }
        return false;
    }
};



int main()
{
    BinaryTree<int> myTree;

    myTree.insert(8);
    myTree.insert(10);
    myTree.insert(3);
    myTree.insert(1);
    myTree.insert(6);
    myTree.insert(14);
    myTree.insert(4);
    myTree.insert(7);
    myTree.insert(13);

    myTree.print(myTree.root);

    cout << endl;
    myTree.print(myTree.root);

    //if (myTree.search(11) != nullptr) {
    //    cout << "YES" << endl;
    //}
    //else {
    //    cout << "NO!" << endl;
    //}

}


