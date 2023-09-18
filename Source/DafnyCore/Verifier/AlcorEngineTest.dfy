include "AlcorEngine.dfy"
module AlcorEngineTest {
  import opened AlcorProofKernel
  import opened Alcor
  import opened AlcorTacticProofChecker

  method {:test} DummyProofFinderTest() {
    print "\n";
    var ia := Identifier("a");
    var ib := Identifier("b");
    var ic := Identifier("c");
    var id := Identifier("d");
    var a := Var(ia);
    var b := Var(ib);
    var c := Var(ic);
    var d := Var(id);
    var remaining := Var(Identifier("remaining"));
    
    var goal := Imp(And(And(a, b), remaining), a);
    var expr :- expect DummyProofFinder(goal);
    print "Automatically found a proof of " + goal.ToString() + "\n";

    goal := Imp(And(And(a, b), remaining), b);
    expr :- expect DummyProofFinder(goal);
    print "Automatically found a proof of " + goal.ToString() + "\n";

    goal := Imp(And(a, And(b, And(c, And(d, remaining)))), d);
    expr :- expect DummyProofFinder(goal);
    print "Automatically found a proof of " + goal.ToString() + "\n";

    
    goal := Imp(remaining, Imp(b, b));
    expr :- expect DummyProofFinder(goal);
    print "Automatically found a proof of " + goal.ToString() + "\n";

    goal := Imp(remaining, Imp(And(a, b), b));
    expr :- expect DummyProofFinder(goal);
    print "Automatically found a proof of " + goal.ToString() + "\n";

    goal := Imp(And(Imp(a, b), And(a, True)), b);
    expr :- expect DummyProofFinder(goal);
    print "Automatically found a proof of " + goal.ToString() + "\n";

    goal := Imp(And(a, And(Imp(a, b), True)), b);
    expr :- expect DummyProofFinder(goal);
    print "Automatically found a proof of " + goal.ToString() + "\n";

    goal := Imp(And(a, And(b, remaining)), And(a, b));
    expr :- expect DummyProofFinder(goal);
    print "Automatically found a proof of " + goal.ToString() + "\n";

    goal := Imp(And(b, And(a, remaining)), And(a, b));
    expr :- expect DummyProofFinder(goal);
    print "Automatically found a proof of " + goal.ToString() + "\n";
  }

  method {:test} ProofCheckerTest() {
    print "\n";
    var ia := Identifier("a");
    var ib := Identifier("b");
    var a := Var(ia);
    var b := Var(ib);
    
    var goal := Forall(Abs(ia,
                Forall(Abs(ib, Imp(And(Imp(a, b), a), And(b, a))))));

    var proofProgram :=
          ForallIntro.apply2(ProofExpr(a),
            ForallIntro.apply2(ProofExpr(b),
              ImpIntro.apply2(
                ProofExpr(And(Imp(a, b), a)),
                ProofAbs("env", Ind,
                  Let("a", Ind, AndElimRight.apply1(ProofVar("env")),
                  Let("aToB", Ind, AndElimLeft.apply1(ProofVar("env")),
                  Let("b", Ind, ImpElim.apply2(ProofVar("aToB"), ProofVar("a")),
                  AndIntro.apply2(ProofVar("b"), ProofVar("a")))))))));
    var result :- expect CheckProof(proofProgram, ProofEnvNil, goal);
  }

  
  method {:test} TacticProofCheckerTest() {
    print "\n";
    var ia := Identifier("a");
    var ib := Identifier("b");
    var a := Var(ia);
    var b := Var(ib);
    
    var goal := Forall(Abs(ia,
                Forall(Abs(ib, Imp(And(Imp(a, b), a), And(b, a))))));

    var thinking := new TacticMode(goal, EnvNil);
    expect thinking.proofState.ToString() == "\n|- forall a :: (forall b :: (a ==> b) && a ==> b && a)";
    var feedback :- expect thinking.Intro();
    print feedback, "\n--------------\n";
    expect feedback == "\n|- forall b :: (a ==> b) && a ==> b && a";
    feedback :- expect thinking.Intro();
    print feedback, "\n--------------\n";
    expect feedback == "\n|- (a ==> b) && a ==> b && a";
    feedback :- expect thinking.Intro("h");
    print feedback, "\n--------------\n";
    expect feedback == "h: (a ==> b) && a\n|- b && a";
    feedback :- expect thinking.Rename("h", "hA");
    print feedback, "\n--------------\n";
    expect feedback == "hA: (a ==> b) && a\n|- b && a";
    feedback :- expect thinking.Cases();
    print feedback, "\n--------------\n";
    expect feedback == "hA: (a ==> b) && a\n|- b\n\nhA: (a ==> b) && a\n|- b ==> a";
    feedback :- expect thinking.CasesEnv("hA", "hAB", "hA");
    print feedback, "\n--------------\n";
    expect feedback == "hAB: a ==> b\nhA: a\n|- b\n\nhA: (a ==> b) && a\n|- b ==> a";
    feedback :- expect thinking.ImpElim("hAB", "hA");
    print feedback, "\n--------------\n";
    expect feedback == "hA: (a ==> b) && a\n|- b ==> a";
    feedback :- expect thinking.CasesEnv("hA", "hAB", "hA");
    print feedback, "\n--------------\n";
    expect feedback == "hAB: a ==> b\nhA: a\n|- b ==> a";
    feedback :- expect thinking.Intro("hB");
    print feedback, "\n--------------\n";
    expect feedback == "hAB: a ==> b\nhA: a\nhB: b\n|- a";
    feedback :- expect thinking.UseHypothesis("hA");
    print feedback, "\n--------------\n";
    expect feedback == "";
    
    // thinking.ImpElim(hAB, hA)
    print "\n";
  }

