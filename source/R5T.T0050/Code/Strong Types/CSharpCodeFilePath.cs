using System;

using R5T.Stagira;


namespace R5T.T0050
{
    public class CSharpCodeFilePath : TypedString
    {
        #region Static

        public static CSharpCodeFilePath From(string value)
        {
            var output = new CSharpCodeFilePath(value);
            return output;
        }

        #endregion


        public CSharpCodeFilePath(string value)
            : base(value)
        {
        }
    }
}
