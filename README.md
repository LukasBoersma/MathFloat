# MathFloat

This is a tiny .Net library with float versions of System.Math methods.

## License and contributing

This software is distributed under the terms of the MIT license. You can use it for your own projects for free under the conditions specified in LICENSE.txt. 

If you have questions, feel free to contact me. Visit [lukas-boersma.com](https://lukas-boersma.com) for my contact details.

If you think you found a bug, you can open an Issue on Github. If you make changes to this library, I would be happy about a pull request. Please note that `MathF.cs` is auto-generated, so any fixes should be made in the generator code.

## How to use

The API is identical to [System.Math](https://msdn.microsoft.com/en-us/library/system.math(v=vs.110).aspx).

Usage example:

````csharp

using MathFloat;

[...]

float x = Math.Sin(1.23f, 4.56f);

````