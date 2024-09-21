

#include <iostream>
#include <cmath>
using namespace std;

/*
//chia doi
float f(float x) {
    return pow(x, 3) - x - 1;
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
    cout<<chiadoi(1, 2);   
}
*/

//lap

//float f(float x) {
//    return pow(x+1, 1/3) ;
//}
//
//float lap(float a, float b) {
//    float esp = 0.01;
//    float x = a;
//    do {
//        float y = x;
//        x = f(x);
//    } while (abs(x - y), esp);
//    return x;
//}
//
//int main() {
//    cout<<lap(1, 2);
//}






#define eps 0.01
float f(float x) {
    return pow(x + 1, 1.0 / 3.0);
}

int main() {
    float x, y;
    cout << "nhap x";
    cin >> x;
    do {
        y = x;
        x = f(x);
        cout << x << y;
    } while (fabs(x - y) > eps);
        cout << x;
}
