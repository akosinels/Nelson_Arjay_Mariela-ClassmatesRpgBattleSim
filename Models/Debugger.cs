using System;

namespace ClassmatesRpgBattleSim.Models
{
    /// <summary>
    /// Debugger - A character type that excels at analyzing and countering attacks.
    /// Has a chance to reflect damage back at the attacker.
    /// </summary>
    public class Debugger : ClassFighter
    {
        private const int BASE_DAMAGE = 12;
        private const double REFLECT_CHANCE = 0.25;
        private const int REFLECT_BONUS = 5;

        public Debugger(string name) : base(name, 120) // Higher health pool for sustainability
        {
        }

        public override int Attack()
        {
            // Base damage with some randomness
            int damage = BASE_DAMAGE + random.Next(-4, 5);

            // 25% chance to analyze and reflect with bonus damage
            if (random.NextDouble() < REFLECT_CHANCE)
            {
                damage = (int)(damage * 2) + REFLECT_BONUS;
                Console.WriteLine($"{Name} analyzes the situation and reflects the attack with bonus damage!");
            }

            return Math.Max(1, damage); // Ensure minimum damage of 1
        }
    }
} 