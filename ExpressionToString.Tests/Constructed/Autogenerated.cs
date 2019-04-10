﻿using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xunit;
using static ExpressionToString.Tests.Runners;
using static System.Linq.Expressions.Expression;

namespace ExpressionToString.Tests.Constructed {
    [Trait("Source", "Autogenerated")]
    public class Autogenerated {
        readonly CallSiteBinder callSiteBinder;
        readonly Expression expression;
        readonly Expression[] expressionArray;
        readonly Guid guid;
        readonly int @int;
        readonly string @string;
        readonly SymbolDocumentInfo symbolDocumentInfo;
        readonly Type type;

        #region DebugInfoExpression

        [Fact(Skip = "Autogenerated tests")]
        public void ClearDebugInfo_Test() =>
            BuildAssert(
                ClearDebugInfo(symbolDocumentInfo),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void DebugInfo_Test() =>
            BuildAssert(
                DebugInfo(symbolDocumentInfo, @int, @int, @int, @int),
                "",
                ""
            );

        #endregion

        #region DynamicExpression

        [Fact(Skip = "Autogenerated tests")]
        public void Dynamic_Test() =>
            BuildAssert(
                Dynamic(callSiteBinder, type, expressionArray),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Dynamic_1_Test() =>
            BuildAssert(
                Dynamic(callSiteBinder, type, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Dynamic_2_Test() =>
            BuildAssert(
                Dynamic(callSiteBinder, type, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Dynamic_3_Test() =>
            BuildAssert(
                Dynamic(callSiteBinder, type, expression, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Dynamic_4_Test() =>
            BuildAssert(
                Dynamic(callSiteBinder, type, expression, expression, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeDynamic_Test() =>
            BuildAssert(
                MakeDynamic(type, callSiteBinder, expressionArray),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeDynamic_1_Test() =>
            BuildAssert(
                MakeDynamic(type, callSiteBinder, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeDynamic_2_Test() =>
            BuildAssert(
                MakeDynamic(type, callSiteBinder, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeDynamic_3_Test() =>
            BuildAssert(
                MakeDynamic(type, callSiteBinder, expression, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeDynamic_4_Test() =>
            BuildAssert(
                MakeDynamic(type, callSiteBinder, expression, expression, expression, expression),
                "",
                ""
            );

        #endregion

        #region SymbolDocumentInfo

        [Fact(Skip = "Autogenerated tests")]
        public void SymbolDocument_Test() =>
            BuildAssert(
                SymbolDocument(@string),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void SymbolDocument_1_Test() =>
            BuildAssert(
                SymbolDocument(@string, guid),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void SymbolDocument_2_Test() =>
            BuildAssert(
                SymbolDocument(@string, guid, guid),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void SymbolDocument_3_Test() =>
            BuildAssert(
                SymbolDocument(@string, guid, guid, guid),
                "",
                ""
            );

        #endregion
    }
}
