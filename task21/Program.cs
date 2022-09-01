// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetRange(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Round(Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb -ya), 2)+ Math.Pow((zb -za), 2)), 2);
}
//Console.WriteLine(GetRange(3, 6, 8, 2, 1, -7)); // первые координаты
Console.WriteLine(GetRange(7, -5, 0, 1, -1, 9)); // вторые координаты