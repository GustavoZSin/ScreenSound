namespace ScreenSound.Models
{
    internal interface IAssessable
    {
        void AddAvaliation(Avaliation rate);
        double Average { get; }
    }
}
