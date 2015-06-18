#pragma once
class Rechteck
{
private:
	int _breite;
	int _höhe;
public:
	explicit Rechteck(int seitenlänge)
		: _breite(seitenlänge), _höhe(seitenlänge)
	{
		
	}

	Rechteck(int breite, int höhe)
		: _breite(breite), _höhe(höhe)
	{
	}

	int BerechneFläche()
	{
		return _breite * _höhe;
	}
};

