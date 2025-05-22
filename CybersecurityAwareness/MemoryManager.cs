using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwareness
{
    /// Manages user data (name, interest, etc.) and provides personalized messaging.

    internal class MemoryManager
    {
        // Case-insensitive dictionary for storing user info
        private Dictionary<string, string> userData = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        // Property to get/set user’s name
        public string Name
        {
            get => userData.TryGetValue("name", out string name) ? name : null;
            set => userData["name"] = value;
        }

        // Property to get/set user’s interest topic
        public string Interest
        {
            get => userData.TryGetValue("interest", out string interest) ? interest : null;
            set => userData["interest"] = value;
        }

        // Save custom key-value data to memory
        public void Remember(string key, string value)
        {
            userData[key.ToLower()] = value;
        }

        // Retrieve previously stored data by key
        public string Recall(string key)
        {
            return userData.TryGetValue(key.ToLower(), out string value) ? value : null;
        }

        // Create personalized message using name and/or interest
        public string PersonalizeResponse(string message)
        {
            if(!string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Interest))
            {
                return $"{Name}, since you're interested in {Interest}, {message}";
            }

            else if(!string.IsNullOrEmpty(Name))
            {
                return $"{Name}, {message}";
            }

            else if(!string.IsNullOrEmpty(Interest))
            {
                return $"Since you're interested in {Interest}, {message}";
            }
            return message;
        }
    }
}
