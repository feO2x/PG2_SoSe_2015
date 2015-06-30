#include <iostream>
#include <string>
#include "Queue.h"
#include "Rechteck.h"
using namespace std;

template <class T>
T max(const T& firstValue, const T& secondValue)
{
	return firstValue < secondValue ? secondValue : firstValue;
}

void main()
{
	cout << max(42, 47) << endl;
	cout << max(33.7, 33.5) << endl;
	cout << max(true, false) << endl;

	Rechteck rechteck1(4, 7);
	Rechteck rechteck2(3, 2);

	auto größeresRechteck = max(rechteck1, rechteck2);
}