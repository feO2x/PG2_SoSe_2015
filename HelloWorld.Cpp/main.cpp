#include <iostream>
#include <string>
#include "Queue.h"
using namespace std;

void main()
{
	Queue<int> queue;

	queue.Enqueue(4);
	queue.Enqueue(5);

	cout << "Count of queue is " << queue.GetCount() << endl;

	while (queue.GetCount() > 0)
	{
		cout << queue.Dequeue() << endl;
	}
}