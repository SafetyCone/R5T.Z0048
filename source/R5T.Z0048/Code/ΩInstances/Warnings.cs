using System;


namespace R5T.Z0048
{
    public class Warnings : IWarnings
    {
        #region Infrastructure

        public static IWarnings Instance { get; } = new Warnings();


        private Warnings()
        {
        }

        #endregion
    }
}
