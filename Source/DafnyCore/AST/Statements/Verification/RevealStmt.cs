using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using JetBrains.Annotations;

namespace Microsoft.Dafny;

public abstract record Tactic(IToken Token, IToken TokenCloseParens);
public record Intro(IToken Token, IToken TokenCloseParens, [CanBeNull] string Name): Tactic(Token, TokenCloseParens);
public record ImpElim(IToken Token, IToken TokenCloseParens, [CanBeNull] string NameImp, [CanBeNull] string NameHyp, [CanBeNull] string NameResult): Tactic(Token, TokenCloseParens);
public record Cases(IToken Token, IToken TokenCloseParens, [CanBeNull] string NameEnvVar, [CanBeNull] string NewNameLeft, [CanBeNull] string NewNameRight): Tactic(Token, TokenCloseParens);
public record RecallEnv(IToken Token, IToken TokenCloseParens, [CanBeNull] string Name): Tactic(Token, TokenCloseParens);
public record Rename(IToken Token, IToken TokenCloseParens, [CanBeNull] string OldName, [CanBeNull] string NewName): Tactic(Token, TokenCloseParens);

public record Simplify(IToken Token, IToken TokenCloseParens, string Name) : Tactic(Token, TokenCloseParens);

public record ForallElim(IToken Token, IToken TokenCloseParens, string Name, Expression Expr, string NewName) : Tactic(
  Token, TokenCloseParens);

public record Definition(IToken Token, IToken TokenCloseParens, string InName, string DefinitionName) : Tactic(Token,
  TokenCloseParens);

public record RevealFunction
  (IToken Token, IToken TokenCloseParens, Function Function) : Tactic(Token, TokenCloseParens);

public class RevealStmt : Statement, ICloneable<RevealStmt>, ICanFormat {
  public readonly List<Expression> Exprs;
  [FilledInDuringResolution] public readonly List<AssertLabel> LabeledAsserts = new List<AssertLabel>();  // to indicate that "Expr" denotes a labeled assertion
  [FilledInDuringResolution] public readonly List<Statement> ResolvedStatements = new List<Statement>();
  [FilledInDuringResolution] public readonly List<Tactic> Tactics = new();

  public override IEnumerable<Statement> SubStatements {
    get { return ResolvedStatements; }
  }

  public override IEnumerable<Statement> PreResolveSubStatements => Enumerable.Empty<Statement>();

  [ContractInvariantMethod]
  void ObjectInvariant() {
    Contract.Invariant(Exprs != null);
    Contract.Invariant(LabeledAsserts.Count <= Exprs.Count);
  }

  public RevealStmt Clone(Cloner cloner) {
    return new RevealStmt(cloner, this);
  }

  public RevealStmt(Cloner cloner, RevealStmt original) : base(cloner, original) {
    Exprs = original.Exprs.Select(cloner.CloneExpr).ToList();
    if (cloner.CloneResolvedFields) {
      LabeledAsserts = original.LabeledAsserts.Select(a => new AssertLabel(cloner.Tok(a.Tok), a.Name)).ToList();
      ResolvedStatements = original.ResolvedStatements.Select(cloner.CloneStmt).ToList();
    }
  }

  public RevealStmt(RangeToken rangeToken, List<Expression> exprs)
    : base(rangeToken) {
    Contract.Requires(exprs != null);
    this.Exprs = exprs;
  }

  public static string SingleName(Expression e) {
    Contract.Requires(e != null);
    if (e is NameSegment || e is LiteralExpr) {
      return e.tok.val;
    } else {
      return null;
    }
  }

  public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter) {
    return formatter.SetIndentPrintRevealStmt(indentBefore, OwnedTokens);
  }
}