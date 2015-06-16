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
	int temperaturwerte[] = { 30, 32, 29 };

	for (int& wert : temperaturwerte)
	{
		wert = (wert * 9.0 / 5.0) + 32;
	}

	for (int wert : temperaturwerte)
	{
		cout << wert << " ";
	}
	cout << endl;
	
}