#include <iostream>
#include "Person.h"
#include "Rechteck.h"

using std::cout;
using std::endl;
using std::cin;

void VerdoppeleRechteckgröße(Rechteck& rechteck)
{
	rechteck._höhe *= 2;
	rechteck._breite *= 2;
}

void main()
{
	Rechteck* rechteck = new Rechteck(5);
	VerdoppeleRechteckgröße(*rechteck);

	delete rechteck;
}