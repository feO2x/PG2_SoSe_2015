#pragma once

template <class T>
struct IQueue
{
	virtual void Enqueue(T item) = 0;
	virtual T Dequeue() = 0;
	virtual int GetCount() const = 0;

	virtual ~IQueue(){}
};