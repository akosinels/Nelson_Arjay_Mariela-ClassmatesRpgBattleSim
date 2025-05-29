using System;

namespace ClassmatesRpgBattleSim.Models
{
    /// <summary>
    /// CodeCrusher - A character type that excels at dealing consistent damage
    /// with occasional critical hits. Inspired by students who are great at coding.
    /// </summary>
    public class CodeCrusher : ClassFighter
    {
        private const int BASE_DAMAGE = 15;
        private const int CRIT_CHANCE = 20; // 20% chance for critical hit
        private const int CRIT_MULTIPLIER = 2;

        public CodeCrusher(string name) : base(name, 100)
        {
        }

        public override int Attack()
        {
            // Base damage with some randomness
            int damage = BASE_DAMAGE + random.Next(-5, 6);

            // Check for critical hit
            if (random.Next(100) < CRIT_CHANCE)
            {
                damage *= CRIT_MULTIPLIER;
            }

            return Math.Max(1, damage); // Ensure minimum damage of 1
        }
    }
} 