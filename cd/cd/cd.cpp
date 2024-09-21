

#include <iostream>
#include <cmath>
using namespace std;


//chia doi
float f(float x) {
    return 3 * pow(x, 3) - 10 * x + 5;
}

float chiadoi(float a, float b) {
    float esp = 0.01;
    float c = (a + b) / 2;

    if (f(a) * f(b) < 0) {
        while (f(c) != 0 && fabs(a - b) > esp) {
            c = (a + b) / 2;
            if (f(a) * f(c) < 0)
                b = c;
            else
                a = c;
        }
        return c;
    }
}

int main() {
    cout << chiadoi(0, 1);
}

