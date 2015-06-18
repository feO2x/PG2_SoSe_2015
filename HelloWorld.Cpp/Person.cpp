#include "Person.h"

using std::string;

string Person::GetName()
{
	return _vorname + " " + _nachname;
}

int Person::GetAlter()
{
	return _alter;
}
