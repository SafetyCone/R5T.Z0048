using System;

using R5T.T0131;
using R5T.T0202;
using R5T.T0202.Extensions;


namespace R5T.Z0048
{
    /// <summary>
    /// Useful list: <see href="https://gist.github.com/thomaslevesque/43e4950a65961e2194e4ce082d64bc31"/>
    /// </summary>
    // Prior work: R5T.F0020.IWarnings
    [ValuesMarker]
    public partial interface IWarnings : IValuesMarker
    {
        /// <summary>
		/// Parameter 'parameter' has no matching param tag in the XML comment for 'parameter' (but other parameters do)
		/// See <see href="https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs1573"/>
		/// </summary>
        /// <remarks>
        /// If any parameter of a method has a documentation comment, this warning is generated for every other parameter of the method that does not.
        /// </remarks>
		public IWarning CS1573 => 1573.ToWarning();

        /// <summary>
        /// XML comment is not placed on a valid language element
        /// See <see href="https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs1587"/>
        /// </summary>
        /// <remarks>
        /// It can be 
        /// </remarks>
        public IWarning CS1587 => 1587.ToWarning();

        /// <summary>
        /// Missing XML comment for publicly visible type or member 'Type_or_Member'
        /// See <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1591"/>
        /// </summary>
        /// <remarks>
        /// When the generate-documentation-file project property is set to true,
        /// this warning is generated for each publically visible type or member that does not have a documentation comment.
        /// </remarks>
        public IWarning CS1591 => 1591.ToWarning();
    }
}
