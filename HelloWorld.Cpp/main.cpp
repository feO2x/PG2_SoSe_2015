#include <iostream>
#include "Person.h"

using std::cout;
using std::endl;
using std::cin;

void main()
{
	Person* walter = new Person("Walter", "White", 52);
	Person jesse("Jesse", "Pinkman", 27);

	cout << walter->GetName() << endl;
	cout << jesse.GetName() << endl;
	
	delete walter;
	walter = nullptr;
}