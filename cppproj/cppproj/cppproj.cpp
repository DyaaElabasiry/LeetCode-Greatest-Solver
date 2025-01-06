#include <iostream>
#include <cstring>

using namespace std;


class Employee{

public:
    int id;
    char* name;
    Employee()
    {
        //cout << "default const" << endl;
        int id=0;
        this->name = new char[100];
    }
    Employee(int id,const char* name)
    {
        //cout << "param const" << endl;
        this->id=id;
        this->name = new char[strlen(name)+1];
        strcpy(this->name,name);
    }
    ~Employee()
    {
        //cout << "destructor" << endl;
        delete[] name;
    }
    Employee (const Employee& other)
    {
        //cout << "copy const" << endl;
        this->id = other.id;
        this->name = new char[strlen(other.name)+1];
        strcpy(this->name,other.name);
    }
    Employee& operator=(const Employee& e)
    {
        //cout << "equal operator" << endl;
        this->id=e.id;
        delete[] this->name;
        this->name = new char[strlen(e.name)+1];
        strcpy(this->name,e.name);
        return *this;
    }
    Employee operator+(const Employee& e)
    {
        Employee temp;
        temp.id = this->id + e.id;
        delete[] temp.name;
        temp.name = new char[strlen(e.name)+strlen(this->name)+1];
        strcpy(temp.name,this->name);
        strcat(temp.name,e.name);
        return temp;
    }
    Employee operator+(const char* name)
    {
        Employee temp;
        delete[] temp.name;
        temp.id = this->id;
        temp.name = new char[strlen(name)+strlen(this->name)+1];
        strcpy(temp.name,this->name);
        strcat(temp.name,name);
        return temp;
    }
    Employee operator+(const int id)
    {
        Employee temp(this->id+id,this->name);
        return temp;
    }
    int operator==(const Employee& e)
    {
        return (!strcmp(this->name,e.name) && e.id==this->id);
    }
    Employee operator++(const int id)
    {
        Employee temp;
        temp=*this;
        this->id = this->id+1;
        return temp;
    }
    Employee operator++()
    {
        this->id = this->id+1;
        return *this;
    }
    operator int()
    {
        return this->id;
    }
    operator char*()
    {
        return   this->name;
    }
    friend Employee operator+(const char* name, const Employee& e);
    friend Employee operator+(const int id, const Employee& e);
};
Employee operator+(const char* name,const Employee& e)
{
    Employee temp;
    delete[] temp.name;
    temp.id = e.id;
    temp.name = new char[strlen(name)+strlen(e.name)+1];
    strcpy(temp.name,name);
    strcat(temp.name,e.name);
    return temp;
}
Employee operator+(const int id, const Employee& e)
    {
        Employee temp(e.id+1,e.name);
        return temp;
    }

int main()
{
    Employee e1(12,"dyaa");
    Employee e2(32,"mohamed");
    Employee e3 = e1;

    e1= e1 +1;
    cout << e1.name << endl;
    cout << e1.id << endl;
    //e3=e1;
    /*cout << e3.name << endl;
    cout << e3.id << endl;


    e3 =e1+e2;
    cout << e3.name << endl;
    cout << e3.id << endl;


    e3=e1+" elabasiry";
    cout << e3.name << endl;
    cout << e3.id << endl;

    e3=" elabasiry" + e1;
    cout << e3.name << endl;
    cout << e3.id << endl;

    cout << (char*)e1 << endl;
    cout << (int)e1 << endl;
    e1++;
    cout << e1.id << endl;
    ++e1;
    cout << e1.id << endl;
    e3=e1+100;
    cout << e3.id << endl;
    e3=100+e1;
    cout << e3.id << endl;*/

    return 0;
}
