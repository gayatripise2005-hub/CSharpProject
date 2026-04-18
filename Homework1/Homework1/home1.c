//Write a C program to find the maximum between two numbers.
#include<stdio.h>
int main()
{
	int a, b, max;
	printf("enter two number:");
	scanf("%d %d", &a, &b);
	max = (a > b) ? a : b;
	printf("maximum=%d", max);
	return 0;
}

//Write a C program to find a maximum between three numbers.
int main()
{
	int a, b, c, max;
	printf("enter three number:");
	scanf("%d %d %d", &a, &b, &c);
	max = (a > b && a > c) ? a : (b > c ? b : c);
	printf("maximum=%d", max);
	return 0;

	//Write a C program to check whether a number is negative, positive or zero.
	 
	void main()
	{
		int n;
		printf("enter the number:");
		scanf("%d", &n);

	(n>0)? printf("it is positive:");
	(n<0)? printf("it is negative:");
		printf("it is zero");
		return 0;
	} 