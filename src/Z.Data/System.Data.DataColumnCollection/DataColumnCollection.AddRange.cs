// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     A DataColumnCollection extension method that adds a range to 'columns'.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columns">A variable-length parameters list containing columns.</param>
    public static void AddRange(this DataColumnCollection @this, params string[] columns)
    {
        foreach (string column in columns)
        {
            @this.Add(column);
        }
    }
}