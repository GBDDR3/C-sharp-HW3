// Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());

double FindDistance(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double AxBx = Math.Pow((Ax - Bx), 2);
    double AyBy = Math.Pow((Ay - By), 2);
    double AzBz = Math.Pow((Az - Bz), 2);
    double Distanse = Math.Sqrt(AxBx + AyBy + AzBz);
    return Distanse;
}
double result = FindDistance(Ax,Ay,Az,Bx,By,Bz);
Console.WriteLine(result);