  method {:test} BetaReductionTest() {
    print "\n";
    var i_x := Identifier("x");
    var i_f := Identifier("f");
    var i_eq := Identifier("==");
    var i_le := Identifier("<=");
    var i_plus := Identifier("+");
    var i_minus := Identifier("-");
    var x := Var(i_x);
    var f := Var(i_f);
    var eq := Var(i_eq);
    var le := Var(i_le);
    var minus := Var(i_minus);
    var plus := Var(i_plus);
    
    var goal := eq.apply2(f.apply(Int(2)), Int(1));
    var env := EnvCons(
      "f_def",
      Forall(Abs(i_x, eq.apply2(
        f.apply(x), 
        Expr.ifthenelse(le.apply2(x, Int(1)),
          x,
          plus.apply2(f.apply(minus.apply2(x, Int(1))), f.apply(minus.apply2(x, Int(2))))
          )))),
      EnvNil
    );

    var thinking := new TacticMode(goal, env);
    print thinking.proofState.ToString(), "\n--------------\n";
    var f_defs := "f_def: forall x :: f(x) == (if x <= 1 then x else f(x - 1) + f(x - 2))";
    expect thinking.proofState.ToString() == f_defs+"\n|- f(2) == 1";
    var feedback :- expect thinking.ForallElim("f_def", Int(2), "f_2");
    var f_2s := "f_2: f(2) == (if 2 <= 1 then 2 else f(2 - 1) + f(2 - 2))";
    expect feedback == f_defs+"\n"+f_2s+"\n|- f(2) == 1";
    feedback :- expect thinking.Simplify("f_2");
    var f_2sp := "f_2: f(2) == f(1) + f(0)";
    expect feedback == f_defs+"\n"+f_2sp+"\n|- f(2) == 1";
    feedback :- expect thinking.ForallElim("f_def", Int(1), "f_1");
    var f_1s := "f_1: f(1) == (if 1 <= 1 then 1 else f(1 - 1) + f(1 - 2))";
    var f_1sp := "f_1: f(1) == 1";
    var f_0s := "f_0: f(0) == (if 0 <= 1 then 0 else f(0 - 1) + f(0 - 2))";
    var f_0sp := "f_0: f(0) == 0";
    expect feedback == f_defs+"\n"+f_2sp+"\n"+f_1s+"\n|- f(2) == 1";
    feedback :- expect thinking.Simplify("f_1");
    expect feedback == f_defs+"\n"+f_2sp+"\n"+f_1sp+"\n|- f(2) == 1";
    feedback :- expect thinking.ForallElim("f_def", Int(0), "f_0");
    expect feedback == f_defs+"\n"+f_2sp+"\n"+f_1sp+"\n"+f_0s+"\n|- f(2) == 1";
    feedback :- expect thinking.Simplify("f_0");
    expect feedback == f_defs+"\n"+f_2sp+"\n"+f_1sp+"\n"+f_0sp+"\n|- f(2) == 1";
    feedback :- expect thinking.Definition("f_2", "f_1");
    feedback :- expect thinking.Definition("f_2", "f_0");
    feedback :- expect thinking.Simplify("f_2");
    feedback :- expect thinking.UseHypothesis("f_2");
    print feedback, "\n";
    expect feedback == "";

    /*var feedback :- expect thinking.Intro();
    print feedback, "\n--------------\n";
    expect feedback == "\n|- forall b :: (a ==> b) && a ==> b && a";
    feedback :- expect thinking.Intro();
    print feedback, "\n--------------\n";
    expect feedback == "\n|- (a ==> b) && a ==> b && a";
    feedback :- expect thinking.Intro("h");
    print feedback, "\n--------------\n";
    expect feedback == "h: (a ==> b) && a\n|- b && a";
    feedback :- expect thinking.Rename("h", "hA");
    print feedback, "\n--------------\n";
    expect feedback == "hA: (a ==> b) && a\n|- b && a";
    feedback :- expect thinking.Cases();
    print feedback, "\n--------------\n";
    expect feedback == "hA: (a ==> b) && a\n|- b\n\nhA: (a ==> b) && a\n|- b ==> a";
    feedback :- expect thinking.CasesEnv("hA", "hAB", "hA");
    print feedback, "\n--------------\n";
    expect feedback == "hAB: a ==> b\nhA: a\n|- b\n\nhA: (a ==> b) && a\n|- b ==> a";
    feedback :- expect thinking.ImpElim("hAB", "hA");
    print feedback, "\n--------------\n";
    expect feedback == "hA: (a ==> b) && a\n|- b ==> a";
    feedback :- expect thinking.CasesEnv("hA", "hAB", "hA");
    print feedback, "\n--------------\n";
    expect feedback == "hAB: a ==> b\nhA: a\n|- b ==> a";
    feedback :- expect thinking.Intro("hB");
    print feedback, "\n--------------\n";
    expect feedback == "hAB: a ==> b\nhA: a\nhB: b\n|- a";
    feedback :- expect thinking.UseHypothesis("hA");
    print feedback, "\n--------------\n";
    expect feedback == "";
    
    // thinking.ImpElim(hAB, hA)
    print "\n";*/
  }
}









