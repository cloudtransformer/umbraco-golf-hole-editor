namespace AgeBase.GolfHoleEditor.Models
{
    /// <summary>
    /// Property converter model class to represent an
    /// individual golf tee.
    /// </summary>
    public class GolfTee
    {
        /// <summary>
        /// Gets or sets the name of the golf tee.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the par of the golf tee.
        /// </summary>
        public int Par { get; set; }

        /// <summary>
        /// Gets or sets the stroke index of the golf tee.
        /// </summary>
        public int StrokeIndex { get; set; }

        /// <summary>
        /// Gets or sets the distance of the golf tee.
        /// </summary>
        public int Distance { get; set; }
    }
}