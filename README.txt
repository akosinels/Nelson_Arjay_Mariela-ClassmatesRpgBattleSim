Classmates RPG Battle Simulator
=============================

A fun RPG-style battle simulator where characters are inspired by classmates and classroom roles.

Character Types
--------------
1. CodeCrusher
   - A character inspired by students who excel at programming
   - Has consistent damage output with occasional critical hits
   - Higher health pool for sustainability
   - Special ability: 20% chance for critical hits that deal double damage

2. QuizMaster
   - A character inspired by students who excel at quizzes and tests
   - Can deal massive damage but has a chance to miss
   - Lower health pool but higher potential damage
   - Special abilities:
     * 30% chance to miss completely
     * 15% chance for "perfect answer" that deals triple damage

OOP Principles Implementation
---------------------------
1. Encapsulation
   - Private fields and protected properties in ClassFighter
   - Health and MaxHealth are protected to prevent direct manipulation
   - Properties with get/set accessors for controlled access

2. Inheritance
   - ClassFighter as the abstract base class
   - CodeCrusher and QuizMaster inherit from ClassFighter
   - Common functionality shared through inheritance

3. Polymorphism
   - Abstract Attack() method in ClassFighter
   - Each character type implements its own unique attack logic
   - Runtime polymorphism through method overriding

4. Abstraction
   - ClassFighter as an abstract class
   - Abstract Attack() method defining the interface
   - Implementation details hidden in derived classes

5. Exception Handling
   - Input validation for names and health values
   - Try-catch blocks in battle logic
   - User-friendly error messages

Challenges Faced
---------------
1. Balancing character abilities to ensure fair gameplay
2. Implementing smooth UI updates during battle
3. Managing state during battle to prevent multiple battles
4. Creating engaging and unique character types

How to Run
----------
1. Open the solution in Visual Studio
2. Build the project
3. Run the application
4. Enter player names and select character types
5. Click "Start Battle" to begin

Note: This project is for educational purposes and demonstrates the implementation of OOP principles in a fun and engaging way. 