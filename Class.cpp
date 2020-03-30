#include "pch.h"
#include <iostream>

using namespace std;

const double Pi = 3.14;
class Sphere 
{
private: 
	int r;
public: 
	Sphere(int radius ) {
		setRadius(radius); 
	}
	void setRadius(int radius ){
		if (radius > 0)	{
			r = radius;
		}
		else{
			r = 1;
		}
	}
    int getRadius()	{
		return r;
	}
	int getDiameter() {
		return 2 * r;
	}
	double getLKola() {
		return Pi * getDiameter();
	}
	double getArea() {
		return 4 * Pi*r*r;
	}
	double getVolume() {
		int r3 = r * r*r;
		return 4 * Pi*r3 / 3;
	}

}; 

int main()
{
	int inpt;
	cout << "Enter radius ";
	cin >> inpt;
	Sphere sph(inpt);
	cout <<"Radius = "<<sph.getRadius() << endl;
	cout <<"Diameter = "<<sph.getDiameter() << endl;
	cout <<"LKola = "<<sph.getLKola() << endl;
	cout <<"Area = " << sph.getArea() << endl;
	cout <<"Volume = " << sph.getVolume() << endl;

	return 0;
}
