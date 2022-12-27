// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int a_x = 1;
int a_y = 1;
int a_z = 1;
int b_x = 0;
int b_y = 0;
int b_z = 0;

double result = Math.Sqrt(Math.Pow(a_x - b_x, 2)
                      + Math.Pow(a_y - b_y, 2)
                      + Math.Pow(a_z - b_z, 2));
Console.WriteLine(result);
