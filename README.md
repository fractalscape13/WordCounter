# _WordCounter_

#### _A C# console program that checks for the occurence of a chosen word in a sentence, 03.06.2020_

#### By _**JW**_

## Description

_Lets a user enter a word and a sentence, and returns the amount of times the word occurs in the sentence._

## Setup/Installation Requirements

* _Setup requires dotnet core to be installed_
* _Visit my GitHub repository at https://github.com/fractalscape13/WordCounter and clone the repository (git clone https://github.com/fractalscape13/WordCounter)_
* _The dictionary file requires the file path to match the computer on which the program is run. If your project folder does not follow this path to the text file newDictionary.txt: (/Users/Guest/Desktop/WordCounter.Solution/newDictionary.txt), it won't work.  Either adjust the file path on line 21 of WordCounter.Solution/WordCounter/Models/WordCounter.cs to fit your location, or you can bypass this by commenting out or deleting line 16 of WordCounter.Solution/WordCounter/Program.cs and commenting in (remove the slashes) on line 18, which will set the value of 'bool realWord' permanently to true._
* _In terminal, navigate to WordCounter directory and run "dotnet build" to build program_
* _In terminal, run "dotnet run" to run program_
* _Open files in text editor to view code_

## Specifications


| Behavior       | Input    | Output     |
| :------------- | :----------: | -----------: |
| Allow a user to enter a word  | Example: User enters "sample"  | Return: "sample"  |
| Allow a user to enter a sentence  | Example: User enters "This is a sample sentence"  | Return: "This is a sample sentence"  |
| Validate that word only contains letters  | Example: User enters "sk8board"  | Return: Error message  |
| Validate that sentence only contains letters  | Example: User enters "My sentence is: sk8boarding is cool!"  | Return: Error message  |
| Allow a user to see frequency of occurence of word in sentence  | Example: Submits valid word and sentence  | Return: "sample" occurs 1 time in this sentence  |
| Allow a user to start program over  | Example: User enters "yes"  | Return: Program starts over  |


## Known Bugs

_No known bugs_

## Support and contact details

_Have feedback, found a bug, or just want to say hi? Submit a pull request on the repository_

## Technologies Used

_Git, C#, .NET, MSTest_

### License

MIT License, 2020 **_JW_**