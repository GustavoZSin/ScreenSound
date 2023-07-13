using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class MenuBandAvaliate : Menu
    {
        internal override void Execute()
        {
            SetReviewToABand();
        }
        private void SetReviewToABand()
        {
            ShowSubtitleSection("Review a Band");

            Console.Write("Type the band that you want to rate: ");
            string bandToReview = Console.ReadLine()!;

            if (Band.BandList.ContainsKey(bandToReview))
            {
                Band band = Band.BandList[bandToReview];

                Console.Write($"What's your rating to the band {bandToReview}? ");
                Avaliation rating = Avaliation.Parse(Console.ReadLine()!);
                band.AddAvaliation(rating);

                Console.WriteLine($"\nYour rating was added to the band {bandToReview}. Thank you for the contribuition.");
                base.Execute();
            }
            else
            {
                Console.WriteLine($"Band '{bandToReview}' not found.");
                base.Execute();
            }
        }

    }
}
