# MathFloat

[![Build status](https://ci.appveyor.com/api/projects/status/b192sp8vox65a5t7/branch/master?svg=true)](https://ci.appveyor.com/project/LukasBoersma/mathfloat/branch/master)


This is a tiny .NET library with float versions of System.Math methods. MathFloat works with .NET 2.0 or newer.

You can install this library from [Nuget](PM> Install-Package MathFloat):

````
PM> Install-Package MathFloat
````

## How to use

The API is identical to [System.Math](https://msdn.microsoft.com/en-us/library/system.math(v=vs.110).aspx).

Usage example for C#:

````csharp

using MathFloat;

[...]

float x = MathF.Sin(1.23f, 4.56f);

````

If you use C# 6 or newer, you can also use the new `using static`-Feature:

````csharp

using static MathFloat.MathF;

[...]

var x = Sin(1.23f, 4.56f);

````

## License and contributing

This software is distributed under the terms of the MIT license. You can use it for your own projects for free under the conditions specified in LICENSE.txt. 

If you have questions, feel free to contact me. Visit [lukas-boersma.com](https://lukas-boersma.com) for my contact details.

If you think you found a bug, you can open an Issue on Github. If you make changes to this library, I would be happy about a pull request. Please note that `MathF.cs` is auto-generated, so any fixes should be made in the generator code.

