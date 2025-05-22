using System;
using AwarenessBot;
using CybersecurityAwareness;

namespace CybersecurityAwareness
{
    internal static class UserInteraction
    {
        /// Starts the user interaction loop and handles responses based on user input.
        /// Integrates sentiment detection and personalization.
        public static void ProvideResponses()
        {
            Console.WriteLine("You can ask me anything about cybersecurity.");
            Console.WriteLine("Your questions may involve phishing, password safety, my purpose in assisting, mitm, safe browsing, ransomware or spyware.");
            Console.WriteLine("You can type 'exit' at any time to end the session.\n");

            Console.WriteLine("What cybersecurity topics are you most interested in?");
            Console.Write("You: ");
            string interestInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(interestInput))
            {
                Program.Memory.Interest = interestInput.ToLower();  // Store user's interest
                Console.WriteLine($"That is great! I will remember that you're interested in {interestInput}.");
            }

            while (true)
            {
                Console.Write("You: ");
                string input = Console.ReadLine()?.ToLower();

                // Handle invalid/empty input
                if (ErrorHandler.IsInvalidInput(input))
                {
                    Console.WriteLine(ErrorHandler.GetDefaultResponse());
                    continue;
                }

                // Detect user's sentiment from input
                var sentiment = SentimentAnalyzer.DetectSentiment(input);

                // This will hold the final message to output
                string response = null;

                // Memory recall commands
                if (input.Contains("remember") || input.Contains("recall"))
                {
                    if (input.Contains("name"))
                        response = $"I remember, your name is {Program.Memory.Name}";
                    else if (input.Contains("interest"))
                        response = $"You told me that you're interested in {Program.Memory.Interest}";
                }
                else if (input.Contains("how are you"))
                {
                    response = Program.Memory.PersonalizeResponse("I am just a bot, but I'm functioning well. Thanks for asking!");
                }
                else if (input.Contains("your purpose"))
                {
                    response = Program.Memory.PersonalizeResponse("My purpose is to assist and educate users about cybersecurity.");
                }
                // Topic-based responses - handled in separate static class
                else if (input.Contains("phishing"))
                {
                    ResponseManager.HandlePhishingResponse();
                    continue;
                }
                else if (input.Contains("password"))
                {
                    ResponseManager.HandlePasswordResponse();
                    continue;
                }
                else if (input.Contains("safe browsing"))
                {
                    ResponseManager.HandleSafeBrowsingResponse();
                    continue;
                }
                else if (input.Contains("ransomware"))
                {
                    ResponseManager.HandleRansomwareResponse();
                    continue;
                }
                else if (input.Contains("spyware"))
                {
                    ResponseManager.HandleSpywareResponse();
                    continue;
                }
                else if (input.Contains("mitm"))
                {
                    ResponseManager.HandleMITMResponse();
                    continue;
                }
                else if (input.Contains("exit"))
                {
                    response = Program.Memory.PersonalizeResponse("Goodbye! I hope you learned more about cybersecurity. See you next time and remember to stay safe online.");
                    Console.WriteLine(SentimentAnalyzer.GetSentimentResponse(sentiment, response));
                    break;
                }
                // Default response for unrecognized input
                else
                {
                    response = ErrorHandler.GetDefaultResponse();
                }

                // Output the final response with sentiment-based tone
                if (!string.IsNullOrEmpty(response))
                {
                    string finalResponse = SentimentAnalyzer.GetSentimentResponse(sentiment, response);
                    Console.WriteLine(finalResponse);
                }
            }
        }
    }
}
