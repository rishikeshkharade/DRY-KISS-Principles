// KISS Keep it Simple, Stupid

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles
{
    class AccessLevels
    {
        // Complex Nested if-Else
        public string GetAccessLevel(string role, bool isActive)
        {
            if (role == "Admin")
            {
                if (isActive)
                {
                    return "Full Access";
                }
                else
                {
                    return "Inactive Admin";
                }
            }
            else if (role == "user")
            {
                if (isActive)
                {
                    return "Limited Access";
                }
                else
                {
                    return "Inactive User";
                }
            }
            else if (role == "Guest")
            {
                return "Read Only Acess";
            }
            else
            {
                return "No Access";
            }
        } 

        // Refactored Code
        public string GetAccessLevel1(string role, bool isActive)
        {
            if (role == "Admin")
                return isActive ? "Full Access" : "Inactive Admin";

            if (role == "User")
                return isActive ? "Limited Access" : "Inactive User";

            if (role == "Guest")
                return "Read Only Access";

            return "No Access";
        }

        //Further Simplification
        public string GetAccessLevel2(string role, bool isActive)
        {
            var accessLevels = new Dictionary<string, string>
            {
                {"Admin", isActive ? "FullAccess" : "Inactive Admin" },
                {"User", isActive ? "FullAccess" : "Inactive User" },
                {"Guest", "Read Only Access" }
            };

            return accessLevels.TryGetValue(role, out var accessLevel) ? accessLevel : "No Access";
        }
    }

    class KISS
    {
        public static void KISSMain()
        {
            AccessLevels accessLevels = new AccessLevels();
            Console.WriteLine(accessLevels.GetAccessLevel("Admin",true));

            Console.WriteLine(accessLevels.GetAccessLevel1("Guest",true));

            Console.WriteLine(accessLevels.GetAccessLevel2("User",true));
        }
    }
}
