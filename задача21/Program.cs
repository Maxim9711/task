// x, y, z
// crd - coordinates
double dist(int [] crdFirst, int [] crdSecond){
    double dist = 0;
    dist = Math.Sqrt((crdSecond[0] - crdFirst[0])*(crdSecond[0] - crdFirst[0]) + 
                     (crdSecond[1] - crdFirst[1])*(crdSecond[1] - crdFirst[1]) +
                     (crdSecond[2] - crdFirst[2])*(crdSecond[2] - crdFirst[2])); 
    return dist;
}

int[] pointFirst = new int[] {0, 0, 0};
int[] pointSecond = new int[] {0, 0, 0};

Console.WriteLine($"Введите координаты первой точки");
Console.Write($"x: ");
pointFirst[0] = Convert.ToInt32(Console.ReadLine());
Console.Write($"y: ");
pointFirst[1] = Convert.ToInt32(Console.ReadLine());
Console.Write($"z: ");
pointFirst[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координаты второй точки");
Console.Write($"x: ");
pointSecond[0] = Convert.ToInt32(Console.ReadLine());
Console.Write($"y: ");
pointSecond[1] = Convert.ToInt32(Console.ReadLine());
Console.Write($"z: ");
pointSecond[2] = Convert.ToInt32(Console.ReadLine());

Console.Write($"Расстояние между точками: ");
Console.WriteLine(dist(pointFirst, pointSecond));
