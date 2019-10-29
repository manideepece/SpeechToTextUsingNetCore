using Microsoft.CognitiveServices.Speech;
using System;
using System.Threading.Tasks;

namespace SpeechToTextClassLibrary
{
    public class Repository
    {
        public string ReturnSpeech()
        {
            Task<string> task = Task.Run(async () => await RecognizeSpeechAsync());
            return task.Result;
        }

        public static async Task<string> RecognizeSpeechAsync()
        {
            // Creates an instance of a speech config with specified subscription key and service region.
            // Replace with your own subscription key // and service region (e.g., "westus").
            var config = SpeechConfig.FromSubscription("19ee855d47dc419e827a085193ea1b1a", "centralus");

            // Creates a speech recognizer.
            using (var recognizer = new SpeechRecognizer(config))
            {

                // Starts speech recognition, and returns after a single utterance is recognized. The end of a
                // single utterance is determined by listening for silence at the end or until a maximum of 15
                // seconds of audio is processed.  The task returns the recognition text as result. 
                // Note: Since RecognizeOnceAsync() returns only a single utterance, it is suitable only for single
                // shot recognition like command or query. 
                // For long-running multi-utterance recognition, use StartContinuousRecognitionAsync() instead.
                var result = await recognizer.RecognizeOnceAsync();

                // Checks result.
                if (result.Reason == ResultReason.RecognizedSpeech)
                {
                    return result.Text;
                }
                else if (result.Reason == ResultReason.NoMatch)
                {
                    return "Speech could not be recognized.";
                }
                else if (result.Reason == ResultReason.Canceled)
                {
                    var cancellation = CancellationDetails.FromResult(result);

                    if (cancellation.Reason == CancellationReason.Error)
                    {
                        return cancellation.ErrorCode + " " + cancellation.ErrorDetails + " Did you update the subscription info?";
                    }
                    return cancellation.Reason.ToString();
                }
            }
            return string.Empty;
        }
    }
}
