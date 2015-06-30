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

template <int n>
struct Fibonacci
{
	static const int Value = Fibonacci<n - 1>::Value + Fibonacci<n - 2>::Value;
};

template<>
struct Fibonacci<1>
{
	static const int Value = 1;
};

template<>
struct Fibonacci<0>
{
	static const int Value = 0;
};

void main()
{
	auto result = Fibonacci<7>::Value;
}