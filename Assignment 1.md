# Assignment for Lesson 1

Before you can program a computer, you need to install a set of tools. 
The types of tools you use in general consist of the following:
1. Source Code Editor
2. Software Development Kit

A Source Code Editor is comparable to the word processing application that you use to write your essay's and reports. 
The difference is that a Code Editor provides feedback regarding the code you have written and whether it follows the 
rules, or syntax, of the language you are using. It also provides color coding of the different keywords, operators, and other components that
define the language itself.

The following is a simple overview of what an SDK and Compiler is so that you can gain just enough understanding to move on to the next step, without providing so much detail that you become overwhelmed before you start.

A Software Development Kit is a set of components that provide a framework to develop robust applications. It includes libraries, which are smaller programs that offer
a very specific set of capabilities and a compiler. A compiler is another application that is a suite of components. A compiler can be thought of a translator because
it is responsible for taking your high level language that you wrote your program in and translates it into the language of the computing machine that it will run on. 

Think about the first time you drove a car. You may not have known how an automatic transmission worked or the internal components of an engine. Yet, you knew that
the gas pedal and gear shift were provided for an explicit reason and without them, your driving experience may not have been very meaningful. 


## Learn by Doing
There is plenty of documentation and resources available on the internet to assist you in installing the software on your OS of choice. 

The most important thing to remember, and one of the hardest thing to do consistently, is to read the documentation before you begin. Even if you are comfortable with installing software, there are always edge cases that occur so it is best to read the docs first. This provides a level of understanding that allows you to be resiliant when your install doesn't go as anticipated. It may not happen today, but it will happen the longer you study and work with software. 

## Install SDK
The [.Net Core](https://dotnet.microsoft.com/) is an Open Source Framework developed by Microsoft. This is the minimum set of resources needed to begin your journey. 

## Install Code Editor
I will use [Visual Studio Code](https://code.visualstudio.com/) for quick application development and prototyping. This is a light weight editor that is meant
to get up and running quickly. 


## Run my version of the world's most famous first program

````csharp
using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everyone, Welcome to My World!");
        }
    }
}
````

## What's up with all that?
We will learn more about everything you see above. For now, just notice that the WriteLine function is what caused your program to write to the screen.