//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\x1ucjk2\Documents\Visual Studio 2013\Projects\Antlr4Calculator\CalculatorParser\Math.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Rubberduck.Math {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MathParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface IMathListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>Exponent</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExponent([NotNull] MathParser.ExponentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Exponent</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExponent([NotNull] MathParser.ExponentContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Multiplicative</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicative([NotNull] MathParser.MultiplicativeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Multiplicative</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicative([NotNull] MathParser.MultiplicativeContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Additive</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditive([NotNull] MathParser.AdditiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Additive</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditive([NotNull] MathParser.AdditiveContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Parenthesized</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesized([NotNull] MathParser.ParenthesizedContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Parenthesized</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesized([NotNull] MathParser.ParenthesizedContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] MathParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] MathParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] MathParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] MathParser.NumberContext context);
}
} // namespace Rubberduck.Math