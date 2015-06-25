#include <iostream>
#include <vector>

using namespace std;

void main()
{
	// Vector on the stack
	vector<int> integers;

	// add elements at the end of the collection
	integers.push_back(2);
	integers.push_back(4);
	integers.push_back(7);

	// Random access with at or index notation
	cout << "Element at position 1: " << integers.at(1) << endl;
	cout << "Element at position 2: " << integers[2] << endl << endl;

	// Run through the whole collection with random access
	cout << "All elements:" << endl;
	for (int i = 0; i < integers.size(); i++)
	{
		cout << "  " << integers[i] << endl;
	}
	cout << endl;

	// Run through the whole collection using iterators
	cout << "Again all elements: " << endl;
	for (auto startIterator = integers.begin(); startIterator < integers.end(); ++startIterator)
	{
		cout << *startIterator << endl;
	}
	cout << endl;

	// Inserts can only be done with iterators
	integers.insert(integers.begin() + 2, 8);

	cout << "After insertion:" << endl;
	for (auto number : integers)
	{
		cout << number << endl;
	}
	cout << endl;

	// Removal can be done only via index
	integers.erase(integers.begin());

	// Removal by element must be performed with a previous search (use std::find for that)
	auto removeIterator = find(integers.begin(), integers.end(), 7);
	integers.erase(removeIterator);

	cout << "After removal:" << endl;
	for (auto number : integers)
	{
		cout << number << endl;
	}
	cout << endl;
}