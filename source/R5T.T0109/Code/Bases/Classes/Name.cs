using System;


namespace R5T.T0109
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Name : IName
    {
        #region Static
        
        public static Name Instance { get; } = new();

        #endregion
    }
}