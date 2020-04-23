using System;

namespace Fitness.BL.Model
{
    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Create new gender
        /// </summary>
        /// <param name="name"> Gender name. </param>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Gender can not be empty or null", nameof(name));       
            }

            Name = name;
           
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
