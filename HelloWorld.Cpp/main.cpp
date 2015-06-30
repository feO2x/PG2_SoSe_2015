#include <iostream>
#include <string>
#include "Queue.h"
#include "Rechteck.h"
#include <vector>
using namespace std;

void main()
{
	Queue<Rechteck*> queue;

	queue.Enqueue(new Rechteck(3, 4));
	queue.Enqueue(new Rechteck(6, 7));

	while (queue.GetCount() > 0)
	{
		auto rechteck = queue.Dequeue();
		delete rechteck;
	}
}