#pragma once
struct Rechteck
{
	int _breite;
	int _höhe;

	explicit Rechteck(int seitenlänge)
		: _breite(seitenlänge), _höhe(seitenlänge)
	{
		
	}

	Rechteck(int breite, int höhe)
		: _breite(breite), _höhe(höhe)
	{
	}

	int BerechneFläche() const
	{
		return _breite * _höhe;
	}

	bool operator <(const Rechteck& anderesRechteck)
	{
		return BerechneFläche() < anderesRechteck.BerechneFläche();
	}
};

