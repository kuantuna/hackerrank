#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <string>
#include <sstream>
using namespace std;



int main() {
    int N;
    cin >> N;
    cin.ignore();
    string input;
    getline(cin, input);
    istringstream iss(input);
    int i;
    vector<int> vec;
    while (iss >> i) {
        vec.push_back(i);
    }
    reverse(vec.begin(), vec.end());
    for (size_t i = 0; i < vec.size(); i++) {
        cout << vec.at(i) << " "; 
    }

    return 0;
}
