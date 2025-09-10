# "Genius or Idiot" Game

A console quiz game where players answer logical questions and receive a "diagnosis" based on their performance.

## Description

"Genius or Idiot" is a simple C# console game that presents players with 5 logical questions requiring numerical answers. Based on the number of correct answers, the player receives a "diagnosis" ranging from "cretin" to "genius".

## Features

* Randomized question order each playthrough
* Input validation (numbers only)
* Option to play multiple rounds
* Correct answer counter
* "Diagnosis" based on performance

## How to Play

1. Launch the program
2. Enter your name
3. Answer questions by entering numerical values
4. Receive your "diagnosis" based on results
5. Choose to play again if desired

## Technical Details

Developed in C# as a console application. The project structure includes three classes:
* `Program` - main game logic
* `Question` - class for storing questions and answers
* `Diagnose` - class for determining player's "diagnosis"

Questions are randomly shuffled before each game to provide variety in gameplay.
