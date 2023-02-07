// iteration 1
Console.Write("How long is the break");
var breakDouble = double.Parse(Console.ReadLine());

Console.Write("How long is the song");
var songLength = TimeSpan.Parse(Console.ReadLine());
var totalMinutes = songLength.TotalMinutes;


var endBreak = DateTimeOffset.Now.AddMinutes(breakDouble);

Console.Write($"At the end of the break it will be {endBreak}\n\n");

Console.Write($"The user should start the song at {endBreak.AddSeconds(totalMinutes * -1)}");

//Iteration 2

var timeRemaining = breakDouble;
while (timeRemaining > 0)
{
    Console.Write($"There are {timeRemaining} minutes left in the break\n");
    Thread.Sleep(1000);
    timeRemaining -= 1;
}