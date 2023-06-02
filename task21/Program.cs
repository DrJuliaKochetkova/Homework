// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int x1 = Prompt("Введите координату X точки А: ");
int x2 = Prompt("Введите координату X точки B: ");
int y1 = Prompt("Введите координату Y точки А: ");
int y2 = Prompt("Введите координату Y точки B: ");
int z1 = Prompt("Введите координату Z точки А: ");
int z2 = Prompt("Введите координату Z точки B: ");

void FindDistanse(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double d = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    Console.WriteLine("Расстояние между точками А и В: " + d);
}

FindDistanse(x1, x2, y1, y2, z1, z2);

// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)