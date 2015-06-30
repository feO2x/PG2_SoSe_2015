#pragma once

#include "IQueue.h"
#include <stdexcept>

template <class T>
class Queue : public IQueue<T>
{
	T* _array;
	int _capacity;
	int _count = 0;

public:
	Queue()
	{
		_capacity = 4;
		_array = new T[_capacity];
	}

	void ExchangeArray()
	{
		auto newArray = new T[_capacity * 2];
		for (int i = 0; i < _capacity; i++)
		{
			newArray[i] = _array[i];
		}
		delete [] _array;
		_array = newArray;
		_capacity *= 2;
	}

	void Enqueue(T item) override
	{
		if (_count == _capacity)
			ExchangeArray();

		_array[_count] = item;
		_count++;
	}

	T Dequeue() override
	{
		if (_count == 0)
			throw std::logic_error("The queue is empty");

		auto returnValue = *_array;
		for (auto i = 0; i < _count - 1; i++)
		{
			_array[i] = _array[i + 1];
		}
		_array[_count - 1] = {};
		_count--;
		return returnValue;
	}

	int GetCount() const override
	{
		return _count;
	}

	~Queue()
	{
		delete [] _array;
	}
};