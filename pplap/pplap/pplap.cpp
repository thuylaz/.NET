#include <iostream>
using namespace std;

float f(float x) {
	return 5 * pow(x, 3) - 20 * x + 3; //khai bao ham f(x)
}
float g(float x) {
	return (5 * pow(x, 3) + 3) / 20; //ham tuong duong f(x)
}
float lap(float a, float b) {
	float exp = 0.0001;
	float x = a;
	float y;
	do {
		y = x;
		x = g(x);
	} while (abs(x - y) > exp);
	return x;
}
int main() {
	float a, b;
	cout << "Nhap 1 khoang ly nghiem a,b: ";
	cin >> a >> b;
	cout << "Nghiem gan dung: " << lap(a, b);
}
