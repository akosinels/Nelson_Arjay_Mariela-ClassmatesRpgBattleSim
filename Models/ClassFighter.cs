using System;

namespace ClassmatesRpgBattleSim.Models
{
    /// <summary>
    /// Abstract base class for all character types in the RPG Battle Simulator.
    /// Demonstrates abstraction and encapsulation principles.
    /// </summary>
    public abstract class ClassFighter
    {
        // Properties with encapsulation
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int MaxHealth { get; protected set; }

        protected Random random = new Random();

        protected ClassFighter(string name, int maxHealth)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty or null", nameof(name));
            
            if (maxHealth <= 0)
                throw new ArgumentException("Max health must be greater than 0", nameof(maxHealth));

            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
        }

        /// <summary>
        /// Abstract method that must be implemented by derived classes.
        /// Demonstrates polymorphism as each character type will have its own attack logic.
        /// </summary>
        /// <returns>The amount of damage dealt</returns>
        public abstract int Attack();

        /// <summary>
        /// Method to handle taking damage, with health bounds checking.
        /// </summary>
        /// <param name="damage">Amount of damage to take</param>
        /// <returns>True if the character is still alive, false if defeated</returns>
        public bool TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException("Damage cannot be negative", nameof(damage));

            Health = Math.Max(0, Health - damage);
            return Health > 0;
        }

        /// <summary>
        /// Resets the character's health to maximum
        /// </summary>
        public void ResetHealth()
        {
            Health = MaxHealth;
        }
    }
} 