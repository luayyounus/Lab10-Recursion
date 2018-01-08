# Tower of Hanoi - Math Puzzle
The Tower of Hanoi is a mathematical game or puzzle. It consists of three rods and a number of disks of different sizes, which can slide onto any rod. The puzzle starts with the disks in a neat stack in ascending order of size on one rod, the smallest at the top, thus making a conical shape.

## Overview
This is a C# console application. The purpose of this program is to show possible puzzle moves with Recursion.

## Requirements to run the Application
- [Visual Studio 2017 Community with .NET Core 2.0 SDK](https://www.microsoft.com/net/core#windowscmd)
- [GitBash / Terminal](https://git-scm.com/downloads) or [GitHub Extension for Visual Studio](https://visualstudio.github.com)

## Getting Started
1. Clone the repository to your local machine.
2. Cd into the application directory where the `AppName.sln` exist.
3. Open the application using `Open/Start AppName.sln`.
4. Once Visual Studio is opened, you can Run the application by clicking on the Play button <img src="https://github.com/luayyounus/Lab02-Unit-Testing/blob/Lab02-Luay/WarCardGame/play-button.jpg" width="16">.
5. A welcome message with instructions will be displayed to teach you how to get the results.

## Diagram Explaining the Puzzle
![Tower Of Hanoi](TowerOfHanoi.gif?raw=true "Inheritance")

#### The whole concept is to move a pile of disks from one rod to another using a helper rode.
**A few rules should be applied to the puzzle:-**
- Only one disk is allowed to move at a time.
- Bigger disks can never be on the top of smaller ones.
- Minimum number of disks to move is 1.

#### To calculate the minimum number of moves required for the stack to be transferred, the following formula is used:-
- `Total Number of Moves = (2 ^ Number Of Disks) - 1` ... Note that `^` is the power operator.

#### Considering that we have three rods/pegs, let's give every one of them a number.
**E.g.: 1-2-3 in ascending order where:**
- **'1'** is the starting pile that has the disks.
- **'2'** is the helper rod that will be calculated every recursive call.
- **'3'** is the destination rode where the final move will happen.

#### The steps taken to calculate movements on the disks are:
1. Move (n - 1) disk from pile 1 to 3 using the helper pile 2 as an intermediate.
2. Move nth disk from pile 1 to 3
3. Move (n - 1) disk from 2 to 3 using the helper pile 1 as an intermediate.

**Note**: `n` is the number of disks needs to be transferred.

##### After performing the total amount of recursive calls calculated earlier, the destination pile will have all the disks ordered exactly as they were on the first rod at the beginning of the puzzle.

### Architecture
 - C# Console Core application.
