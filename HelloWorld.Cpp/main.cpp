#include <iostream>

using std::cout;
using std::endl;
using std::cin;

// Const Correctness 
void TuEtwas(const double * const pYourValue)
{
	
}

void main()
{
	double value1 = 42;
	const double* pointerToValue1 = &value1;
	TuEtwas(pointerToValue1);
	//*pointerToValue1 += 5;

	double value2 = 43;
	double value3 = 44;
	double * const pointerToValue2 = &value2;
	//pointerToValue2 = &value3;
	*pointerToValue2 += 3;

	double const * const pointerToValue4 = new double(42);
	//pointerToValue4 = &value3;
	//*pointerToValue4 = 55;
	delete pointerToValue4;
	//pointerToValue4 = nullptr;
	
}