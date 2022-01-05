using System;


namespace R5T.T0109
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NameToken : INameToken
    {
        #region Static
        
        public static NameToken Instance { get; } = new();

        #endregion
    }
}