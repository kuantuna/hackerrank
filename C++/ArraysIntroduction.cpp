#include <vector>
#include <iostream>
#include <string>
#include <sstream>
using namespace std;

int main() {
	int N;
	// This variable is for length of the array, but in the end I decided not to use it at all

	cin >> N;
	cin.ignore();
	// We need to use this method or we cannot get input with getline method.

	string input;
	// The getline method takes the input as a string, so our variable type should be string.

	getline(cin, input);
	istringstream iss(input);
	// Object class of istringstream 

	int i;
	// To store integer values to be streamed from istringstream

	vector<int> vec;
	// I finally decided to use a vector instead of an array
	// because when I used the input to create the size of the array, I got an error and couldn't find an easy way to solve it.

	while (iss >> i) {
		vec.push_back(i);
	}
	// I did the transfer of integer values from string to an integer variable with the extraction operator.
	// The extraction operator will read until whitespace is reached or until the stream fails.

	reverse(vec.begin(), vec.end());
	// You can check https://www.geeksforgeeks.org/stdreverse-in-c/ to understand what this line is doing.

	for (int i = 0; i < vec.size(); i++) {
		cout << vec.at(i) << " "; 
	}
	//Finally, I printed it in a line with spaces between values

	return 0;
}
