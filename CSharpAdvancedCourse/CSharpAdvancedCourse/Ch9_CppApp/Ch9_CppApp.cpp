// Ch9_CppApp.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"
#include <iostream>

int Sum(int x, int y)
{
	int s = x + y;
	return s;
}

int __cdecl Calc(int i, int j)
{
	int sum = Sum(i, j);
	int result = i * j - sum;
	return result;
}

int main()
{
	int a = 1;
	int b = 2;

	int res = Calc(a, b);
	std::cout << res;
}

