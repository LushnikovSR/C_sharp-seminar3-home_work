// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int[] pointA = new int[3];
int[] pointB = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите координаты точки А[{i + 1}] = ");
    pointA[i] = Convert.ToInt16(Console.ReadLine());
}
// Console.WriteLine($"Mas = {point1[2]}");
for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите координаты точки B[{i + 1}] = ");
    pointB[i] = Convert.ToInt16(Console.ReadLine());
}
double result = Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2));
Console.WriteLine($"A ({pointA[0]},{pointA[1]},{pointA[2]}; B ({pointB[0]},{pointB[1]},{pointB[2]}) -> {result:f2}");