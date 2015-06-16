#include <iostream>

using std::cout;
using std::endl;
using std::cin;

void DoSomething(int value)
{
	value += 5;
	cout << value << endl;
}

void DoSomethingByReference(int* value)
{
	*value += 5;
	cout << *value << endl;
}

void DoSomethingByReference(const int& value)
{
	/*value += 5;*/
	cout << value << endl;
}



void main()
{
	auto value = 5;
	DoSomething(value);
	cout << value << endl;

	DoSomethingByReference(&value);
	cout << value << endl;

	DoSomethingByReference(value);
	cout << value << endl;

	DoSomethingByReference(5);

	
}