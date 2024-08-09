// RUN: %testDafnyForEachResolver --expect-exit-code=4 "%s" -- --standard-libraries

import opened Std.Wrappers

opaque predicate P() { true }

lemma ProveP() ensures P() {
  reveal P();
}

method NeedsP()
  requires P()
{}

method NeedsPAndReturns3() returns (r: int)
  requires P()
  ensures r == 3
{ r := 3; }

method NeedsPAndReturnsNone() returns (r: Option<int>)
  requires P()
{ r := None; }

method A() {
  NeedsP() by { ProveP(); }
  assert P(); // Should fail
}

method B() {
  var v: int;
  v := NeedsPAndReturns3() by { reveal P(); }
  assert P(); // Should fail
}

method C() {
  assert p: P() by { ProveP(); }
  var v := NeedsPAndReturns3() by { reveal p; }
  assert v == 3;  // should pass
  assert P(); // should fail
}

method D() returns (r: Option<int>){
  var v: int;
  v :- NeedsPAndReturnsNone() by {
    match false {
      case true => assert true;
      case false => ProveP();
    }
  }
  assert P(); // should fail
  r := None;
}

method E() returns (r: Option<int>){
  var v :- NeedsPAndReturnsNone() by { reveal P(); }
  assert P(); //  should fail
  r := None;
}
