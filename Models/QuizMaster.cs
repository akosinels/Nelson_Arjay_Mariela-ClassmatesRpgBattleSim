using System;

namespace ClassmatesRpgBattleSim.Models
{
    /// <summary>
    /// QuizMaster - A character type that has a chance to deal massive damage
    /// but can also miss completely. Inspired by students who excel at quizzes.
    /// </summary>
    public class QuizMaster : ClassFighter
    {
        private const int BASE_DAMAGE = 20;
        private const int MISS_CHANCE = 30; // 30% chance to miss
        private const int PERFECT_ANSWER_CHANCE = 15; // 15% chance for perfect answer
        private const int PERFECT_ANSWER_MULTIPLIER = 3;

        public QuizMaster(string name) : base(name, 80) // Lower health but higher potential damage
        {
        }

        public override int Attack()
        {
            // Check for miss
            if (random.Next(100) < MISS_CHANCE)
            {
                return 0; // Complete miss
            }

            // Base damage with some randomness
            int damage = BASE_DAMAGE + random.Next(-8, 9);

            // Check for perfect answer
            if (random.Next(100) < PERFECT_ANSWER_CHANCE)
            {
                damage *= PERFECT_ANSWER_MULTIPLIER;
            }

            return Math.Max(1, damage); // Ensure minimum damage of 1
        }
    }
} 