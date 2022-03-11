
var maxWidth = Console.LargestWindowWidth;
var maxHeight = Console.LargestWindowHeight;

var diretion = new List<(int, int)> { (2, 0), (0, -1), (-2, 0), (0, 1) };
var number = 1;

var positionWidth = maxWidth / 2;
var positionhHeight = maxHeight / 2;

Console.SetWindowSize(maxWidth, maxHeight);
Console.SetCursorPosition(positionWidth, positionhHeight);

var repetitions = 1;
var count = 1;
var way = 0;


try
{

    while (true)
    {
        for (int i = 0; i < repetitions; i++)
        {
            if(IsPrime(number))Console.Write("°");
            number++;

            positionWidth += diretion[way].Item1;
            positionhHeight += diretion[way].Item2;
            Console.SetCursorPosition(positionWidth, positionhHeight);
            Thread.Sleep(10);
        }
        if (way == 3) way = 0;
        else way++;

        if (count % 2 == 0) repetitions++;
        count++;
    }
}
catch (Exception)
{

    Console.WriteLine("small screen");
}
static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;

    return true;
}