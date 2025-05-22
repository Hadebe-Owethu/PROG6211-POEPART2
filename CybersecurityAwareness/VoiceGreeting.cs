using System.Media;


namespace CybersecurityAwareness
{
    internal static class VoiceGreeting
    {
        public static void Play()
        {
            string filepath = "C:\\Users\\lab_services_student\\Desktop\\prog6221-poe-Hadebe-Owethu\\voiceRecording.wav";

            using (SoundPlayer player = new SoundPlayer(filepath))
            {
                player.PlaySync();
            }
        }
    }
}
