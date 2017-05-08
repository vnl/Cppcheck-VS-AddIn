# Cppcheck VS AddIn

<!-- Replace this badge with your own-->
[![Build status](https://ci.appveyor.com/api/projects/status/o27wunv5g1p63or6?svg=true)](https://ci.appveyor.com/project/vnl/cppcheck-vs-addin)

<!-- Update the VS Gallery link after you upload the VSIX-->
Download this extension from the [VS Gallery](https://visualstudiogallery.msdn.microsoft.com/[GuidFromGallery])
or get the [CI build](http://vsixgallery.com/extension/884bcde1-206c-4261-b159-b8df2942e457/).

---------------------------------------

Visual Studio integration for Cppcheck, an open-source static code analyzer for C++

#### What is Cppcheck?

[Cppcheck](http://cppcheck.sourceforge.net/) is a static analysis tool for C/C++ code. Unlike C/C++ compilers and many other analysis tools it does not detect syntax errors in the code. Cppcheck primarily detects the types of bugs that the compilers normally do not detect. The goal is to detect only real errors in the code (i.e. have zero false positives).

See the [change log](CHANGELOG.md) for changes and road map.

## Features

- Automatically checking every C / C++ source file upon saving;
- Checking the currently selected project in the Solution Explorer (**Tools -> Check current project**)
- Convenient message suppression management with options to suppress specific messages, all messages in a given file, specific message types in a given file, message types globally, solution-wide and project-wide.


### Feature 1
Describe feature 1. Add screenshots/code samples etc.

## Contribute
Check out the [contribution guidelines](CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure
to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features
used by this project.

Should work flawlessly under VS2017.

## License
[Apache 2.0](LICENSE)