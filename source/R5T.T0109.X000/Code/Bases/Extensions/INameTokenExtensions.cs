using System;

using R5T.T0109;
using R5T.T0109.X000;


namespace System
{
    public static class INameTokenExtensions
    {
        public static string Private(this INameToken _)
        {
            return NameTokens.Private;
        }
    }
}
