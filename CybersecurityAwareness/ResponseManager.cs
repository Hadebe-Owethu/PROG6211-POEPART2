using System;
using System.Collections.Generic;
using AwarenessBot;


namespace CybersecurityAwareness
{
    /// Manages topic-specific cybersecurity responses and personalizes them.
    internal static class ResponseManager
    {
        private static Random rnd = new Random();

        // Helper to get a personalized message from memory
        private static string GetPersonalizedResponse(string message)
        {
            return Program.Memory.PersonalizeResponse(message);
        }

        public static void HandlePhishingResponse()
        {
            var phishingTips = new List<string> 
            {
                
                    "Phishing is the fraudulent communications that may appear legitimate and a reputable source. Usually done through emails and text messaging.",
                    "Avoid clicking on any links in unsolicated emails or messages! Always verify the source first.",
                    "Enable two-factor authentication wherever possible to add an extra layer of security",
                    "Be careful of emails that ask for any personal information. Scammers usually disguise themselves as trusted organisations. "
                  };
                Console.WriteLine(GetPersonalizedResponse(phishingTips[rnd.Next(phishingTips.Count)]));
            }
        public static void HandlePasswordResponse()
        {
            var passwordSafety = new List<string> 
            {
                        "It is crucial to have a strong password to prevent any unauthorized access to your accounts and sensitive data.",
                        "Enable two-factor authentication whenever it is possible. This helps in adding an extra layer of security by requiring a second form of verification, such as a code that can be sent to your phone or any other device.",
                        "Update your passwords regularly! Change your password annually, especially for sensitive accounts. If a server experiences a data breach, update your password immediatly."
            };
            Console.WriteLine(GetPersonalizedResponse(passwordSafety[rnd.Next(passwordSafety.Count)]));
        }
        public static void HandleSafeBrowsingResponse()
        {
            var saferBrowsing = new List<string> 
            {
                        "Use HTTPS Websites: Websites that start with 'https://', indicate that the website uses encryption to protect your data. Avoid entering any sensitive information on sites that only use http. ",
                        "Be cautious with links and attachments! Do not click on suspicious links or download attachments from untrusted sources, as they may contain malware or phishing attempts",
                        "Keep your browser and software updated! This is to ensure that you have the latest security patches, which protects you against vulnerabilities and malicious attacks.",
                        "Use a reliable security tool! You can do this by installing and maintain reputable antivirus or anti-malware software. Consider using a VPN or secure browser extension for added privacy and protection."
            };
            Console.WriteLine(GetPersonalizedResponse(saferBrowsing[rnd.Next(saferBrowsing.Count)]));
        }
        public static void HandleRansomwareResponse()
        {
            var Ransomware = new List<string> 
            {
                        "Ransomware is a walware that locks your files and demands a ransom payment to regain access.",
                        "Always keep updated backups of important data, stored offline or in a secure cloud service. If ransomware strikes, you will be able to restore your files without paying the ransom.",
                        "Use up-to-date antivirus software and enable firewalls to block any malicious activity. You must also ensure all software and systems receive regular security updates.",
                        "Limit the number of accounts with administrative rights. Ransomware often exploits high-level access to encrypt files, so keeping permissions restricted reduces the potential damage."
            };
            Console.WriteLine(GetPersonalizedResponse(Ransomware[rnd.Next(Ransomware.Count)]));
        }
        public static void HandleSpywareResponse()
        {
            var Spyware = new List<string>
            {
                        "Spyware is a walware that is installed on a device without the user's knowledge. It secretely gathers information about the user and device usage.",
                        "Use trusted security software! Install reputable anti-spyware and anti-malware tools to detect and remove any spyware. Keep them updated to counter evolving threats.",
                        "Beware of free software and downloads! Many spyware infections come from unverified apps, browser extensions, or pirated software. Always download from official sources and verify authenticity.",
                        "Adjust privacy and permissions! Review the permissions of your apps on your device. Spyware often exploits excessive access,so limit the permissions, especially for location, microphone, and camera usage."
            };
            Console.WriteLine(GetPersonalizedResponse(Spyware[rnd.Next(Spyware.Count)]));
        }
        public static void HandleMITMResponse()
        {
            var MITM = new List<string> 
            {
                        "Mitm is a cyberattack where an attacker intercepts and relays communication between two parties.",
                        "Enable Multi-Factor Authentication (MFA)! If an attacker intercepts login credentials, MFA adds an extra layer of security, which reduces the chances of unauthorized access.",
                        "Avoid using public wi-fi for sensitive transactions! MITM attackers often exploit unsecured networks like public Wi-Fi. If you want to use them, connect through a VPN to encrypt your data.",
                        "Use encrypted connections! Always enable HTTPS, VPNs, and end-to-end encryption when communicating online. This prevents attackers from intercepting any sensitive information."
             };
            Console.WriteLine(GetPersonalizedResponse(MITM[rnd.Next(MITM.Count)]));
        }
    }
}
    

