// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Constructor_GetSignature_ParamsParameterConstructor
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            ConstructorInfo @this = typeof(ParamsParameterConstructorModel).GetConstructors()[0];

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("ParamsParameterConstructorModel(int[])", result);
        }
    }
}