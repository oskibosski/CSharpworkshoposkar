// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//i wish to write a functio that 
// does not take any arguments
// does not return anything

//function definition 
void FunctionTypeone()
{
    string somestring1 = "Hey guys, the Flash movie is not that good";
    Console.WriteLine(somestring1);
}

//function call
FunctionTypeone();

//Type Two
//i wish to write a funciton that
// that will take single integer parameter
//and does not return anything

void FunctionTypeTwo(int numberofmovies)
{
    string outputSentence = $" I have watched {numberofmovies} moives this year";
    Console.WriteLine(outputSentence);
}

int tobesentToFunctionMovieCount = 200;

FunctionTypeTwo(tobesentToFunctionMovieCount);

FunctionTypeTwo(10);

//same as type 2 but with more than one parameter

void FunctionTypeTwoPartB(int one, string two ,bool three)
{
    string someOutput = $"The Values are {one}, {two}, {three}";
    Console.WriteLine(someOutput);
}

int one = 1;
string two = "two";
bool three = true;

FunctionTypeTwoPartB(one, two, three);

//function call
//a function that is taking some parameters
//and returning some value

//function definition

//function that will add two numbers
int FunctionThatAddsTwoNumbers(int numberOne , int numberTwo)
{
    int sum = numberOne + numberTwo;
    return sum;
}

int doubleoseven = 7;
int randomagent = 50;

//function call

int result = FunctionThatAddsTwoNumbers(doubleoseven,randomagent);

string outputofAgents =$"The sum of {doubleoseven} and {randomagent} is {result}";
Console.WriteLine(outputofAgents);




