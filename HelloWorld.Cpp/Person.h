#pragma once

#include <string>
#include <stdexcept>

class Person
{
private:
	std::string _vorname;
	std::string _nachname;
	int _alter;

public:
	Person(std::string vorname, std::string nachname, int alter)
		: _vorname(vorname), _nachname(nachname), _alter(alter)
	{
		if (vorname.length() == 0)
			throw std::invalid_argument("vorname darf nicht leer sein");
	}

	std::string GetName();

	int GetAlter();

};