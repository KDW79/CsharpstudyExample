// Ch9_CppApp.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
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

