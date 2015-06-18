#include <iostream>
#include "Person.h"
#include "Rechteck.h"

using std::cout;
using std::endl;
using std::cin;

class A
{
private:
	int _counterA = 0;

public:
	void Increment()
	{
		_counterA++;
	}

	int GetCounter()
	{
		return _counterA;
	}
};

class B : public A
{
	int _counterB = 1;
public:
	void IncrementBy3()
	{
		for (int i = 0; i < 3; i++)
		{
			Increment();
		}
	}
};

void main()
{
	B objekt1;
	
	objekt1.Increment();
	objekt1.IncrementBy3();

	A* pointerToObjekt1 = &objekt1; // Ist-Eine-Beziehung
	pointerToObjekt1->Increment();

	A& referenceToObjekt1 = objekt1; // Ist-Eine-Beziehung
	referenceToObjekt1.Increment();

	// Ist-Eine-Beziehung ohne Pointer oder Referenzen
	A objekt2 = objekt1; // Slicing - das ist meistens nicht gewünscht
	objekt2.GetCounter();
}