using System;
using System.Linq;

namespace SimonSaysProject
{
    public class CommandProvider
    {
        private readonly char[] commands;
        private readonly Random random;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandProvider"/> 
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor sets up the internal command array used for 
        /// generating command patterns in the Simon Says game and initializes 
        /// the random number generator.
        /// </remarks>
        public CommandProvider()
        {
            commands = new char[] { 'W', 'A', 'S', 'D' };
            random = new Random(); // Initialize the random number generator
        }


        /// <summary>
        /// Generates a random pattern of commands based on the specified round 
        /// number.
        /// </summary>
        /// <param name="round">An <see cref="int"/> representing the number of 
        /// commands to generate in the pattern.</param>
        /// <returns>
        /// A <see cref="string"/> representing the generated pattern of 
        /// commands. The pattern is composed of randomly 
        /// chosen commands from the array <c>{"W", "A", "S", "D"}</c>, with the
        /// length of the pattern being equal to the round number.
        /// </returns>
        /// <remarks>
        /// The pattern is generated by randomly selecting commands from the 
        /// predefined array of commands ({"W", "A", "S", "D"}) 
        /// and joining them into a single string. The round number determines 
        /// how many commands are included in the pattern.
        /// </remarks>
        public string GeneratePattern(int round)
        {
            string pattern = string.Empty; // Initialize an empty string to store the pattern

            // Generate a random pattern of commands based on the round number
            for (int i = 0; i < round; i++)
            {
                // Select a random command from the commands array
                pattern += commands[random.Next(commands.Length)];
            }

            return pattern; // Return the generated pattern
        }
    }
}