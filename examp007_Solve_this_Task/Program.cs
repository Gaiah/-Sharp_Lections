int count = 0;
while (count < 100) {
    int dot1 = new Random().Next(1, 100);
int dot2 = new Random().Next(1, 100);
int dotMin;
int dotMax;

if (dot1 < dot2) {
    dotMin = dot1;
    dotMax = dot2;
}

else {
    dotMin = dot2;
    dotMax = dot1;
}

int dot3 = (dotMax - dotMin) / 2 + dotMin;

Console.WriteLine(dot1);
Console.WriteLine(dot2);
Console.WriteLine("These are your dots");
Console.Write("The 'middle' of your dots is: ");
Console.WriteLine(dot3);
count = count ++;
//count += 1
}