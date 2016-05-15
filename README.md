# Mini-MasterMind
CME 1101 - PROJECT BASED LEARNING I COURSE(2015) / Project 1 







Code / Project     :  CME1101 / 1
Year / Semester	:  2015-2016 Fall Semester 
Duration	      :  4 weeks


Project:  MMM (Mini MasterMind)

The aim of the project is to develop a two-player guessing game. 


Game Playing Rules

1. The game is played on 2-square rows.
2. Each square in a row can be 1, 2 or 3. The same number cannot be repeated.
3. There are two players: Codemaker and codebreaker.
4. Codemaker chooses the numbers/code to be guessed by codebreaker. The objective is guessing the codemaker's code with min. number of tries.
5. After each guess of the codebreaker, codemaker gives feedback.
6. In feedback, there are two numbers: positive and negative. The positive number gives the number of squares whose number and position are correct. The negative number gives the number of squares whose number is correct but position is wrong. 
7. There are two games in a round. In the first game, codemaker is the computer and codebreaker is the human player. In the second game, codemaker is the human player and codebreaker is the computer player. In each game, the number of guesses codebreaker needs to break the code is added to codemaker's score.
8. After 10 rounds, main game is finished. The player with max. score wins. 
9. Computer AI for the breaking code should not be brute force and cannot be greater than 3 guesses.


Sample Game


Round: 1
Game:  1
Computer Score: 0
Player Score: 0

Your Guess (1): 21
My Feedback: +1, -0

Your Guess (2): 23
My Feedback: +2, -0

You win.

--------------------



Round: 1
Game:  2
Computer Score: 2
Player Score: 0

My Guess (1): 12
Your Feedback (+): 0
Your Feedback (-): 2

My Guess (2): 21
Your Feedback (+): 2
Your Feedback (-): 0

I win.

--------------------


Round: 2
Game:  1
Computer Score: 2
Player Score: 2

Your Guess (1): 32
My Feedback: +0, -1

Your Guess (2): 31
My Feedback: +1, -0

Your Guess (3): 21
My Feedback: +2, -0

You win.

--------------------




Round: 2
Game:  2
Computer Score: 5
Player Score: 2

My Guess (1): 23
Your Feedback (+): 

...



Suggested Weekly Program

1. Discussing and designing solution alternatives, creating the necessary variables, screen.
2. Designing the flowchart of the project. Choosing 2-square code for computer codemaker. 
3. Computing feedback for computer codemaker. 
    Strategy and implementation of computer codebreaker (for one round). 
4. Playing the game for all rounds. Remaining parts of the game. 




First Evaluation: 9.10.2014 
               Report: 9.10.2014
 
 
Final Evaluation: 23.10.2014   (powerpoint + poster)
               Report: 26.10.2014                            



