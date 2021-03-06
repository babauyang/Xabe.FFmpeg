namespace Xabe.FFmpeg
{
    /// <summary>
    ///     Preset of conversion. Faster speed causes worse optimization and quality.
    /// </summary>
    public enum ConversionPreset
    {
        /// <summary>
        ///     Very slow
        /// </summary>
        VerySlow,

        /// <summary>
        ///     Slower
        /// </summary>
        Slower,

        /// <summary>
        ///     Slow
        /// </summary>
        Slow,

        /// <summary>
        ///     Medium
        /// </summary>
        Medium,

        /// <summary>
        ///     Fast
        /// </summary>
        Fast,

        /// <summary>
        ///     Faster
        /// </summary>
        Faster,

        /// <summary>
        ///     Very fast
        /// </summary>
        VeryFast,

        /// <summary>
        ///     Super fast
        /// </summary>
        SuperFast,

        /// <summary>
        ///     Ultra fast
        /// </summary>
        UltraFast
    }
}
