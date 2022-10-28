double userInput;

void menu()
{
    Console.WriteLine("1. Convert from celsius to fahrenheit");
    Console.WriteLine("2. Convert from farhenheit to celsius");
    Console.WriteLine("3. Convert from celsius to kelvin");
    Console.WriteLine("4. Convert from kelvin to celsius");
    Console.WriteLine("5. Convert from fahrenheit to kelvin");
    Console.WriteLine("6. Convert from kelvin to fahrenheit");
    Console.WriteLine("7. Convert from inches to feet");
    Console.WriteLine("8. Convert from feet to inches");
    Console.WriteLine("9. Convert from inches to yards");
    Console.WriteLine("10. Convert from yards to inches");
    Console.WriteLine("11. Convert from fet to yards");
    Console.WriteLine("12. Convert from yards to feet");
    Console.WriteLine("13. Convert from seconds to minutes");
    Console.WriteLine("14. Convert from minutes to seconds");
    Console.WriteLine("15. Convert from seconds to hours");
    Console.WriteLine("16. Convert from hours to seconds");
    Console.WriteLine("17. Convert from hours to minutes");
    Console.WriteLine("18. Convert from minutes to hours");
    Console.WriteLine("Tell me what you want to do 1-18");
}
menu();

(double, temp) celsiusKelvin(double tempCelsius) 
{
    double tempKelvin;
    tempKelvin = tempCelsius + 273.15;
    Console.WriteLine($"{userInput} {temp.celsius} is {tempKelvin} {temp.kelvin}");
    return (tempKelvin, temp.kelvin);
}
(double, temp) fahrenheitKelvin(double tempFahrenheit) 
{
    double tempKelvin;
    tempKelvin = ((tempFahrenheit + 459.67) * 5) / 9;
    Console.WriteLine($"{userInput} {temp.fahrenheit} is {tempKelvin} {temp.kelvin}");
    return (tempKelvin, temp.kelvin);
}
(double, temp) kelvinFahrenheit(double tempKelvin) 
{
    double tempFahrenheit;
    tempFahrenheit = ((tempKelvin * (9)) / 5) - 459.67;
    Console.WriteLine($"{userInput} {temp.kelvin} is {tempFahrenheit} {temp.fahrenheit}");
    return (tempFahrenheit, temp.fahrenheit);
}
(double, temp) celsiusFahrenheit(double tempCelsius) 
{
    double tempFahrenheit;
    tempFahrenheit = ((tempCelsius * (9)) / 5) + 32;
    Console.WriteLine($"{userInput} {temp.celsius} is {tempFahrenheit} {temp.fahrenheit}");
    return (tempFahrenheit, temp.fahrenheit);
}
(double, temp) fahrenheitCelsius(double tempFahrenheit) 
{
    double tempCelsius;
    tempCelsius = ((tempFahrenheit - 32) * 5) / 9;
    Console.WriteLine($"{userInput} {temp.fahrenheit} is {tempCelsius} {temp.celsius}");
    return (tempCelsius, temp.celsius);
}
(double, temp) kelvinCelsius(double tempKelvin) 
{
    double tempCelsius;
    tempCelsius = tempKelvin - 273.15;
    Console.WriteLine($"{userInput} {temp.kelvin} is {tempCelsius} {temp.celsius}");
    return (tempCelsius, temp.celsius);
}
(double, length) inchesFeet(double lengthInches) 
{
    double lengthFeet;
    lengthFeet = lengthInches / 12;
    Console.WriteLine($"{userInput} {length.inch} is {lengthFeet} {length.feet}");
    return (lengthFeet, length.feet);
}
(double, length) inchesYards(double lengthInches) 
{
    double lengthYards;
    lengthYards = lengthInches / 36;
    Console.WriteLine($"{userInput} {length.inch} is {lengthYards} {length.yard}");
    return (lengthYards, length.yard);
}
(double, length) feetInches(double lengthFeet) 
{
    double lengthInches;
    lengthInches = lengthFeet * 12;
    Console.WriteLine($"{userInput} {length.feet} is {lengthInches} {length.inch}");
    return (lengthInches, length.inch);
}
(double, length) feetYards(double lengthFeet) 
{
    double lengthYards;
    lengthYards = lengthFeet / 3;
    Console.WriteLine($"{userInput} {length.feet} is {lengthYards} {length.yard}");
    return (lengthYards, length.yard);
}
(double, length) yardsInches(double lengthYards) 
{
    double lengthInches;
    lengthInches = lengthYards * 36;
    Console.WriteLine($"{userInput} {length.yard} is {lengthInches} {length.inch}");
    return (lengthInches, length.inch);
}
(double, length) yardsFeet(double lengthYards) 
{
    double lengthFeet;
    lengthFeet = lengthYards * 3;
    Console.WriteLine($"{userInput} {length.yard} is {lengthFeet} {length.feet}");
    return (lengthFeet, length.feet);
}
(double, time) secondsMinutes(double timeSeconds) 
{
    double timeMinutes;
    timeMinutes = timeSeconds / 60;
    Console.WriteLine($"{userInput} {time.seconds} is {timeMinutes} {time.minutes}");
    return (timeMinutes, time.seconds);
}
(double, time) secondsHours(double timeSeconds) 
{
    double timeHours;
    timeHours = timeSeconds / 3600;
    Console.WriteLine($"{userInput} {time.seconds} is {timeHours} {time.hours}");
    return (timeHours, time.hours);
}
(double, time) hoursSeconds(double timeHours) 
{
    double timeSeconds;
    timeSeconds = timeHours * 3600;
    Console.WriteLine($"{userInput} {time.hours} is {timeSeconds} {time.seconds}");
    return (timeSeconds, time.seconds);
}
(double, time) hoursMinutes(double timeHours) 
{
    double timeMinutes;
    timeMinutes = timeHours * 60;
    Console.WriteLine($"{userInput} {time.hours} is {timeMinutes} {time.minutes}");
    return (timeMinutes, time.minutes);
}
(double, time) minutesHours(double timeMinutes) 
{
    double timeHours;
    timeHours = timeMinutes / 60;
    Console.WriteLine($"{userInput} {time.minutes} is {timeHours} {time.hours}");
    return (timeHours, time.hours);
}
(double, time) minutesSeconds(double timeMinutes) 
{
    double timeSeconds;
    timeSeconds = timeMinutes * 60;
    Console.WriteLine($"{userInput} {time.minutes} is {timeSeconds} {time.seconds}");
    return (timeSeconds, time.seconds);
}
void conversion()
{
    string converting = Console.ReadLine();
    if (converting == "1") 
    {
        Console.WriteLine("enter a temperature for celsius eh");
        userInput = double.Parse(Console.ReadLine());
        celsiusFahrenheit(userInput);
    }
    else if (converting == "2") 
    {
        Console.WriteLine("enter a temperature in fahrenheit");
        userInput = double.Parse(Console.ReadLine());
        fahrenheitCelsius(userInput);
    }
    else if (converting == "3") 
    {
        Console.WriteLine("enter a temperature in celsius eh");
        userInput = double.Parse(Console.ReadLine());
        celsiusKelvin(userInput);
    }
    else if (converting == "4") 
    {
        Console.WriteLine("enter a temperature in kelvin");
        userInput = double.Parse(Console.ReadLine());
        kelvinCelsius(userInput);
    }
    else if (converting== "5") 
    {
        Console.WriteLine("enter a temperature in fahrenheit");
        userInput = double.Parse(Console.ReadLine());
        fahrenheitKelvin(userInput);
    }
    else if (converting == "6") 
    {
        Console.WriteLine("enter a temperature in kelvin");
        userInput = double.Parse(Console.ReadLine());
        kelvinFahrenheit(userInput);
    }
    else if (converting == "7") 
    {
        Console.WriteLine("enter a length in inches");
        userInput = double.Parse(Console.ReadLine());
        inchesFeet(userInput);
    }
    else if (converting == "8") 
    {
        Console.WriteLine("enter a length in feet");
        userInput = double.Parse(Console.ReadLine());
        feetInches(userInput);
    }
    else if (converting== "9") 
    {
        Console.WriteLine("enter a length in inches");
        userInput = double.Parse(Console.ReadLine());
        inchesYards(userInput);
    }
    else if (converting == "10") 
    {
        Console.WriteLine("enter a length in yards");
        userInput = double.Parse(Console.ReadLine());
        yardsInches(userInput);
    }
    else if (converting == "11") 
    {
        Console.WriteLine("enter a length in feet");
        userInput = double.Parse(Console.ReadLine());
        feetYards(userInput);
    }
    else if (converting == "12") 
    {
        Console.WriteLine("enter a length in yards");
        userInput = double.Parse(Console.ReadLine());
        yardsFeet(userInput);
    }
    else if (converting == "13") 
    {
        Console.WriteLine("enter a time in seconds");
        userInput = double.Parse(Console.ReadLine());
        secondsMinutes(userInput);
    }
    else if (converting == "14") 
    {
        Console.WriteLine("enter a time in minutes");
        userInput = double.Parse(Console.ReadLine());
        minutesSeconds(userInput);
    }
    else if (converting == "15") 
    {
        Console.WriteLine("enter a time in seconds");
        userInput = double.Parse(Console.ReadLine());
        secondsHours(userInput);
    }
    else if (converting == "16") 
    {
        Console.WriteLine("enter a time in hours");
        userInput = double.Parse(Console.ReadLine());
        hoursSeconds(userInput);
    }
    else if (converting == "17") 
    {
        Console.WriteLine("enter a time in hours");
        userInput = double.Parse(Console.ReadLine());
        hoursMinutes(userInput);
    }
    else if (converting == "18") 
    {
        Console.WriteLine("enter a time in minutes");
        userInput = double.Parse(Console.ReadLine());
        minutesHours(userInput);
    }
    else
    {
        Console.WriteLine("no entiendo, choose a number between 1 and 18.");
        conversion();
    }
    Console.WriteLine("do you want to convert something else? yes or no");
    string anotherRound = Console.ReadLine();
    if (anotherRound== "yes" || anotherRound == "Yes")
    {
        menu();
        conversion();
    }
}
conversion();
enum temp { celsius, fahrenheit, kelvin }
enum length { inch, feet, yard }
enum time { seconds, minutes, hours }
