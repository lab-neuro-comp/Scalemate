[![Scalemate](Identity/Banner.png)](https://github.com/ishiikurisu/Scalemate/releases)

Scalemate is a psychological scales engine for C#. Any test composed of written of questions and answers can be implemented here.

Scalemate was written by [Cris Silva Jr.](http://www.crisjr.eng.br) in the Laboratory of Neuroscience and Behavior at the University of Brasília, and it was released under the [MIT License](https://opensource.org/licenses/MIT).

# Building

This project is being made and built with [Microsoft Visual Studio](https://www.visualstudio.com). It does not have external dependencies. Just open solution and build it.

## Project Structure

The solution in the [Scalemate](Scalemate) folder is composed of two projects: [`Scalemate`](Scalemate/Scalemate) and [`ScalemateForms`](Scalemate/ScalemateForms).

The `Scalemate` project holds the main library with the *Tester* class and an interface to communicate with it.

The `ScalemateForms` project is an implementation of the Scalemate engine using [Microsoft's Windows Forms](https://docs.microsoft.com/en-us/dotnet/framework/winforms/index) framework.
