// Dafny program the_program compiled into C#
// To recompile, you will need the libraries
//     System.Runtime.Numerics.dll System.Collections.Immutable.dll
// but the 'dotnet' tool in net6.0 should pick those up automatically.
// Optionally, you may want to include compiler switches like
//     /debug /nowarn:162,164,168,183,219,436,1717,1718

using System;
using System.Numerics;
using System.Collections;

namespace RAST {

  public partial class __default {
    public static Dafny.ISequence<Dafny.Rune> SeqToString<__T>(Dafny.ISequence<__T> s, Func<__T, Dafny.ISequence<Dafny.Rune>> f, Dafny.ISequence<Dafny.Rune> separator)
    {
      if ((new BigInteger((s).Count)).Sign == 0) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      } else {
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Helpers.Id<Func<__T, Dafny.ISequence<Dafny.Rune>>>(f)((s).Select(BigInteger.Zero)), (((new BigInteger((s).Count)) > (BigInteger.One)) ? (Dafny.Sequence<Dafny.Rune>.Concat(separator, RAST.__default.SeqToString<__T>((s).Drop(BigInteger.One), f, separator))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))));
      }
    }
    public static RAST._IType Rc(RAST._IType underlying) {
      return RAST.Type.create_TypeApp(((RAST.__default.std__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("rc"))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Rc")), Dafny.Sequence<RAST._IType>.FromElements(underlying));
    }
    public static RAST._IType RefCell(RAST._IType underlying) {
      return RAST.Type.create_TypeApp(((RAST.__default.std__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("cell"))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("RefCell")), Dafny.Sequence<RAST._IType>.FromElements(underlying));
    }
    public static RAST._IType Vec(RAST._IType underlying) {
      return RAST.Type.create_TypeApp(((RAST.__default.std__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec"))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Vec")), Dafny.Sequence<RAST._IType>.FromElements(underlying));
    }
    public static RAST._IExpr NewVec(Dafny.ISequence<RAST._IExpr> elements) {
      return (RAST.Expr.create_Identifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec!"))).Apply(elements);
    }
    public static RAST._IExpr Clone(RAST._IExpr underlying) {
      return (RAST.Expr.create_Select(underlying, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("clone"))).Apply(Dafny.Sequence<RAST._IExpr>.FromElements());
    }
    public static RAST._IExpr Borrow(RAST._IExpr underlying) {
      return RAST.Expr.create_UnaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), underlying, DAST.Format.UnaryOpFormat.create_NoFormat());
    }
    public static RAST._IExpr BorrowMut(RAST._IExpr underlying) {
      return RAST.Expr.create_UnaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&mut"), underlying, DAST.Format.UnaryOpFormat.create_NoFormat());
    }
    public static RAST._IType RawType(Dafny.ISequence<Dafny.Rune> content) {
      return RAST.Type.create_TIdentifier(content);
    }
    public static RAST._IType Box(RAST._IType content) {
      return RAST.Type.create_TypeApp(RAST.Type.create_TIdentifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Box")), Dafny.Sequence<RAST._IType>.FromElements(content));
    }
    public static RAST._IExpr BoxNew(RAST._IExpr content) {
      return ((RAST.Expr.create_Identifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Box"))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("new"))).Apply(Dafny.Sequence<RAST._IExpr>.FromElements(content));
    }
    public static bool IsImmutableConversion(RAST._IType fromTpe, RAST._IType toTpe)
    {
      _System._ITuple2<RAST._IType, RAST._IType> _source25 = _System.Tuple2<RAST._IType, RAST._IType>.create(fromTpe, toTpe);
      RAST._IType _830___mcc_h0 = _source25.dtor__0;
      RAST._IType _831___mcc_h1 = _source25.dtor__1;
      RAST._IType _source26 = _830___mcc_h0;
      if (_source26.is_SelfOwned) {
        return false;
      } else if (_source26.is_U8) {
        return false;
      } else if (_source26.is_U16) {
        return false;
      } else if (_source26.is_U32) {
        return false;
      } else if (_source26.is_U64) {
        return false;
      } else if (_source26.is_U128) {
        return false;
      } else if (_source26.is_I8) {
        return false;
      } else if (_source26.is_I16) {
        return false;
      } else if (_source26.is_I32) {
        return false;
      } else if (_source26.is_I64) {
        return false;
      } else if (_source26.is_I128) {
        return false;
      } else if (_source26.is_Bool) {
        return false;
      } else if (_source26.is_TIdentifier) {
        Dafny.ISequence<Dafny.Rune> _832___mcc_h4 = _source26.dtor_name;
        return false;
      } else if (_source26.is_TMemberSelect) {
        RAST._IType _833___mcc_h6 = _source26.dtor_base;
        Dafny.ISequence<Dafny.Rune> _834___mcc_h7 = _source26.dtor_name;
        return false;
      } else if (_source26.is_TypeApp) {
        RAST._IType _835___mcc_h10 = _source26.dtor_baseName;
        Dafny.ISequence<RAST._IType> _836___mcc_h11 = _source26.dtor_arguments;
        RAST._IType _source27 = _835___mcc_h10;
        if (_source27.is_SelfOwned) {
          return false;
        } else if (_source27.is_U8) {
          return false;
        } else if (_source27.is_U16) {
          return false;
        } else if (_source27.is_U32) {
          return false;
        } else if (_source27.is_U64) {
          return false;
        } else if (_source27.is_U128) {
          return false;
        } else if (_source27.is_I8) {
          return false;
        } else if (_source27.is_I16) {
          return false;
        } else if (_source27.is_I32) {
          return false;
        } else if (_source27.is_I64) {
          return false;
        } else if (_source27.is_I128) {
          return false;
        } else if (_source27.is_Bool) {
          return false;
        } else if (_source27.is_TIdentifier) {
          Dafny.ISequence<Dafny.Rune> _837___mcc_h14 = _source27.dtor_name;
          return false;
        } else if (_source27.is_TMemberSelect) {
          RAST._IType _838___mcc_h16 = _source27.dtor_base;
          Dafny.ISequence<Dafny.Rune> _839___mcc_h17 = _source27.dtor_name;
          RAST._IType _source28 = _838___mcc_h16;
          if (_source28.is_SelfOwned) {
            return false;
          } else if (_source28.is_U8) {
            return false;
          } else if (_source28.is_U16) {
            return false;
          } else if (_source28.is_U32) {
            return false;
          } else if (_source28.is_U64) {
            return false;
          } else if (_source28.is_U128) {
            return false;
          } else if (_source28.is_I8) {
            return false;
          } else if (_source28.is_I16) {
            return false;
          } else if (_source28.is_I32) {
            return false;
          } else if (_source28.is_I64) {
            return false;
          } else if (_source28.is_I128) {
            return false;
          } else if (_source28.is_Bool) {
            return false;
          } else if (_source28.is_TIdentifier) {
            Dafny.ISequence<Dafny.Rune> _840___mcc_h20 = _source28.dtor_name;
            return false;
          } else if (_source28.is_TMemberSelect) {
            RAST._IType _841___mcc_h22 = _source28.dtor_base;
            Dafny.ISequence<Dafny.Rune> _842___mcc_h23 = _source28.dtor_name;
            RAST._IType _source29 = _841___mcc_h22;
            if (_source29.is_SelfOwned) {
              return false;
            } else if (_source29.is_U8) {
              return false;
            } else if (_source29.is_U16) {
              return false;
            } else if (_source29.is_U32) {
              return false;
            } else if (_source29.is_U64) {
              return false;
            } else if (_source29.is_U128) {
              return false;
            } else if (_source29.is_I8) {
              return false;
            } else if (_source29.is_I16) {
              return false;
            } else if (_source29.is_I32) {
              return false;
            } else if (_source29.is_I64) {
              return false;
            } else if (_source29.is_I128) {
              return false;
            } else if (_source29.is_Bool) {
              return false;
            } else if (_source29.is_TIdentifier) {
              Dafny.ISequence<Dafny.Rune> _843___mcc_h26 = _source29.dtor_name;
              if (object.Equals(_843___mcc_h26, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) {
                if (object.Equals(_842___mcc_h23, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("dafny_runtime"))) {
                  RAST._IType _source30 = _831___mcc_h1;
                  if (_source30.is_SelfOwned) {
                    return false;
                  } else if (_source30.is_U8) {
                    return false;
                  } else if (_source30.is_U16) {
                    return false;
                  } else if (_source30.is_U32) {
                    return false;
                  } else if (_source30.is_U64) {
                    return false;
                  } else if (_source30.is_U128) {
                    return false;
                  } else if (_source30.is_I8) {
                    return false;
                  } else if (_source30.is_I16) {
                    return false;
                  } else if (_source30.is_I32) {
                    return false;
                  } else if (_source30.is_I64) {
                    return false;
                  } else if (_source30.is_I128) {
                    return false;
                  } else if (_source30.is_Bool) {
                    return false;
                  } else if (_source30.is_TIdentifier) {
                    Dafny.ISequence<Dafny.Rune> _844___mcc_h28 = _source30.dtor_name;
                    return false;
                  } else if (_source30.is_TMemberSelect) {
                    RAST._IType _845___mcc_h30 = _source30.dtor_base;
                    Dafny.ISequence<Dafny.Rune> _846___mcc_h31 = _source30.dtor_name;
                    return false;
                  } else if (_source30.is_TypeApp) {
                    RAST._IType _847___mcc_h34 = _source30.dtor_baseName;
                    Dafny.ISequence<RAST._IType> _848___mcc_h35 = _source30.dtor_arguments;
                    RAST._IType _source31 = _847___mcc_h34;
                    if (_source31.is_SelfOwned) {
                      return false;
                    } else if (_source31.is_U8) {
                      return false;
                    } else if (_source31.is_U16) {
                      return false;
                    } else if (_source31.is_U32) {
                      return false;
                    } else if (_source31.is_U64) {
                      return false;
                    } else if (_source31.is_U128) {
                      return false;
                    } else if (_source31.is_I8) {
                      return false;
                    } else if (_source31.is_I16) {
                      return false;
                    } else if (_source31.is_I32) {
                      return false;
                    } else if (_source31.is_I64) {
                      return false;
                    } else if (_source31.is_I128) {
                      return false;
                    } else if (_source31.is_Bool) {
                      return false;
                    } else if (_source31.is_TIdentifier) {
                      Dafny.ISequence<Dafny.Rune> _849___mcc_h38 = _source31.dtor_name;
                      return false;
                    } else if (_source31.is_TMemberSelect) {
                      RAST._IType _850___mcc_h40 = _source31.dtor_base;
                      Dafny.ISequence<Dafny.Rune> _851___mcc_h41 = _source31.dtor_name;
                      RAST._IType _source32 = _850___mcc_h40;
                      if (_source32.is_SelfOwned) {
                        return false;
                      } else if (_source32.is_U8) {
                        return false;
                      } else if (_source32.is_U16) {
                        return false;
                      } else if (_source32.is_U32) {
                        return false;
                      } else if (_source32.is_U64) {
                        return false;
                      } else if (_source32.is_U128) {
                        return false;
                      } else if (_source32.is_I8) {
                        return false;
                      } else if (_source32.is_I16) {
                        return false;
                      } else if (_source32.is_I32) {
                        return false;
                      } else if (_source32.is_I64) {
                        return false;
                      } else if (_source32.is_I128) {
                        return false;
                      } else if (_source32.is_Bool) {
                        return false;
                      } else if (_source32.is_TIdentifier) {
                        Dafny.ISequence<Dafny.Rune> _852___mcc_h44 = _source32.dtor_name;
                        return false;
                      } else if (_source32.is_TMemberSelect) {
                        RAST._IType _853___mcc_h46 = _source32.dtor_base;
                        Dafny.ISequence<Dafny.Rune> _854___mcc_h47 = _source32.dtor_name;
                        RAST._IType _source33 = _853___mcc_h46;
                        if (_source33.is_SelfOwned) {
                          return false;
                        } else if (_source33.is_U8) {
                          return false;
                        } else if (_source33.is_U16) {
                          return false;
                        } else if (_source33.is_U32) {
                          return false;
                        } else if (_source33.is_U64) {
                          return false;
                        } else if (_source33.is_U128) {
                          return false;
                        } else if (_source33.is_I8) {
                          return false;
                        } else if (_source33.is_I16) {
                          return false;
                        } else if (_source33.is_I32) {
                          return false;
                        } else if (_source33.is_I64) {
                          return false;
                        } else if (_source33.is_I128) {
                          return false;
                        } else if (_source33.is_Bool) {
                          return false;
                        } else if (_source33.is_TIdentifier) {
                          Dafny.ISequence<Dafny.Rune> _855___mcc_h50 = _source33.dtor_name;
                          if (object.Equals(_855___mcc_h50, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) {
                            if (object.Equals(_854___mcc_h47, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("dafny_runtime"))) {
                              Dafny.ISequence<RAST._IType> _856_elems2 = _848___mcc_h35;
                              Dafny.ISequence<Dafny.Rune> _857_tpe2 = _851___mcc_h41;
                              Dafny.ISequence<RAST._IType> _858_elems1 = _836___mcc_h11;
                              Dafny.ISequence<Dafny.Rune> _859_tpe1 = _839___mcc_h17;
                              return ((_859_tpe1).Equals(_857_tpe2)) && (((((_859_tpe1).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Set"))) || ((_859_tpe1).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Sequence")))) || ((_859_tpe1).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Multiset")))) || ((_859_tpe1).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Map"))));
                            } else {
                              return false;
                            }
                          } else {
                            return false;
                          }
                        } else if (_source33.is_TMemberSelect) {
                          RAST._IType _860___mcc_h52 = _source33.dtor_base;
                          Dafny.ISequence<Dafny.Rune> _861___mcc_h53 = _source33.dtor_name;
                          return false;
                        } else if (_source33.is_TypeApp) {
                          RAST._IType _862___mcc_h56 = _source33.dtor_baseName;
                          Dafny.ISequence<RAST._IType> _863___mcc_h57 = _source33.dtor_arguments;
                          return false;
                        } else if (_source33.is_Borrowed) {
                          RAST._IType _864___mcc_h60 = _source33.dtor_underlying;
                          return false;
                        } else if (_source33.is_BorrowedMut) {
                          RAST._IType _865___mcc_h62 = _source33.dtor_underlying;
                          return false;
                        } else if (_source33.is_ImplType) {
                          RAST._IType _866___mcc_h64 = _source33.dtor_underlying;
                          return false;
                        } else if (_source33.is_DynType) {
                          RAST._IType _867___mcc_h66 = _source33.dtor_underlying;
                          return false;
                        } else if (_source33.is_TupleType) {
                          Dafny.ISequence<RAST._IType> _868___mcc_h68 = _source33.dtor_arguments;
                          return false;
                        } else if (_source33.is_FnType) {
                          Dafny.ISequence<RAST._IType> _869___mcc_h70 = _source33.dtor_arguments;
                          RAST._IType _870___mcc_h71 = _source33.dtor_returnType;
                          return false;
                        } else {
                          RAST._IType _871___mcc_h74 = _source33.dtor_left;
                          RAST._IType _872___mcc_h75 = _source33.dtor_right;
                          return false;
                        }
                      } else if (_source32.is_TypeApp) {
                        RAST._IType _873___mcc_h78 = _source32.dtor_baseName;
                        Dafny.ISequence<RAST._IType> _874___mcc_h79 = _source32.dtor_arguments;
                        return false;
                      } else if (_source32.is_Borrowed) {
                        RAST._IType _875___mcc_h82 = _source32.dtor_underlying;
                        return false;
                      } else if (_source32.is_BorrowedMut) {
                        RAST._IType _876___mcc_h84 = _source32.dtor_underlying;
                        return false;
                      } else if (_source32.is_ImplType) {
                        RAST._IType _877___mcc_h86 = _source32.dtor_underlying;
                        return false;
                      } else if (_source32.is_DynType) {
                        RAST._IType _878___mcc_h88 = _source32.dtor_underlying;
                        return false;
                      } else if (_source32.is_TupleType) {
                        Dafny.ISequence<RAST._IType> _879___mcc_h90 = _source32.dtor_arguments;
                        return false;
                      } else if (_source32.is_FnType) {
                        Dafny.ISequence<RAST._IType> _880___mcc_h92 = _source32.dtor_arguments;
                        RAST._IType _881___mcc_h93 = _source32.dtor_returnType;
                        return false;
                      } else {
                        RAST._IType _882___mcc_h96 = _source32.dtor_left;
                        RAST._IType _883___mcc_h97 = _source32.dtor_right;
                        return false;
                      }
                    } else if (_source31.is_TypeApp) {
                      RAST._IType _884___mcc_h100 = _source31.dtor_baseName;
                      Dafny.ISequence<RAST._IType> _885___mcc_h101 = _source31.dtor_arguments;
                      return false;
                    } else if (_source31.is_Borrowed) {
                      RAST._IType _886___mcc_h104 = _source31.dtor_underlying;
                      return false;
                    } else if (_source31.is_BorrowedMut) {
                      RAST._IType _887___mcc_h106 = _source31.dtor_underlying;
                      return false;
                    } else if (_source31.is_ImplType) {
                      RAST._IType _888___mcc_h108 = _source31.dtor_underlying;
                      return false;
                    } else if (_source31.is_DynType) {
                      RAST._IType _889___mcc_h110 = _source31.dtor_underlying;
                      return false;
                    } else if (_source31.is_TupleType) {
                      Dafny.ISequence<RAST._IType> _890___mcc_h112 = _source31.dtor_arguments;
                      return false;
                    } else if (_source31.is_FnType) {
                      Dafny.ISequence<RAST._IType> _891___mcc_h114 = _source31.dtor_arguments;
                      RAST._IType _892___mcc_h115 = _source31.dtor_returnType;
                      return false;
                    } else {
                      RAST._IType _893___mcc_h118 = _source31.dtor_left;
                      RAST._IType _894___mcc_h119 = _source31.dtor_right;
                      return false;
                    }
                  } else if (_source30.is_Borrowed) {
                    RAST._IType _895___mcc_h122 = _source30.dtor_underlying;
                    return false;
                  } else if (_source30.is_BorrowedMut) {
                    RAST._IType _896___mcc_h124 = _source30.dtor_underlying;
                    return false;
                  } else if (_source30.is_ImplType) {
                    RAST._IType _897___mcc_h126 = _source30.dtor_underlying;
                    return false;
                  } else if (_source30.is_DynType) {
                    RAST._IType _898___mcc_h128 = _source30.dtor_underlying;
                    return false;
                  } else if (_source30.is_TupleType) {
                    Dafny.ISequence<RAST._IType> _899___mcc_h130 = _source30.dtor_arguments;
                    return false;
                  } else if (_source30.is_FnType) {
                    Dafny.ISequence<RAST._IType> _900___mcc_h132 = _source30.dtor_arguments;
                    RAST._IType _901___mcc_h133 = _source30.dtor_returnType;
                    return false;
                  } else {
                    RAST._IType _902___mcc_h136 = _source30.dtor_left;
                    RAST._IType _903___mcc_h137 = _source30.dtor_right;
                    return false;
                  }
                } else {
                  return false;
                }
              } else {
                return false;
              }
            } else if (_source29.is_TMemberSelect) {
              RAST._IType _904___mcc_h140 = _source29.dtor_base;
              Dafny.ISequence<Dafny.Rune> _905___mcc_h141 = _source29.dtor_name;
              return false;
            } else if (_source29.is_TypeApp) {
              RAST._IType _906___mcc_h144 = _source29.dtor_baseName;
              Dafny.ISequence<RAST._IType> _907___mcc_h145 = _source29.dtor_arguments;
              return false;
            } else if (_source29.is_Borrowed) {
              RAST._IType _908___mcc_h148 = _source29.dtor_underlying;
              return false;
            } else if (_source29.is_BorrowedMut) {
              RAST._IType _909___mcc_h150 = _source29.dtor_underlying;
              return false;
            } else if (_source29.is_ImplType) {
              RAST._IType _910___mcc_h152 = _source29.dtor_underlying;
              return false;
            } else if (_source29.is_DynType) {
              RAST._IType _911___mcc_h154 = _source29.dtor_underlying;
              return false;
            } else if (_source29.is_TupleType) {
              Dafny.ISequence<RAST._IType> _912___mcc_h156 = _source29.dtor_arguments;
              return false;
            } else if (_source29.is_FnType) {
              Dafny.ISequence<RAST._IType> _913___mcc_h158 = _source29.dtor_arguments;
              RAST._IType _914___mcc_h159 = _source29.dtor_returnType;
              return false;
            } else {
              RAST._IType _915___mcc_h162 = _source29.dtor_left;
              RAST._IType _916___mcc_h163 = _source29.dtor_right;
              return false;
            }
          } else if (_source28.is_TypeApp) {
            RAST._IType _917___mcc_h166 = _source28.dtor_baseName;
            Dafny.ISequence<RAST._IType> _918___mcc_h167 = _source28.dtor_arguments;
            return false;
          } else if (_source28.is_Borrowed) {
            RAST._IType _919___mcc_h170 = _source28.dtor_underlying;
            return false;
          } else if (_source28.is_BorrowedMut) {
            RAST._IType _920___mcc_h172 = _source28.dtor_underlying;
            return false;
          } else if (_source28.is_ImplType) {
            RAST._IType _921___mcc_h174 = _source28.dtor_underlying;
            return false;
          } else if (_source28.is_DynType) {
            RAST._IType _922___mcc_h176 = _source28.dtor_underlying;
            return false;
          } else if (_source28.is_TupleType) {
            Dafny.ISequence<RAST._IType> _923___mcc_h178 = _source28.dtor_arguments;
            return false;
          } else if (_source28.is_FnType) {
            Dafny.ISequence<RAST._IType> _924___mcc_h180 = _source28.dtor_arguments;
            RAST._IType _925___mcc_h181 = _source28.dtor_returnType;
            return false;
          } else {
            RAST._IType _926___mcc_h184 = _source28.dtor_left;
            RAST._IType _927___mcc_h185 = _source28.dtor_right;
            return false;
          }
        } else if (_source27.is_TypeApp) {
          RAST._IType _928___mcc_h188 = _source27.dtor_baseName;
          Dafny.ISequence<RAST._IType> _929___mcc_h189 = _source27.dtor_arguments;
          return false;
        } else if (_source27.is_Borrowed) {
          RAST._IType _930___mcc_h192 = _source27.dtor_underlying;
          return false;
        } else if (_source27.is_BorrowedMut) {
          RAST._IType _931___mcc_h194 = _source27.dtor_underlying;
          return false;
        } else if (_source27.is_ImplType) {
          RAST._IType _932___mcc_h196 = _source27.dtor_underlying;
          return false;
        } else if (_source27.is_DynType) {
          RAST._IType _933___mcc_h198 = _source27.dtor_underlying;
          return false;
        } else if (_source27.is_TupleType) {
          Dafny.ISequence<RAST._IType> _934___mcc_h200 = _source27.dtor_arguments;
          return false;
        } else if (_source27.is_FnType) {
          Dafny.ISequence<RAST._IType> _935___mcc_h202 = _source27.dtor_arguments;
          RAST._IType _936___mcc_h203 = _source27.dtor_returnType;
          return false;
        } else {
          RAST._IType _937___mcc_h206 = _source27.dtor_left;
          RAST._IType _938___mcc_h207 = _source27.dtor_right;
          return false;
        }
      } else if (_source26.is_Borrowed) {
        RAST._IType _939___mcc_h210 = _source26.dtor_underlying;
        return false;
      } else if (_source26.is_BorrowedMut) {
        RAST._IType _940___mcc_h212 = _source26.dtor_underlying;
        return false;
      } else if (_source26.is_ImplType) {
        RAST._IType _941___mcc_h214 = _source26.dtor_underlying;
        return false;
      } else if (_source26.is_DynType) {
        RAST._IType _942___mcc_h216 = _source26.dtor_underlying;
        return false;
      } else if (_source26.is_TupleType) {
        Dafny.ISequence<RAST._IType> _943___mcc_h218 = _source26.dtor_arguments;
        return false;
      } else if (_source26.is_FnType) {
        Dafny.ISequence<RAST._IType> _944___mcc_h220 = _source26.dtor_arguments;
        RAST._IType _945___mcc_h221 = _source26.dtor_returnType;
        return false;
      } else {
        RAST._IType _946___mcc_h224 = _source26.dtor_left;
        RAST._IType _947___mcc_h225 = _source26.dtor_right;
        return false;
      }
    }
    public static Dafny.ISequence<Dafny.Rune> AddIndent(Dafny.ISequence<Dafny.Rune> raw, Dafny.ISequence<Dafny.Rune> ind)
    {
      Dafny.ISequence<Dafny.Rune> _948___accumulator = Dafny.Sequence<Dafny.Rune>.FromElements();
    TAIL_CALL_START: ;
      if ((new BigInteger((raw).Count)).Sign == 0) {
        return Dafny.Sequence<Dafny.Rune>.Concat(_948___accumulator, raw);
      } else if ((Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[({")).Contains((raw).Select(BigInteger.Zero))) {
        _948___accumulator = Dafny.Sequence<Dafny.Rune>.Concat(_948___accumulator, Dafny.Sequence<Dafny.Rune>.FromElements((raw).Select(BigInteger.Zero)));
        Dafny.ISequence<Dafny.Rune> _in103 = (raw).Drop(BigInteger.One);
        Dafny.ISequence<Dafny.Rune> _in104 = Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND);
        raw = _in103;
        ind = _in104;
        goto TAIL_CALL_START;
      } else if (((Dafny.Sequence<Dafny.Rune>.UnicodeFromString("})]")).Contains((raw).Select(BigInteger.Zero))) && ((new BigInteger((ind).Count)) > (new BigInteger(2)))) {
        _948___accumulator = Dafny.Sequence<Dafny.Rune>.Concat(_948___accumulator, Dafny.Sequence<Dafny.Rune>.FromElements((raw).Select(BigInteger.Zero)));
        Dafny.ISequence<Dafny.Rune> _in105 = (raw).Drop(BigInteger.One);
        Dafny.ISequence<Dafny.Rune> _in106 = (ind).Take((new BigInteger((ind).Count)) - (new BigInteger(2)));
        raw = _in105;
        ind = _in106;
        goto TAIL_CALL_START;
      } else if (((raw).Select(BigInteger.Zero)) == (new Dafny.Rune('\n'))) {
        _948___accumulator = Dafny.Sequence<Dafny.Rune>.Concat(_948___accumulator, Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.FromElements((raw).Select(BigInteger.Zero)), ind));
        Dafny.ISequence<Dafny.Rune> _in107 = (raw).Drop(BigInteger.One);
        Dafny.ISequence<Dafny.Rune> _in108 = ind;
        raw = _in107;
        ind = _in108;
        goto TAIL_CALL_START;
      } else {
        _948___accumulator = Dafny.Sequence<Dafny.Rune>.Concat(_948___accumulator, Dafny.Sequence<Dafny.Rune>.FromElements((raw).Select(BigInteger.Zero)));
        Dafny.ISequence<Dafny.Rune> _in109 = (raw).Drop(BigInteger.One);
        Dafny.ISequence<Dafny.Rune> _in110 = ind;
        raw = _in109;
        ind = _in110;
        goto TAIL_CALL_START;
      }
    }
    public static BigInteger max(BigInteger i, BigInteger j)
    {
      if ((i) < (j)) {
        return j;
      } else {
        return i;
      }
    }
    public static RAST._IExpr AssignVar(Dafny.ISequence<Dafny.Rune> name, RAST._IExpr rhs)
    {
      return RAST.Expr.create_Assign(Std.Wrappers.Option<RAST._IAssignLhs>.create_Some(RAST.AssignLhs.create_LocalVar(name)), rhs);
    }
    public static RAST._IExpr AssignMember(RAST._IExpr @on, Dafny.ISequence<Dafny.Rune> field, RAST._IExpr rhs)
    {
      return RAST.Expr.create_Assign(Std.Wrappers.Option<RAST._IAssignLhs>.create_Some(RAST.AssignLhs.create_SelectMember(@on, field)), rhs);
    }
    public static RAST._IExpr MaybePlacebo(RAST._IExpr underlying) {
      return (((RAST.__default.dafny__runtime).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("MaybePlacebo"))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("from"))).Apply1(underlying);
    }
    public static RAST._IExpr RcNew(RAST._IExpr underlying) {
      return RAST.Expr.create_Call(RAST.__default.std__rc__Rc__new, Dafny.Sequence<RAST._IExpr>.FromElements(underlying));
    }
    public static RAST._IType SelfBorrowed { get {
      return RAST.Type.create_Borrowed(RAST.Type.create_SelfOwned());
    } }
    public static RAST._IType SelfBorrowedMut { get {
      return RAST.Type.create_BorrowedMut(RAST.Type.create_SelfOwned());
    } }
    public static RAST._IType global__type { get {
      return RAST.Type.create_TIdentifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
    } }
    public static RAST._IType std__type { get {
      return (RAST.__default.global__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("std"));
    } }
    public static RAST._IType super__type { get {
      return RAST.Type.create_TIdentifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("super"));
    } }
    public static RAST._IType cell__type { get {
      return (RAST.__default.std__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("cell"));
    } }
    public static RAST._IType refcell__type { get {
      return (RAST.__default.cell__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("RefCell"));
    } }
    public static RAST._IType dafny__runtime__type { get {
      return (RAST.__default.global__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("dafny_runtime"));
    } }
    public static RAST._IType CloneTrait { get {
      return RAST.__default.RawType(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Clone"));
    } }
    public static RAST._IType DefaultTrait { get {
      return ((RAST.__default.std__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("default"))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Default"));
    } }
    public static RAST._IType StaticTrait { get {
      return RAST.__default.RawType(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'static"));
    } }
    public static RAST._IType DafnyType { get {
      return (RAST.__default.dafny__runtime__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("DafnyType"));
    } }
    public static RAST._IType DafnyPrint { get {
      return (RAST.__default.dafny__runtime__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("DafnyPrint"));
    } }
    public static RAST._IType DafnyTypeEq { get {
      return (RAST.__default.dafny__runtime__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("DafnyTypeEq"));
    } }
    public static RAST._IType Eq { get {
      return RAST.Type.create_TIdentifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Eq"));
    } }
    public static RAST._IType DafnyInt { get {
      return (RAST.__default.dafny__runtime__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("DafnyInt"));
    } }
    public static Dafny.ISequence<Dafny.Rune> IND { get {
      return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("  ");
    } }
    public static RAST._IExpr self { get {
      return RAST.Expr.create_Identifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"));
    } }
    public static RAST._IExpr @global { get {
      return RAST.Expr.create_Identifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
    } }
    public static RAST._IExpr dafny__runtime { get {
      return (RAST.__default.@global).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("dafny_runtime"));
    } }
    public static RAST._IExpr dafny__runtime__Set { get {
      return (RAST.__default.dafny__runtime).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Set"));
    } }
    public static RAST._IExpr dafny__runtime__Set__from__array { get {
      return (RAST.__default.dafny__runtime__Set).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("from_array"));
    } }
    public static RAST._IExpr dafny__runtime__Sequence { get {
      return (RAST.__default.dafny__runtime).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Sequence"));
    } }
    public static RAST._IExpr Sequence__from__array__owned { get {
      return (RAST.__default.dafny__runtime__Sequence).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("from_array_owned"));
    } }
    public static RAST._IExpr Sequence__from__array { get {
      return (RAST.__default.dafny__runtime__Sequence).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("from_array"));
    } }
    public static RAST._IExpr dafny__runtime__Multiset { get {
      return (RAST.__default.dafny__runtime).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Multiset"));
    } }
    public static RAST._IExpr dafny__runtime__Multiset__from__array { get {
      return (RAST.__default.dafny__runtime__Multiset).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("from_array"));
    } }
    public static RAST._IExpr std { get {
      return (RAST.__default.@global).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("std"));
    } }
    public static RAST._IExpr std__rc { get {
      return (RAST.__default.std).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("rc"));
    } }
    public static RAST._IExpr std__rc__Rc { get {
      return (RAST.__default.std__rc).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Rc"));
    } }
    public static RAST._IExpr std__rc__Rc__new { get {
      return (RAST.__default.std__rc__Rc).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("new"));
    } }
    public static RAST._IExpr std__Default__default { get {
      return ((((RAST.__default.std).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("default"))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Default"))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("default"))).Apply(Dafny.Sequence<RAST._IExpr>.FromElements());
    } }
    public static RAST._IExpr modify__macro { get {
      return (RAST.__default.dafny__runtime).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("modify!"));
    } }
  }

  public interface _IMod {
    bool is_Mod { get; }
    bool is_ExternMod { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<RAST._IModDecl> dtor_body { get; }
    _IMod DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public abstract class Mod : _IMod {
    public Mod() {
    }
    private static readonly RAST._IMod theDefault = create_Mod(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._IModDecl>.Empty);
    public static RAST._IMod Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IMod> _TYPE = new Dafny.TypeDescriptor<RAST._IMod>(RAST.Mod.Default());
    public static Dafny.TypeDescriptor<RAST._IMod> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IMod create_Mod(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._IModDecl> body) {
      return new Mod_Mod(name, body);
    }
    public static _IMod create_ExternMod(Dafny.ISequence<Dafny.Rune> name) {
      return new Mod_ExternMod(name);
    }
    public bool is_Mod { get { return this is Mod_Mod; } }
    public bool is_ExternMod { get { return this is Mod_ExternMod; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        var d = this;
        if (d is Mod_Mod) { return ((Mod_Mod)d)._name; }
        return ((Mod_ExternMod)d)._name;
      }
    }
    public Dafny.ISequence<RAST._IModDecl> dtor_body {
      get {
        var d = this;
        return ((Mod_Mod)d)._body;
      }
    }
    public abstract _IMod DowncastClone();
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      RAST._IMod _source34 = this;
      if (_source34.is_Mod) {
        Dafny.ISequence<Dafny.Rune> _949___mcc_h0 = _source34.dtor_name;
        Dafny.ISequence<RAST._IModDecl> _950___mcc_h1 = _source34.dtor_body;
        Dafny.ISequence<RAST._IModDecl> _951_body = _950___mcc_h1;
        Dafny.ISequence<Dafny.Rune> _952_name = _949___mcc_h0;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub mod "), _952_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), ind), RAST.__default.IND), RAST.__default.SeqToString<RAST._IModDecl>(_951_body, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IModDecl, Dafny.ISequence<Dafny.Rune>>>>((_953_ind) => ((System.Func<RAST._IModDecl, Dafny.ISequence<Dafny.Rune>>)((_954_modDecl) => {
          return (_954_modDecl)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_953_ind, RAST.__default.IND));
        })))(ind), Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n\n"), ind), RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
      } else {
        Dafny.ISequence<Dafny.Rune> _955___mcc_h2 = _source34.dtor_name;
        Dafny.ISequence<Dafny.Rune> _956_name = _955___mcc_h2;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub mod "), _956_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
      }
    }
  }
  public class Mod_Mod : Mod {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<RAST._IModDecl> _body;
    public Mod_Mod(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._IModDecl> body) : base() {
      this._name = name;
      this._body = body;
    }
    public override _IMod DowncastClone() {
      if (this is _IMod dt) { return dt; }
      return new Mod_Mod(_name, _body);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Mod_Mod;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Mod.Mod";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
  }
  public class Mod_ExternMod : Mod {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public Mod_ExternMod(Dafny.ISequence<Dafny.Rune> name) : base() {
      this._name = name;
    }
    public override _IMod DowncastClone() {
      if (this is _IMod dt) { return dt; }
      return new Mod_ExternMod(_name);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Mod_ExternMod;
      return oth != null && object.Equals(this._name, oth._name);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Mod.ExternMod";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }

  public interface _IModDecl {
    bool is_RawDecl { get; }
    bool is_ModDecl { get; }
    bool is_StructDecl { get; }
    bool is_TypeDecl { get; }
    bool is_EnumDecl { get; }
    bool is_ImplDecl { get; }
    bool is_TraitDecl { get; }
    bool is_TopFnDecl { get; }
    Dafny.ISequence<Dafny.Rune> dtor_body { get; }
    RAST._IMod dtor_mod { get; }
    RAST._IStruct dtor_struct { get; }
    RAST._ITypeSynonym dtor_tpe { get; }
    RAST._IEnum dtor_enum { get; }
    RAST._IImpl dtor_impl { get; }
    RAST._ITrait dtor_tr { get; }
    RAST._ITopFnDecl dtor_fn { get; }
    _IModDecl DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public abstract class ModDecl : _IModDecl {
    public ModDecl() {
    }
    private static readonly RAST._IModDecl theDefault = create_RawDecl(Dafny.Sequence<Dafny.Rune>.Empty);
    public static RAST._IModDecl Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IModDecl> _TYPE = new Dafny.TypeDescriptor<RAST._IModDecl>(RAST.ModDecl.Default());
    public static Dafny.TypeDescriptor<RAST._IModDecl> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IModDecl create_RawDecl(Dafny.ISequence<Dafny.Rune> body) {
      return new ModDecl_RawDecl(body);
    }
    public static _IModDecl create_ModDecl(RAST._IMod mod) {
      return new ModDecl_ModDecl(mod);
    }
    public static _IModDecl create_StructDecl(RAST._IStruct @struct) {
      return new ModDecl_StructDecl(@struct);
    }
    public static _IModDecl create_TypeDecl(RAST._ITypeSynonym tpe) {
      return new ModDecl_TypeDecl(tpe);
    }
    public static _IModDecl create_EnumDecl(RAST._IEnum @enum) {
      return new ModDecl_EnumDecl(@enum);
    }
    public static _IModDecl create_ImplDecl(RAST._IImpl impl) {
      return new ModDecl_ImplDecl(impl);
    }
    public static _IModDecl create_TraitDecl(RAST._ITrait tr) {
      return new ModDecl_TraitDecl(tr);
    }
    public static _IModDecl create_TopFnDecl(RAST._ITopFnDecl fn) {
      return new ModDecl_TopFnDecl(fn);
    }
    public bool is_RawDecl { get { return this is ModDecl_RawDecl; } }
    public bool is_ModDecl { get { return this is ModDecl_ModDecl; } }
    public bool is_StructDecl { get { return this is ModDecl_StructDecl; } }
    public bool is_TypeDecl { get { return this is ModDecl_TypeDecl; } }
    public bool is_EnumDecl { get { return this is ModDecl_EnumDecl; } }
    public bool is_ImplDecl { get { return this is ModDecl_ImplDecl; } }
    public bool is_TraitDecl { get { return this is ModDecl_TraitDecl; } }
    public bool is_TopFnDecl { get { return this is ModDecl_TopFnDecl; } }
    public Dafny.ISequence<Dafny.Rune> dtor_body {
      get {
        var d = this;
        return ((ModDecl_RawDecl)d)._body;
      }
    }
    public RAST._IMod dtor_mod {
      get {
        var d = this;
        return ((ModDecl_ModDecl)d)._mod;
      }
    }
    public RAST._IStruct dtor_struct {
      get {
        var d = this;
        return ((ModDecl_StructDecl)d)._struct;
      }
    }
    public RAST._ITypeSynonym dtor_tpe {
      get {
        var d = this;
        return ((ModDecl_TypeDecl)d)._tpe;
      }
    }
    public RAST._IEnum dtor_enum {
      get {
        var d = this;
        return ((ModDecl_EnumDecl)d)._enum;
      }
    }
    public RAST._IImpl dtor_impl {
      get {
        var d = this;
        return ((ModDecl_ImplDecl)d)._impl;
      }
    }
    public RAST._ITrait dtor_tr {
      get {
        var d = this;
        return ((ModDecl_TraitDecl)d)._tr;
      }
    }
    public RAST._ITopFnDecl dtor_fn {
      get {
        var d = this;
        return ((ModDecl_TopFnDecl)d)._fn;
      }
    }
    public abstract _IModDecl DowncastClone();
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      if ((this).is_ModDecl) {
        return ((this).dtor_mod)._ToString(ind);
      } else if ((this).is_StructDecl) {
        return ((this).dtor_struct)._ToString(ind);
      } else if ((this).is_ImplDecl) {
        return ((this).dtor_impl)._ToString(ind);
      } else if ((this).is_EnumDecl) {
        return ((this).dtor_enum)._ToString(ind);
      } else if ((this).is_TypeDecl) {
        return ((this).dtor_tpe)._ToString(ind);
      } else if ((this).is_TraitDecl) {
        return ((this).dtor_tr)._ToString(ind);
      } else if ((this).is_TopFnDecl) {
        return ((this).dtor_fn)._ToString(ind);
      } else {
        return (this).dtor_body;
      }
    }
  }
  public class ModDecl_RawDecl : ModDecl {
    public readonly Dafny.ISequence<Dafny.Rune> _body;
    public ModDecl_RawDecl(Dafny.ISequence<Dafny.Rune> body) : base() {
      this._body = body;
    }
    public override _IModDecl DowncastClone() {
      if (this is _IModDecl dt) { return dt; }
      return new ModDecl_RawDecl(_body);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.ModDecl_RawDecl;
      return oth != null && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.ModDecl.RawDecl";
      s += "(";
      s += this._body.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class ModDecl_ModDecl : ModDecl {
    public readonly RAST._IMod _mod;
    public ModDecl_ModDecl(RAST._IMod mod) : base() {
      this._mod = mod;
    }
    public override _IModDecl DowncastClone() {
      if (this is _IModDecl dt) { return dt; }
      return new ModDecl_ModDecl(_mod);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.ModDecl_ModDecl;
      return oth != null && object.Equals(this._mod, oth._mod);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._mod));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.ModDecl.ModDecl";
      s += "(";
      s += Dafny.Helpers.ToString(this._mod);
      s += ")";
      return s;
    }
  }
  public class ModDecl_StructDecl : ModDecl {
    public readonly RAST._IStruct _struct;
    public ModDecl_StructDecl(RAST._IStruct @struct) : base() {
      this._struct = @struct;
    }
    public override _IModDecl DowncastClone() {
      if (this is _IModDecl dt) { return dt; }
      return new ModDecl_StructDecl(_struct);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.ModDecl_StructDecl;
      return oth != null && object.Equals(this._struct, oth._struct);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._struct));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.ModDecl.StructDecl";
      s += "(";
      s += Dafny.Helpers.ToString(this._struct);
      s += ")";
      return s;
    }
  }
  public class ModDecl_TypeDecl : ModDecl {
    public readonly RAST._ITypeSynonym _tpe;
    public ModDecl_TypeDecl(RAST._ITypeSynonym tpe) : base() {
      this._tpe = tpe;
    }
    public override _IModDecl DowncastClone() {
      if (this is _IModDecl dt) { return dt; }
      return new ModDecl_TypeDecl(_tpe);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.ModDecl_TypeDecl;
      return oth != null && object.Equals(this._tpe, oth._tpe);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tpe));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.ModDecl.TypeDecl";
      s += "(";
      s += Dafny.Helpers.ToString(this._tpe);
      s += ")";
      return s;
    }
  }
  public class ModDecl_EnumDecl : ModDecl {
    public readonly RAST._IEnum _enum;
    public ModDecl_EnumDecl(RAST._IEnum @enum) : base() {
      this._enum = @enum;
    }
    public override _IModDecl DowncastClone() {
      if (this is _IModDecl dt) { return dt; }
      return new ModDecl_EnumDecl(_enum);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.ModDecl_EnumDecl;
      return oth != null && object.Equals(this._enum, oth._enum);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 4;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._enum));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.ModDecl.EnumDecl";
      s += "(";
      s += Dafny.Helpers.ToString(this._enum);
      s += ")";
      return s;
    }
  }
  public class ModDecl_ImplDecl : ModDecl {
    public readonly RAST._IImpl _impl;
    public ModDecl_ImplDecl(RAST._IImpl impl) : base() {
      this._impl = impl;
    }
    public override _IModDecl DowncastClone() {
      if (this is _IModDecl dt) { return dt; }
      return new ModDecl_ImplDecl(_impl);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.ModDecl_ImplDecl;
      return oth != null && object.Equals(this._impl, oth._impl);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 5;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._impl));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.ModDecl.ImplDecl";
      s += "(";
      s += Dafny.Helpers.ToString(this._impl);
      s += ")";
      return s;
    }
  }
  public class ModDecl_TraitDecl : ModDecl {
    public readonly RAST._ITrait _tr;
    public ModDecl_TraitDecl(RAST._ITrait tr) : base() {
      this._tr = tr;
    }
    public override _IModDecl DowncastClone() {
      if (this is _IModDecl dt) { return dt; }
      return new ModDecl_TraitDecl(_tr);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.ModDecl_TraitDecl;
      return oth != null && object.Equals(this._tr, oth._tr);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 6;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tr));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.ModDecl.TraitDecl";
      s += "(";
      s += Dafny.Helpers.ToString(this._tr);
      s += ")";
      return s;
    }
  }
  public class ModDecl_TopFnDecl : ModDecl {
    public readonly RAST._ITopFnDecl _fn;
    public ModDecl_TopFnDecl(RAST._ITopFnDecl fn) : base() {
      this._fn = fn;
    }
    public override _IModDecl DowncastClone() {
      if (this is _IModDecl dt) { return dt; }
      return new ModDecl_TopFnDecl(_fn);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.ModDecl_TopFnDecl;
      return oth != null && object.Equals(this._fn, oth._fn);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 7;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._fn));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.ModDecl.TopFnDecl";
      s += "(";
      s += Dafny.Helpers.ToString(this._fn);
      s += ")";
      return s;
    }
  }

  public interface _ITopFnDecl {
    bool is_TopFn { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes { get; }
    RAST._IVisibility dtor_visibility { get; }
    RAST._IFn dtor_fn { get; }
    _ITopFnDecl DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class TopFnDecl : _ITopFnDecl {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _attributes;
    public readonly RAST._IVisibility _visibility;
    public readonly RAST._IFn _fn;
    public TopFnDecl(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, RAST._IVisibility visibility, RAST._IFn fn) {
      this._attributes = attributes;
      this._visibility = visibility;
      this._fn = fn;
    }
    public _ITopFnDecl DowncastClone() {
      if (this is _ITopFnDecl dt) { return dt; }
      return new TopFnDecl(_attributes, _visibility, _fn);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.TopFnDecl;
      return oth != null && object.Equals(this._attributes, oth._attributes) && object.Equals(this._visibility, oth._visibility) && object.Equals(this._fn, oth._fn);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._attributes));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._visibility));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._fn));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.TopFnDecl.TopFn";
      s += "(";
      s += Dafny.Helpers.ToString(this._attributes);
      s += ", ";
      s += Dafny.Helpers.ToString(this._visibility);
      s += ", ";
      s += Dafny.Helpers.ToString(this._fn);
      s += ")";
      return s;
    }
    private static readonly RAST._ITopFnDecl theDefault = create(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Empty, RAST.Visibility.Default(), RAST.Fn.Default());
    public static RAST._ITopFnDecl Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._ITopFnDecl> _TYPE = new Dafny.TypeDescriptor<RAST._ITopFnDecl>(RAST.TopFnDecl.Default());
    public static Dafny.TypeDescriptor<RAST._ITopFnDecl> _TypeDescriptor() {
      return _TYPE;
    }
    public static _ITopFnDecl create(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, RAST._IVisibility visibility, RAST._IFn fn) {
      return new TopFnDecl(attributes, visibility, fn);
    }
    public static _ITopFnDecl create_TopFn(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, RAST._IVisibility visibility, RAST._IFn fn) {
      return create(attributes, visibility, fn);
    }
    public bool is_TopFn { get { return true; } }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes {
      get {
        return this._attributes;
      }
    }
    public RAST._IVisibility dtor_visibility {
      get {
        return this._visibility;
      }
    }
    public RAST._IFn dtor_fn {
      get {
        return this._fn;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(RAST.Attribute.ToStringMultiple((this).dtor_attributes, ind), ((this).dtor_visibility)._ToString()), ((this).dtor_fn)._ToString(ind));
    }
  }

  public interface _IAttribute {
    bool is_RawAttribute { get; }
    Dafny.ISequence<Dafny.Rune> dtor_content { get; }
  }
  public class Attribute : _IAttribute {
    public readonly Dafny.ISequence<Dafny.Rune> _content;
    public Attribute(Dafny.ISequence<Dafny.Rune> content) {
      this._content = content;
    }
    public static Dafny.ISequence<Dafny.Rune> DowncastClone(Dafny.ISequence<Dafny.Rune> _this) {
      return _this;
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Attribute;
      return oth != null && object.Equals(this._content, oth._content);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._content));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Attribute.RawAttribute";
      s += "(";
      s += this._content.ToVerbatimString(true);
      s += ")";
      return s;
    }
    private static readonly Dafny.ISequence<Dafny.Rune> theDefault = Dafny.Sequence<Dafny.Rune>.Empty;
    public static Dafny.ISequence<Dafny.Rune> Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TYPE = new Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>>(Dafny.Sequence<Dafny.Rune>.Empty);
    public static Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IAttribute create(Dafny.ISequence<Dafny.Rune> content) {
      return new Attribute(content);
    }
    public static _IAttribute create_RawAttribute(Dafny.ISequence<Dafny.Rune> content) {
      return create(content);
    }
    public bool is_RawAttribute { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_content {
      get {
        return this._content;
      }
    }
    public static Dafny.ISequence<Dafny.Rune> ToStringMultiple(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> ind)
    {
      return RAST.__default.SeqToString<Dafny.ISequence<Dafny.Rune>>(attributes, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>>>((_957_ind) => ((System.Func<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>)((_958_attribute) => {
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((_958_attribute), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _957_ind);
      })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
    }
  }

  public interface _IStruct {
    bool is_Struct { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams { get; }
    RAST._IFields dtor_fields { get; }
    _IStruct DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class Struct : _IStruct {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _attributes;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<RAST._ITypeParamDecl> _typeParams;
    public readonly RAST._IFields _fields;
    public Struct(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IFields fields) {
      this._attributes = attributes;
      this._name = name;
      this._typeParams = typeParams;
      this._fields = fields;
    }
    public _IStruct DowncastClone() {
      if (this is _IStruct dt) { return dt; }
      return new Struct(_attributes, _name, _typeParams, _fields);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Struct;
      return oth != null && object.Equals(this._attributes, oth._attributes) && object.Equals(this._name, oth._name) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._fields, oth._fields);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._attributes));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._fields));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Struct.Struct";
      s += "(";
      s += Dafny.Helpers.ToString(this._attributes);
      s += ", ";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._fields);
      s += ")";
      return s;
    }
    private static readonly RAST._IStruct theDefault = create(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Empty, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._ITypeParamDecl>.Empty, RAST.Fields.Default());
    public static RAST._IStruct Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IStruct> _TYPE = new Dafny.TypeDescriptor<RAST._IStruct>(RAST.Struct.Default());
    public static Dafny.TypeDescriptor<RAST._IStruct> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IStruct create(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IFields fields) {
      return new Struct(attributes, name, typeParams, fields);
    }
    public static _IStruct create_Struct(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IFields fields) {
      return create(attributes, name, typeParams, fields);
    }
    public bool is_Struct { get { return true; } }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes {
      get {
        return this._attributes;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams {
      get {
        return this._typeParams;
      }
    }
    public RAST._IFields dtor_fields {
      get {
        return this._fields;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(RAST.Attribute.ToStringMultiple((this).dtor_attributes, ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub struct ")), (this).dtor_name), RAST.TypeParamDecl.ToStringMultiple((this).dtor_typeParams, ind)), ((this).dtor_fields)._ToString(ind, ((this).dtor_fields).is_NamedFields)), ((((this).dtor_fields).is_NamelessFields) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))));
    }
  }

  public interface _ITypeSynonym {
    bool is_TypeSynonym { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams { get; }
    RAST._IType dtor_tpe { get; }
    _ITypeSynonym DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class TypeSynonym : _ITypeSynonym {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _attributes;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<RAST._ITypeParamDecl> _typeParams;
    public readonly RAST._IType _tpe;
    public TypeSynonym(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IType tpe) {
      this._attributes = attributes;
      this._name = name;
      this._typeParams = typeParams;
      this._tpe = tpe;
    }
    public _ITypeSynonym DowncastClone() {
      if (this is _ITypeSynonym dt) { return dt; }
      return new TypeSynonym(_attributes, _name, _typeParams, _tpe);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.TypeSynonym;
      return oth != null && object.Equals(this._attributes, oth._attributes) && object.Equals(this._name, oth._name) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._tpe, oth._tpe);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._attributes));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tpe));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.TypeSynonym.TypeSynonym";
      s += "(";
      s += Dafny.Helpers.ToString(this._attributes);
      s += ", ";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._tpe);
      s += ")";
      return s;
    }
    private static readonly RAST._ITypeSynonym theDefault = create(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Empty, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._ITypeParamDecl>.Empty, RAST.Type.Default());
    public static RAST._ITypeSynonym Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._ITypeSynonym> _TYPE = new Dafny.TypeDescriptor<RAST._ITypeSynonym>(RAST.TypeSynonym.Default());
    public static Dafny.TypeDescriptor<RAST._ITypeSynonym> _TypeDescriptor() {
      return _TYPE;
    }
    public static _ITypeSynonym create(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IType tpe) {
      return new TypeSynonym(attributes, name, typeParams, tpe);
    }
    public static _ITypeSynonym create_TypeSynonym(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IType tpe) {
      return create(attributes, name, typeParams, tpe);
    }
    public bool is_TypeSynonym { get { return true; } }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes {
      get {
        return this._attributes;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams {
      get {
        return this._typeParams;
      }
    }
    public RAST._IType dtor_tpe {
      get {
        return this._tpe;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(RAST.Attribute.ToStringMultiple((this).dtor_attributes, ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub type ")), (this).dtor_name), RAST.TypeParamDecl.ToStringMultiple((this).dtor_typeParams, ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), ((this).dtor_tpe)._ToString(ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
    }
  }

  public interface _INamelessField {
    bool is_NamelessField { get; }
    RAST._IVisibility dtor_visibility { get; }
    RAST._IType dtor_tpe { get; }
    _INamelessField DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class NamelessField : _INamelessField {
    public readonly RAST._IVisibility _visibility;
    public readonly RAST._IType _tpe;
    public NamelessField(RAST._IVisibility visibility, RAST._IType tpe) {
      this._visibility = visibility;
      this._tpe = tpe;
    }
    public _INamelessField DowncastClone() {
      if (this is _INamelessField dt) { return dt; }
      return new NamelessField(_visibility, _tpe);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.NamelessField;
      return oth != null && object.Equals(this._visibility, oth._visibility) && object.Equals(this._tpe, oth._tpe);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._visibility));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tpe));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.NamelessField.NamelessField";
      s += "(";
      s += Dafny.Helpers.ToString(this._visibility);
      s += ", ";
      s += Dafny.Helpers.ToString(this._tpe);
      s += ")";
      return s;
    }
    private static readonly RAST._INamelessField theDefault = create(RAST.Visibility.Default(), RAST.Type.Default());
    public static RAST._INamelessField Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._INamelessField> _TYPE = new Dafny.TypeDescriptor<RAST._INamelessField>(RAST.NamelessField.Default());
    public static Dafny.TypeDescriptor<RAST._INamelessField> _TypeDescriptor() {
      return _TYPE;
    }
    public static _INamelessField create(RAST._IVisibility visibility, RAST._IType tpe) {
      return new NamelessField(visibility, tpe);
    }
    public static _INamelessField create_NamelessField(RAST._IVisibility visibility, RAST._IType tpe) {
      return create(visibility, tpe);
    }
    public bool is_NamelessField { get { return true; } }
    public RAST._IVisibility dtor_visibility {
      get {
        return this._visibility;
      }
    }
    public RAST._IType dtor_tpe {
      get {
        return this._tpe;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      return Dafny.Sequence<Dafny.Rune>.Concat(((this).dtor_visibility)._ToString(), ((this).dtor_tpe)._ToString(ind));
    }
  }

  public interface _IField {
    bool is_Field { get; }
    RAST._IVisibility dtor_visibility { get; }
    RAST._IFormal dtor_formal { get; }
    _IField DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class Field : _IField {
    public readonly RAST._IVisibility _visibility;
    public readonly RAST._IFormal _formal;
    public Field(RAST._IVisibility visibility, RAST._IFormal formal) {
      this._visibility = visibility;
      this._formal = formal;
    }
    public _IField DowncastClone() {
      if (this is _IField dt) { return dt; }
      return new Field(_visibility, _formal);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Field;
      return oth != null && object.Equals(this._visibility, oth._visibility) && object.Equals(this._formal, oth._formal);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._visibility));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._formal));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Field.Field";
      s += "(";
      s += Dafny.Helpers.ToString(this._visibility);
      s += ", ";
      s += Dafny.Helpers.ToString(this._formal);
      s += ")";
      return s;
    }
    private static readonly RAST._IField theDefault = create(RAST.Visibility.Default(), RAST.Formal.Default());
    public static RAST._IField Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IField> _TYPE = new Dafny.TypeDescriptor<RAST._IField>(RAST.Field.Default());
    public static Dafny.TypeDescriptor<RAST._IField> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IField create(RAST._IVisibility visibility, RAST._IFormal formal) {
      return new Field(visibility, formal);
    }
    public static _IField create_Field(RAST._IVisibility visibility, RAST._IFormal formal) {
      return create(visibility, formal);
    }
    public bool is_Field { get { return true; } }
    public RAST._IVisibility dtor_visibility {
      get {
        return this._visibility;
      }
    }
    public RAST._IFormal dtor_formal {
      get {
        return this._formal;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      return Dafny.Sequence<Dafny.Rune>.Concat(((this).dtor_visibility)._ToString(), ((this).dtor_formal)._ToString(ind));
    }
  }

  public interface _IFields {
    bool is_NamedFields { get; }
    bool is_NamelessFields { get; }
    Dafny.ISequence<RAST._IField> dtor_fields { get; }
    Dafny.ISequence<RAST._INamelessField> dtor_types { get; }
    _IFields DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind, bool newLine);
  }
  public abstract class Fields : _IFields {
    public Fields() {
    }
    private static readonly RAST._IFields theDefault = create_NamedFields(Dafny.Sequence<RAST._IField>.Empty);
    public static RAST._IFields Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IFields> _TYPE = new Dafny.TypeDescriptor<RAST._IFields>(RAST.Fields.Default());
    public static Dafny.TypeDescriptor<RAST._IFields> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IFields create_NamedFields(Dafny.ISequence<RAST._IField> fields) {
      return new Fields_NamedFields(fields);
    }
    public static _IFields create_NamelessFields(Dafny.ISequence<RAST._INamelessField> types) {
      return new Fields_NamelessFields(types);
    }
    public bool is_NamedFields { get { return this is Fields_NamedFields; } }
    public bool is_NamelessFields { get { return this is Fields_NamelessFields; } }
    public Dafny.ISequence<RAST._IField> dtor_fields {
      get {
        var d = this;
        return ((Fields_NamedFields)d)._fields;
      }
    }
    public Dafny.ISequence<RAST._INamelessField> dtor_types {
      get {
        var d = this;
        return ((Fields_NamelessFields)d)._types;
      }
    }
    public abstract _IFields DowncastClone();
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind, bool newLine)
    {
      if ((this).is_NamedFields) {
        Dafny.ISequence<Dafny.Rune> _959_separator = ((newLine) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"), ind), RAST.__default.IND)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")));
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs40 = (((newLine) && ((new BigInteger(((this).dtor_fields).Count)).Sign == 1)) ? (_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind), RAST.__default.IND), Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind))) : ((((new BigInteger(((this).dtor_fields).Count)).Sign == 1) ? (_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "))) : (_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))))));
        Dafny.ISequence<Dafny.Rune> _960_beginSpace = _let_tmp_rhs40.dtor__0;
        Dafny.ISequence<Dafny.Rune> _961_endSpace = _let_tmp_rhs40.dtor__1;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"), _960_beginSpace), RAST.__default.SeqToString<RAST._IField>((this).dtor_fields, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IField, Dafny.ISequence<Dafny.Rune>>>>((_962_ind) => ((System.Func<RAST._IField, Dafny.ISequence<Dafny.Rune>>)((_963_field) => {
          return (_963_field)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_962_ind, RAST.__default.IND));
        })))(ind), _959_separator)), _961_endSpace), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
      } else {
        Dafny.ISequence<Dafny.Rune> _964_separator = ((newLine) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"), ind), RAST.__default.IND)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")));
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), RAST.__default.SeqToString<RAST._INamelessField>((this).dtor_types, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._INamelessField, Dafny.ISequence<Dafny.Rune>>>>((_965_ind) => ((System.Func<RAST._INamelessField, Dafny.ISequence<Dafny.Rune>>)((_966_t) => {
          return (_966_t)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_965_ind, RAST.__default.IND));
        })))(ind), _964_separator)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
    }
  }
  public class Fields_NamedFields : Fields {
    public readonly Dafny.ISequence<RAST._IField> _fields;
    public Fields_NamedFields(Dafny.ISequence<RAST._IField> fields) : base() {
      this._fields = fields;
    }
    public override _IFields DowncastClone() {
      if (this is _IFields dt) { return dt; }
      return new Fields_NamedFields(_fields);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Fields_NamedFields;
      return oth != null && object.Equals(this._fields, oth._fields);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._fields));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Fields.NamedFields";
      s += "(";
      s += Dafny.Helpers.ToString(this._fields);
      s += ")";
      return s;
    }
  }
  public class Fields_NamelessFields : Fields {
    public readonly Dafny.ISequence<RAST._INamelessField> _types;
    public Fields_NamelessFields(Dafny.ISequence<RAST._INamelessField> types) : base() {
      this._types = types;
    }
    public override _IFields DowncastClone() {
      if (this is _IFields dt) { return dt; }
      return new Fields_NamelessFields(_types);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Fields_NamelessFields;
      return oth != null && object.Equals(this._types, oth._types);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._types));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Fields.NamelessFields";
      s += "(";
      s += Dafny.Helpers.ToString(this._types);
      s += ")";
      return s;
    }
  }

  public interface _IEnumCase {
    bool is_EnumCase { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    RAST._IFields dtor_fields { get; }
    _IEnumCase DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind, bool newLine);
  }
  public class EnumCase : _IEnumCase {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly RAST._IFields _fields;
    public EnumCase(Dafny.ISequence<Dafny.Rune> name, RAST._IFields fields) {
      this._name = name;
      this._fields = fields;
    }
    public _IEnumCase DowncastClone() {
      if (this is _IEnumCase dt) { return dt; }
      return new EnumCase(_name, _fields);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.EnumCase;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._fields, oth._fields);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._fields));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.EnumCase.EnumCase";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._fields);
      s += ")";
      return s;
    }
    private static readonly RAST._IEnumCase theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, RAST.Fields.Default());
    public static RAST._IEnumCase Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IEnumCase> _TYPE = new Dafny.TypeDescriptor<RAST._IEnumCase>(RAST.EnumCase.Default());
    public static Dafny.TypeDescriptor<RAST._IEnumCase> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IEnumCase create(Dafny.ISequence<Dafny.Rune> name, RAST._IFields fields) {
      return new EnumCase(name, fields);
    }
    public static _IEnumCase create_EnumCase(Dafny.ISequence<Dafny.Rune> name, RAST._IFields fields) {
      return create(name, fields);
    }
    public bool is_EnumCase { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public RAST._IFields dtor_fields {
      get {
        return this._fields;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind, bool newLine)
    {
      return Dafny.Sequence<Dafny.Rune>.Concat((this).dtor_name, ((this).dtor_fields)._ToString(ind, newLine));
    }
  }

  public interface _IEnum {
    bool is_Enum { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams { get; }
    Dafny.ISequence<RAST._IEnumCase> dtor_variants { get; }
    _IEnum DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class Enum : _IEnum {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _attributes;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<RAST._ITypeParamDecl> _typeParams;
    public readonly Dafny.ISequence<RAST._IEnumCase> _variants;
    public Enum(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, Dafny.ISequence<RAST._IEnumCase> variants) {
      this._attributes = attributes;
      this._name = name;
      this._typeParams = typeParams;
      this._variants = variants;
    }
    public _IEnum DowncastClone() {
      if (this is _IEnum dt) { return dt; }
      return new Enum(_attributes, _name, _typeParams, _variants);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Enum;
      return oth != null && object.Equals(this._attributes, oth._attributes) && object.Equals(this._name, oth._name) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._variants, oth._variants);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._attributes));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._variants));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Enum.Enum";
      s += "(";
      s += Dafny.Helpers.ToString(this._attributes);
      s += ", ";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._variants);
      s += ")";
      return s;
    }
    private static readonly RAST._IEnum theDefault = create(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Empty, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._ITypeParamDecl>.Empty, Dafny.Sequence<RAST._IEnumCase>.Empty);
    public static RAST._IEnum Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IEnum> _TYPE = new Dafny.TypeDescriptor<RAST._IEnum>(RAST.Enum.Default());
    public static Dafny.TypeDescriptor<RAST._IEnum> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IEnum create(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, Dafny.ISequence<RAST._IEnumCase> variants) {
      return new Enum(attributes, name, typeParams, variants);
    }
    public static _IEnum create_Enum(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, Dafny.ISequence<RAST._IEnumCase> variants) {
      return create(attributes, name, typeParams, variants);
    }
    public bool is_Enum { get { return true; } }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes {
      get {
        return this._attributes;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams {
      get {
        return this._typeParams;
      }
    }
    public Dafny.ISequence<RAST._IEnumCase> dtor_variants {
      get {
        return this._variants;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(RAST.Attribute.ToStringMultiple((this).dtor_attributes, ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub enum ")), (this).dtor_name), RAST.TypeParamDecl.ToStringMultiple((this).dtor_typeParams, ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {")), RAST.__default.SeqToString<RAST._IEnumCase>((this).dtor_variants, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IEnumCase, Dafny.ISequence<Dafny.Rune>>>>((_967_ind) => ((System.Func<RAST._IEnumCase, Dafny.ISequence<Dafny.Rune>>)((_968_variant) => {
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), _967_ind), RAST.__default.IND), (_968_variant)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_967_ind, RAST.__default.IND), true));
      })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
    }
  }

  public interface _ITypeParamDecl {
    bool is_TypeParamDecl { get; }
    Dafny.ISequence<Dafny.Rune> dtor_content { get; }
    Dafny.ISequence<RAST._IType> dtor_constraints { get; }
    _ITypeParamDecl DowncastClone();
    RAST._ITypeParamDecl AddConstraints(Dafny.ISequence<RAST._IType> constraints);
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class TypeParamDecl : _ITypeParamDecl {
    public readonly Dafny.ISequence<Dafny.Rune> _content;
    public readonly Dafny.ISequence<RAST._IType> _constraints;
    public TypeParamDecl(Dafny.ISequence<Dafny.Rune> content, Dafny.ISequence<RAST._IType> constraints) {
      this._content = content;
      this._constraints = constraints;
    }
    public _ITypeParamDecl DowncastClone() {
      if (this is _ITypeParamDecl dt) { return dt; }
      return new TypeParamDecl(_content, _constraints);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.TypeParamDecl;
      return oth != null && object.Equals(this._content, oth._content) && object.Equals(this._constraints, oth._constraints);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._content));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._constraints));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.TypeParamDecl.TypeParamDecl";
      s += "(";
      s += this._content.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._constraints);
      s += ")";
      return s;
    }
    private static readonly RAST._ITypeParamDecl theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._IType>.Empty);
    public static RAST._ITypeParamDecl Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._ITypeParamDecl> _TYPE = new Dafny.TypeDescriptor<RAST._ITypeParamDecl>(RAST.TypeParamDecl.Default());
    public static Dafny.TypeDescriptor<RAST._ITypeParamDecl> _TypeDescriptor() {
      return _TYPE;
    }
    public static _ITypeParamDecl create(Dafny.ISequence<Dafny.Rune> content, Dafny.ISequence<RAST._IType> constraints) {
      return new TypeParamDecl(content, constraints);
    }
    public static _ITypeParamDecl create_TypeParamDecl(Dafny.ISequence<Dafny.Rune> content, Dafny.ISequence<RAST._IType> constraints) {
      return create(content, constraints);
    }
    public bool is_TypeParamDecl { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_content {
      get {
        return this._content;
      }
    }
    public Dafny.ISequence<RAST._IType> dtor_constraints {
      get {
        return this._constraints;
      }
    }
    public static Dafny.ISequence<Dafny.Rune> ToStringMultiple(Dafny.ISequence<RAST._ITypeParamDecl> typeParams, Dafny.ISequence<Dafny.Rune> ind)
    {
      if ((new BigInteger((typeParams).Count)).Sign == 0) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      } else {
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), RAST.__default.SeqToString<RAST._ITypeParamDecl>(typeParams, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._ITypeParamDecl, Dafny.ISequence<Dafny.Rune>>>>((_969_ind) => ((System.Func<RAST._ITypeParamDecl, Dafny.ISequence<Dafny.Rune>>)((_970_t) => {
          return (_970_t)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_969_ind, RAST.__default.IND));
        })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
    }
    public static Dafny.ISequence<RAST._ITypeParamDecl> AddConstraintsMultiple(Dafny.ISequence<RAST._ITypeParamDecl> typeParams, Dafny.ISequence<RAST._IType> constraints)
    {
      Dafny.ISequence<RAST._ITypeParamDecl> _971___accumulator = Dafny.Sequence<RAST._ITypeParamDecl>.FromElements();
    TAIL_CALL_START: ;
      if ((new BigInteger((typeParams).Count)).Sign == 0) {
        return Dafny.Sequence<RAST._ITypeParamDecl>.Concat(_971___accumulator, Dafny.Sequence<RAST._ITypeParamDecl>.FromElements());
      } else {
        _971___accumulator = Dafny.Sequence<RAST._ITypeParamDecl>.Concat(_971___accumulator, Dafny.Sequence<RAST._ITypeParamDecl>.FromElements(((typeParams).Select(BigInteger.Zero)).AddConstraints(constraints)));
        Dafny.ISequence<RAST._ITypeParamDecl> _in111 = (typeParams).Drop(BigInteger.One);
        Dafny.ISequence<RAST._IType> _in112 = constraints;
        typeParams = _in111;
        constraints = _in112;
        goto TAIL_CALL_START;
      }
    }
    public RAST._ITypeParamDecl AddConstraints(Dafny.ISequence<RAST._IType> constraints) {
      RAST._ITypeParamDecl _972_dt__update__tmp_h0 = this;
      Dafny.ISequence<RAST._IType> _973_dt__update_hconstraints_h0 = Dafny.Sequence<RAST._IType>.Concat((this).dtor_constraints, constraints);
      return RAST.TypeParamDecl.create((_972_dt__update__tmp_h0).dtor_content, _973_dt__update_hconstraints_h0);
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      return Dafny.Sequence<Dafny.Rune>.Concat((this).dtor_content, (((new BigInteger(((this).dtor_constraints).Count)).Sign == 0) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": "), RAST.__default.SeqToString<RAST._IType>((this).dtor_constraints, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>>>((_974_ind) => ((System.Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>)((_975_t) => {
        return (_975_t)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_974_ind, RAST.__default.IND));
      })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + "))))));
    }
  }

  public interface _IType {
    bool is_SelfOwned { get; }
    bool is_U8 { get; }
    bool is_U16 { get; }
    bool is_U32 { get; }
    bool is_U64 { get; }
    bool is_U128 { get; }
    bool is_I8 { get; }
    bool is_I16 { get; }
    bool is_I32 { get; }
    bool is_I64 { get; }
    bool is_I128 { get; }
    bool is_Bool { get; }
    bool is_TIdentifier { get; }
    bool is_TMemberSelect { get; }
    bool is_TypeApp { get; }
    bool is_Borrowed { get; }
    bool is_BorrowedMut { get; }
    bool is_ImplType { get; }
    bool is_DynType { get; }
    bool is_TupleType { get; }
    bool is_FnType { get; }
    bool is_IntersectionType { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    RAST._IType dtor_base { get; }
    RAST._IType dtor_baseName { get; }
    Dafny.ISequence<RAST._IType> dtor_arguments { get; }
    RAST._IType dtor_underlying { get; }
    RAST._IType dtor_returnType { get; }
    RAST._IType dtor_left { get; }
    RAST._IType dtor_right { get; }
    _IType DowncastClone();
    bool CanReadWithoutClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    RAST._IType MSel(Dafny.ISequence<Dafny.Rune> name);
    RAST._IType Apply1(RAST._IType arg);
    RAST._IType Apply(Dafny.ISequence<RAST._IType> args);
    RAST._IType ToOwned();
  }
  public abstract class Type : _IType {
    public Type() {
    }
    private static readonly RAST._IType theDefault = create_SelfOwned();
    public static RAST._IType Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IType> _TYPE = new Dafny.TypeDescriptor<RAST._IType>(RAST.Type.Default());
    public static Dafny.TypeDescriptor<RAST._IType> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IType create_SelfOwned() {
      return new Type_SelfOwned();
    }
    public static _IType create_U8() {
      return new Type_U8();
    }
    public static _IType create_U16() {
      return new Type_U16();
    }
    public static _IType create_U32() {
      return new Type_U32();
    }
    public static _IType create_U64() {
      return new Type_U64();
    }
    public static _IType create_U128() {
      return new Type_U128();
    }
    public static _IType create_I8() {
      return new Type_I8();
    }
    public static _IType create_I16() {
      return new Type_I16();
    }
    public static _IType create_I32() {
      return new Type_I32();
    }
    public static _IType create_I64() {
      return new Type_I64();
    }
    public static _IType create_I128() {
      return new Type_I128();
    }
    public static _IType create_Bool() {
      return new Type_Bool();
    }
    public static _IType create_TIdentifier(Dafny.ISequence<Dafny.Rune> name) {
      return new Type_TIdentifier(name);
    }
    public static _IType create_TMemberSelect(RAST._IType @base, Dafny.ISequence<Dafny.Rune> name) {
      return new Type_TMemberSelect(@base, name);
    }
    public static _IType create_TypeApp(RAST._IType baseName, Dafny.ISequence<RAST._IType> arguments) {
      return new Type_TypeApp(baseName, arguments);
    }
    public static _IType create_Borrowed(RAST._IType underlying) {
      return new Type_Borrowed(underlying);
    }
    public static _IType create_BorrowedMut(RAST._IType underlying) {
      return new Type_BorrowedMut(underlying);
    }
    public static _IType create_ImplType(RAST._IType underlying) {
      return new Type_ImplType(underlying);
    }
    public static _IType create_DynType(RAST._IType underlying) {
      return new Type_DynType(underlying);
    }
    public static _IType create_TupleType(Dafny.ISequence<RAST._IType> arguments) {
      return new Type_TupleType(arguments);
    }
    public static _IType create_FnType(Dafny.ISequence<RAST._IType> arguments, RAST._IType returnType) {
      return new Type_FnType(arguments, returnType);
    }
    public static _IType create_IntersectionType(RAST._IType left, RAST._IType right) {
      return new Type_IntersectionType(left, right);
    }
    public bool is_SelfOwned { get { return this is Type_SelfOwned; } }
    public bool is_U8 { get { return this is Type_U8; } }
    public bool is_U16 { get { return this is Type_U16; } }
    public bool is_U32 { get { return this is Type_U32; } }
    public bool is_U64 { get { return this is Type_U64; } }
    public bool is_U128 { get { return this is Type_U128; } }
    public bool is_I8 { get { return this is Type_I8; } }
    public bool is_I16 { get { return this is Type_I16; } }
    public bool is_I32 { get { return this is Type_I32; } }
    public bool is_I64 { get { return this is Type_I64; } }
    public bool is_I128 { get { return this is Type_I128; } }
    public bool is_Bool { get { return this is Type_Bool; } }
    public bool is_TIdentifier { get { return this is Type_TIdentifier; } }
    public bool is_TMemberSelect { get { return this is Type_TMemberSelect; } }
    public bool is_TypeApp { get { return this is Type_TypeApp; } }
    public bool is_Borrowed { get { return this is Type_Borrowed; } }
    public bool is_BorrowedMut { get { return this is Type_BorrowedMut; } }
    public bool is_ImplType { get { return this is Type_ImplType; } }
    public bool is_DynType { get { return this is Type_DynType; } }
    public bool is_TupleType { get { return this is Type_TupleType; } }
    public bool is_FnType { get { return this is Type_FnType; } }
    public bool is_IntersectionType { get { return this is Type_IntersectionType; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        var d = this;
        if (d is Type_TIdentifier) { return ((Type_TIdentifier)d)._name; }
        return ((Type_TMemberSelect)d)._name;
      }
    }
    public RAST._IType dtor_base {
      get {
        var d = this;
        return ((Type_TMemberSelect)d)._base;
      }
    }
    public RAST._IType dtor_baseName {
      get {
        var d = this;
        return ((Type_TypeApp)d)._baseName;
      }
    }
    public Dafny.ISequence<RAST._IType> dtor_arguments {
      get {
        var d = this;
        if (d is Type_TypeApp) { return ((Type_TypeApp)d)._arguments; }
        if (d is Type_TupleType) { return ((Type_TupleType)d)._arguments; }
        return ((Type_FnType)d)._arguments;
      }
    }
    public RAST._IType dtor_underlying {
      get {
        var d = this;
        if (d is Type_Borrowed) { return ((Type_Borrowed)d)._underlying; }
        if (d is Type_BorrowedMut) { return ((Type_BorrowedMut)d)._underlying; }
        if (d is Type_ImplType) { return ((Type_ImplType)d)._underlying; }
        return ((Type_DynType)d)._underlying;
      }
    }
    public RAST._IType dtor_returnType {
      get {
        var d = this;
        return ((Type_FnType)d)._returnType;
      }
    }
    public RAST._IType dtor_left {
      get {
        var d = this;
        return ((Type_IntersectionType)d)._left;
      }
    }
    public RAST._IType dtor_right {
      get {
        var d = this;
        return ((Type_IntersectionType)d)._right;
      }
    }
    public abstract _IType DowncastClone();
    public bool CanReadWithoutClone() {
      return (((((((((((this).is_U8) || ((this).is_U16)) || ((this).is_U32)) || ((this).is_U64)) || ((this).is_U128)) || ((this).is_I8)) || ((this).is_I16)) || ((this).is_I32)) || ((this).is_I64)) || ((this).is_I128)) || ((this).is_Bool);
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      RAST._IType _source35 = this;
      if (_source35.is_SelfOwned) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Self");
      } else if (_source35.is_U8) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("u8");
      } else if (_source35.is_U16) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("u16");
      } else if (_source35.is_U32) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("u32");
      } else if (_source35.is_U64) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("u64");
      } else if (_source35.is_U128) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("u128");
      } else if (_source35.is_I8) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("i8");
      } else if (_source35.is_I16) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("i16");
      } else if (_source35.is_I32) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("i32");
      } else if (_source35.is_I64) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("i64");
      } else if (_source35.is_I128) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("i128");
      } else if (_source35.is_Bool) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("bool");
      } else if (_source35.is_TIdentifier) {
        Dafny.ISequence<Dafny.Rune> _976___mcc_h0 = _source35.dtor_name;
        Dafny.ISequence<Dafny.Rune> _977_underlying = _976___mcc_h0;
        return _977_underlying;
      } else if (_source35.is_TMemberSelect) {
        RAST._IType _978___mcc_h1 = _source35.dtor_base;
        Dafny.ISequence<Dafny.Rune> _979___mcc_h2 = _source35.dtor_name;
        Dafny.ISequence<Dafny.Rune> _980_name = _979___mcc_h2;
        RAST._IType _981_underlying = _978___mcc_h1;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((_981_underlying)._ToString(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _980_name);
      } else if (_source35.is_TypeApp) {
        RAST._IType _982___mcc_h3 = _source35.dtor_baseName;
        Dafny.ISequence<RAST._IType> _983___mcc_h4 = _source35.dtor_arguments;
        Dafny.ISequence<RAST._IType> _984_args = _983___mcc_h4;
        RAST._IType _985_base = _982___mcc_h3;
        return Dafny.Sequence<Dafny.Rune>.Concat((_985_base)._ToString(ind), (((_984_args).Equals(Dafny.Sequence<RAST._IType>.FromElements())) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), RAST.__default.SeqToString<RAST._IType>(_984_args, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>>>((_986_ind) => ((System.Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>)((_987_arg) => {
          return (_987_arg)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_986_ind, RAST.__default.IND));
        })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">")))));
      } else if (_source35.is_Borrowed) {
        RAST._IType _988___mcc_h5 = _source35.dtor_underlying;
        RAST._IType _989_underlying = _988___mcc_h5;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), (_989_underlying)._ToString(ind));
      } else if (_source35.is_BorrowedMut) {
        RAST._IType _990___mcc_h6 = _source35.dtor_underlying;
        RAST._IType _991_underlying = _990___mcc_h6;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&mut "), (_991_underlying)._ToString(ind));
      } else if (_source35.is_ImplType) {
        RAST._IType _992___mcc_h7 = _source35.dtor_underlying;
        RAST._IType _993_underlying = _992___mcc_h7;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), (_993_underlying)._ToString(ind));
      } else if (_source35.is_DynType) {
        RAST._IType _994___mcc_h8 = _source35.dtor_underlying;
        RAST._IType _995_underlying = _994___mcc_h8;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("dyn "), (_995_underlying)._ToString(ind));
      } else if (_source35.is_TupleType) {
        Dafny.ISequence<RAST._IType> _996___mcc_h9 = _source35.dtor_arguments;
        Dafny.ISequence<RAST._IType> _997_args = _996___mcc_h9;
        if ((_997_args).Equals(Dafny.Sequence<RAST._IType>.FromElements())) {
          return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()");
        } else {
          return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), RAST.__default.SeqToString<RAST._IType>(_997_args, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>>>((_998_ind) => ((System.Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>)((_999_arg) => {
            return (_999_arg)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_998_ind, RAST.__default.IND));
          })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
        }
      } else if (_source35.is_FnType) {
        Dafny.ISequence<RAST._IType> _1000___mcc_h10 = _source35.dtor_arguments;
        RAST._IType _1001___mcc_h11 = _source35.dtor_returnType;
        RAST._IType _1002_returnType = _1001___mcc_h11;
        Dafny.ISequence<RAST._IType> _1003_arguments = _1000___mcc_h10;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Fn("), RAST.__default.SeqToString<RAST._IType>(_1003_arguments, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>>>((_1004_ind) => ((System.Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>)((_1005_arg) => {
          return (_1005_arg)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1004_ind, RAST.__default.IND));
        })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), (_1002_returnType)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)));
      } else {
        RAST._IType _1006___mcc_h12 = _source35.dtor_left;
        RAST._IType _1007___mcc_h13 = _source35.dtor_right;
        RAST._IType _1008_right = _1007___mcc_h13;
        RAST._IType _1009_left = _1006___mcc_h12;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((_1009_left)._ToString(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + ")), (_1008_right)._ToString(ind));
      }
    }
    public RAST._IType MSel(Dafny.ISequence<Dafny.Rune> name) {
      return RAST.Type.create_TMemberSelect(this, name);
    }
    public RAST._IType Apply1(RAST._IType arg) {
      return RAST.Type.create_TypeApp(this, Dafny.Sequence<RAST._IType>.FromElements(arg));
    }
    public RAST._IType Apply(Dafny.ISequence<RAST._IType> args) {
      return RAST.Type.create_TypeApp(this, args);
    }
    public RAST._IType ToOwned() {
      RAST._IType _source36 = this;
      if (_source36.is_SelfOwned) {
        RAST._IType _1010_x = this;
        return _1010_x;
      } else if (_source36.is_U8) {
        RAST._IType _1011_x = this;
        return _1011_x;
      } else if (_source36.is_U16) {
        RAST._IType _1012_x = this;
        return _1012_x;
      } else if (_source36.is_U32) {
        RAST._IType _1013_x = this;
        return _1013_x;
      } else if (_source36.is_U64) {
        RAST._IType _1014_x = this;
        return _1014_x;
      } else if (_source36.is_U128) {
        RAST._IType _1015_x = this;
        return _1015_x;
      } else if (_source36.is_I8) {
        RAST._IType _1016_x = this;
        return _1016_x;
      } else if (_source36.is_I16) {
        RAST._IType _1017_x = this;
        return _1017_x;
      } else if (_source36.is_I32) {
        RAST._IType _1018_x = this;
        return _1018_x;
      } else if (_source36.is_I64) {
        RAST._IType _1019_x = this;
        return _1019_x;
      } else if (_source36.is_I128) {
        RAST._IType _1020_x = this;
        return _1020_x;
      } else if (_source36.is_Bool) {
        RAST._IType _1021_x = this;
        return _1021_x;
      } else if (_source36.is_TIdentifier) {
        Dafny.ISequence<Dafny.Rune> _1022___mcc_h0 = _source36.dtor_name;
        RAST._IType _1023_x = this;
        return _1023_x;
      } else if (_source36.is_TMemberSelect) {
        RAST._IType _1024___mcc_h2 = _source36.dtor_base;
        Dafny.ISequence<Dafny.Rune> _1025___mcc_h3 = _source36.dtor_name;
        RAST._IType _1026_x = this;
        return _1026_x;
      } else if (_source36.is_TypeApp) {
        RAST._IType _1027___mcc_h6 = _source36.dtor_baseName;
        Dafny.ISequence<RAST._IType> _1028___mcc_h7 = _source36.dtor_arguments;
        RAST._IType _1029_x = this;
        return _1029_x;
      } else if (_source36.is_Borrowed) {
        RAST._IType _1030___mcc_h10 = _source36.dtor_underlying;
        RAST._IType _1031_x = _1030___mcc_h10;
        return _1031_x;
      } else if (_source36.is_BorrowedMut) {
        RAST._IType _1032___mcc_h12 = _source36.dtor_underlying;
        RAST._IType _1033_x = _1032___mcc_h12;
        return _1033_x;
      } else if (_source36.is_ImplType) {
        RAST._IType _1034___mcc_h14 = _source36.dtor_underlying;
        RAST._IType _1035_x = this;
        return _1035_x;
      } else if (_source36.is_DynType) {
        RAST._IType _1036___mcc_h16 = _source36.dtor_underlying;
        RAST._IType _1037_x = this;
        return _1037_x;
      } else if (_source36.is_TupleType) {
        Dafny.ISequence<RAST._IType> _1038___mcc_h18 = _source36.dtor_arguments;
        RAST._IType _1039_x = this;
        return _1039_x;
      } else if (_source36.is_FnType) {
        Dafny.ISequence<RAST._IType> _1040___mcc_h20 = _source36.dtor_arguments;
        RAST._IType _1041___mcc_h21 = _source36.dtor_returnType;
        RAST._IType _1042_x = this;
        return _1042_x;
      } else {
        RAST._IType _1043___mcc_h24 = _source36.dtor_left;
        RAST._IType _1044___mcc_h25 = _source36.dtor_right;
        RAST._IType _1045_x = this;
        return _1045_x;
      }
    }
  }
  public class Type_SelfOwned : Type {
    public Type_SelfOwned() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_SelfOwned();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_SelfOwned;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.SelfOwned";
      return s;
    }
  }
  public class Type_U8 : Type {
    public Type_U8() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_U8();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_U8;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.U8";
      return s;
    }
  }
  public class Type_U16 : Type {
    public Type_U16() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_U16();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_U16;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.U16";
      return s;
    }
  }
  public class Type_U32 : Type {
    public Type_U32() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_U32();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_U32;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.U32";
      return s;
    }
  }
  public class Type_U64 : Type {
    public Type_U64() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_U64();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_U64;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 4;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.U64";
      return s;
    }
  }
  public class Type_U128 : Type {
    public Type_U128() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_U128();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_U128;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 5;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.U128";
      return s;
    }
  }
  public class Type_I8 : Type {
    public Type_I8() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_I8();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_I8;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 6;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.I8";
      return s;
    }
  }
  public class Type_I16 : Type {
    public Type_I16() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_I16();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_I16;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 7;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.I16";
      return s;
    }
  }
  public class Type_I32 : Type {
    public Type_I32() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_I32();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_I32;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 8;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.I32";
      return s;
    }
  }
  public class Type_I64 : Type {
    public Type_I64() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_I64();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_I64;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 9;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.I64";
      return s;
    }
  }
  public class Type_I128 : Type {
    public Type_I128() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_I128();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_I128;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 10;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.I128";
      return s;
    }
  }
  public class Type_Bool : Type {
    public Type_Bool() : base() {
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Bool();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_Bool;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 11;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.Bool";
      return s;
    }
  }
  public class Type_TIdentifier : Type {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public Type_TIdentifier(Dafny.ISequence<Dafny.Rune> name) : base() {
      this._name = name;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_TIdentifier(_name);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_TIdentifier;
      return oth != null && object.Equals(this._name, oth._name);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 12;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.TIdentifier";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Type_TMemberSelect : Type {
    public readonly RAST._IType _base;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public Type_TMemberSelect(RAST._IType @base, Dafny.ISequence<Dafny.Rune> name) : base() {
      this._base = @base;
      this._name = name;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_TMemberSelect(_base, _name);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_TMemberSelect;
      return oth != null && object.Equals(this._base, oth._base) && object.Equals(this._name, oth._name);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 13;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._base));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.TMemberSelect";
      s += "(";
      s += Dafny.Helpers.ToString(this._base);
      s += ", ";
      s += this._name.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Type_TypeApp : Type {
    public readonly RAST._IType _baseName;
    public readonly Dafny.ISequence<RAST._IType> _arguments;
    public Type_TypeApp(RAST._IType baseName, Dafny.ISequence<RAST._IType> arguments) : base() {
      this._baseName = baseName;
      this._arguments = arguments;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_TypeApp(_baseName, _arguments);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_TypeApp;
      return oth != null && object.Equals(this._baseName, oth._baseName) && object.Equals(this._arguments, oth._arguments);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 14;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._baseName));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._arguments));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.TypeApp";
      s += "(";
      s += Dafny.Helpers.ToString(this._baseName);
      s += ", ";
      s += Dafny.Helpers.ToString(this._arguments);
      s += ")";
      return s;
    }
  }
  public class Type_Borrowed : Type {
    public readonly RAST._IType _underlying;
    public Type_Borrowed(RAST._IType underlying) : base() {
      this._underlying = underlying;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Borrowed(_underlying);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_Borrowed;
      return oth != null && object.Equals(this._underlying, oth._underlying);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 15;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._underlying));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.Borrowed";
      s += "(";
      s += Dafny.Helpers.ToString(this._underlying);
      s += ")";
      return s;
    }
  }
  public class Type_BorrowedMut : Type {
    public readonly RAST._IType _underlying;
    public Type_BorrowedMut(RAST._IType underlying) : base() {
      this._underlying = underlying;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_BorrowedMut(_underlying);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_BorrowedMut;
      return oth != null && object.Equals(this._underlying, oth._underlying);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 16;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._underlying));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.BorrowedMut";
      s += "(";
      s += Dafny.Helpers.ToString(this._underlying);
      s += ")";
      return s;
    }
  }
  public class Type_ImplType : Type {
    public readonly RAST._IType _underlying;
    public Type_ImplType(RAST._IType underlying) : base() {
      this._underlying = underlying;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_ImplType(_underlying);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_ImplType;
      return oth != null && object.Equals(this._underlying, oth._underlying);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 17;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._underlying));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.ImplType";
      s += "(";
      s += Dafny.Helpers.ToString(this._underlying);
      s += ")";
      return s;
    }
  }
  public class Type_DynType : Type {
    public readonly RAST._IType _underlying;
    public Type_DynType(RAST._IType underlying) : base() {
      this._underlying = underlying;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_DynType(_underlying);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_DynType;
      return oth != null && object.Equals(this._underlying, oth._underlying);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 18;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._underlying));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.DynType";
      s += "(";
      s += Dafny.Helpers.ToString(this._underlying);
      s += ")";
      return s;
    }
  }
  public class Type_TupleType : Type {
    public readonly Dafny.ISequence<RAST._IType> _arguments;
    public Type_TupleType(Dafny.ISequence<RAST._IType> arguments) : base() {
      this._arguments = arguments;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_TupleType(_arguments);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_TupleType;
      return oth != null && object.Equals(this._arguments, oth._arguments);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 19;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._arguments));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.TupleType";
      s += "(";
      s += Dafny.Helpers.ToString(this._arguments);
      s += ")";
      return s;
    }
  }
  public class Type_FnType : Type {
    public readonly Dafny.ISequence<RAST._IType> _arguments;
    public readonly RAST._IType _returnType;
    public Type_FnType(Dafny.ISequence<RAST._IType> arguments, RAST._IType returnType) : base() {
      this._arguments = arguments;
      this._returnType = returnType;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_FnType(_arguments, _returnType);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_FnType;
      return oth != null && object.Equals(this._arguments, oth._arguments) && object.Equals(this._returnType, oth._returnType);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 20;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._arguments));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._returnType));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.FnType";
      s += "(";
      s += Dafny.Helpers.ToString(this._arguments);
      s += ", ";
      s += Dafny.Helpers.ToString(this._returnType);
      s += ")";
      return s;
    }
  }
  public class Type_IntersectionType : Type {
    public readonly RAST._IType _left;
    public readonly RAST._IType _right;
    public Type_IntersectionType(RAST._IType left, RAST._IType right) : base() {
      this._left = left;
      this._right = right;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_IntersectionType(_left, _right);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Type_IntersectionType;
      return oth != null && object.Equals(this._left, oth._left) && object.Equals(this._right, oth._right);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 21;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._left));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._right));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Type.IntersectionType";
      s += "(";
      s += Dafny.Helpers.ToString(this._left);
      s += ", ";
      s += Dafny.Helpers.ToString(this._right);
      s += ")";
      return s;
    }
  }

  public interface _ITrait {
    bool is_Trait { get; }
    Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams { get; }
    RAST._IType dtor_tpe { get; }
    Dafny.ISequence<Dafny.Rune> dtor_where { get; }
    Dafny.ISequence<RAST._IImplMember> dtor_body { get; }
    _ITrait DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class Trait : _ITrait {
    public readonly Dafny.ISequence<RAST._ITypeParamDecl> _typeParams;
    public readonly RAST._IType _tpe;
    public readonly Dafny.ISequence<Dafny.Rune> _where;
    public readonly Dafny.ISequence<RAST._IImplMember> _body;
    public Trait(Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IType tpe, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body) {
      this._typeParams = typeParams;
      this._tpe = tpe;
      this._where = @where;
      this._body = body;
    }
    public _ITrait DowncastClone() {
      if (this is _ITrait dt) { return dt; }
      return new Trait(_typeParams, _tpe, _where, _body);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Trait;
      return oth != null && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._tpe, oth._tpe) && object.Equals(this._where, oth._where) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tpe));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._where));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Trait.Trait";
      s += "(";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._tpe);
      s += ", ";
      s += this._where.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
    private static readonly RAST._ITrait theDefault = create(Dafny.Sequence<RAST._ITypeParamDecl>.Empty, RAST.Type.Default(), Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._IImplMember>.Empty);
    public static RAST._ITrait Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._ITrait> _TYPE = new Dafny.TypeDescriptor<RAST._ITrait>(RAST.Trait.Default());
    public static Dafny.TypeDescriptor<RAST._ITrait> _TypeDescriptor() {
      return _TYPE;
    }
    public static _ITrait create(Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IType tpe, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body) {
      return new Trait(typeParams, tpe, @where, body);
    }
    public static _ITrait create_Trait(Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IType tpe, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body) {
      return create(typeParams, tpe, @where, body);
    }
    public bool is_Trait { get { return true; } }
    public Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams {
      get {
        return this._typeParams;
      }
    }
    public RAST._IType dtor_tpe {
      get {
        return this._tpe;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_where {
      get {
        return this._where;
      }
    }
    public Dafny.ISequence<RAST._IImplMember> dtor_body {
      get {
        return this._body;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub trait "), RAST.TypeParamDecl.ToStringMultiple((this).dtor_typeParams, ind)), ((this).dtor_tpe)._ToString(ind)), ((!((this).dtor_where).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind), RAST.__default.IND), (this).dtor_where)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {")), RAST.__default.SeqToString<RAST._IImplMember>((this).dtor_body, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IImplMember, Dafny.ISequence<Dafny.Rune>>>>((_1046_ind) => ((System.Func<RAST._IImplMember, Dafny.ISequence<Dafny.Rune>>)((_1047_member) => {
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), _1046_ind), RAST.__default.IND), (_1047_member)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1046_ind, RAST.__default.IND)));
      })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), (((new BigInteger(((this).dtor_body).Count)).Sign == 0) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind)))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
    }
  }

  public interface _IImpl {
    bool is_ImplFor { get; }
    bool is_Impl { get; }
    Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams { get; }
    RAST._IType dtor_tpe { get; }
    RAST._IType dtor_forType { get; }
    Dafny.ISequence<Dafny.Rune> dtor_where { get; }
    Dafny.ISequence<RAST._IImplMember> dtor_body { get; }
    _IImpl DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public abstract class Impl : _IImpl {
    public Impl() {
    }
    private static readonly RAST._IImpl theDefault = create_ImplFor(Dafny.Sequence<RAST._ITypeParamDecl>.Empty, RAST.Type.Default(), RAST.Type.Default(), Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._IImplMember>.Empty);
    public static RAST._IImpl Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IImpl> _TYPE = new Dafny.TypeDescriptor<RAST._IImpl>(RAST.Impl.Default());
    public static Dafny.TypeDescriptor<RAST._IImpl> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IImpl create_ImplFor(Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IType tpe, RAST._IType forType, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body) {
      return new Impl_ImplFor(typeParams, tpe, forType, @where, body);
    }
    public static _IImpl create_Impl(Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IType tpe, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body) {
      return new Impl_Impl(typeParams, tpe, @where, body);
    }
    public bool is_ImplFor { get { return this is Impl_ImplFor; } }
    public bool is_Impl { get { return this is Impl_Impl; } }
    public Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams {
      get {
        var d = this;
        if (d is Impl_ImplFor) { return ((Impl_ImplFor)d)._typeParams; }
        return ((Impl_Impl)d)._typeParams;
      }
    }
    public RAST._IType dtor_tpe {
      get {
        var d = this;
        if (d is Impl_ImplFor) { return ((Impl_ImplFor)d)._tpe; }
        return ((Impl_Impl)d)._tpe;
      }
    }
    public RAST._IType dtor_forType {
      get {
        var d = this;
        return ((Impl_ImplFor)d)._forType;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_where {
      get {
        var d = this;
        if (d is Impl_ImplFor) { return ((Impl_ImplFor)d)._where; }
        return ((Impl_Impl)d)._where;
      }
    }
    public Dafny.ISequence<RAST._IImplMember> dtor_body {
      get {
        var d = this;
        if (d is Impl_ImplFor) { return ((Impl_ImplFor)d)._body; }
        return ((Impl_Impl)d)._body;
      }
    }
    public abstract _IImpl DowncastClone();
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl"), RAST.TypeParamDecl.ToStringMultiple((this).dtor_typeParams, ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), ((this).dtor_tpe)._ToString(ind)), (((this).is_ImplFor) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind), RAST.__default.IND), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("for ")), ((this).dtor_forType)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), ((!((this).dtor_where).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind), RAST.__default.IND), (this).dtor_where)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {")), RAST.__default.SeqToString<RAST._IImplMember>((this).dtor_body, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IImplMember, Dafny.ISequence<Dafny.Rune>>>>((_1048_ind) => ((System.Func<RAST._IImplMember, Dafny.ISequence<Dafny.Rune>>)((_1049_member) => {
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), _1048_ind), RAST.__default.IND), (_1049_member)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1048_ind, RAST.__default.IND)));
      })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), (((new BigInteger(((this).dtor_body).Count)).Sign == 0) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind)))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
    }
  }
  public class Impl_ImplFor : Impl {
    public readonly Dafny.ISequence<RAST._ITypeParamDecl> _typeParams;
    public readonly RAST._IType _tpe;
    public readonly RAST._IType _forType;
    public readonly Dafny.ISequence<Dafny.Rune> _where;
    public readonly Dafny.ISequence<RAST._IImplMember> _body;
    public Impl_ImplFor(Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IType tpe, RAST._IType forType, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body) : base() {
      this._typeParams = typeParams;
      this._tpe = tpe;
      this._forType = forType;
      this._where = @where;
      this._body = body;
    }
    public override _IImpl DowncastClone() {
      if (this is _IImpl dt) { return dt; }
      return new Impl_ImplFor(_typeParams, _tpe, _forType, _where, _body);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Impl_ImplFor;
      return oth != null && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._tpe, oth._tpe) && object.Equals(this._forType, oth._forType) && object.Equals(this._where, oth._where) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tpe));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._forType));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._where));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Impl.ImplFor";
      s += "(";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._tpe);
      s += ", ";
      s += Dafny.Helpers.ToString(this._forType);
      s += ", ";
      s += this._where.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
  }
  public class Impl_Impl : Impl {
    public readonly Dafny.ISequence<RAST._ITypeParamDecl> _typeParams;
    public readonly RAST._IType _tpe;
    public readonly Dafny.ISequence<Dafny.Rune> _where;
    public readonly Dafny.ISequence<RAST._IImplMember> _body;
    public Impl_Impl(Dafny.ISequence<RAST._ITypeParamDecl> typeParams, RAST._IType tpe, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body) : base() {
      this._typeParams = typeParams;
      this._tpe = tpe;
      this._where = @where;
      this._body = body;
    }
    public override _IImpl DowncastClone() {
      if (this is _IImpl dt) { return dt; }
      return new Impl_Impl(_typeParams, _tpe, _where, _body);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Impl_Impl;
      return oth != null && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._tpe, oth._tpe) && object.Equals(this._where, oth._where) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tpe));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._where));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Impl.Impl";
      s += "(";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._tpe);
      s += ", ";
      s += this._where.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
  }

  public interface _IImplMember {
    bool is_RawImplMember { get; }
    bool is_FnDecl { get; }
    Dafny.ISequence<Dafny.Rune> dtor_content { get; }
    RAST._IVisibility dtor_pub { get; }
    RAST._IFn dtor_fun { get; }
    _IImplMember DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public abstract class ImplMember : _IImplMember {
    public ImplMember() {
    }
    private static readonly RAST._IImplMember theDefault = create_RawImplMember(Dafny.Sequence<Dafny.Rune>.Empty);
    public static RAST._IImplMember Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IImplMember> _TYPE = new Dafny.TypeDescriptor<RAST._IImplMember>(RAST.ImplMember.Default());
    public static Dafny.TypeDescriptor<RAST._IImplMember> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IImplMember create_RawImplMember(Dafny.ISequence<Dafny.Rune> content) {
      return new ImplMember_RawImplMember(content);
    }
    public static _IImplMember create_FnDecl(RAST._IVisibility pub, RAST._IFn fun) {
      return new ImplMember_FnDecl(pub, fun);
    }
    public bool is_RawImplMember { get { return this is ImplMember_RawImplMember; } }
    public bool is_FnDecl { get { return this is ImplMember_FnDecl; } }
    public Dafny.ISequence<Dafny.Rune> dtor_content {
      get {
        var d = this;
        return ((ImplMember_RawImplMember)d)._content;
      }
    }
    public RAST._IVisibility dtor_pub {
      get {
        var d = this;
        return ((ImplMember_FnDecl)d)._pub;
      }
    }
    public RAST._IFn dtor_fun {
      get {
        var d = this;
        return ((ImplMember_FnDecl)d)._fun;
      }
    }
    public abstract _IImplMember DowncastClone();
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      if ((this).is_FnDecl) {
        return Dafny.Sequence<Dafny.Rune>.Concat(((this).dtor_pub)._ToString(), ((this).dtor_fun)._ToString(ind));
      } else {
        return (this).dtor_content;
      }
    }
  }
  public class ImplMember_RawImplMember : ImplMember {
    public readonly Dafny.ISequence<Dafny.Rune> _content;
    public ImplMember_RawImplMember(Dafny.ISequence<Dafny.Rune> content) : base() {
      this._content = content;
    }
    public override _IImplMember DowncastClone() {
      if (this is _IImplMember dt) { return dt; }
      return new ImplMember_RawImplMember(_content);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.ImplMember_RawImplMember;
      return oth != null && object.Equals(this._content, oth._content);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._content));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.ImplMember.RawImplMember";
      s += "(";
      s += this._content.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class ImplMember_FnDecl : ImplMember {
    public readonly RAST._IVisibility _pub;
    public readonly RAST._IFn _fun;
    public ImplMember_FnDecl(RAST._IVisibility pub, RAST._IFn fun) : base() {
      this._pub = pub;
      this._fun = fun;
    }
    public override _IImplMember DowncastClone() {
      if (this is _IImplMember dt) { return dt; }
      return new ImplMember_FnDecl(_pub, _fun);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.ImplMember_FnDecl;
      return oth != null && object.Equals(this._pub, oth._pub) && object.Equals(this._fun, oth._fun);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._pub));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._fun));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.ImplMember.FnDecl";
      s += "(";
      s += Dafny.Helpers.ToString(this._pub);
      s += ", ";
      s += Dafny.Helpers.ToString(this._fun);
      s += ")";
      return s;
    }
  }

  public interface _IVisibility {
    bool is_PUB { get; }
    bool is_PRIV { get; }
    _IVisibility DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString();
  }
  public abstract class Visibility : _IVisibility {
    public Visibility() {
    }
    private static readonly RAST._IVisibility theDefault = create_PUB();
    public static RAST._IVisibility Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IVisibility> _TYPE = new Dafny.TypeDescriptor<RAST._IVisibility>(RAST.Visibility.Default());
    public static Dafny.TypeDescriptor<RAST._IVisibility> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IVisibility create_PUB() {
      return new Visibility_PUB();
    }
    public static _IVisibility create_PRIV() {
      return new Visibility_PRIV();
    }
    public bool is_PUB { get { return this is Visibility_PUB; } }
    public bool is_PRIV { get { return this is Visibility_PRIV; } }
    public static System.Collections.Generic.IEnumerable<_IVisibility> AllSingletonConstructors {
      get {
        yield return Visibility.create_PUB();
        yield return Visibility.create_PRIV();
      }
    }
    public abstract _IVisibility DowncastClone();
    public Dafny.ISequence<Dafny.Rune> _ToString() {
      if ((this).is_PUB) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub ");
      } else {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      }
    }
  }
  public class Visibility_PUB : Visibility {
    public Visibility_PUB() : base() {
    }
    public override _IVisibility DowncastClone() {
      if (this is _IVisibility dt) { return dt; }
      return new Visibility_PUB();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Visibility_PUB;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Visibility.PUB";
      return s;
    }
  }
  public class Visibility_PRIV : Visibility {
    public Visibility_PRIV() : base() {
    }
    public override _IVisibility DowncastClone() {
      if (this is _IVisibility dt) { return dt; }
      return new Visibility_PRIV();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Visibility_PRIV;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Visibility.PRIV";
      return s;
    }
  }

  public interface _IFormal {
    bool is_Formal { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    RAST._IType dtor_tpe { get; }
    _IFormal DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class Formal : _IFormal {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly RAST._IType _tpe;
    public Formal(Dafny.ISequence<Dafny.Rune> name, RAST._IType tpe) {
      this._name = name;
      this._tpe = tpe;
    }
    public _IFormal DowncastClone() {
      if (this is _IFormal dt) { return dt; }
      return new Formal(_name, _tpe);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Formal;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._tpe, oth._tpe);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tpe));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Formal.Formal";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._tpe);
      s += ")";
      return s;
    }
    private static readonly RAST._IFormal theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, RAST.Type.Default());
    public static RAST._IFormal Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IFormal> _TYPE = new Dafny.TypeDescriptor<RAST._IFormal>(RAST.Formal.Default());
    public static Dafny.TypeDescriptor<RAST._IFormal> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IFormal create(Dafny.ISequence<Dafny.Rune> name, RAST._IType tpe) {
      return new Formal(name, tpe);
    }
    public static _IFormal create_Formal(Dafny.ISequence<Dafny.Rune> name, RAST._IType tpe) {
      return create(name, tpe);
    }
    public bool is_Formal { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public RAST._IType dtor_tpe {
      get {
        return this._tpe;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      if ((((this).dtor_name).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) && (object.Equals((this).dtor_tpe, RAST.Type.create_SelfOwned()))) {
        return (this).dtor_name;
      } else if ((((this).dtor_name).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) && (object.Equals((this).dtor_tpe, RAST.__default.SelfBorrowed))) {
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), (this).dtor_name);
      } else if ((((this).dtor_name).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) && (object.Equals((this).dtor_tpe, RAST.__default.SelfBorrowedMut))) {
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&mut "), (this).dtor_name);
      } else {
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((this).dtor_name, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((this).dtor_tpe)._ToString(ind));
      }
    }
    public static RAST._IFormal selfBorrowed { get {
      return RAST.Formal.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"), RAST.__default.SelfBorrowed);
    } }
    public static RAST._IFormal selfOwned { get {
      return RAST.Formal.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"), RAST.Type.create_SelfOwned());
    } }
    public static RAST._IFormal selfBorrowedMut { get {
      return RAST.Formal.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"), RAST.__default.SelfBorrowedMut);
    } }
  }

  public interface _IPattern {
    bool is_RawPattern { get; }
    Dafny.ISequence<Dafny.Rune> dtor_content { get; }
  }
  public class Pattern : _IPattern {
    public readonly Dafny.ISequence<Dafny.Rune> _content;
    public Pattern(Dafny.ISequence<Dafny.Rune> content) {
      this._content = content;
    }
    public static Dafny.ISequence<Dafny.Rune> DowncastClone(Dafny.ISequence<Dafny.Rune> _this) {
      return _this;
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Pattern;
      return oth != null && object.Equals(this._content, oth._content);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._content));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Pattern.RawPattern";
      s += "(";
      s += this._content.ToVerbatimString(true);
      s += ")";
      return s;
    }
    private static readonly Dafny.ISequence<Dafny.Rune> theDefault = Dafny.Sequence<Dafny.Rune>.Empty;
    public static Dafny.ISequence<Dafny.Rune> Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TYPE = new Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>>(Dafny.Sequence<Dafny.Rune>.Empty);
    public static Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IPattern create(Dafny.ISequence<Dafny.Rune> content) {
      return new Pattern(content);
    }
    public static _IPattern create_RawPattern(Dafny.ISequence<Dafny.Rune> content) {
      return create(content);
    }
    public bool is_RawPattern { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_content {
      get {
        return this._content;
      }
    }
    public static Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> _this, Dafny.ISequence<Dafny.Rune> ind) {
      return (_this);
    }
  }

  public interface _IMatchCase {
    bool is_MatchCase { get; }
    Dafny.ISequence<Dafny.Rune> dtor_pattern { get; }
    RAST._IExpr dtor_rhs { get; }
    _IMatchCase DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class MatchCase : _IMatchCase {
    public readonly Dafny.ISequence<Dafny.Rune> _pattern;
    public readonly RAST._IExpr _rhs;
    public MatchCase(Dafny.ISequence<Dafny.Rune> pattern, RAST._IExpr rhs) {
      this._pattern = pattern;
      this._rhs = rhs;
    }
    public _IMatchCase DowncastClone() {
      if (this is _IMatchCase dt) { return dt; }
      return new MatchCase(_pattern, _rhs);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.MatchCase;
      return oth != null && object.Equals(this._pattern, oth._pattern) && object.Equals(this._rhs, oth._rhs);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._pattern));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._rhs));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.MatchCase.MatchCase";
      s += "(";
      s += Dafny.Helpers.ToString(this._pattern);
      s += ", ";
      s += Dafny.Helpers.ToString(this._rhs);
      s += ")";
      return s;
    }
    private static readonly RAST._IMatchCase theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, RAST.Expr.Default());
    public static RAST._IMatchCase Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IMatchCase> _TYPE = new Dafny.TypeDescriptor<RAST._IMatchCase>(RAST.MatchCase.Default());
    public static Dafny.TypeDescriptor<RAST._IMatchCase> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IMatchCase create(Dafny.ISequence<Dafny.Rune> pattern, RAST._IExpr rhs) {
      return new MatchCase(pattern, rhs);
    }
    public static _IMatchCase create_MatchCase(Dafny.ISequence<Dafny.Rune> pattern, RAST._IExpr rhs) {
      return create(pattern, rhs);
    }
    public bool is_MatchCase { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_pattern {
      get {
        return this._pattern;
      }
    }
    public RAST._IExpr dtor_rhs {
      get {
        return this._rhs;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      Dafny.ISequence<Dafny.Rune> _1050_newIndent = ((((this).dtor_rhs).is_Block) ? (ind) : (Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)));
      Dafny.ISequence<Dafny.Rune> _1051_rhsString = ((this).dtor_rhs)._ToString(_1050_newIndent);
      return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(RAST.Pattern._ToString((this).dtor_pattern, ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" =>")), ((((_1051_rhsString).Contains(new Dafny.Rune('\n'))) && (((_1051_rhsString).Select(BigInteger.Zero)) != (new Dafny.Rune('{')))) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind), RAST.__default.IND), _1051_rhsString)) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "), _1051_rhsString))));
    }
  }

  public interface _IAssignIdentifier {
    bool is_AssignIdentifier { get; }
    Dafny.ISequence<Dafny.Rune> dtor_identifier { get; }
    RAST._IExpr dtor_rhs { get; }
    _IAssignIdentifier DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class AssignIdentifier : _IAssignIdentifier {
    public readonly Dafny.ISequence<Dafny.Rune> _identifier;
    public readonly RAST._IExpr _rhs;
    public AssignIdentifier(Dafny.ISequence<Dafny.Rune> identifier, RAST._IExpr rhs) {
      this._identifier = identifier;
      this._rhs = rhs;
    }
    public _IAssignIdentifier DowncastClone() {
      if (this is _IAssignIdentifier dt) { return dt; }
      return new AssignIdentifier(_identifier, _rhs);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.AssignIdentifier;
      return oth != null && object.Equals(this._identifier, oth._identifier) && object.Equals(this._rhs, oth._rhs);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._identifier));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._rhs));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.AssignIdentifier.AssignIdentifier";
      s += "(";
      s += this._identifier.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._rhs);
      s += ")";
      return s;
    }
    private static readonly RAST._IAssignIdentifier theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, RAST.Expr.Default());
    public static RAST._IAssignIdentifier Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IAssignIdentifier> _TYPE = new Dafny.TypeDescriptor<RAST._IAssignIdentifier>(RAST.AssignIdentifier.Default());
    public static Dafny.TypeDescriptor<RAST._IAssignIdentifier> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IAssignIdentifier create(Dafny.ISequence<Dafny.Rune> identifier, RAST._IExpr rhs) {
      return new AssignIdentifier(identifier, rhs);
    }
    public static _IAssignIdentifier create_AssignIdentifier(Dafny.ISequence<Dafny.Rune> identifier, RAST._IExpr rhs) {
      return create(identifier, rhs);
    }
    public bool is_AssignIdentifier { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_identifier {
      get {
        return this._identifier;
      }
    }
    public RAST._IExpr dtor_rhs {
      get {
        return this._rhs;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((this).dtor_identifier, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((this).dtor_rhs)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)));
    }
  }

  public interface _IDeclareType {
    bool is_MUT { get; }
    bool is_CONST { get; }
    _IDeclareType DowncastClone();
  }
  public abstract class DeclareType : _IDeclareType {
    public DeclareType() {
    }
    private static readonly RAST._IDeclareType theDefault = create_MUT();
    public static RAST._IDeclareType Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IDeclareType> _TYPE = new Dafny.TypeDescriptor<RAST._IDeclareType>(RAST.DeclareType.Default());
    public static Dafny.TypeDescriptor<RAST._IDeclareType> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IDeclareType create_MUT() {
      return new DeclareType_MUT();
    }
    public static _IDeclareType create_CONST() {
      return new DeclareType_CONST();
    }
    public bool is_MUT { get { return this is DeclareType_MUT; } }
    public bool is_CONST { get { return this is DeclareType_CONST; } }
    public static System.Collections.Generic.IEnumerable<_IDeclareType> AllSingletonConstructors {
      get {
        yield return DeclareType.create_MUT();
        yield return DeclareType.create_CONST();
      }
    }
    public abstract _IDeclareType DowncastClone();
  }
  public class DeclareType_MUT : DeclareType {
    public DeclareType_MUT() : base() {
    }
    public override _IDeclareType DowncastClone() {
      if (this is _IDeclareType dt) { return dt; }
      return new DeclareType_MUT();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.DeclareType_MUT;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.DeclareType.MUT";
      return s;
    }
  }
  public class DeclareType_CONST : DeclareType {
    public DeclareType_CONST() : base() {
    }
    public override _IDeclareType DowncastClone() {
      if (this is _IDeclareType dt) { return dt; }
      return new DeclareType_CONST();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.DeclareType_CONST;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.DeclareType.CONST";
      return s;
    }
  }

  public interface _IAssociativity {
    bool is_LeftToRight { get; }
    bool is_RightToLeft { get; }
    bool is_RequiresParentheses { get; }
    _IAssociativity DowncastClone();
  }
  public abstract class Associativity : _IAssociativity {
    public Associativity() {
    }
    private static readonly RAST._IAssociativity theDefault = create_LeftToRight();
    public static RAST._IAssociativity Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IAssociativity> _TYPE = new Dafny.TypeDescriptor<RAST._IAssociativity>(RAST.Associativity.Default());
    public static Dafny.TypeDescriptor<RAST._IAssociativity> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IAssociativity create_LeftToRight() {
      return new Associativity_LeftToRight();
    }
    public static _IAssociativity create_RightToLeft() {
      return new Associativity_RightToLeft();
    }
    public static _IAssociativity create_RequiresParentheses() {
      return new Associativity_RequiresParentheses();
    }
    public bool is_LeftToRight { get { return this is Associativity_LeftToRight; } }
    public bool is_RightToLeft { get { return this is Associativity_RightToLeft; } }
    public bool is_RequiresParentheses { get { return this is Associativity_RequiresParentheses; } }
    public static System.Collections.Generic.IEnumerable<_IAssociativity> AllSingletonConstructors {
      get {
        yield return Associativity.create_LeftToRight();
        yield return Associativity.create_RightToLeft();
        yield return Associativity.create_RequiresParentheses();
      }
    }
    public abstract _IAssociativity DowncastClone();
  }
  public class Associativity_LeftToRight : Associativity {
    public Associativity_LeftToRight() : base() {
    }
    public override _IAssociativity DowncastClone() {
      if (this is _IAssociativity dt) { return dt; }
      return new Associativity_LeftToRight();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Associativity_LeftToRight;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Associativity.LeftToRight";
      return s;
    }
  }
  public class Associativity_RightToLeft : Associativity {
    public Associativity_RightToLeft() : base() {
    }
    public override _IAssociativity DowncastClone() {
      if (this is _IAssociativity dt) { return dt; }
      return new Associativity_RightToLeft();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Associativity_RightToLeft;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Associativity.RightToLeft";
      return s;
    }
  }
  public class Associativity_RequiresParentheses : Associativity {
    public Associativity_RequiresParentheses() : base() {
    }
    public override _IAssociativity DowncastClone() {
      if (this is _IAssociativity dt) { return dt; }
      return new Associativity_RequiresParentheses();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Associativity_RequiresParentheses;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Associativity.RequiresParentheses";
      return s;
    }
  }

  public interface _IPrintingInfo {
    bool is_UnknownPrecedence { get; }
    bool is_Precedence { get; }
    bool is_SuffixPrecedence { get; }
    bool is_PrecedenceAssociativity { get; }
    BigInteger dtor_precedence { get; }
    RAST._IAssociativity dtor_associativity { get; }
    _IPrintingInfo DowncastClone();
    bool NeedParenthesesFor(RAST._IPrintingInfo underlying);
    bool NeedParenthesesForLeft(RAST._IPrintingInfo underlying);
    bool NeedParenthesesForRight(RAST._IPrintingInfo underlying);
  }
  public abstract class PrintingInfo : _IPrintingInfo {
    public PrintingInfo() {
    }
    private static readonly RAST._IPrintingInfo theDefault = create_UnknownPrecedence();
    public static RAST._IPrintingInfo Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IPrintingInfo> _TYPE = new Dafny.TypeDescriptor<RAST._IPrintingInfo>(RAST.PrintingInfo.Default());
    public static Dafny.TypeDescriptor<RAST._IPrintingInfo> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IPrintingInfo create_UnknownPrecedence() {
      return new PrintingInfo_UnknownPrecedence();
    }
    public static _IPrintingInfo create_Precedence(BigInteger precedence) {
      return new PrintingInfo_Precedence(precedence);
    }
    public static _IPrintingInfo create_SuffixPrecedence(BigInteger precedence) {
      return new PrintingInfo_SuffixPrecedence(precedence);
    }
    public static _IPrintingInfo create_PrecedenceAssociativity(BigInteger precedence, RAST._IAssociativity associativity) {
      return new PrintingInfo_PrecedenceAssociativity(precedence, associativity);
    }
    public bool is_UnknownPrecedence { get { return this is PrintingInfo_UnknownPrecedence; } }
    public bool is_Precedence { get { return this is PrintingInfo_Precedence; } }
    public bool is_SuffixPrecedence { get { return this is PrintingInfo_SuffixPrecedence; } }
    public bool is_PrecedenceAssociativity { get { return this is PrintingInfo_PrecedenceAssociativity; } }
    public BigInteger dtor_precedence {
      get {
        var d = this;
        if (d is PrintingInfo_Precedence) { return ((PrintingInfo_Precedence)d)._precedence; }
        if (d is PrintingInfo_SuffixPrecedence) { return ((PrintingInfo_SuffixPrecedence)d)._precedence; }
        return ((PrintingInfo_PrecedenceAssociativity)d)._precedence;
      }
    }
    public RAST._IAssociativity dtor_associativity {
      get {
        var d = this;
        return ((PrintingInfo_PrecedenceAssociativity)d)._associativity;
      }
    }
    public abstract _IPrintingInfo DowncastClone();
    public bool NeedParenthesesFor(RAST._IPrintingInfo underlying) {
      if ((this).is_UnknownPrecedence) {
        return true;
      } else if ((underlying).is_UnknownPrecedence) {
        return true;
      } else if (((this).dtor_precedence) <= ((underlying).dtor_precedence)) {
        return true;
      } else {
        return false;
      }
    }
    public bool NeedParenthesesForLeft(RAST._IPrintingInfo underlying) {
      if ((this).is_UnknownPrecedence) {
        return true;
      } else if ((underlying).is_UnknownPrecedence) {
        return true;
      } else if (((this).dtor_precedence) <= ((underlying).dtor_precedence)) {
        return ((((this).dtor_precedence) < ((underlying).dtor_precedence)) || (!((this).is_PrecedenceAssociativity))) || (!(((this).dtor_associativity).is_LeftToRight));
      } else {
        return false;
      }
    }
    public bool NeedParenthesesForRight(RAST._IPrintingInfo underlying) {
      if ((this).is_UnknownPrecedence) {
        return true;
      } else if ((underlying).is_UnknownPrecedence) {
        return true;
      } else if (((this).dtor_precedence) <= ((underlying).dtor_precedence)) {
        return ((((this).dtor_precedence) < ((underlying).dtor_precedence)) || (!((this).is_PrecedenceAssociativity))) || (!(((this).dtor_associativity).is_RightToLeft));
      } else {
        return false;
      }
    }
  }
  public class PrintingInfo_UnknownPrecedence : PrintingInfo {
    public PrintingInfo_UnknownPrecedence() : base() {
    }
    public override _IPrintingInfo DowncastClone() {
      if (this is _IPrintingInfo dt) { return dt; }
      return new PrintingInfo_UnknownPrecedence();
    }
    public override bool Equals(object other) {
      var oth = other as RAST.PrintingInfo_UnknownPrecedence;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.PrintingInfo.UnknownPrecedence";
      return s;
    }
  }
  public class PrintingInfo_Precedence : PrintingInfo {
    public readonly BigInteger _precedence;
    public PrintingInfo_Precedence(BigInteger precedence) : base() {
      this._precedence = precedence;
    }
    public override _IPrintingInfo DowncastClone() {
      if (this is _IPrintingInfo dt) { return dt; }
      return new PrintingInfo_Precedence(_precedence);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.PrintingInfo_Precedence;
      return oth != null && this._precedence == oth._precedence;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._precedence));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.PrintingInfo.Precedence";
      s += "(";
      s += Dafny.Helpers.ToString(this._precedence);
      s += ")";
      return s;
    }
  }
  public class PrintingInfo_SuffixPrecedence : PrintingInfo {
    public readonly BigInteger _precedence;
    public PrintingInfo_SuffixPrecedence(BigInteger precedence) : base() {
      this._precedence = precedence;
    }
    public override _IPrintingInfo DowncastClone() {
      if (this is _IPrintingInfo dt) { return dt; }
      return new PrintingInfo_SuffixPrecedence(_precedence);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.PrintingInfo_SuffixPrecedence;
      return oth != null && this._precedence == oth._precedence;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._precedence));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.PrintingInfo.SuffixPrecedence";
      s += "(";
      s += Dafny.Helpers.ToString(this._precedence);
      s += ")";
      return s;
    }
  }
  public class PrintingInfo_PrecedenceAssociativity : PrintingInfo {
    public readonly BigInteger _precedence;
    public readonly RAST._IAssociativity _associativity;
    public PrintingInfo_PrecedenceAssociativity(BigInteger precedence, RAST._IAssociativity associativity) : base() {
      this._precedence = precedence;
      this._associativity = associativity;
    }
    public override _IPrintingInfo DowncastClone() {
      if (this is _IPrintingInfo dt) { return dt; }
      return new PrintingInfo_PrecedenceAssociativity(_precedence, _associativity);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.PrintingInfo_PrecedenceAssociativity;
      return oth != null && this._precedence == oth._precedence && object.Equals(this._associativity, oth._associativity);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._precedence));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._associativity));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.PrintingInfo.PrecedenceAssociativity";
      s += "(";
      s += Dafny.Helpers.ToString(this._precedence);
      s += ", ";
      s += Dafny.Helpers.ToString(this._associativity);
      s += ")";
      return s;
    }
  }

  public interface _IAssignLhs {
    bool is_LocalVar { get; }
    bool is_SelectMember { get; }
    bool is_ExtractTuple { get; }
    bool is_Index { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    RAST._IExpr dtor_on { get; }
    Dafny.ISequence<Dafny.Rune> dtor_field { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_names { get; }
    RAST._IExpr dtor_expr { get; }
    Dafny.ISequence<RAST._IExpr> dtor_indices { get; }
    _IAssignLhs DowncastClone();
  }
  public abstract class AssignLhs : _IAssignLhs {
    public AssignLhs() {
    }
    private static readonly RAST._IAssignLhs theDefault = create_LocalVar(Dafny.Sequence<Dafny.Rune>.Empty);
    public static RAST._IAssignLhs Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IAssignLhs> _TYPE = new Dafny.TypeDescriptor<RAST._IAssignLhs>(RAST.AssignLhs.Default());
    public static Dafny.TypeDescriptor<RAST._IAssignLhs> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IAssignLhs create_LocalVar(Dafny.ISequence<Dafny.Rune> name) {
      return new AssignLhs_LocalVar(name);
    }
    public static _IAssignLhs create_SelectMember(RAST._IExpr @on, Dafny.ISequence<Dafny.Rune> field) {
      return new AssignLhs_SelectMember(@on, field);
    }
    public static _IAssignLhs create_ExtractTuple(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> names) {
      return new AssignLhs_ExtractTuple(names);
    }
    public static _IAssignLhs create_Index(RAST._IExpr expr, Dafny.ISequence<RAST._IExpr> indices) {
      return new AssignLhs_Index(expr, indices);
    }
    public bool is_LocalVar { get { return this is AssignLhs_LocalVar; } }
    public bool is_SelectMember { get { return this is AssignLhs_SelectMember; } }
    public bool is_ExtractTuple { get { return this is AssignLhs_ExtractTuple; } }
    public bool is_Index { get { return this is AssignLhs_Index; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        var d = this;
        return ((AssignLhs_LocalVar)d)._name;
      }
    }
    public RAST._IExpr dtor_on {
      get {
        var d = this;
        return ((AssignLhs_SelectMember)d)._on;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_field {
      get {
        var d = this;
        return ((AssignLhs_SelectMember)d)._field;
      }
    }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_names {
      get {
        var d = this;
        return ((AssignLhs_ExtractTuple)d)._names;
      }
    }
    public RAST._IExpr dtor_expr {
      get {
        var d = this;
        return ((AssignLhs_Index)d)._expr;
      }
    }
    public Dafny.ISequence<RAST._IExpr> dtor_indices {
      get {
        var d = this;
        return ((AssignLhs_Index)d)._indices;
      }
    }
    public abstract _IAssignLhs DowncastClone();
  }
  public class AssignLhs_LocalVar : AssignLhs {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public AssignLhs_LocalVar(Dafny.ISequence<Dafny.Rune> name) : base() {
      this._name = name;
    }
    public override _IAssignLhs DowncastClone() {
      if (this is _IAssignLhs dt) { return dt; }
      return new AssignLhs_LocalVar(_name);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.AssignLhs_LocalVar;
      return oth != null && object.Equals(this._name, oth._name);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.AssignLhs.LocalVar";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class AssignLhs_SelectMember : AssignLhs {
    public readonly RAST._IExpr _on;
    public readonly Dafny.ISequence<Dafny.Rune> _field;
    public AssignLhs_SelectMember(RAST._IExpr @on, Dafny.ISequence<Dafny.Rune> field) : base() {
      this._on = @on;
      this._field = field;
    }
    public override _IAssignLhs DowncastClone() {
      if (this is _IAssignLhs dt) { return dt; }
      return new AssignLhs_SelectMember(_on, _field);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.AssignLhs_SelectMember;
      return oth != null && object.Equals(this._on, oth._on) && object.Equals(this._field, oth._field);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._on));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._field));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.AssignLhs.SelectMember";
      s += "(";
      s += Dafny.Helpers.ToString(this._on);
      s += ", ";
      s += this._field.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class AssignLhs_ExtractTuple : AssignLhs {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _names;
    public AssignLhs_ExtractTuple(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> names) : base() {
      this._names = names;
    }
    public override _IAssignLhs DowncastClone() {
      if (this is _IAssignLhs dt) { return dt; }
      return new AssignLhs_ExtractTuple(_names);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.AssignLhs_ExtractTuple;
      return oth != null && object.Equals(this._names, oth._names);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._names));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.AssignLhs.ExtractTuple";
      s += "(";
      s += Dafny.Helpers.ToString(this._names);
      s += ")";
      return s;
    }
  }
  public class AssignLhs_Index : AssignLhs {
    public readonly RAST._IExpr _expr;
    public readonly Dafny.ISequence<RAST._IExpr> _indices;
    public AssignLhs_Index(RAST._IExpr expr, Dafny.ISequence<RAST._IExpr> indices) : base() {
      this._expr = expr;
      this._indices = indices;
    }
    public override _IAssignLhs DowncastClone() {
      if (this is _IAssignLhs dt) { return dt; }
      return new AssignLhs_Index(_expr, _indices);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.AssignLhs_Index;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._indices, oth._indices);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._indices));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.AssignLhs.Index";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += Dafny.Helpers.ToString(this._indices);
      s += ")";
      return s;
    }
  }

  public interface _IExpr {
    bool is_RawExpr { get; }
    bool is_ExprFromType { get; }
    bool is_Identifier { get; }
    bool is_Match { get; }
    bool is_StmtExpr { get; }
    bool is_Block { get; }
    bool is_StructBuild { get; }
    bool is_Tuple { get; }
    bool is_UnaryOp { get; }
    bool is_BinaryOp { get; }
    bool is_TypeAscription { get; }
    bool is_LiteralInt { get; }
    bool is_LiteralBool { get; }
    bool is_LiteralString { get; }
    bool is_DeclareVar { get; }
    bool is_Assign { get; }
    bool is_IfExpr { get; }
    bool is_Loop { get; }
    bool is_For { get; }
    bool is_Labelled { get; }
    bool is_Break { get; }
    bool is_Continue { get; }
    bool is_Return { get; }
    bool is_CallType { get; }
    bool is_Call { get; }
    bool is_Select { get; }
    bool is_MemberSelect { get; }
    bool is_Lambda { get; }
    Dafny.ISequence<Dafny.Rune> dtor_content { get; }
    RAST._IType dtor_tpe { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    RAST._IExpr dtor_matchee { get; }
    Dafny.ISequence<RAST._IMatchCase> dtor_cases { get; }
    RAST._IExpr dtor_stmt { get; }
    RAST._IExpr dtor_rhs { get; }
    RAST._IExpr dtor_underlying { get; }
    Dafny.ISequence<RAST._IAssignIdentifier> dtor_assignments { get; }
    Dafny.ISequence<RAST._IExpr> dtor_arguments { get; }
    Dafny.ISequence<Dafny.Rune> dtor_op1 { get; }
    DAST.Format._IUnaryOpFormat dtor_format { get; }
    Dafny.ISequence<Dafny.Rune> dtor_op2 { get; }
    RAST._IExpr dtor_left { get; }
    RAST._IExpr dtor_right { get; }
    DAST.Format._IBinaryOpFormat dtor_format2 { get; }
    Dafny.ISequence<Dafny.Rune> dtor_value { get; }
    bool dtor_bvalue { get; }
    bool dtor_binary { get; }
    RAST._IDeclareType dtor_declareType { get; }
    Std.Wrappers._IOption<RAST._IType> dtor_optType { get; }
    Std.Wrappers._IOption<RAST._IExpr> dtor_optRhs { get; }
    Std.Wrappers._IOption<RAST._IAssignLhs> dtor_names { get; }
    RAST._IExpr dtor_cond { get; }
    RAST._IExpr dtor_thn { get; }
    RAST._IExpr dtor_els { get; }
    Std.Wrappers._IOption<RAST._IExpr> dtor_optCond { get; }
    RAST._IExpr dtor_range { get; }
    RAST._IExpr dtor_body { get; }
    Dafny.ISequence<Dafny.Rune> dtor_lbl { get; }
    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> dtor_optLbl { get; }
    Std.Wrappers._IOption<RAST._IExpr> dtor_optExpr { get; }
    RAST._IExpr dtor_obj { get; }
    Dafny.ISequence<RAST._IType> dtor_typeParameters { get; }
    Dafny.ISequence<RAST._IFormal> dtor_params { get; }
    Std.Wrappers._IOption<RAST._IType> dtor_retType { get; }
    _IExpr DowncastClone();
    bool NoExtraSemicolonAfter();
    RAST._IPrintingInfo printingInfo { get; }
    RAST._IExpr Optimize();
    bool LeftRequiresParentheses(RAST._IExpr left);
    _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> LeftParentheses(RAST._IExpr left);
    bool RightRequiresParentheses(RAST._IExpr right);
    _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> RightParentheses(RAST._IExpr right);
    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> RightMostIdentifier();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    RAST._IExpr Then(RAST._IExpr rhs2);
    RAST._IExpr Sel(Dafny.ISequence<Dafny.Rune> name);
    RAST._IExpr MSel(Dafny.ISequence<Dafny.Rune> name);
    RAST._IExpr ApplyType(Dafny.ISequence<RAST._IType> typeParameters);
    RAST._IExpr ApplyType1(RAST._IType typeParameter);
    RAST._IExpr Apply(Dafny.ISequence<RAST._IExpr> arguments);
    RAST._IExpr Apply1(RAST._IExpr argument);
    bool IsLhsIdentifier();
    Dafny.ISequence<Dafny.Rune> LhsIdentifierName();
  }
  public abstract class Expr : _IExpr {
    public Expr() {
    }
    private static readonly RAST._IExpr theDefault = create_RawExpr(Dafny.Sequence<Dafny.Rune>.Empty);
    public static RAST._IExpr Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IExpr> _TYPE = new Dafny.TypeDescriptor<RAST._IExpr>(RAST.Expr.Default());
    public static Dafny.TypeDescriptor<RAST._IExpr> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IExpr create_RawExpr(Dafny.ISequence<Dafny.Rune> content) {
      return new Expr_RawExpr(content);
    }
    public static _IExpr create_ExprFromType(RAST._IType tpe) {
      return new Expr_ExprFromType(tpe);
    }
    public static _IExpr create_Identifier(Dafny.ISequence<Dafny.Rune> name) {
      return new Expr_Identifier(name);
    }
    public static _IExpr create_Match(RAST._IExpr matchee, Dafny.ISequence<RAST._IMatchCase> cases) {
      return new Expr_Match(matchee, cases);
    }
    public static _IExpr create_StmtExpr(RAST._IExpr stmt, RAST._IExpr rhs) {
      return new Expr_StmtExpr(stmt, rhs);
    }
    public static _IExpr create_Block(RAST._IExpr underlying) {
      return new Expr_Block(underlying);
    }
    public static _IExpr create_StructBuild(RAST._IExpr underlying, Dafny.ISequence<RAST._IAssignIdentifier> assignments) {
      return new Expr_StructBuild(underlying, assignments);
    }
    public static _IExpr create_Tuple(Dafny.ISequence<RAST._IExpr> arguments) {
      return new Expr_Tuple(arguments);
    }
    public static _IExpr create_UnaryOp(Dafny.ISequence<Dafny.Rune> op1, RAST._IExpr underlying, DAST.Format._IUnaryOpFormat format) {
      return new Expr_UnaryOp(op1, underlying, format);
    }
    public static _IExpr create_BinaryOp(Dafny.ISequence<Dafny.Rune> op2, RAST._IExpr left, RAST._IExpr right, DAST.Format._IBinaryOpFormat format2) {
      return new Expr_BinaryOp(op2, left, right, format2);
    }
    public static _IExpr create_TypeAscription(RAST._IExpr left, RAST._IType tpe) {
      return new Expr_TypeAscription(left, tpe);
    }
    public static _IExpr create_LiteralInt(Dafny.ISequence<Dafny.Rune> @value) {
      return new Expr_LiteralInt(@value);
    }
    public static _IExpr create_LiteralBool(bool bvalue) {
      return new Expr_LiteralBool(bvalue);
    }
    public static _IExpr create_LiteralString(Dafny.ISequence<Dafny.Rune> @value, bool binary) {
      return new Expr_LiteralString(@value, binary);
    }
    public static _IExpr create_DeclareVar(RAST._IDeclareType declareType, Dafny.ISequence<Dafny.Rune> name, Std.Wrappers._IOption<RAST._IType> optType, Std.Wrappers._IOption<RAST._IExpr> optRhs) {
      return new Expr_DeclareVar(declareType, name, optType, optRhs);
    }
    public static _IExpr create_Assign(Std.Wrappers._IOption<RAST._IAssignLhs> names, RAST._IExpr rhs) {
      return new Expr_Assign(names, rhs);
    }
    public static _IExpr create_IfExpr(RAST._IExpr cond, RAST._IExpr thn, RAST._IExpr els) {
      return new Expr_IfExpr(cond, thn, els);
    }
    public static _IExpr create_Loop(Std.Wrappers._IOption<RAST._IExpr> optCond, RAST._IExpr underlying) {
      return new Expr_Loop(optCond, underlying);
    }
    public static _IExpr create_For(Dafny.ISequence<Dafny.Rune> name, RAST._IExpr range, RAST._IExpr body) {
      return new Expr_For(name, range, body);
    }
    public static _IExpr create_Labelled(Dafny.ISequence<Dafny.Rune> lbl, RAST._IExpr underlying) {
      return new Expr_Labelled(lbl, underlying);
    }
    public static _IExpr create_Break(Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> optLbl) {
      return new Expr_Break(optLbl);
    }
    public static _IExpr create_Continue(Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> optLbl) {
      return new Expr_Continue(optLbl);
    }
    public static _IExpr create_Return(Std.Wrappers._IOption<RAST._IExpr> optExpr) {
      return new Expr_Return(optExpr);
    }
    public static _IExpr create_CallType(RAST._IExpr obj, Dafny.ISequence<RAST._IType> typeParameters) {
      return new Expr_CallType(obj, typeParameters);
    }
    public static _IExpr create_Call(RAST._IExpr obj, Dafny.ISequence<RAST._IExpr> arguments) {
      return new Expr_Call(obj, arguments);
    }
    public static _IExpr create_Select(RAST._IExpr obj, Dafny.ISequence<Dafny.Rune> name) {
      return new Expr_Select(obj, name);
    }
    public static _IExpr create_MemberSelect(RAST._IExpr obj, Dafny.ISequence<Dafny.Rune> name) {
      return new Expr_MemberSelect(obj, name);
    }
    public static _IExpr create_Lambda(Dafny.ISequence<RAST._IFormal> @params, Std.Wrappers._IOption<RAST._IType> retType, RAST._IExpr body) {
      return new Expr_Lambda(@params, retType, body);
    }
    public bool is_RawExpr { get { return this is Expr_RawExpr; } }
    public bool is_ExprFromType { get { return this is Expr_ExprFromType; } }
    public bool is_Identifier { get { return this is Expr_Identifier; } }
    public bool is_Match { get { return this is Expr_Match; } }
    public bool is_StmtExpr { get { return this is Expr_StmtExpr; } }
    public bool is_Block { get { return this is Expr_Block; } }
    public bool is_StructBuild { get { return this is Expr_StructBuild; } }
    public bool is_Tuple { get { return this is Expr_Tuple; } }
    public bool is_UnaryOp { get { return this is Expr_UnaryOp; } }
    public bool is_BinaryOp { get { return this is Expr_BinaryOp; } }
    public bool is_TypeAscription { get { return this is Expr_TypeAscription; } }
    public bool is_LiteralInt { get { return this is Expr_LiteralInt; } }
    public bool is_LiteralBool { get { return this is Expr_LiteralBool; } }
    public bool is_LiteralString { get { return this is Expr_LiteralString; } }
    public bool is_DeclareVar { get { return this is Expr_DeclareVar; } }
    public bool is_Assign { get { return this is Expr_Assign; } }
    public bool is_IfExpr { get { return this is Expr_IfExpr; } }
    public bool is_Loop { get { return this is Expr_Loop; } }
    public bool is_For { get { return this is Expr_For; } }
    public bool is_Labelled { get { return this is Expr_Labelled; } }
    public bool is_Break { get { return this is Expr_Break; } }
    public bool is_Continue { get { return this is Expr_Continue; } }
    public bool is_Return { get { return this is Expr_Return; } }
    public bool is_CallType { get { return this is Expr_CallType; } }
    public bool is_Call { get { return this is Expr_Call; } }
    public bool is_Select { get { return this is Expr_Select; } }
    public bool is_MemberSelect { get { return this is Expr_MemberSelect; } }
    public bool is_Lambda { get { return this is Expr_Lambda; } }
    public Dafny.ISequence<Dafny.Rune> dtor_content {
      get {
        var d = this;
        return ((Expr_RawExpr)d)._content;
      }
    }
    public RAST._IType dtor_tpe {
      get {
        var d = this;
        if (d is Expr_ExprFromType) { return ((Expr_ExprFromType)d)._tpe; }
        return ((Expr_TypeAscription)d)._tpe;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        var d = this;
        if (d is Expr_Identifier) { return ((Expr_Identifier)d)._name; }
        if (d is Expr_DeclareVar) { return ((Expr_DeclareVar)d)._name; }
        if (d is Expr_For) { return ((Expr_For)d)._name; }
        if (d is Expr_Select) { return ((Expr_Select)d)._name; }
        return ((Expr_MemberSelect)d)._name;
      }
    }
    public RAST._IExpr dtor_matchee {
      get {
        var d = this;
        return ((Expr_Match)d)._matchee;
      }
    }
    public Dafny.ISequence<RAST._IMatchCase> dtor_cases {
      get {
        var d = this;
        return ((Expr_Match)d)._cases;
      }
    }
    public RAST._IExpr dtor_stmt {
      get {
        var d = this;
        return ((Expr_StmtExpr)d)._stmt;
      }
    }
    public RAST._IExpr dtor_rhs {
      get {
        var d = this;
        if (d is Expr_StmtExpr) { return ((Expr_StmtExpr)d)._rhs; }
        return ((Expr_Assign)d)._rhs;
      }
    }
    public RAST._IExpr dtor_underlying {
      get {
        var d = this;
        if (d is Expr_Block) { return ((Expr_Block)d)._underlying; }
        if (d is Expr_StructBuild) { return ((Expr_StructBuild)d)._underlying; }
        if (d is Expr_UnaryOp) { return ((Expr_UnaryOp)d)._underlying; }
        if (d is Expr_Loop) { return ((Expr_Loop)d)._underlying; }
        return ((Expr_Labelled)d)._underlying;
      }
    }
    public Dafny.ISequence<RAST._IAssignIdentifier> dtor_assignments {
      get {
        var d = this;
        return ((Expr_StructBuild)d)._assignments;
      }
    }
    public Dafny.ISequence<RAST._IExpr> dtor_arguments {
      get {
        var d = this;
        if (d is Expr_Tuple) { return ((Expr_Tuple)d)._arguments; }
        return ((Expr_Call)d)._arguments;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_op1 {
      get {
        var d = this;
        return ((Expr_UnaryOp)d)._op1;
      }
    }
    public DAST.Format._IUnaryOpFormat dtor_format {
      get {
        var d = this;
        return ((Expr_UnaryOp)d)._format;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_op2 {
      get {
        var d = this;
        return ((Expr_BinaryOp)d)._op2;
      }
    }
    public RAST._IExpr dtor_left {
      get {
        var d = this;
        if (d is Expr_BinaryOp) { return ((Expr_BinaryOp)d)._left; }
        return ((Expr_TypeAscription)d)._left;
      }
    }
    public RAST._IExpr dtor_right {
      get {
        var d = this;
        return ((Expr_BinaryOp)d)._right;
      }
    }
    public DAST.Format._IBinaryOpFormat dtor_format2 {
      get {
        var d = this;
        return ((Expr_BinaryOp)d)._format2;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_value {
      get {
        var d = this;
        if (d is Expr_LiteralInt) { return ((Expr_LiteralInt)d)._value; }
        return ((Expr_LiteralString)d)._value;
      }
    }
    public bool dtor_bvalue {
      get {
        var d = this;
        return ((Expr_LiteralBool)d)._bvalue;
      }
    }
    public bool dtor_binary {
      get {
        var d = this;
        return ((Expr_LiteralString)d)._binary;
      }
    }
    public RAST._IDeclareType dtor_declareType {
      get {
        var d = this;
        return ((Expr_DeclareVar)d)._declareType;
      }
    }
    public Std.Wrappers._IOption<RAST._IType> dtor_optType {
      get {
        var d = this;
        return ((Expr_DeclareVar)d)._optType;
      }
    }
    public Std.Wrappers._IOption<RAST._IExpr> dtor_optRhs {
      get {
        var d = this;
        return ((Expr_DeclareVar)d)._optRhs;
      }
    }
    public Std.Wrappers._IOption<RAST._IAssignLhs> dtor_names {
      get {
        var d = this;
        return ((Expr_Assign)d)._names;
      }
    }
    public RAST._IExpr dtor_cond {
      get {
        var d = this;
        return ((Expr_IfExpr)d)._cond;
      }
    }
    public RAST._IExpr dtor_thn {
      get {
        var d = this;
        return ((Expr_IfExpr)d)._thn;
      }
    }
    public RAST._IExpr dtor_els {
      get {
        var d = this;
        return ((Expr_IfExpr)d)._els;
      }
    }
    public Std.Wrappers._IOption<RAST._IExpr> dtor_optCond {
      get {
        var d = this;
        return ((Expr_Loop)d)._optCond;
      }
    }
    public RAST._IExpr dtor_range {
      get {
        var d = this;
        return ((Expr_For)d)._range;
      }
    }
    public RAST._IExpr dtor_body {
      get {
        var d = this;
        if (d is Expr_For) { return ((Expr_For)d)._body; }
        return ((Expr_Lambda)d)._body;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_lbl {
      get {
        var d = this;
        return ((Expr_Labelled)d)._lbl;
      }
    }
    public Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> dtor_optLbl {
      get {
        var d = this;
        if (d is Expr_Break) { return ((Expr_Break)d)._optLbl; }
        return ((Expr_Continue)d)._optLbl;
      }
    }
    public Std.Wrappers._IOption<RAST._IExpr> dtor_optExpr {
      get {
        var d = this;
        return ((Expr_Return)d)._optExpr;
      }
    }
    public RAST._IExpr dtor_obj {
      get {
        var d = this;
        if (d is Expr_CallType) { return ((Expr_CallType)d)._obj; }
        if (d is Expr_Call) { return ((Expr_Call)d)._obj; }
        if (d is Expr_Select) { return ((Expr_Select)d)._obj; }
        return ((Expr_MemberSelect)d)._obj;
      }
    }
    public Dafny.ISequence<RAST._IType> dtor_typeParameters {
      get {
        var d = this;
        return ((Expr_CallType)d)._typeParameters;
      }
    }
    public Dafny.ISequence<RAST._IFormal> dtor_params {
      get {
        var d = this;
        return ((Expr_Lambda)d)._params;
      }
    }
    public Std.Wrappers._IOption<RAST._IType> dtor_retType {
      get {
        var d = this;
        return ((Expr_Lambda)d)._retType;
      }
    }
    public abstract _IExpr DowncastClone();
    public bool NoExtraSemicolonAfter() {
      return (((((((this).is_DeclareVar) || ((this).is_Assign)) || ((this).is_Break)) || ((this).is_Continue)) || ((this).is_Return)) || ((this).is_For)) || ((((this).is_RawExpr) && ((new BigInteger(((this).dtor_content).Count)).Sign == 1)) && ((((this).dtor_content).Select((new BigInteger(((this).dtor_content).Count)) - (BigInteger.One))) == (new Dafny.Rune(';'))));
    }
    public RAST._IExpr Optimize() {
      RAST._IExpr _source37 = this;
      if (_source37.is_RawExpr) {
        Dafny.ISequence<Dafny.Rune> _1052___mcc_h0 = _source37.dtor_content;
        return this;
      } else if (_source37.is_ExprFromType) {
        RAST._IType _1053___mcc_h2 = _source37.dtor_tpe;
        return this;
      } else if (_source37.is_Identifier) {
        Dafny.ISequence<Dafny.Rune> _1054___mcc_h4 = _source37.dtor_name;
        return this;
      } else if (_source37.is_Match) {
        RAST._IExpr _1055___mcc_h6 = _source37.dtor_matchee;
        Dafny.ISequence<RAST._IMatchCase> _1056___mcc_h7 = _source37.dtor_cases;
        return this;
      } else if (_source37.is_StmtExpr) {
        RAST._IExpr _1057___mcc_h10 = _source37.dtor_stmt;
        RAST._IExpr _1058___mcc_h11 = _source37.dtor_rhs;
        RAST._IExpr _source38 = _1057___mcc_h10;
        if (_source38.is_RawExpr) {
          Dafny.ISequence<Dafny.Rune> _1059___mcc_h14 = _source38.dtor_content;
          return this;
        } else if (_source38.is_ExprFromType) {
          RAST._IType _1060___mcc_h16 = _source38.dtor_tpe;
          return this;
        } else if (_source38.is_Identifier) {
          Dafny.ISequence<Dafny.Rune> _1061___mcc_h18 = _source38.dtor_name;
          return this;
        } else if (_source38.is_Match) {
          RAST._IExpr _1062___mcc_h20 = _source38.dtor_matchee;
          Dafny.ISequence<RAST._IMatchCase> _1063___mcc_h21 = _source38.dtor_cases;
          return this;
        } else if (_source38.is_StmtExpr) {
          RAST._IExpr _1064___mcc_h24 = _source38.dtor_stmt;
          RAST._IExpr _1065___mcc_h25 = _source38.dtor_rhs;
          return this;
        } else if (_source38.is_Block) {
          RAST._IExpr _1066___mcc_h28 = _source38.dtor_underlying;
          return this;
        } else if (_source38.is_StructBuild) {
          RAST._IExpr _1067___mcc_h30 = _source38.dtor_underlying;
          Dafny.ISequence<RAST._IAssignIdentifier> _1068___mcc_h31 = _source38.dtor_assignments;
          return this;
        } else if (_source38.is_Tuple) {
          Dafny.ISequence<RAST._IExpr> _1069___mcc_h34 = _source38.dtor_arguments;
          return this;
        } else if (_source38.is_UnaryOp) {
          Dafny.ISequence<Dafny.Rune> _1070___mcc_h36 = _source38.dtor_op1;
          RAST._IExpr _1071___mcc_h37 = _source38.dtor_underlying;
          DAST.Format._IUnaryOpFormat _1072___mcc_h38 = _source38.dtor_format;
          return this;
        } else if (_source38.is_BinaryOp) {
          Dafny.ISequence<Dafny.Rune> _1073___mcc_h42 = _source38.dtor_op2;
          RAST._IExpr _1074___mcc_h43 = _source38.dtor_left;
          RAST._IExpr _1075___mcc_h44 = _source38.dtor_right;
          DAST.Format._IBinaryOpFormat _1076___mcc_h45 = _source38.dtor_format2;
          return this;
        } else if (_source38.is_TypeAscription) {
          RAST._IExpr _1077___mcc_h50 = _source38.dtor_left;
          RAST._IType _1078___mcc_h51 = _source38.dtor_tpe;
          return this;
        } else if (_source38.is_LiteralInt) {
          Dafny.ISequence<Dafny.Rune> _1079___mcc_h54 = _source38.dtor_value;
          return this;
        } else if (_source38.is_LiteralBool) {
          bool _1080___mcc_h56 = _source38.dtor_bvalue;
          return this;
        } else if (_source38.is_LiteralString) {
          Dafny.ISequence<Dafny.Rune> _1081___mcc_h58 = _source38.dtor_value;
          bool _1082___mcc_h59 = _source38.dtor_binary;
          return this;
        } else if (_source38.is_DeclareVar) {
          RAST._IDeclareType _1083___mcc_h62 = _source38.dtor_declareType;
          Dafny.ISequence<Dafny.Rune> _1084___mcc_h63 = _source38.dtor_name;
          Std.Wrappers._IOption<RAST._IType> _1085___mcc_h64 = _source38.dtor_optType;
          Std.Wrappers._IOption<RAST._IExpr> _1086___mcc_h65 = _source38.dtor_optRhs;
          Std.Wrappers._IOption<RAST._IType> _source39 = _1085___mcc_h64;
          if (_source39.is_None) {
            return this;
          } else {
            RAST._IType _1087___mcc_h70 = _source39.dtor_value;
            Std.Wrappers._IOption<RAST._IExpr> _source40 = _1086___mcc_h65;
            if (_source40.is_None) {
              RAST._IExpr _source41 = _1058___mcc_h11;
              if (_source41.is_RawExpr) {
                Dafny.ISequence<Dafny.Rune> _1088___mcc_h72 = _source41.dtor_content;
                return this;
              } else if (_source41.is_ExprFromType) {
                RAST._IType _1089___mcc_h74 = _source41.dtor_tpe;
                return this;
              } else if (_source41.is_Identifier) {
                Dafny.ISequence<Dafny.Rune> _1090___mcc_h76 = _source41.dtor_name;
                return this;
              } else if (_source41.is_Match) {
                RAST._IExpr _1091___mcc_h78 = _source41.dtor_matchee;
                Dafny.ISequence<RAST._IMatchCase> _1092___mcc_h79 = _source41.dtor_cases;
                return this;
              } else if (_source41.is_StmtExpr) {
                RAST._IExpr _1093___mcc_h82 = _source41.dtor_stmt;
                RAST._IExpr _1094___mcc_h83 = _source41.dtor_rhs;
                RAST._IExpr _source42 = _1093___mcc_h82;
                if (_source42.is_RawExpr) {
                  Dafny.ISequence<Dafny.Rune> _1095___mcc_h86 = _source42.dtor_content;
                  return this;
                } else if (_source42.is_ExprFromType) {
                  RAST._IType _1096___mcc_h88 = _source42.dtor_tpe;
                  return this;
                } else if (_source42.is_Identifier) {
                  Dafny.ISequence<Dafny.Rune> _1097___mcc_h90 = _source42.dtor_name;
                  return this;
                } else if (_source42.is_Match) {
                  RAST._IExpr _1098___mcc_h92 = _source42.dtor_matchee;
                  Dafny.ISequence<RAST._IMatchCase> _1099___mcc_h93 = _source42.dtor_cases;
                  return this;
                } else if (_source42.is_StmtExpr) {
                  RAST._IExpr _1100___mcc_h96 = _source42.dtor_stmt;
                  RAST._IExpr _1101___mcc_h97 = _source42.dtor_rhs;
                  return this;
                } else if (_source42.is_Block) {
                  RAST._IExpr _1102___mcc_h100 = _source42.dtor_underlying;
                  return this;
                } else if (_source42.is_StructBuild) {
                  RAST._IExpr _1103___mcc_h102 = _source42.dtor_underlying;
                  Dafny.ISequence<RAST._IAssignIdentifier> _1104___mcc_h103 = _source42.dtor_assignments;
                  return this;
                } else if (_source42.is_Tuple) {
                  Dafny.ISequence<RAST._IExpr> _1105___mcc_h106 = _source42.dtor_arguments;
                  return this;
                } else if (_source42.is_UnaryOp) {
                  Dafny.ISequence<Dafny.Rune> _1106___mcc_h108 = _source42.dtor_op1;
                  RAST._IExpr _1107___mcc_h109 = _source42.dtor_underlying;
                  DAST.Format._IUnaryOpFormat _1108___mcc_h110 = _source42.dtor_format;
                  return this;
                } else if (_source42.is_BinaryOp) {
                  Dafny.ISequence<Dafny.Rune> _1109___mcc_h114 = _source42.dtor_op2;
                  RAST._IExpr _1110___mcc_h115 = _source42.dtor_left;
                  RAST._IExpr _1111___mcc_h116 = _source42.dtor_right;
                  DAST.Format._IBinaryOpFormat _1112___mcc_h117 = _source42.dtor_format2;
                  return this;
                } else if (_source42.is_TypeAscription) {
                  RAST._IExpr _1113___mcc_h122 = _source42.dtor_left;
                  RAST._IType _1114___mcc_h123 = _source42.dtor_tpe;
                  return this;
                } else if (_source42.is_LiteralInt) {
                  Dafny.ISequence<Dafny.Rune> _1115___mcc_h126 = _source42.dtor_value;
                  return this;
                } else if (_source42.is_LiteralBool) {
                  bool _1116___mcc_h128 = _source42.dtor_bvalue;
                  return this;
                } else if (_source42.is_LiteralString) {
                  Dafny.ISequence<Dafny.Rune> _1117___mcc_h130 = _source42.dtor_value;
                  bool _1118___mcc_h131 = _source42.dtor_binary;
                  return this;
                } else if (_source42.is_DeclareVar) {
                  RAST._IDeclareType _1119___mcc_h134 = _source42.dtor_declareType;
                  Dafny.ISequence<Dafny.Rune> _1120___mcc_h135 = _source42.dtor_name;
                  Std.Wrappers._IOption<RAST._IType> _1121___mcc_h136 = _source42.dtor_optType;
                  Std.Wrappers._IOption<RAST._IExpr> _1122___mcc_h137 = _source42.dtor_optRhs;
                  return this;
                } else if (_source42.is_Assign) {
                  Std.Wrappers._IOption<RAST._IAssignLhs> _1123___mcc_h142 = _source42.dtor_names;
                  RAST._IExpr _1124___mcc_h143 = _source42.dtor_rhs;
                  RAST._IExpr _1125_last = _1094___mcc_h83;
                  RAST._IExpr _1126_rhs = _1124___mcc_h143;
                  Std.Wrappers._IOption<RAST._IAssignLhs> _1127_name2 = _1123___mcc_h142;
                  RAST._IType _1128_tpe = _1087___mcc_h70;
                  Dafny.ISequence<Dafny.Rune> _1129_name = _1084___mcc_h63;
                  RAST._IDeclareType _1130_mod = _1083___mcc_h62;
                  if (object.Equals(_1127_name2, Std.Wrappers.Option<RAST._IAssignLhs>.create_Some(RAST.AssignLhs.create_LocalVar(_1129_name)))) {
                    RAST._IExpr _1131_rewriting = RAST.Expr.create_StmtExpr(RAST.Expr.create_DeclareVar(_1130_mod, _1129_name, Std.Wrappers.Option<RAST._IType>.create_Some(_1128_tpe), Std.Wrappers.Option<RAST._IExpr>.create_Some(_1126_rhs)), _1125_last);
                    return _1131_rewriting;
                  } else {
                    return this;
                  }
                } else if (_source42.is_IfExpr) {
                  RAST._IExpr _1132___mcc_h146 = _source42.dtor_cond;
                  RAST._IExpr _1133___mcc_h147 = _source42.dtor_thn;
                  RAST._IExpr _1134___mcc_h148 = _source42.dtor_els;
                  return this;
                } else if (_source42.is_Loop) {
                  Std.Wrappers._IOption<RAST._IExpr> _1135___mcc_h152 = _source42.dtor_optCond;
                  RAST._IExpr _1136___mcc_h153 = _source42.dtor_underlying;
                  return this;
                } else if (_source42.is_For) {
                  Dafny.ISequence<Dafny.Rune> _1137___mcc_h156 = _source42.dtor_name;
                  RAST._IExpr _1138___mcc_h157 = _source42.dtor_range;
                  RAST._IExpr _1139___mcc_h158 = _source42.dtor_body;
                  return this;
                } else if (_source42.is_Labelled) {
                  Dafny.ISequence<Dafny.Rune> _1140___mcc_h162 = _source42.dtor_lbl;
                  RAST._IExpr _1141___mcc_h163 = _source42.dtor_underlying;
                  return this;
                } else if (_source42.is_Break) {
                  Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1142___mcc_h166 = _source42.dtor_optLbl;
                  return this;
                } else if (_source42.is_Continue) {
                  Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1143___mcc_h168 = _source42.dtor_optLbl;
                  return this;
                } else if (_source42.is_Return) {
                  Std.Wrappers._IOption<RAST._IExpr> _1144___mcc_h170 = _source42.dtor_optExpr;
                  return this;
                } else if (_source42.is_CallType) {
                  RAST._IExpr _1145___mcc_h172 = _source42.dtor_obj;
                  Dafny.ISequence<RAST._IType> _1146___mcc_h173 = _source42.dtor_typeParameters;
                  return this;
                } else if (_source42.is_Call) {
                  RAST._IExpr _1147___mcc_h176 = _source42.dtor_obj;
                  Dafny.ISequence<RAST._IExpr> _1148___mcc_h177 = _source42.dtor_arguments;
                  return this;
                } else if (_source42.is_Select) {
                  RAST._IExpr _1149___mcc_h180 = _source42.dtor_obj;
                  Dafny.ISequence<Dafny.Rune> _1150___mcc_h181 = _source42.dtor_name;
                  return this;
                } else if (_source42.is_MemberSelect) {
                  RAST._IExpr _1151___mcc_h184 = _source42.dtor_obj;
                  Dafny.ISequence<Dafny.Rune> _1152___mcc_h185 = _source42.dtor_name;
                  return this;
                } else {
                  Dafny.ISequence<RAST._IFormal> _1153___mcc_h188 = _source42.dtor_params;
                  Std.Wrappers._IOption<RAST._IType> _1154___mcc_h189 = _source42.dtor_retType;
                  RAST._IExpr _1155___mcc_h190 = _source42.dtor_body;
                  return this;
                }
              } else if (_source41.is_Block) {
                RAST._IExpr _1156___mcc_h194 = _source41.dtor_underlying;
                return this;
              } else if (_source41.is_StructBuild) {
                RAST._IExpr _1157___mcc_h196 = _source41.dtor_underlying;
                Dafny.ISequence<RAST._IAssignIdentifier> _1158___mcc_h197 = _source41.dtor_assignments;
                return this;
              } else if (_source41.is_Tuple) {
                Dafny.ISequence<RAST._IExpr> _1159___mcc_h200 = _source41.dtor_arguments;
                return this;
              } else if (_source41.is_UnaryOp) {
                Dafny.ISequence<Dafny.Rune> _1160___mcc_h202 = _source41.dtor_op1;
                RAST._IExpr _1161___mcc_h203 = _source41.dtor_underlying;
                DAST.Format._IUnaryOpFormat _1162___mcc_h204 = _source41.dtor_format;
                return this;
              } else if (_source41.is_BinaryOp) {
                Dafny.ISequence<Dafny.Rune> _1163___mcc_h208 = _source41.dtor_op2;
                RAST._IExpr _1164___mcc_h209 = _source41.dtor_left;
                RAST._IExpr _1165___mcc_h210 = _source41.dtor_right;
                DAST.Format._IBinaryOpFormat _1166___mcc_h211 = _source41.dtor_format2;
                return this;
              } else if (_source41.is_TypeAscription) {
                RAST._IExpr _1167___mcc_h216 = _source41.dtor_left;
                RAST._IType _1168___mcc_h217 = _source41.dtor_tpe;
                return this;
              } else if (_source41.is_LiteralInt) {
                Dafny.ISequence<Dafny.Rune> _1169___mcc_h220 = _source41.dtor_value;
                return this;
              } else if (_source41.is_LiteralBool) {
                bool _1170___mcc_h222 = _source41.dtor_bvalue;
                return this;
              } else if (_source41.is_LiteralString) {
                Dafny.ISequence<Dafny.Rune> _1171___mcc_h224 = _source41.dtor_value;
                bool _1172___mcc_h225 = _source41.dtor_binary;
                return this;
              } else if (_source41.is_DeclareVar) {
                RAST._IDeclareType _1173___mcc_h228 = _source41.dtor_declareType;
                Dafny.ISequence<Dafny.Rune> _1174___mcc_h229 = _source41.dtor_name;
                Std.Wrappers._IOption<RAST._IType> _1175___mcc_h230 = _source41.dtor_optType;
                Std.Wrappers._IOption<RAST._IExpr> _1176___mcc_h231 = _source41.dtor_optRhs;
                return this;
              } else if (_source41.is_Assign) {
                Std.Wrappers._IOption<RAST._IAssignLhs> _1177___mcc_h236 = _source41.dtor_names;
                RAST._IExpr _1178___mcc_h237 = _source41.dtor_rhs;
                return this;
              } else if (_source41.is_IfExpr) {
                RAST._IExpr _1179___mcc_h240 = _source41.dtor_cond;
                RAST._IExpr _1180___mcc_h241 = _source41.dtor_thn;
                RAST._IExpr _1181___mcc_h242 = _source41.dtor_els;
                return this;
              } else if (_source41.is_Loop) {
                Std.Wrappers._IOption<RAST._IExpr> _1182___mcc_h246 = _source41.dtor_optCond;
                RAST._IExpr _1183___mcc_h247 = _source41.dtor_underlying;
                return this;
              } else if (_source41.is_For) {
                Dafny.ISequence<Dafny.Rune> _1184___mcc_h250 = _source41.dtor_name;
                RAST._IExpr _1185___mcc_h251 = _source41.dtor_range;
                RAST._IExpr _1186___mcc_h252 = _source41.dtor_body;
                return this;
              } else if (_source41.is_Labelled) {
                Dafny.ISequence<Dafny.Rune> _1187___mcc_h256 = _source41.dtor_lbl;
                RAST._IExpr _1188___mcc_h257 = _source41.dtor_underlying;
                return this;
              } else if (_source41.is_Break) {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1189___mcc_h260 = _source41.dtor_optLbl;
                return this;
              } else if (_source41.is_Continue) {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1190___mcc_h262 = _source41.dtor_optLbl;
                return this;
              } else if (_source41.is_Return) {
                Std.Wrappers._IOption<RAST._IExpr> _1191___mcc_h264 = _source41.dtor_optExpr;
                return this;
              } else if (_source41.is_CallType) {
                RAST._IExpr _1192___mcc_h266 = _source41.dtor_obj;
                Dafny.ISequence<RAST._IType> _1193___mcc_h267 = _source41.dtor_typeParameters;
                return this;
              } else if (_source41.is_Call) {
                RAST._IExpr _1194___mcc_h270 = _source41.dtor_obj;
                Dafny.ISequence<RAST._IExpr> _1195___mcc_h271 = _source41.dtor_arguments;
                return this;
              } else if (_source41.is_Select) {
                RAST._IExpr _1196___mcc_h274 = _source41.dtor_obj;
                Dafny.ISequence<Dafny.Rune> _1197___mcc_h275 = _source41.dtor_name;
                return this;
              } else if (_source41.is_MemberSelect) {
                RAST._IExpr _1198___mcc_h278 = _source41.dtor_obj;
                Dafny.ISequence<Dafny.Rune> _1199___mcc_h279 = _source41.dtor_name;
                return this;
              } else {
                Dafny.ISequence<RAST._IFormal> _1200___mcc_h282 = _source41.dtor_params;
                Std.Wrappers._IOption<RAST._IType> _1201___mcc_h283 = _source41.dtor_retType;
                RAST._IExpr _1202___mcc_h284 = _source41.dtor_body;
                return this;
              }
            } else {
              RAST._IExpr _1203___mcc_h288 = _source40.dtor_value;
              return this;
            }
          }
        } else if (_source38.is_Assign) {
          Std.Wrappers._IOption<RAST._IAssignLhs> _1204___mcc_h290 = _source38.dtor_names;
          RAST._IExpr _1205___mcc_h291 = _source38.dtor_rhs;
          return this;
        } else if (_source38.is_IfExpr) {
          RAST._IExpr _1206___mcc_h294 = _source38.dtor_cond;
          RAST._IExpr _1207___mcc_h295 = _source38.dtor_thn;
          RAST._IExpr _1208___mcc_h296 = _source38.dtor_els;
          RAST._IExpr _source43 = _1206___mcc_h294;
          if (_source43.is_RawExpr) {
            Dafny.ISequence<Dafny.Rune> _1209___mcc_h300 = _source43.dtor_content;
            return this;
          } else if (_source43.is_ExprFromType) {
            RAST._IType _1210___mcc_h302 = _source43.dtor_tpe;
            return this;
          } else if (_source43.is_Identifier) {
            Dafny.ISequence<Dafny.Rune> _1211___mcc_h304 = _source43.dtor_name;
            return this;
          } else if (_source43.is_Match) {
            RAST._IExpr _1212___mcc_h306 = _source43.dtor_matchee;
            Dafny.ISequence<RAST._IMatchCase> _1213___mcc_h307 = _source43.dtor_cases;
            return this;
          } else if (_source43.is_StmtExpr) {
            RAST._IExpr _1214___mcc_h310 = _source43.dtor_stmt;
            RAST._IExpr _1215___mcc_h311 = _source43.dtor_rhs;
            return this;
          } else if (_source43.is_Block) {
            RAST._IExpr _1216___mcc_h314 = _source43.dtor_underlying;
            return this;
          } else if (_source43.is_StructBuild) {
            RAST._IExpr _1217___mcc_h316 = _source43.dtor_underlying;
            Dafny.ISequence<RAST._IAssignIdentifier> _1218___mcc_h317 = _source43.dtor_assignments;
            return this;
          } else if (_source43.is_Tuple) {
            Dafny.ISequence<RAST._IExpr> _1219___mcc_h320 = _source43.dtor_arguments;
            return this;
          } else if (_source43.is_UnaryOp) {
            Dafny.ISequence<Dafny.Rune> _1220___mcc_h322 = _source43.dtor_op1;
            RAST._IExpr _1221___mcc_h323 = _source43.dtor_underlying;
            DAST.Format._IUnaryOpFormat _1222___mcc_h324 = _source43.dtor_format;
            if (object.Equals(_1220___mcc_h322, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!"))) {
              RAST._IExpr _source44 = _1221___mcc_h323;
              if (_source44.is_RawExpr) {
                Dafny.ISequence<Dafny.Rune> _1223___mcc_h328 = _source44.dtor_content;
                return this;
              } else if (_source44.is_ExprFromType) {
                RAST._IType _1224___mcc_h330 = _source44.dtor_tpe;
                return this;
              } else if (_source44.is_Identifier) {
                Dafny.ISequence<Dafny.Rune> _1225___mcc_h332 = _source44.dtor_name;
                return this;
              } else if (_source44.is_Match) {
                RAST._IExpr _1226___mcc_h334 = _source44.dtor_matchee;
                Dafny.ISequence<RAST._IMatchCase> _1227___mcc_h335 = _source44.dtor_cases;
                return this;
              } else if (_source44.is_StmtExpr) {
                RAST._IExpr _1228___mcc_h338 = _source44.dtor_stmt;
                RAST._IExpr _1229___mcc_h339 = _source44.dtor_rhs;
                return this;
              } else if (_source44.is_Block) {
                RAST._IExpr _1230___mcc_h342 = _source44.dtor_underlying;
                return this;
              } else if (_source44.is_StructBuild) {
                RAST._IExpr _1231___mcc_h344 = _source44.dtor_underlying;
                Dafny.ISequence<RAST._IAssignIdentifier> _1232___mcc_h345 = _source44.dtor_assignments;
                return this;
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<RAST._IExpr> _1233___mcc_h348 = _source44.dtor_arguments;
                return this;
              } else if (_source44.is_UnaryOp) {
                Dafny.ISequence<Dafny.Rune> _1234___mcc_h350 = _source44.dtor_op1;
                RAST._IExpr _1235___mcc_h351 = _source44.dtor_underlying;
                DAST.Format._IUnaryOpFormat _1236___mcc_h352 = _source44.dtor_format;
                return this;
              } else if (_source44.is_BinaryOp) {
                Dafny.ISequence<Dafny.Rune> _1237___mcc_h356 = _source44.dtor_op2;
                RAST._IExpr _1238___mcc_h357 = _source44.dtor_left;
                RAST._IExpr _1239___mcc_h358 = _source44.dtor_right;
                DAST.Format._IBinaryOpFormat _1240___mcc_h359 = _source44.dtor_format2;
                if (object.Equals(_1237___mcc_h356, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("=="))) {
                  RAST._IExpr _source45 = _1207___mcc_h295;
                  if (_source45.is_RawExpr) {
                    Dafny.ISequence<Dafny.Rune> _1241___mcc_h364 = _source45.dtor_content;
                    if (object.Equals(_1241___mcc_h364, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("panic!(\"Halt\");"))) {
                      RAST._IExpr _source46 = _1208___mcc_h296;
                      if (_source46.is_RawExpr) {
                        Dafny.ISequence<Dafny.Rune> _1242___mcc_h366 = _source46.dtor_content;
                        if (object.Equals(_1242___mcc_h366, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) {
                          RAST._IExpr _1243_last = _1058___mcc_h11;
                          DAST.Format._IUnaryOpFormat _1244_of = _1222___mcc_h324;
                          DAST.Format._IBinaryOpFormat _1245_f = _1240___mcc_h359;
                          RAST._IExpr _1246_b = _1239___mcc_h358;
                          RAST._IExpr _1247_a = _1238___mcc_h357;
                          RAST._IExpr _1248_rewriting = RAST.Expr.create_StmtExpr((RAST.Expr.create_Identifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("assert_eq!"))).Apply(Dafny.Sequence<RAST._IExpr>.FromElements(_1247_a, _1246_b)), _1243_last);
                          return _1248_rewriting;
                        } else {
                          return this;
                        }
                      } else if (_source46.is_ExprFromType) {
                        RAST._IType _1249___mcc_h368 = _source46.dtor_tpe;
                        return this;
                      } else if (_source46.is_Identifier) {
                        Dafny.ISequence<Dafny.Rune> _1250___mcc_h370 = _source46.dtor_name;
                        return this;
                      } else if (_source46.is_Match) {
                        RAST._IExpr _1251___mcc_h372 = _source46.dtor_matchee;
                        Dafny.ISequence<RAST._IMatchCase> _1252___mcc_h373 = _source46.dtor_cases;
                        return this;
                      } else if (_source46.is_StmtExpr) {
                        RAST._IExpr _1253___mcc_h376 = _source46.dtor_stmt;
                        RAST._IExpr _1254___mcc_h377 = _source46.dtor_rhs;
                        return this;
                      } else if (_source46.is_Block) {
                        RAST._IExpr _1255___mcc_h380 = _source46.dtor_underlying;
                        return this;
                      } else if (_source46.is_StructBuild) {
                        RAST._IExpr _1256___mcc_h382 = _source46.dtor_underlying;
                        Dafny.ISequence<RAST._IAssignIdentifier> _1257___mcc_h383 = _source46.dtor_assignments;
                        return this;
                      } else if (_source46.is_Tuple) {
                        Dafny.ISequence<RAST._IExpr> _1258___mcc_h386 = _source46.dtor_arguments;
                        return this;
                      } else if (_source46.is_UnaryOp) {
                        Dafny.ISequence<Dafny.Rune> _1259___mcc_h388 = _source46.dtor_op1;
                        RAST._IExpr _1260___mcc_h389 = _source46.dtor_underlying;
                        DAST.Format._IUnaryOpFormat _1261___mcc_h390 = _source46.dtor_format;
                        return this;
                      } else if (_source46.is_BinaryOp) {
                        Dafny.ISequence<Dafny.Rune> _1262___mcc_h394 = _source46.dtor_op2;
                        RAST._IExpr _1263___mcc_h395 = _source46.dtor_left;
                        RAST._IExpr _1264___mcc_h396 = _source46.dtor_right;
                        DAST.Format._IBinaryOpFormat _1265___mcc_h397 = _source46.dtor_format2;
                        return this;
                      } else if (_source46.is_TypeAscription) {
                        RAST._IExpr _1266___mcc_h402 = _source46.dtor_left;
                        RAST._IType _1267___mcc_h403 = _source46.dtor_tpe;
                        return this;
                      } else if (_source46.is_LiteralInt) {
                        Dafny.ISequence<Dafny.Rune> _1268___mcc_h406 = _source46.dtor_value;
                        return this;
                      } else if (_source46.is_LiteralBool) {
                        bool _1269___mcc_h408 = _source46.dtor_bvalue;
                        return this;
                      } else if (_source46.is_LiteralString) {
                        Dafny.ISequence<Dafny.Rune> _1270___mcc_h410 = _source46.dtor_value;
                        bool _1271___mcc_h411 = _source46.dtor_binary;
                        return this;
                      } else if (_source46.is_DeclareVar) {
                        RAST._IDeclareType _1272___mcc_h414 = _source46.dtor_declareType;
                        Dafny.ISequence<Dafny.Rune> _1273___mcc_h415 = _source46.dtor_name;
                        Std.Wrappers._IOption<RAST._IType> _1274___mcc_h416 = _source46.dtor_optType;
                        Std.Wrappers._IOption<RAST._IExpr> _1275___mcc_h417 = _source46.dtor_optRhs;
                        return this;
                      } else if (_source46.is_Assign) {
                        Std.Wrappers._IOption<RAST._IAssignLhs> _1276___mcc_h422 = _source46.dtor_names;
                        RAST._IExpr _1277___mcc_h423 = _source46.dtor_rhs;
                        return this;
                      } else if (_source46.is_IfExpr) {
                        RAST._IExpr _1278___mcc_h426 = _source46.dtor_cond;
                        RAST._IExpr _1279___mcc_h427 = _source46.dtor_thn;
                        RAST._IExpr _1280___mcc_h428 = _source46.dtor_els;
                        return this;
                      } else if (_source46.is_Loop) {
                        Std.Wrappers._IOption<RAST._IExpr> _1281___mcc_h432 = _source46.dtor_optCond;
                        RAST._IExpr _1282___mcc_h433 = _source46.dtor_underlying;
                        return this;
                      } else if (_source46.is_For) {
                        Dafny.ISequence<Dafny.Rune> _1283___mcc_h436 = _source46.dtor_name;
                        RAST._IExpr _1284___mcc_h437 = _source46.dtor_range;
                        RAST._IExpr _1285___mcc_h438 = _source46.dtor_body;
                        return this;
                      } else if (_source46.is_Labelled) {
                        Dafny.ISequence<Dafny.Rune> _1286___mcc_h442 = _source46.dtor_lbl;
                        RAST._IExpr _1287___mcc_h443 = _source46.dtor_underlying;
                        return this;
                      } else if (_source46.is_Break) {
                        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1288___mcc_h446 = _source46.dtor_optLbl;
                        return this;
                      } else if (_source46.is_Continue) {
                        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1289___mcc_h448 = _source46.dtor_optLbl;
                        return this;
                      } else if (_source46.is_Return) {
                        Std.Wrappers._IOption<RAST._IExpr> _1290___mcc_h450 = _source46.dtor_optExpr;
                        return this;
                      } else if (_source46.is_CallType) {
                        RAST._IExpr _1291___mcc_h452 = _source46.dtor_obj;
                        Dafny.ISequence<RAST._IType> _1292___mcc_h453 = _source46.dtor_typeParameters;
                        return this;
                      } else if (_source46.is_Call) {
                        RAST._IExpr _1293___mcc_h456 = _source46.dtor_obj;
                        Dafny.ISequence<RAST._IExpr> _1294___mcc_h457 = _source46.dtor_arguments;
                        return this;
                      } else if (_source46.is_Select) {
                        RAST._IExpr _1295___mcc_h460 = _source46.dtor_obj;
                        Dafny.ISequence<Dafny.Rune> _1296___mcc_h461 = _source46.dtor_name;
                        return this;
                      } else if (_source46.is_MemberSelect) {
                        RAST._IExpr _1297___mcc_h464 = _source46.dtor_obj;
                        Dafny.ISequence<Dafny.Rune> _1298___mcc_h465 = _source46.dtor_name;
                        return this;
                      } else {
                        Dafny.ISequence<RAST._IFormal> _1299___mcc_h468 = _source46.dtor_params;
                        Std.Wrappers._IOption<RAST._IType> _1300___mcc_h469 = _source46.dtor_retType;
                        RAST._IExpr _1301___mcc_h470 = _source46.dtor_body;
                        return this;
                      }
                    } else {
                      return this;
                    }
                  } else if (_source45.is_ExprFromType) {
                    RAST._IType _1302___mcc_h474 = _source45.dtor_tpe;
                    return this;
                  } else if (_source45.is_Identifier) {
                    Dafny.ISequence<Dafny.Rune> _1303___mcc_h476 = _source45.dtor_name;
                    return this;
                  } else if (_source45.is_Match) {
                    RAST._IExpr _1304___mcc_h478 = _source45.dtor_matchee;
                    Dafny.ISequence<RAST._IMatchCase> _1305___mcc_h479 = _source45.dtor_cases;
                    return this;
                  } else if (_source45.is_StmtExpr) {
                    RAST._IExpr _1306___mcc_h482 = _source45.dtor_stmt;
                    RAST._IExpr _1307___mcc_h483 = _source45.dtor_rhs;
                    return this;
                  } else if (_source45.is_Block) {
                    RAST._IExpr _1308___mcc_h486 = _source45.dtor_underlying;
                    return this;
                  } else if (_source45.is_StructBuild) {
                    RAST._IExpr _1309___mcc_h488 = _source45.dtor_underlying;
                    Dafny.ISequence<RAST._IAssignIdentifier> _1310___mcc_h489 = _source45.dtor_assignments;
                    return this;
                  } else if (_source45.is_Tuple) {
                    Dafny.ISequence<RAST._IExpr> _1311___mcc_h492 = _source45.dtor_arguments;
                    return this;
                  } else if (_source45.is_UnaryOp) {
                    Dafny.ISequence<Dafny.Rune> _1312___mcc_h494 = _source45.dtor_op1;
                    RAST._IExpr _1313___mcc_h495 = _source45.dtor_underlying;
                    DAST.Format._IUnaryOpFormat _1314___mcc_h496 = _source45.dtor_format;
                    return this;
                  } else if (_source45.is_BinaryOp) {
                    Dafny.ISequence<Dafny.Rune> _1315___mcc_h500 = _source45.dtor_op2;
                    RAST._IExpr _1316___mcc_h501 = _source45.dtor_left;
                    RAST._IExpr _1317___mcc_h502 = _source45.dtor_right;
                    DAST.Format._IBinaryOpFormat _1318___mcc_h503 = _source45.dtor_format2;
                    return this;
                  } else if (_source45.is_TypeAscription) {
                    RAST._IExpr _1319___mcc_h508 = _source45.dtor_left;
                    RAST._IType _1320___mcc_h509 = _source45.dtor_tpe;
                    return this;
                  } else if (_source45.is_LiteralInt) {
                    Dafny.ISequence<Dafny.Rune> _1321___mcc_h512 = _source45.dtor_value;
                    return this;
                  } else if (_source45.is_LiteralBool) {
                    bool _1322___mcc_h514 = _source45.dtor_bvalue;
                    return this;
                  } else if (_source45.is_LiteralString) {
                    Dafny.ISequence<Dafny.Rune> _1323___mcc_h516 = _source45.dtor_value;
                    bool _1324___mcc_h517 = _source45.dtor_binary;
                    return this;
                  } else if (_source45.is_DeclareVar) {
                    RAST._IDeclareType _1325___mcc_h520 = _source45.dtor_declareType;
                    Dafny.ISequence<Dafny.Rune> _1326___mcc_h521 = _source45.dtor_name;
                    Std.Wrappers._IOption<RAST._IType> _1327___mcc_h522 = _source45.dtor_optType;
                    Std.Wrappers._IOption<RAST._IExpr> _1328___mcc_h523 = _source45.dtor_optRhs;
                    return this;
                  } else if (_source45.is_Assign) {
                    Std.Wrappers._IOption<RAST._IAssignLhs> _1329___mcc_h528 = _source45.dtor_names;
                    RAST._IExpr _1330___mcc_h529 = _source45.dtor_rhs;
                    return this;
                  } else if (_source45.is_IfExpr) {
                    RAST._IExpr _1331___mcc_h532 = _source45.dtor_cond;
                    RAST._IExpr _1332___mcc_h533 = _source45.dtor_thn;
                    RAST._IExpr _1333___mcc_h534 = _source45.dtor_els;
                    return this;
                  } else if (_source45.is_Loop) {
                    Std.Wrappers._IOption<RAST._IExpr> _1334___mcc_h538 = _source45.dtor_optCond;
                    RAST._IExpr _1335___mcc_h539 = _source45.dtor_underlying;
                    return this;
                  } else if (_source45.is_For) {
                    Dafny.ISequence<Dafny.Rune> _1336___mcc_h542 = _source45.dtor_name;
                    RAST._IExpr _1337___mcc_h543 = _source45.dtor_range;
                    RAST._IExpr _1338___mcc_h544 = _source45.dtor_body;
                    return this;
                  } else if (_source45.is_Labelled) {
                    Dafny.ISequence<Dafny.Rune> _1339___mcc_h548 = _source45.dtor_lbl;
                    RAST._IExpr _1340___mcc_h549 = _source45.dtor_underlying;
                    return this;
                  } else if (_source45.is_Break) {
                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1341___mcc_h552 = _source45.dtor_optLbl;
                    return this;
                  } else if (_source45.is_Continue) {
                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1342___mcc_h554 = _source45.dtor_optLbl;
                    return this;
                  } else if (_source45.is_Return) {
                    Std.Wrappers._IOption<RAST._IExpr> _1343___mcc_h556 = _source45.dtor_optExpr;
                    return this;
                  } else if (_source45.is_CallType) {
                    RAST._IExpr _1344___mcc_h558 = _source45.dtor_obj;
                    Dafny.ISequence<RAST._IType> _1345___mcc_h559 = _source45.dtor_typeParameters;
                    return this;
                  } else if (_source45.is_Call) {
                    RAST._IExpr _1346___mcc_h562 = _source45.dtor_obj;
                    Dafny.ISequence<RAST._IExpr> _1347___mcc_h563 = _source45.dtor_arguments;
                    return this;
                  } else if (_source45.is_Select) {
                    RAST._IExpr _1348___mcc_h566 = _source45.dtor_obj;
                    Dafny.ISequence<Dafny.Rune> _1349___mcc_h567 = _source45.dtor_name;
                    return this;
                  } else if (_source45.is_MemberSelect) {
                    RAST._IExpr _1350___mcc_h570 = _source45.dtor_obj;
                    Dafny.ISequence<Dafny.Rune> _1351___mcc_h571 = _source45.dtor_name;
                    return this;
                  } else {
                    Dafny.ISequence<RAST._IFormal> _1352___mcc_h574 = _source45.dtor_params;
                    Std.Wrappers._IOption<RAST._IType> _1353___mcc_h575 = _source45.dtor_retType;
                    RAST._IExpr _1354___mcc_h576 = _source45.dtor_body;
                    return this;
                  }
                } else {
                  return this;
                }
              } else if (_source44.is_TypeAscription) {
                RAST._IExpr _1355___mcc_h580 = _source44.dtor_left;
                RAST._IType _1356___mcc_h581 = _source44.dtor_tpe;
                return this;
              } else if (_source44.is_LiteralInt) {
                Dafny.ISequence<Dafny.Rune> _1357___mcc_h584 = _source44.dtor_value;
                return this;
              } else if (_source44.is_LiteralBool) {
                bool _1358___mcc_h586 = _source44.dtor_bvalue;
                return this;
              } else if (_source44.is_LiteralString) {
                Dafny.ISequence<Dafny.Rune> _1359___mcc_h588 = _source44.dtor_value;
                bool _1360___mcc_h589 = _source44.dtor_binary;
                return this;
              } else if (_source44.is_DeclareVar) {
                RAST._IDeclareType _1361___mcc_h592 = _source44.dtor_declareType;
                Dafny.ISequence<Dafny.Rune> _1362___mcc_h593 = _source44.dtor_name;
                Std.Wrappers._IOption<RAST._IType> _1363___mcc_h594 = _source44.dtor_optType;
                Std.Wrappers._IOption<RAST._IExpr> _1364___mcc_h595 = _source44.dtor_optRhs;
                return this;
              } else if (_source44.is_Assign) {
                Std.Wrappers._IOption<RAST._IAssignLhs> _1365___mcc_h600 = _source44.dtor_names;
                RAST._IExpr _1366___mcc_h601 = _source44.dtor_rhs;
                return this;
              } else if (_source44.is_IfExpr) {
                RAST._IExpr _1367___mcc_h604 = _source44.dtor_cond;
                RAST._IExpr _1368___mcc_h605 = _source44.dtor_thn;
                RAST._IExpr _1369___mcc_h606 = _source44.dtor_els;
                return this;
              } else if (_source44.is_Loop) {
                Std.Wrappers._IOption<RAST._IExpr> _1370___mcc_h610 = _source44.dtor_optCond;
                RAST._IExpr _1371___mcc_h611 = _source44.dtor_underlying;
                return this;
              } else if (_source44.is_For) {
                Dafny.ISequence<Dafny.Rune> _1372___mcc_h614 = _source44.dtor_name;
                RAST._IExpr _1373___mcc_h615 = _source44.dtor_range;
                RAST._IExpr _1374___mcc_h616 = _source44.dtor_body;
                return this;
              } else if (_source44.is_Labelled) {
                Dafny.ISequence<Dafny.Rune> _1375___mcc_h620 = _source44.dtor_lbl;
                RAST._IExpr _1376___mcc_h621 = _source44.dtor_underlying;
                return this;
              } else if (_source44.is_Break) {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1377___mcc_h624 = _source44.dtor_optLbl;
                return this;
              } else if (_source44.is_Continue) {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1378___mcc_h626 = _source44.dtor_optLbl;
                return this;
              } else if (_source44.is_Return) {
                Std.Wrappers._IOption<RAST._IExpr> _1379___mcc_h628 = _source44.dtor_optExpr;
                return this;
              } else if (_source44.is_CallType) {
                RAST._IExpr _1380___mcc_h630 = _source44.dtor_obj;
                Dafny.ISequence<RAST._IType> _1381___mcc_h631 = _source44.dtor_typeParameters;
                return this;
              } else if (_source44.is_Call) {
                RAST._IExpr _1382___mcc_h634 = _source44.dtor_obj;
                Dafny.ISequence<RAST._IExpr> _1383___mcc_h635 = _source44.dtor_arguments;
                return this;
              } else if (_source44.is_Select) {
                RAST._IExpr _1384___mcc_h638 = _source44.dtor_obj;
                Dafny.ISequence<Dafny.Rune> _1385___mcc_h639 = _source44.dtor_name;
                return this;
              } else if (_source44.is_MemberSelect) {
                RAST._IExpr _1386___mcc_h642 = _source44.dtor_obj;
                Dafny.ISequence<Dafny.Rune> _1387___mcc_h643 = _source44.dtor_name;
                return this;
              } else {
                Dafny.ISequence<RAST._IFormal> _1388___mcc_h646 = _source44.dtor_params;
                Std.Wrappers._IOption<RAST._IType> _1389___mcc_h647 = _source44.dtor_retType;
                RAST._IExpr _1390___mcc_h648 = _source44.dtor_body;
                return this;
              }
            } else {
              return this;
            }
          } else if (_source43.is_BinaryOp) {
            Dafny.ISequence<Dafny.Rune> _1391___mcc_h652 = _source43.dtor_op2;
            RAST._IExpr _1392___mcc_h653 = _source43.dtor_left;
            RAST._IExpr _1393___mcc_h654 = _source43.dtor_right;
            DAST.Format._IBinaryOpFormat _1394___mcc_h655 = _source43.dtor_format2;
            return this;
          } else if (_source43.is_TypeAscription) {
            RAST._IExpr _1395___mcc_h660 = _source43.dtor_left;
            RAST._IType _1396___mcc_h661 = _source43.dtor_tpe;
            return this;
          } else if (_source43.is_LiteralInt) {
            Dafny.ISequence<Dafny.Rune> _1397___mcc_h664 = _source43.dtor_value;
            return this;
          } else if (_source43.is_LiteralBool) {
            bool _1398___mcc_h666 = _source43.dtor_bvalue;
            return this;
          } else if (_source43.is_LiteralString) {
            Dafny.ISequence<Dafny.Rune> _1399___mcc_h668 = _source43.dtor_value;
            bool _1400___mcc_h669 = _source43.dtor_binary;
            return this;
          } else if (_source43.is_DeclareVar) {
            RAST._IDeclareType _1401___mcc_h672 = _source43.dtor_declareType;
            Dafny.ISequence<Dafny.Rune> _1402___mcc_h673 = _source43.dtor_name;
            Std.Wrappers._IOption<RAST._IType> _1403___mcc_h674 = _source43.dtor_optType;
            Std.Wrappers._IOption<RAST._IExpr> _1404___mcc_h675 = _source43.dtor_optRhs;
            return this;
          } else if (_source43.is_Assign) {
            Std.Wrappers._IOption<RAST._IAssignLhs> _1405___mcc_h680 = _source43.dtor_names;
            RAST._IExpr _1406___mcc_h681 = _source43.dtor_rhs;
            return this;
          } else if (_source43.is_IfExpr) {
            RAST._IExpr _1407___mcc_h684 = _source43.dtor_cond;
            RAST._IExpr _1408___mcc_h685 = _source43.dtor_thn;
            RAST._IExpr _1409___mcc_h686 = _source43.dtor_els;
            return this;
          } else if (_source43.is_Loop) {
            Std.Wrappers._IOption<RAST._IExpr> _1410___mcc_h690 = _source43.dtor_optCond;
            RAST._IExpr _1411___mcc_h691 = _source43.dtor_underlying;
            return this;
          } else if (_source43.is_For) {
            Dafny.ISequence<Dafny.Rune> _1412___mcc_h694 = _source43.dtor_name;
            RAST._IExpr _1413___mcc_h695 = _source43.dtor_range;
            RAST._IExpr _1414___mcc_h696 = _source43.dtor_body;
            return this;
          } else if (_source43.is_Labelled) {
            Dafny.ISequence<Dafny.Rune> _1415___mcc_h700 = _source43.dtor_lbl;
            RAST._IExpr _1416___mcc_h701 = _source43.dtor_underlying;
            return this;
          } else if (_source43.is_Break) {
            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1417___mcc_h704 = _source43.dtor_optLbl;
            return this;
          } else if (_source43.is_Continue) {
            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1418___mcc_h706 = _source43.dtor_optLbl;
            return this;
          } else if (_source43.is_Return) {
            Std.Wrappers._IOption<RAST._IExpr> _1419___mcc_h708 = _source43.dtor_optExpr;
            return this;
          } else if (_source43.is_CallType) {
            RAST._IExpr _1420___mcc_h710 = _source43.dtor_obj;
            Dafny.ISequence<RAST._IType> _1421___mcc_h711 = _source43.dtor_typeParameters;
            return this;
          } else if (_source43.is_Call) {
            RAST._IExpr _1422___mcc_h714 = _source43.dtor_obj;
            Dafny.ISequence<RAST._IExpr> _1423___mcc_h715 = _source43.dtor_arguments;
            return this;
          } else if (_source43.is_Select) {
            RAST._IExpr _1424___mcc_h718 = _source43.dtor_obj;
            Dafny.ISequence<Dafny.Rune> _1425___mcc_h719 = _source43.dtor_name;
            return this;
          } else if (_source43.is_MemberSelect) {
            RAST._IExpr _1426___mcc_h722 = _source43.dtor_obj;
            Dafny.ISequence<Dafny.Rune> _1427___mcc_h723 = _source43.dtor_name;
            return this;
          } else {
            Dafny.ISequence<RAST._IFormal> _1428___mcc_h726 = _source43.dtor_params;
            Std.Wrappers._IOption<RAST._IType> _1429___mcc_h727 = _source43.dtor_retType;
            RAST._IExpr _1430___mcc_h728 = _source43.dtor_body;
            return this;
          }
        } else if (_source38.is_Loop) {
          Std.Wrappers._IOption<RAST._IExpr> _1431___mcc_h732 = _source38.dtor_optCond;
          RAST._IExpr _1432___mcc_h733 = _source38.dtor_underlying;
          return this;
        } else if (_source38.is_For) {
          Dafny.ISequence<Dafny.Rune> _1433___mcc_h736 = _source38.dtor_name;
          RAST._IExpr _1434___mcc_h737 = _source38.dtor_range;
          RAST._IExpr _1435___mcc_h738 = _source38.dtor_body;
          return this;
        } else if (_source38.is_Labelled) {
          Dafny.ISequence<Dafny.Rune> _1436___mcc_h742 = _source38.dtor_lbl;
          RAST._IExpr _1437___mcc_h743 = _source38.dtor_underlying;
          return this;
        } else if (_source38.is_Break) {
          Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1438___mcc_h746 = _source38.dtor_optLbl;
          return this;
        } else if (_source38.is_Continue) {
          Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1439___mcc_h748 = _source38.dtor_optLbl;
          return this;
        } else if (_source38.is_Return) {
          Std.Wrappers._IOption<RAST._IExpr> _1440___mcc_h750 = _source38.dtor_optExpr;
          return this;
        } else if (_source38.is_CallType) {
          RAST._IExpr _1441___mcc_h752 = _source38.dtor_obj;
          Dafny.ISequence<RAST._IType> _1442___mcc_h753 = _source38.dtor_typeParameters;
          return this;
        } else if (_source38.is_Call) {
          RAST._IExpr _1443___mcc_h756 = _source38.dtor_obj;
          Dafny.ISequence<RAST._IExpr> _1444___mcc_h757 = _source38.dtor_arguments;
          return this;
        } else if (_source38.is_Select) {
          RAST._IExpr _1445___mcc_h760 = _source38.dtor_obj;
          Dafny.ISequence<Dafny.Rune> _1446___mcc_h761 = _source38.dtor_name;
          return this;
        } else if (_source38.is_MemberSelect) {
          RAST._IExpr _1447___mcc_h764 = _source38.dtor_obj;
          Dafny.ISequence<Dafny.Rune> _1448___mcc_h765 = _source38.dtor_name;
          return this;
        } else {
          Dafny.ISequence<RAST._IFormal> _1449___mcc_h768 = _source38.dtor_params;
          Std.Wrappers._IOption<RAST._IType> _1450___mcc_h769 = _source38.dtor_retType;
          RAST._IExpr _1451___mcc_h770 = _source38.dtor_body;
          return this;
        }
      } else if (_source37.is_Block) {
        RAST._IExpr _1452___mcc_h774 = _source37.dtor_underlying;
        return this;
      } else if (_source37.is_StructBuild) {
        RAST._IExpr _1453___mcc_h776 = _source37.dtor_underlying;
        Dafny.ISequence<RAST._IAssignIdentifier> _1454___mcc_h777 = _source37.dtor_assignments;
        return this;
      } else if (_source37.is_Tuple) {
        Dafny.ISequence<RAST._IExpr> _1455___mcc_h780 = _source37.dtor_arguments;
        return this;
      } else if (_source37.is_UnaryOp) {
        Dafny.ISequence<Dafny.Rune> _1456___mcc_h782 = _source37.dtor_op1;
        RAST._IExpr _1457___mcc_h783 = _source37.dtor_underlying;
        DAST.Format._IUnaryOpFormat _1458___mcc_h784 = _source37.dtor_format;
        if (object.Equals(_1456___mcc_h782, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"))) {
          RAST._IExpr _source47 = _1457___mcc_h783;
          if (_source47.is_RawExpr) {
            Dafny.ISequence<Dafny.Rune> _1459___mcc_h788 = _source47.dtor_content;
            return this;
          } else if (_source47.is_ExprFromType) {
            RAST._IType _1460___mcc_h790 = _source47.dtor_tpe;
            return this;
          } else if (_source47.is_Identifier) {
            Dafny.ISequence<Dafny.Rune> _1461___mcc_h792 = _source47.dtor_name;
            return this;
          } else if (_source47.is_Match) {
            RAST._IExpr _1462___mcc_h794 = _source47.dtor_matchee;
            Dafny.ISequence<RAST._IMatchCase> _1463___mcc_h795 = _source47.dtor_cases;
            return this;
          } else if (_source47.is_StmtExpr) {
            RAST._IExpr _1464___mcc_h798 = _source47.dtor_stmt;
            RAST._IExpr _1465___mcc_h799 = _source47.dtor_rhs;
            return this;
          } else if (_source47.is_Block) {
            RAST._IExpr _1466___mcc_h802 = _source47.dtor_underlying;
            return this;
          } else if (_source47.is_StructBuild) {
            RAST._IExpr _1467___mcc_h804 = _source47.dtor_underlying;
            Dafny.ISequence<RAST._IAssignIdentifier> _1468___mcc_h805 = _source47.dtor_assignments;
            return this;
          } else if (_source47.is_Tuple) {
            Dafny.ISequence<RAST._IExpr> _1469___mcc_h808 = _source47.dtor_arguments;
            return this;
          } else if (_source47.is_UnaryOp) {
            Dafny.ISequence<Dafny.Rune> _1470___mcc_h810 = _source47.dtor_op1;
            RAST._IExpr _1471___mcc_h811 = _source47.dtor_underlying;
            DAST.Format._IUnaryOpFormat _1472___mcc_h812 = _source47.dtor_format;
            return this;
          } else if (_source47.is_BinaryOp) {
            Dafny.ISequence<Dafny.Rune> _1473___mcc_h816 = _source47.dtor_op2;
            RAST._IExpr _1474___mcc_h817 = _source47.dtor_left;
            RAST._IExpr _1475___mcc_h818 = _source47.dtor_right;
            DAST.Format._IBinaryOpFormat _1476___mcc_h819 = _source47.dtor_format2;
            return this;
          } else if (_source47.is_TypeAscription) {
            RAST._IExpr _1477___mcc_h824 = _source47.dtor_left;
            RAST._IType _1478___mcc_h825 = _source47.dtor_tpe;
            return this;
          } else if (_source47.is_LiteralInt) {
            Dafny.ISequence<Dafny.Rune> _1479___mcc_h828 = _source47.dtor_value;
            return this;
          } else if (_source47.is_LiteralBool) {
            bool _1480___mcc_h830 = _source47.dtor_bvalue;
            return this;
          } else if (_source47.is_LiteralString) {
            Dafny.ISequence<Dafny.Rune> _1481___mcc_h832 = _source47.dtor_value;
            bool _1482___mcc_h833 = _source47.dtor_binary;
            return this;
          } else if (_source47.is_DeclareVar) {
            RAST._IDeclareType _1483___mcc_h836 = _source47.dtor_declareType;
            Dafny.ISequence<Dafny.Rune> _1484___mcc_h837 = _source47.dtor_name;
            Std.Wrappers._IOption<RAST._IType> _1485___mcc_h838 = _source47.dtor_optType;
            Std.Wrappers._IOption<RAST._IExpr> _1486___mcc_h839 = _source47.dtor_optRhs;
            return this;
          } else if (_source47.is_Assign) {
            Std.Wrappers._IOption<RAST._IAssignLhs> _1487___mcc_h844 = _source47.dtor_names;
            RAST._IExpr _1488___mcc_h845 = _source47.dtor_rhs;
            return this;
          } else if (_source47.is_IfExpr) {
            RAST._IExpr _1489___mcc_h848 = _source47.dtor_cond;
            RAST._IExpr _1490___mcc_h849 = _source47.dtor_thn;
            RAST._IExpr _1491___mcc_h850 = _source47.dtor_els;
            return this;
          } else if (_source47.is_Loop) {
            Std.Wrappers._IOption<RAST._IExpr> _1492___mcc_h854 = _source47.dtor_optCond;
            RAST._IExpr _1493___mcc_h855 = _source47.dtor_underlying;
            return this;
          } else if (_source47.is_For) {
            Dafny.ISequence<Dafny.Rune> _1494___mcc_h858 = _source47.dtor_name;
            RAST._IExpr _1495___mcc_h859 = _source47.dtor_range;
            RAST._IExpr _1496___mcc_h860 = _source47.dtor_body;
            return this;
          } else if (_source47.is_Labelled) {
            Dafny.ISequence<Dafny.Rune> _1497___mcc_h864 = _source47.dtor_lbl;
            RAST._IExpr _1498___mcc_h865 = _source47.dtor_underlying;
            return this;
          } else if (_source47.is_Break) {
            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1499___mcc_h868 = _source47.dtor_optLbl;
            return this;
          } else if (_source47.is_Continue) {
            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1500___mcc_h870 = _source47.dtor_optLbl;
            return this;
          } else if (_source47.is_Return) {
            Std.Wrappers._IOption<RAST._IExpr> _1501___mcc_h872 = _source47.dtor_optExpr;
            return this;
          } else if (_source47.is_CallType) {
            RAST._IExpr _1502___mcc_h874 = _source47.dtor_obj;
            Dafny.ISequence<RAST._IType> _1503___mcc_h875 = _source47.dtor_typeParameters;
            return this;
          } else if (_source47.is_Call) {
            RAST._IExpr _1504___mcc_h878 = _source47.dtor_obj;
            Dafny.ISequence<RAST._IExpr> _1505___mcc_h879 = _source47.dtor_arguments;
            RAST._IExpr _source48 = _1504___mcc_h878;
            if (_source48.is_RawExpr) {
              Dafny.ISequence<Dafny.Rune> _1506___mcc_h882 = _source48.dtor_content;
              return this;
            } else if (_source48.is_ExprFromType) {
              RAST._IType _1507___mcc_h884 = _source48.dtor_tpe;
              return this;
            } else if (_source48.is_Identifier) {
              Dafny.ISequence<Dafny.Rune> _1508___mcc_h886 = _source48.dtor_name;
              return this;
            } else if (_source48.is_Match) {
              RAST._IExpr _1509___mcc_h888 = _source48.dtor_matchee;
              Dafny.ISequence<RAST._IMatchCase> _1510___mcc_h889 = _source48.dtor_cases;
              return this;
            } else if (_source48.is_StmtExpr) {
              RAST._IExpr _1511___mcc_h892 = _source48.dtor_stmt;
              RAST._IExpr _1512___mcc_h893 = _source48.dtor_rhs;
              return this;
            } else if (_source48.is_Block) {
              RAST._IExpr _1513___mcc_h896 = _source48.dtor_underlying;
              return this;
            } else if (_source48.is_StructBuild) {
              RAST._IExpr _1514___mcc_h898 = _source48.dtor_underlying;
              Dafny.ISequence<RAST._IAssignIdentifier> _1515___mcc_h899 = _source48.dtor_assignments;
              return this;
            } else if (_source48.is_Tuple) {
              Dafny.ISequence<RAST._IExpr> _1516___mcc_h902 = _source48.dtor_arguments;
              return this;
            } else if (_source48.is_UnaryOp) {
              Dafny.ISequence<Dafny.Rune> _1517___mcc_h904 = _source48.dtor_op1;
              RAST._IExpr _1518___mcc_h905 = _source48.dtor_underlying;
              DAST.Format._IUnaryOpFormat _1519___mcc_h906 = _source48.dtor_format;
              return this;
            } else if (_source48.is_BinaryOp) {
              Dafny.ISequence<Dafny.Rune> _1520___mcc_h910 = _source48.dtor_op2;
              RAST._IExpr _1521___mcc_h911 = _source48.dtor_left;
              RAST._IExpr _1522___mcc_h912 = _source48.dtor_right;
              DAST.Format._IBinaryOpFormat _1523___mcc_h913 = _source48.dtor_format2;
              return this;
            } else if (_source48.is_TypeAscription) {
              RAST._IExpr _1524___mcc_h918 = _source48.dtor_left;
              RAST._IType _1525___mcc_h919 = _source48.dtor_tpe;
              return this;
            } else if (_source48.is_LiteralInt) {
              Dafny.ISequence<Dafny.Rune> _1526___mcc_h922 = _source48.dtor_value;
              return this;
            } else if (_source48.is_LiteralBool) {
              bool _1527___mcc_h924 = _source48.dtor_bvalue;
              return this;
            } else if (_source48.is_LiteralString) {
              Dafny.ISequence<Dafny.Rune> _1528___mcc_h926 = _source48.dtor_value;
              bool _1529___mcc_h927 = _source48.dtor_binary;
              return this;
            } else if (_source48.is_DeclareVar) {
              RAST._IDeclareType _1530___mcc_h930 = _source48.dtor_declareType;
              Dafny.ISequence<Dafny.Rune> _1531___mcc_h931 = _source48.dtor_name;
              Std.Wrappers._IOption<RAST._IType> _1532___mcc_h932 = _source48.dtor_optType;
              Std.Wrappers._IOption<RAST._IExpr> _1533___mcc_h933 = _source48.dtor_optRhs;
              return this;
            } else if (_source48.is_Assign) {
              Std.Wrappers._IOption<RAST._IAssignLhs> _1534___mcc_h938 = _source48.dtor_names;
              RAST._IExpr _1535___mcc_h939 = _source48.dtor_rhs;
              return this;
            } else if (_source48.is_IfExpr) {
              RAST._IExpr _1536___mcc_h942 = _source48.dtor_cond;
              RAST._IExpr _1537___mcc_h943 = _source48.dtor_thn;
              RAST._IExpr _1538___mcc_h944 = _source48.dtor_els;
              return this;
            } else if (_source48.is_Loop) {
              Std.Wrappers._IOption<RAST._IExpr> _1539___mcc_h948 = _source48.dtor_optCond;
              RAST._IExpr _1540___mcc_h949 = _source48.dtor_underlying;
              return this;
            } else if (_source48.is_For) {
              Dafny.ISequence<Dafny.Rune> _1541___mcc_h952 = _source48.dtor_name;
              RAST._IExpr _1542___mcc_h953 = _source48.dtor_range;
              RAST._IExpr _1543___mcc_h954 = _source48.dtor_body;
              return this;
            } else if (_source48.is_Labelled) {
              Dafny.ISequence<Dafny.Rune> _1544___mcc_h958 = _source48.dtor_lbl;
              RAST._IExpr _1545___mcc_h959 = _source48.dtor_underlying;
              return this;
            } else if (_source48.is_Break) {
              Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1546___mcc_h962 = _source48.dtor_optLbl;
              return this;
            } else if (_source48.is_Continue) {
              Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1547___mcc_h964 = _source48.dtor_optLbl;
              return this;
            } else if (_source48.is_Return) {
              Std.Wrappers._IOption<RAST._IExpr> _1548___mcc_h966 = _source48.dtor_optExpr;
              return this;
            } else if (_source48.is_CallType) {
              RAST._IExpr _1549___mcc_h968 = _source48.dtor_obj;
              Dafny.ISequence<RAST._IType> _1550___mcc_h969 = _source48.dtor_typeParameters;
              return this;
            } else if (_source48.is_Call) {
              RAST._IExpr _1551___mcc_h972 = _source48.dtor_obj;
              Dafny.ISequence<RAST._IExpr> _1552___mcc_h973 = _source48.dtor_arguments;
              return this;
            } else if (_source48.is_Select) {
              RAST._IExpr _1553___mcc_h976 = _source48.dtor_obj;
              Dafny.ISequence<Dafny.Rune> _1554___mcc_h977 = _source48.dtor_name;
              if (object.Equals(_1554___mcc_h977, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("clone"))) {
                DAST.Format._IUnaryOpFormat _1555_format = _1458___mcc_h784;
                Dafny.ISequence<RAST._IExpr> _1556_args = _1505___mcc_h879;
                RAST._IExpr _1557_underlying = _1553___mcc_h976;
                if ((_1556_args).Equals(Dafny.Sequence<RAST._IExpr>.FromElements())) {
                  return RAST.Expr.create_UnaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _1557_underlying, _1555_format);
                } else {
                  return this;
                }
              } else {
                return this;
              }
            } else if (_source48.is_MemberSelect) {
              RAST._IExpr _1558___mcc_h980 = _source48.dtor_obj;
              Dafny.ISequence<Dafny.Rune> _1559___mcc_h981 = _source48.dtor_name;
              return this;
            } else {
              Dafny.ISequence<RAST._IFormal> _1560___mcc_h984 = _source48.dtor_params;
              Std.Wrappers._IOption<RAST._IType> _1561___mcc_h985 = _source48.dtor_retType;
              RAST._IExpr _1562___mcc_h986 = _source48.dtor_body;
              return this;
            }
          } else if (_source47.is_Select) {
            RAST._IExpr _1563___mcc_h990 = _source47.dtor_obj;
            Dafny.ISequence<Dafny.Rune> _1564___mcc_h991 = _source47.dtor_name;
            return this;
          } else if (_source47.is_MemberSelect) {
            RAST._IExpr _1565___mcc_h994 = _source47.dtor_obj;
            Dafny.ISequence<Dafny.Rune> _1566___mcc_h995 = _source47.dtor_name;
            return this;
          } else {
            Dafny.ISequence<RAST._IFormal> _1567___mcc_h998 = _source47.dtor_params;
            Std.Wrappers._IOption<RAST._IType> _1568___mcc_h999 = _source47.dtor_retType;
            RAST._IExpr _1569___mcc_h1000 = _source47.dtor_body;
            return this;
          }
        } else if (object.Equals(_1456___mcc_h782, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!"))) {
          RAST._IExpr _source49 = _1457___mcc_h783;
          if (_source49.is_RawExpr) {
            Dafny.ISequence<Dafny.Rune> _1570___mcc_h1004 = _source49.dtor_content;
            return this;
          } else if (_source49.is_ExprFromType) {
            RAST._IType _1571___mcc_h1006 = _source49.dtor_tpe;
            return this;
          } else if (_source49.is_Identifier) {
            Dafny.ISequence<Dafny.Rune> _1572___mcc_h1008 = _source49.dtor_name;
            return this;
          } else if (_source49.is_Match) {
            RAST._IExpr _1573___mcc_h1010 = _source49.dtor_matchee;
            Dafny.ISequence<RAST._IMatchCase> _1574___mcc_h1011 = _source49.dtor_cases;
            return this;
          } else if (_source49.is_StmtExpr) {
            RAST._IExpr _1575___mcc_h1014 = _source49.dtor_stmt;
            RAST._IExpr _1576___mcc_h1015 = _source49.dtor_rhs;
            return this;
          } else if (_source49.is_Block) {
            RAST._IExpr _1577___mcc_h1018 = _source49.dtor_underlying;
            return this;
          } else if (_source49.is_StructBuild) {
            RAST._IExpr _1578___mcc_h1020 = _source49.dtor_underlying;
            Dafny.ISequence<RAST._IAssignIdentifier> _1579___mcc_h1021 = _source49.dtor_assignments;
            return this;
          } else if (_source49.is_Tuple) {
            Dafny.ISequence<RAST._IExpr> _1580___mcc_h1024 = _source49.dtor_arguments;
            return this;
          } else if (_source49.is_UnaryOp) {
            Dafny.ISequence<Dafny.Rune> _1581___mcc_h1026 = _source49.dtor_op1;
            RAST._IExpr _1582___mcc_h1027 = _source49.dtor_underlying;
            DAST.Format._IUnaryOpFormat _1583___mcc_h1028 = _source49.dtor_format;
            return this;
          } else if (_source49.is_BinaryOp) {
            Dafny.ISequence<Dafny.Rune> _1584___mcc_h1032 = _source49.dtor_op2;
            RAST._IExpr _1585___mcc_h1033 = _source49.dtor_left;
            RAST._IExpr _1586___mcc_h1034 = _source49.dtor_right;
            DAST.Format._IBinaryOpFormat _1587___mcc_h1035 = _source49.dtor_format2;
            if (object.Equals(_1584___mcc_h1032, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("=="))) {
              DAST.Format._IUnaryOpFormat _source50 = _1458___mcc_h784;
              if (_source50.is_NoFormat) {
                return this;
              } else {
                DAST.Format._IBinaryOpFormat _1588_format = _1587___mcc_h1035;
                RAST._IExpr _1589_right = _1586___mcc_h1034;
                RAST._IExpr _1590_left = _1585___mcc_h1033;
                return RAST.Expr.create_BinaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!="), _1590_left, _1589_right, DAST.Format.BinaryOpFormat.create_NoFormat());
              }
            } else if (object.Equals(_1584___mcc_h1032, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"))) {
              DAST.Format._IBinaryOpFormat _source51 = _1587___mcc_h1035;
              if (_source51.is_NoFormat) {
                DAST.Format._IUnaryOpFormat _source52 = _1458___mcc_h784;
                if (_source52.is_NoFormat) {
                  return this;
                } else {
                  RAST._IExpr _1591_right = _1586___mcc_h1034;
                  RAST._IExpr _1592_left = _1585___mcc_h1033;
                  return RAST.Expr.create_BinaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">="), _1592_left, _1591_right, DAST.Format.BinaryOpFormat.create_NoFormat());
                }
              } else if (_source51.is_ImpliesFormat) {
                return this;
              } else if (_source51.is_EquivalenceFormat) {
                return this;
              } else {
                DAST.Format._IUnaryOpFormat _source53 = _1458___mcc_h784;
                if (_source53.is_NoFormat) {
                  return this;
                } else {
                  RAST._IExpr _1593_right = _1586___mcc_h1034;
                  RAST._IExpr _1594_left = _1585___mcc_h1033;
                  return RAST.Expr.create_BinaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<="), _1593_right, _1594_left, DAST.Format.BinaryOpFormat.create_NoFormat());
                }
              }
            } else {
              return this;
            }
          } else if (_source49.is_TypeAscription) {
            RAST._IExpr _1595___mcc_h1040 = _source49.dtor_left;
            RAST._IType _1596___mcc_h1041 = _source49.dtor_tpe;
            return this;
          } else if (_source49.is_LiteralInt) {
            Dafny.ISequence<Dafny.Rune> _1597___mcc_h1044 = _source49.dtor_value;
            return this;
          } else if (_source49.is_LiteralBool) {
            bool _1598___mcc_h1046 = _source49.dtor_bvalue;
            return this;
          } else if (_source49.is_LiteralString) {
            Dafny.ISequence<Dafny.Rune> _1599___mcc_h1048 = _source49.dtor_value;
            bool _1600___mcc_h1049 = _source49.dtor_binary;
            return this;
          } else if (_source49.is_DeclareVar) {
            RAST._IDeclareType _1601___mcc_h1052 = _source49.dtor_declareType;
            Dafny.ISequence<Dafny.Rune> _1602___mcc_h1053 = _source49.dtor_name;
            Std.Wrappers._IOption<RAST._IType> _1603___mcc_h1054 = _source49.dtor_optType;
            Std.Wrappers._IOption<RAST._IExpr> _1604___mcc_h1055 = _source49.dtor_optRhs;
            return this;
          } else if (_source49.is_Assign) {
            Std.Wrappers._IOption<RAST._IAssignLhs> _1605___mcc_h1060 = _source49.dtor_names;
            RAST._IExpr _1606___mcc_h1061 = _source49.dtor_rhs;
            return this;
          } else if (_source49.is_IfExpr) {
            RAST._IExpr _1607___mcc_h1064 = _source49.dtor_cond;
            RAST._IExpr _1608___mcc_h1065 = _source49.dtor_thn;
            RAST._IExpr _1609___mcc_h1066 = _source49.dtor_els;
            return this;
          } else if (_source49.is_Loop) {
            Std.Wrappers._IOption<RAST._IExpr> _1610___mcc_h1070 = _source49.dtor_optCond;
            RAST._IExpr _1611___mcc_h1071 = _source49.dtor_underlying;
            return this;
          } else if (_source49.is_For) {
            Dafny.ISequence<Dafny.Rune> _1612___mcc_h1074 = _source49.dtor_name;
            RAST._IExpr _1613___mcc_h1075 = _source49.dtor_range;
            RAST._IExpr _1614___mcc_h1076 = _source49.dtor_body;
            return this;
          } else if (_source49.is_Labelled) {
            Dafny.ISequence<Dafny.Rune> _1615___mcc_h1080 = _source49.dtor_lbl;
            RAST._IExpr _1616___mcc_h1081 = _source49.dtor_underlying;
            return this;
          } else if (_source49.is_Break) {
            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1617___mcc_h1084 = _source49.dtor_optLbl;
            return this;
          } else if (_source49.is_Continue) {
            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1618___mcc_h1086 = _source49.dtor_optLbl;
            return this;
          } else if (_source49.is_Return) {
            Std.Wrappers._IOption<RAST._IExpr> _1619___mcc_h1088 = _source49.dtor_optExpr;
            return this;
          } else if (_source49.is_CallType) {
            RAST._IExpr _1620___mcc_h1090 = _source49.dtor_obj;
            Dafny.ISequence<RAST._IType> _1621___mcc_h1091 = _source49.dtor_typeParameters;
            return this;
          } else if (_source49.is_Call) {
            RAST._IExpr _1622___mcc_h1094 = _source49.dtor_obj;
            Dafny.ISequence<RAST._IExpr> _1623___mcc_h1095 = _source49.dtor_arguments;
            return this;
          } else if (_source49.is_Select) {
            RAST._IExpr _1624___mcc_h1098 = _source49.dtor_obj;
            Dafny.ISequence<Dafny.Rune> _1625___mcc_h1099 = _source49.dtor_name;
            return this;
          } else if (_source49.is_MemberSelect) {
            RAST._IExpr _1626___mcc_h1102 = _source49.dtor_obj;
            Dafny.ISequence<Dafny.Rune> _1627___mcc_h1103 = _source49.dtor_name;
            return this;
          } else {
            Dafny.ISequence<RAST._IFormal> _1628___mcc_h1106 = _source49.dtor_params;
            Std.Wrappers._IOption<RAST._IType> _1629___mcc_h1107 = _source49.dtor_retType;
            RAST._IExpr _1630___mcc_h1108 = _source49.dtor_body;
            return this;
          }
        } else {
          return this;
        }
      } else if (_source37.is_BinaryOp) {
        Dafny.ISequence<Dafny.Rune> _1631___mcc_h1112 = _source37.dtor_op2;
        RAST._IExpr _1632___mcc_h1113 = _source37.dtor_left;
        RAST._IExpr _1633___mcc_h1114 = _source37.dtor_right;
        DAST.Format._IBinaryOpFormat _1634___mcc_h1115 = _source37.dtor_format2;
        return this;
      } else if (_source37.is_TypeAscription) {
        RAST._IExpr _1635___mcc_h1120 = _source37.dtor_left;
        RAST._IType _1636___mcc_h1121 = _source37.dtor_tpe;
        return this;
      } else if (_source37.is_LiteralInt) {
        Dafny.ISequence<Dafny.Rune> _1637___mcc_h1124 = _source37.dtor_value;
        return this;
      } else if (_source37.is_LiteralBool) {
        bool _1638___mcc_h1126 = _source37.dtor_bvalue;
        return this;
      } else if (_source37.is_LiteralString) {
        Dafny.ISequence<Dafny.Rune> _1639___mcc_h1128 = _source37.dtor_value;
        bool _1640___mcc_h1129 = _source37.dtor_binary;
        return this;
      } else if (_source37.is_DeclareVar) {
        RAST._IDeclareType _1641___mcc_h1132 = _source37.dtor_declareType;
        Dafny.ISequence<Dafny.Rune> _1642___mcc_h1133 = _source37.dtor_name;
        Std.Wrappers._IOption<RAST._IType> _1643___mcc_h1134 = _source37.dtor_optType;
        Std.Wrappers._IOption<RAST._IExpr> _1644___mcc_h1135 = _source37.dtor_optRhs;
        return this;
      } else if (_source37.is_Assign) {
        Std.Wrappers._IOption<RAST._IAssignLhs> _1645___mcc_h1140 = _source37.dtor_names;
        RAST._IExpr _1646___mcc_h1141 = _source37.dtor_rhs;
        return this;
      } else if (_source37.is_IfExpr) {
        RAST._IExpr _1647___mcc_h1144 = _source37.dtor_cond;
        RAST._IExpr _1648___mcc_h1145 = _source37.dtor_thn;
        RAST._IExpr _1649___mcc_h1146 = _source37.dtor_els;
        return this;
      } else if (_source37.is_Loop) {
        Std.Wrappers._IOption<RAST._IExpr> _1650___mcc_h1150 = _source37.dtor_optCond;
        RAST._IExpr _1651___mcc_h1151 = _source37.dtor_underlying;
        return this;
      } else if (_source37.is_For) {
        Dafny.ISequence<Dafny.Rune> _1652___mcc_h1154 = _source37.dtor_name;
        RAST._IExpr _1653___mcc_h1155 = _source37.dtor_range;
        RAST._IExpr _1654___mcc_h1156 = _source37.dtor_body;
        return this;
      } else if (_source37.is_Labelled) {
        Dafny.ISequence<Dafny.Rune> _1655___mcc_h1160 = _source37.dtor_lbl;
        RAST._IExpr _1656___mcc_h1161 = _source37.dtor_underlying;
        return this;
      } else if (_source37.is_Break) {
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1657___mcc_h1164 = _source37.dtor_optLbl;
        return this;
      } else if (_source37.is_Continue) {
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1658___mcc_h1166 = _source37.dtor_optLbl;
        return this;
      } else if (_source37.is_Return) {
        Std.Wrappers._IOption<RAST._IExpr> _1659___mcc_h1168 = _source37.dtor_optExpr;
        return this;
      } else if (_source37.is_CallType) {
        RAST._IExpr _1660___mcc_h1170 = _source37.dtor_obj;
        Dafny.ISequence<RAST._IType> _1661___mcc_h1171 = _source37.dtor_typeParameters;
        return this;
      } else if (_source37.is_Call) {
        RAST._IExpr _1662___mcc_h1174 = _source37.dtor_obj;
        Dafny.ISequence<RAST._IExpr> _1663___mcc_h1175 = _source37.dtor_arguments;
        RAST._IExpr _source54 = _1662___mcc_h1174;
        if (_source54.is_RawExpr) {
          Dafny.ISequence<Dafny.Rune> _1664___mcc_h1178 = _source54.dtor_content;
          return this;
        } else if (_source54.is_ExprFromType) {
          RAST._IType _1665___mcc_h1180 = _source54.dtor_tpe;
          return this;
        } else if (_source54.is_Identifier) {
          Dafny.ISequence<Dafny.Rune> _1666___mcc_h1182 = _source54.dtor_name;
          return this;
        } else if (_source54.is_Match) {
          RAST._IExpr _1667___mcc_h1184 = _source54.dtor_matchee;
          Dafny.ISequence<RAST._IMatchCase> _1668___mcc_h1185 = _source54.dtor_cases;
          return this;
        } else if (_source54.is_StmtExpr) {
          RAST._IExpr _1669___mcc_h1188 = _source54.dtor_stmt;
          RAST._IExpr _1670___mcc_h1189 = _source54.dtor_rhs;
          return this;
        } else if (_source54.is_Block) {
          RAST._IExpr _1671___mcc_h1192 = _source54.dtor_underlying;
          return this;
        } else if (_source54.is_StructBuild) {
          RAST._IExpr _1672___mcc_h1194 = _source54.dtor_underlying;
          Dafny.ISequence<RAST._IAssignIdentifier> _1673___mcc_h1195 = _source54.dtor_assignments;
          return this;
        } else if (_source54.is_Tuple) {
          Dafny.ISequence<RAST._IExpr> _1674___mcc_h1198 = _source54.dtor_arguments;
          return this;
        } else if (_source54.is_UnaryOp) {
          Dafny.ISequence<Dafny.Rune> _1675___mcc_h1200 = _source54.dtor_op1;
          RAST._IExpr _1676___mcc_h1201 = _source54.dtor_underlying;
          DAST.Format._IUnaryOpFormat _1677___mcc_h1202 = _source54.dtor_format;
          return this;
        } else if (_source54.is_BinaryOp) {
          Dafny.ISequence<Dafny.Rune> _1678___mcc_h1206 = _source54.dtor_op2;
          RAST._IExpr _1679___mcc_h1207 = _source54.dtor_left;
          RAST._IExpr _1680___mcc_h1208 = _source54.dtor_right;
          DAST.Format._IBinaryOpFormat _1681___mcc_h1209 = _source54.dtor_format2;
          return this;
        } else if (_source54.is_TypeAscription) {
          RAST._IExpr _1682___mcc_h1214 = _source54.dtor_left;
          RAST._IType _1683___mcc_h1215 = _source54.dtor_tpe;
          return this;
        } else if (_source54.is_LiteralInt) {
          Dafny.ISequence<Dafny.Rune> _1684___mcc_h1218 = _source54.dtor_value;
          return this;
        } else if (_source54.is_LiteralBool) {
          bool _1685___mcc_h1220 = _source54.dtor_bvalue;
          return this;
        } else if (_source54.is_LiteralString) {
          Dafny.ISequence<Dafny.Rune> _1686___mcc_h1222 = _source54.dtor_value;
          bool _1687___mcc_h1223 = _source54.dtor_binary;
          return this;
        } else if (_source54.is_DeclareVar) {
          RAST._IDeclareType _1688___mcc_h1226 = _source54.dtor_declareType;
          Dafny.ISequence<Dafny.Rune> _1689___mcc_h1227 = _source54.dtor_name;
          Std.Wrappers._IOption<RAST._IType> _1690___mcc_h1228 = _source54.dtor_optType;
          Std.Wrappers._IOption<RAST._IExpr> _1691___mcc_h1229 = _source54.dtor_optRhs;
          return this;
        } else if (_source54.is_Assign) {
          Std.Wrappers._IOption<RAST._IAssignLhs> _1692___mcc_h1234 = _source54.dtor_names;
          RAST._IExpr _1693___mcc_h1235 = _source54.dtor_rhs;
          return this;
        } else if (_source54.is_IfExpr) {
          RAST._IExpr _1694___mcc_h1238 = _source54.dtor_cond;
          RAST._IExpr _1695___mcc_h1239 = _source54.dtor_thn;
          RAST._IExpr _1696___mcc_h1240 = _source54.dtor_els;
          return this;
        } else if (_source54.is_Loop) {
          Std.Wrappers._IOption<RAST._IExpr> _1697___mcc_h1244 = _source54.dtor_optCond;
          RAST._IExpr _1698___mcc_h1245 = _source54.dtor_underlying;
          return this;
        } else if (_source54.is_For) {
          Dafny.ISequence<Dafny.Rune> _1699___mcc_h1248 = _source54.dtor_name;
          RAST._IExpr _1700___mcc_h1249 = _source54.dtor_range;
          RAST._IExpr _1701___mcc_h1250 = _source54.dtor_body;
          return this;
        } else if (_source54.is_Labelled) {
          Dafny.ISequence<Dafny.Rune> _1702___mcc_h1254 = _source54.dtor_lbl;
          RAST._IExpr _1703___mcc_h1255 = _source54.dtor_underlying;
          return this;
        } else if (_source54.is_Break) {
          Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1704___mcc_h1258 = _source54.dtor_optLbl;
          return this;
        } else if (_source54.is_Continue) {
          Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1705___mcc_h1260 = _source54.dtor_optLbl;
          return this;
        } else if (_source54.is_Return) {
          Std.Wrappers._IOption<RAST._IExpr> _1706___mcc_h1262 = _source54.dtor_optExpr;
          return this;
        } else if (_source54.is_CallType) {
          RAST._IExpr _1707___mcc_h1264 = _source54.dtor_obj;
          Dafny.ISequence<RAST._IType> _1708___mcc_h1265 = _source54.dtor_typeParameters;
          return this;
        } else if (_source54.is_Call) {
          RAST._IExpr _1709___mcc_h1268 = _source54.dtor_obj;
          Dafny.ISequence<RAST._IExpr> _1710___mcc_h1269 = _source54.dtor_arguments;
          return this;
        } else if (_source54.is_Select) {
          RAST._IExpr _1711___mcc_h1272 = _source54.dtor_obj;
          Dafny.ISequence<Dafny.Rune> _1712___mcc_h1273 = _source54.dtor_name;
          return this;
        } else if (_source54.is_MemberSelect) {
          RAST._IExpr _1713___mcc_h1276 = _source54.dtor_obj;
          Dafny.ISequence<Dafny.Rune> _1714___mcc_h1277 = _source54.dtor_name;
          if (object.Equals(_1714___mcc_h1277, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("truncate!"))) {
            Dafny.ISequence<RAST._IExpr> _1715_args = _1663___mcc_h1175;
            RAST._IExpr _1716_r = _1713___mcc_h1276;
            if (((!object.Equals(_1716_r, RAST.__default.dafny__runtime)) && (!object.Equals(_1716_r, RAST.__default.@global))) || ((new BigInteger((_1715_args).Count)) != (new BigInteger(2)))) {
              return this;
            } else {
              RAST._IExpr _1717_expr = (_1715_args).Select(BigInteger.Zero);
              RAST._IExpr _1718_tpeExpr = (_1715_args).Select(BigInteger.One);
              if (!((_1718_tpeExpr).is_ExprFromType)) {
                return this;
              } else {
                RAST._IType _1719_tpe = (_1718_tpeExpr).dtor_tpe;
                if (((((((((((_1719_tpe).is_U8) || ((_1719_tpe).is_U16)) || ((_1719_tpe).is_U32)) || ((_1719_tpe).is_U64)) || ((_1719_tpe).is_U128)) || ((_1719_tpe).is_I8)) || ((_1719_tpe).is_I16)) || ((_1719_tpe).is_I32)) || ((_1719_tpe).is_I64)) || ((_1719_tpe).is_I128)) {
                  RAST._IExpr _source55 = _1717_expr;
                  if (_source55.is_RawExpr) {
                    Dafny.ISequence<Dafny.Rune> _1720___mcc_h1300 = _source55.dtor_content;
                    return this;
                  } else if (_source55.is_ExprFromType) {
                    RAST._IType _1721___mcc_h1302 = _source55.dtor_tpe;
                    return this;
                  } else if (_source55.is_Identifier) {
                    Dafny.ISequence<Dafny.Rune> _1722___mcc_h1304 = _source55.dtor_name;
                    return this;
                  } else if (_source55.is_Match) {
                    RAST._IExpr _1723___mcc_h1306 = _source55.dtor_matchee;
                    Dafny.ISequence<RAST._IMatchCase> _1724___mcc_h1307 = _source55.dtor_cases;
                    return this;
                  } else if (_source55.is_StmtExpr) {
                    RAST._IExpr _1725___mcc_h1310 = _source55.dtor_stmt;
                    RAST._IExpr _1726___mcc_h1311 = _source55.dtor_rhs;
                    return this;
                  } else if (_source55.is_Block) {
                    RAST._IExpr _1727___mcc_h1314 = _source55.dtor_underlying;
                    return this;
                  } else if (_source55.is_StructBuild) {
                    RAST._IExpr _1728___mcc_h1316 = _source55.dtor_underlying;
                    Dafny.ISequence<RAST._IAssignIdentifier> _1729___mcc_h1317 = _source55.dtor_assignments;
                    return this;
                  } else if (_source55.is_Tuple) {
                    Dafny.ISequence<RAST._IExpr> _1730___mcc_h1320 = _source55.dtor_arguments;
                    return this;
                  } else if (_source55.is_UnaryOp) {
                    Dafny.ISequence<Dafny.Rune> _1731___mcc_h1322 = _source55.dtor_op1;
                    RAST._IExpr _1732___mcc_h1323 = _source55.dtor_underlying;
                    DAST.Format._IUnaryOpFormat _1733___mcc_h1324 = _source55.dtor_format;
                    return this;
                  } else if (_source55.is_BinaryOp) {
                    Dafny.ISequence<Dafny.Rune> _1734___mcc_h1328 = _source55.dtor_op2;
                    RAST._IExpr _1735___mcc_h1329 = _source55.dtor_left;
                    RAST._IExpr _1736___mcc_h1330 = _source55.dtor_right;
                    DAST.Format._IBinaryOpFormat _1737___mcc_h1331 = _source55.dtor_format2;
                    return this;
                  } else if (_source55.is_TypeAscription) {
                    RAST._IExpr _1738___mcc_h1336 = _source55.dtor_left;
                    RAST._IType _1739___mcc_h1337 = _source55.dtor_tpe;
                    return this;
                  } else if (_source55.is_LiteralInt) {
                    Dafny.ISequence<Dafny.Rune> _1740___mcc_h1340 = _source55.dtor_value;
                    return this;
                  } else if (_source55.is_LiteralBool) {
                    bool _1741___mcc_h1342 = _source55.dtor_bvalue;
                    return this;
                  } else if (_source55.is_LiteralString) {
                    Dafny.ISequence<Dafny.Rune> _1742___mcc_h1344 = _source55.dtor_value;
                    bool _1743___mcc_h1345 = _source55.dtor_binary;
                    return this;
                  } else if (_source55.is_DeclareVar) {
                    RAST._IDeclareType _1744___mcc_h1348 = _source55.dtor_declareType;
                    Dafny.ISequence<Dafny.Rune> _1745___mcc_h1349 = _source55.dtor_name;
                    Std.Wrappers._IOption<RAST._IType> _1746___mcc_h1350 = _source55.dtor_optType;
                    Std.Wrappers._IOption<RAST._IExpr> _1747___mcc_h1351 = _source55.dtor_optRhs;
                    return this;
                  } else if (_source55.is_Assign) {
                    Std.Wrappers._IOption<RAST._IAssignLhs> _1748___mcc_h1356 = _source55.dtor_names;
                    RAST._IExpr _1749___mcc_h1357 = _source55.dtor_rhs;
                    return this;
                  } else if (_source55.is_IfExpr) {
                    RAST._IExpr _1750___mcc_h1360 = _source55.dtor_cond;
                    RAST._IExpr _1751___mcc_h1361 = _source55.dtor_thn;
                    RAST._IExpr _1752___mcc_h1362 = _source55.dtor_els;
                    return this;
                  } else if (_source55.is_Loop) {
                    Std.Wrappers._IOption<RAST._IExpr> _1753___mcc_h1366 = _source55.dtor_optCond;
                    RAST._IExpr _1754___mcc_h1367 = _source55.dtor_underlying;
                    return this;
                  } else if (_source55.is_For) {
                    Dafny.ISequence<Dafny.Rune> _1755___mcc_h1370 = _source55.dtor_name;
                    RAST._IExpr _1756___mcc_h1371 = _source55.dtor_range;
                    RAST._IExpr _1757___mcc_h1372 = _source55.dtor_body;
                    return this;
                  } else if (_source55.is_Labelled) {
                    Dafny.ISequence<Dafny.Rune> _1758___mcc_h1376 = _source55.dtor_lbl;
                    RAST._IExpr _1759___mcc_h1377 = _source55.dtor_underlying;
                    return this;
                  } else if (_source55.is_Break) {
                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1760___mcc_h1380 = _source55.dtor_optLbl;
                    return this;
                  } else if (_source55.is_Continue) {
                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1761___mcc_h1382 = _source55.dtor_optLbl;
                    return this;
                  } else if (_source55.is_Return) {
                    Std.Wrappers._IOption<RAST._IExpr> _1762___mcc_h1384 = _source55.dtor_optExpr;
                    return this;
                  } else if (_source55.is_CallType) {
                    RAST._IExpr _1763___mcc_h1386 = _source55.dtor_obj;
                    Dafny.ISequence<RAST._IType> _1764___mcc_h1387 = _source55.dtor_typeParameters;
                    return this;
                  } else if (_source55.is_Call) {
                    RAST._IExpr _1765___mcc_h1390 = _source55.dtor_obj;
                    Dafny.ISequence<RAST._IExpr> _1766___mcc_h1391 = _source55.dtor_arguments;
                    RAST._IExpr _source56 = _1765___mcc_h1390;
                    if (_source56.is_RawExpr) {
                      Dafny.ISequence<Dafny.Rune> _1767___mcc_h1394 = _source56.dtor_content;
                      return this;
                    } else if (_source56.is_ExprFromType) {
                      RAST._IType _1768___mcc_h1396 = _source56.dtor_tpe;
                      return this;
                    } else if (_source56.is_Identifier) {
                      Dafny.ISequence<Dafny.Rune> _1769___mcc_h1398 = _source56.dtor_name;
                      return this;
                    } else if (_source56.is_Match) {
                      RAST._IExpr _1770___mcc_h1400 = _source56.dtor_matchee;
                      Dafny.ISequence<RAST._IMatchCase> _1771___mcc_h1401 = _source56.dtor_cases;
                      return this;
                    } else if (_source56.is_StmtExpr) {
                      RAST._IExpr _1772___mcc_h1404 = _source56.dtor_stmt;
                      RAST._IExpr _1773___mcc_h1405 = _source56.dtor_rhs;
                      return this;
                    } else if (_source56.is_Block) {
                      RAST._IExpr _1774___mcc_h1408 = _source56.dtor_underlying;
                      return this;
                    } else if (_source56.is_StructBuild) {
                      RAST._IExpr _1775___mcc_h1410 = _source56.dtor_underlying;
                      Dafny.ISequence<RAST._IAssignIdentifier> _1776___mcc_h1411 = _source56.dtor_assignments;
                      return this;
                    } else if (_source56.is_Tuple) {
                      Dafny.ISequence<RAST._IExpr> _1777___mcc_h1414 = _source56.dtor_arguments;
                      return this;
                    } else if (_source56.is_UnaryOp) {
                      Dafny.ISequence<Dafny.Rune> _1778___mcc_h1416 = _source56.dtor_op1;
                      RAST._IExpr _1779___mcc_h1417 = _source56.dtor_underlying;
                      DAST.Format._IUnaryOpFormat _1780___mcc_h1418 = _source56.dtor_format;
                      return this;
                    } else if (_source56.is_BinaryOp) {
                      Dafny.ISequence<Dafny.Rune> _1781___mcc_h1422 = _source56.dtor_op2;
                      RAST._IExpr _1782___mcc_h1423 = _source56.dtor_left;
                      RAST._IExpr _1783___mcc_h1424 = _source56.dtor_right;
                      DAST.Format._IBinaryOpFormat _1784___mcc_h1425 = _source56.dtor_format2;
                      return this;
                    } else if (_source56.is_TypeAscription) {
                      RAST._IExpr _1785___mcc_h1430 = _source56.dtor_left;
                      RAST._IType _1786___mcc_h1431 = _source56.dtor_tpe;
                      return this;
                    } else if (_source56.is_LiteralInt) {
                      Dafny.ISequence<Dafny.Rune> _1787___mcc_h1434 = _source56.dtor_value;
                      return this;
                    } else if (_source56.is_LiteralBool) {
                      bool _1788___mcc_h1436 = _source56.dtor_bvalue;
                      return this;
                    } else if (_source56.is_LiteralString) {
                      Dafny.ISequence<Dafny.Rune> _1789___mcc_h1438 = _source56.dtor_value;
                      bool _1790___mcc_h1439 = _source56.dtor_binary;
                      return this;
                    } else if (_source56.is_DeclareVar) {
                      RAST._IDeclareType _1791___mcc_h1442 = _source56.dtor_declareType;
                      Dafny.ISequence<Dafny.Rune> _1792___mcc_h1443 = _source56.dtor_name;
                      Std.Wrappers._IOption<RAST._IType> _1793___mcc_h1444 = _source56.dtor_optType;
                      Std.Wrappers._IOption<RAST._IExpr> _1794___mcc_h1445 = _source56.dtor_optRhs;
                      return this;
                    } else if (_source56.is_Assign) {
                      Std.Wrappers._IOption<RAST._IAssignLhs> _1795___mcc_h1450 = _source56.dtor_names;
                      RAST._IExpr _1796___mcc_h1451 = _source56.dtor_rhs;
                      return this;
                    } else if (_source56.is_IfExpr) {
                      RAST._IExpr _1797___mcc_h1454 = _source56.dtor_cond;
                      RAST._IExpr _1798___mcc_h1455 = _source56.dtor_thn;
                      RAST._IExpr _1799___mcc_h1456 = _source56.dtor_els;
                      return this;
                    } else if (_source56.is_Loop) {
                      Std.Wrappers._IOption<RAST._IExpr> _1800___mcc_h1460 = _source56.dtor_optCond;
                      RAST._IExpr _1801___mcc_h1461 = _source56.dtor_underlying;
                      return this;
                    } else if (_source56.is_For) {
                      Dafny.ISequence<Dafny.Rune> _1802___mcc_h1464 = _source56.dtor_name;
                      RAST._IExpr _1803___mcc_h1465 = _source56.dtor_range;
                      RAST._IExpr _1804___mcc_h1466 = _source56.dtor_body;
                      return this;
                    } else if (_source56.is_Labelled) {
                      Dafny.ISequence<Dafny.Rune> _1805___mcc_h1470 = _source56.dtor_lbl;
                      RAST._IExpr _1806___mcc_h1471 = _source56.dtor_underlying;
                      return this;
                    } else if (_source56.is_Break) {
                      Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1807___mcc_h1474 = _source56.dtor_optLbl;
                      return this;
                    } else if (_source56.is_Continue) {
                      Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1808___mcc_h1476 = _source56.dtor_optLbl;
                      return this;
                    } else if (_source56.is_Return) {
                      Std.Wrappers._IOption<RAST._IExpr> _1809___mcc_h1478 = _source56.dtor_optExpr;
                      return this;
                    } else if (_source56.is_CallType) {
                      RAST._IExpr _1810___mcc_h1480 = _source56.dtor_obj;
                      Dafny.ISequence<RAST._IType> _1811___mcc_h1481 = _source56.dtor_typeParameters;
                      return this;
                    } else if (_source56.is_Call) {
                      RAST._IExpr _1812___mcc_h1484 = _source56.dtor_obj;
                      Dafny.ISequence<RAST._IExpr> _1813___mcc_h1485 = _source56.dtor_arguments;
                      return this;
                    } else if (_source56.is_Select) {
                      RAST._IExpr _1814___mcc_h1488 = _source56.dtor_obj;
                      Dafny.ISequence<Dafny.Rune> _1815___mcc_h1489 = _source56.dtor_name;
                      return this;
                    } else if (_source56.is_MemberSelect) {
                      RAST._IExpr _1816___mcc_h1492 = _source56.dtor_obj;
                      Dafny.ISequence<Dafny.Rune> _1817___mcc_h1493 = _source56.dtor_name;
                      if (object.Equals(_1817___mcc_h1493, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("int!"))) {
                        Dafny.ISequence<RAST._IExpr> _1818_args = _1766___mcc_h1391;
                        RAST._IExpr _1819_base = _1816___mcc_h1492;
                        if (((new BigInteger((_1818_args).Count)) == (BigInteger.One)) && ((object.Equals(_1819_base, RAST.__default.dafny__runtime)) || (object.Equals(_1819_base, RAST.__default.@global)))) {
                          RAST._IExpr _source57 = (_1818_args).Select(BigInteger.Zero);
                          if (_source57.is_RawExpr) {
                            Dafny.ISequence<Dafny.Rune> _1820___mcc_h1516 = _source57.dtor_content;
                            return this;
                          } else if (_source57.is_ExprFromType) {
                            RAST._IType _1821___mcc_h1518 = _source57.dtor_tpe;
                            return this;
                          } else if (_source57.is_Identifier) {
                            Dafny.ISequence<Dafny.Rune> _1822___mcc_h1520 = _source57.dtor_name;
                            return this;
                          } else if (_source57.is_Match) {
                            RAST._IExpr _1823___mcc_h1522 = _source57.dtor_matchee;
                            Dafny.ISequence<RAST._IMatchCase> _1824___mcc_h1523 = _source57.dtor_cases;
                            return this;
                          } else if (_source57.is_StmtExpr) {
                            RAST._IExpr _1825___mcc_h1526 = _source57.dtor_stmt;
                            RAST._IExpr _1826___mcc_h1527 = _source57.dtor_rhs;
                            return this;
                          } else if (_source57.is_Block) {
                            RAST._IExpr _1827___mcc_h1530 = _source57.dtor_underlying;
                            return this;
                          } else if (_source57.is_StructBuild) {
                            RAST._IExpr _1828___mcc_h1532 = _source57.dtor_underlying;
                            Dafny.ISequence<RAST._IAssignIdentifier> _1829___mcc_h1533 = _source57.dtor_assignments;
                            return this;
                          } else if (_source57.is_Tuple) {
                            Dafny.ISequence<RAST._IExpr> _1830___mcc_h1536 = _source57.dtor_arguments;
                            return this;
                          } else if (_source57.is_UnaryOp) {
                            Dafny.ISequence<Dafny.Rune> _1831___mcc_h1538 = _source57.dtor_op1;
                            RAST._IExpr _1832___mcc_h1539 = _source57.dtor_underlying;
                            DAST.Format._IUnaryOpFormat _1833___mcc_h1540 = _source57.dtor_format;
                            return this;
                          } else if (_source57.is_BinaryOp) {
                            Dafny.ISequence<Dafny.Rune> _1834___mcc_h1544 = _source57.dtor_op2;
                            RAST._IExpr _1835___mcc_h1545 = _source57.dtor_left;
                            RAST._IExpr _1836___mcc_h1546 = _source57.dtor_right;
                            DAST.Format._IBinaryOpFormat _1837___mcc_h1547 = _source57.dtor_format2;
                            return this;
                          } else if (_source57.is_TypeAscription) {
                            RAST._IExpr _1838___mcc_h1552 = _source57.dtor_left;
                            RAST._IType _1839___mcc_h1553 = _source57.dtor_tpe;
                            return this;
                          } else if (_source57.is_LiteralInt) {
                            Dafny.ISequence<Dafny.Rune> _1840___mcc_h1556 = _source57.dtor_value;
                            Dafny.ISequence<Dafny.Rune> _1841_number = _1840___mcc_h1556;
                            return RAST.Expr.create_LiteralInt(_1841_number);
                          } else if (_source57.is_LiteralBool) {
                            bool _1842___mcc_h1558 = _source57.dtor_bvalue;
                            return this;
                          } else if (_source57.is_LiteralString) {
                            Dafny.ISequence<Dafny.Rune> _1843___mcc_h1560 = _source57.dtor_value;
                            bool _1844___mcc_h1561 = _source57.dtor_binary;
                            Dafny.ISequence<Dafny.Rune> _1845_number = _1843___mcc_h1560;
                            return RAST.Expr.create_LiteralInt(_1845_number);
                          } else if (_source57.is_DeclareVar) {
                            RAST._IDeclareType _1846___mcc_h1564 = _source57.dtor_declareType;
                            Dafny.ISequence<Dafny.Rune> _1847___mcc_h1565 = _source57.dtor_name;
                            Std.Wrappers._IOption<RAST._IType> _1848___mcc_h1566 = _source57.dtor_optType;
                            Std.Wrappers._IOption<RAST._IExpr> _1849___mcc_h1567 = _source57.dtor_optRhs;
                            return this;
                          } else if (_source57.is_Assign) {
                            Std.Wrappers._IOption<RAST._IAssignLhs> _1850___mcc_h1572 = _source57.dtor_names;
                            RAST._IExpr _1851___mcc_h1573 = _source57.dtor_rhs;
                            return this;
                          } else if (_source57.is_IfExpr) {
                            RAST._IExpr _1852___mcc_h1576 = _source57.dtor_cond;
                            RAST._IExpr _1853___mcc_h1577 = _source57.dtor_thn;
                            RAST._IExpr _1854___mcc_h1578 = _source57.dtor_els;
                            return this;
                          } else if (_source57.is_Loop) {
                            Std.Wrappers._IOption<RAST._IExpr> _1855___mcc_h1582 = _source57.dtor_optCond;
                            RAST._IExpr _1856___mcc_h1583 = _source57.dtor_underlying;
                            return this;
                          } else if (_source57.is_For) {
                            Dafny.ISequence<Dafny.Rune> _1857___mcc_h1586 = _source57.dtor_name;
                            RAST._IExpr _1858___mcc_h1587 = _source57.dtor_range;
                            RAST._IExpr _1859___mcc_h1588 = _source57.dtor_body;
                            return this;
                          } else if (_source57.is_Labelled) {
                            Dafny.ISequence<Dafny.Rune> _1860___mcc_h1592 = _source57.dtor_lbl;
                            RAST._IExpr _1861___mcc_h1593 = _source57.dtor_underlying;
                            return this;
                          } else if (_source57.is_Break) {
                            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1862___mcc_h1596 = _source57.dtor_optLbl;
                            return this;
                          } else if (_source57.is_Continue) {
                            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1863___mcc_h1598 = _source57.dtor_optLbl;
                            return this;
                          } else if (_source57.is_Return) {
                            Std.Wrappers._IOption<RAST._IExpr> _1864___mcc_h1600 = _source57.dtor_optExpr;
                            return this;
                          } else if (_source57.is_CallType) {
                            RAST._IExpr _1865___mcc_h1602 = _source57.dtor_obj;
                            Dafny.ISequence<RAST._IType> _1866___mcc_h1603 = _source57.dtor_typeParameters;
                            return this;
                          } else if (_source57.is_Call) {
                            RAST._IExpr _1867___mcc_h1606 = _source57.dtor_obj;
                            Dafny.ISequence<RAST._IExpr> _1868___mcc_h1607 = _source57.dtor_arguments;
                            return this;
                          } else if (_source57.is_Select) {
                            RAST._IExpr _1869___mcc_h1610 = _source57.dtor_obj;
                            Dafny.ISequence<Dafny.Rune> _1870___mcc_h1611 = _source57.dtor_name;
                            return this;
                          } else if (_source57.is_MemberSelect) {
                            RAST._IExpr _1871___mcc_h1614 = _source57.dtor_obj;
                            Dafny.ISequence<Dafny.Rune> _1872___mcc_h1615 = _source57.dtor_name;
                            return this;
                          } else {
                            Dafny.ISequence<RAST._IFormal> _1873___mcc_h1618 = _source57.dtor_params;
                            Std.Wrappers._IOption<RAST._IType> _1874___mcc_h1619 = _source57.dtor_retType;
                            RAST._IExpr _1875___mcc_h1620 = _source57.dtor_body;
                            return this;
                          }
                        } else {
                          return this;
                        }
                      } else {
                        return this;
                      }
                    } else {
                      Dafny.ISequence<RAST._IFormal> _1876___mcc_h1496 = _source56.dtor_params;
                      Std.Wrappers._IOption<RAST._IType> _1877___mcc_h1497 = _source56.dtor_retType;
                      RAST._IExpr _1878___mcc_h1498 = _source56.dtor_body;
                      return this;
                    }
                  } else if (_source55.is_Select) {
                    RAST._IExpr _1879___mcc_h1502 = _source55.dtor_obj;
                    Dafny.ISequence<Dafny.Rune> _1880___mcc_h1503 = _source55.dtor_name;
                    return this;
                  } else if (_source55.is_MemberSelect) {
                    RAST._IExpr _1881___mcc_h1506 = _source55.dtor_obj;
                    Dafny.ISequence<Dafny.Rune> _1882___mcc_h1507 = _source55.dtor_name;
                    return this;
                  } else {
                    Dafny.ISequence<RAST._IFormal> _1883___mcc_h1510 = _source55.dtor_params;
                    Std.Wrappers._IOption<RAST._IType> _1884___mcc_h1511 = _source55.dtor_retType;
                    RAST._IExpr _1885___mcc_h1512 = _source55.dtor_body;
                    return this;
                  }
                } else {
                  return this;
                }
              }
            }
          } else {
            return this;
          }
        } else {
          Dafny.ISequence<RAST._IFormal> _1886___mcc_h1280 = _source54.dtor_params;
          Std.Wrappers._IOption<RAST._IType> _1887___mcc_h1281 = _source54.dtor_retType;
          RAST._IExpr _1888___mcc_h1282 = _source54.dtor_body;
          return this;
        }
      } else if (_source37.is_Select) {
        RAST._IExpr _1889___mcc_h1286 = _source37.dtor_obj;
        Dafny.ISequence<Dafny.Rune> _1890___mcc_h1287 = _source37.dtor_name;
        return this;
      } else if (_source37.is_MemberSelect) {
        RAST._IExpr _1891___mcc_h1290 = _source37.dtor_obj;
        Dafny.ISequence<Dafny.Rune> _1892___mcc_h1291 = _source37.dtor_name;
        return this;
      } else {
        Dafny.ISequence<RAST._IFormal> _1893___mcc_h1294 = _source37.dtor_params;
        Std.Wrappers._IOption<RAST._IType> _1894___mcc_h1295 = _source37.dtor_retType;
        RAST._IExpr _1895___mcc_h1296 = _source37.dtor_body;
        return this;
      }
    }
    public bool LeftRequiresParentheses(RAST._IExpr left) {
      return ((this).printingInfo).NeedParenthesesForLeft((left).printingInfo);
    }
    public _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> LeftParentheses(RAST._IExpr left) {
      if ((this).LeftRequiresParentheses(left)) {
        return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      } else {
        return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
      }
    }
    public bool RightRequiresParentheses(RAST._IExpr right) {
      return ((this).printingInfo).NeedParenthesesForRight((right).printingInfo);
    }
    public _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> RightParentheses(RAST._IExpr right) {
      if ((this).RightRequiresParentheses(right)) {
        return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      } else {
        return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
      }
    }
    public Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> RightMostIdentifier() {
      RAST._IExpr _source58 = this;
      if (_source58.is_RawExpr) {
        Dafny.ISequence<Dafny.Rune> _1896___mcc_h0 = _source58.dtor_content;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_ExprFromType) {
        RAST._IType _1897___mcc_h2 = _source58.dtor_tpe;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Identifier) {
        Dafny.ISequence<Dafny.Rune> _1898___mcc_h4 = _source58.dtor_name;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Match) {
        RAST._IExpr _1899___mcc_h6 = _source58.dtor_matchee;
        Dafny.ISequence<RAST._IMatchCase> _1900___mcc_h7 = _source58.dtor_cases;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_StmtExpr) {
        RAST._IExpr _1901___mcc_h10 = _source58.dtor_stmt;
        RAST._IExpr _1902___mcc_h11 = _source58.dtor_rhs;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Block) {
        RAST._IExpr _1903___mcc_h14 = _source58.dtor_underlying;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_StructBuild) {
        RAST._IExpr _1904___mcc_h16 = _source58.dtor_underlying;
        Dafny.ISequence<RAST._IAssignIdentifier> _1905___mcc_h17 = _source58.dtor_assignments;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Tuple) {
        Dafny.ISequence<RAST._IExpr> _1906___mcc_h20 = _source58.dtor_arguments;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_UnaryOp) {
        Dafny.ISequence<Dafny.Rune> _1907___mcc_h22 = _source58.dtor_op1;
        RAST._IExpr _1908___mcc_h23 = _source58.dtor_underlying;
        DAST.Format._IUnaryOpFormat _1909___mcc_h24 = _source58.dtor_format;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_BinaryOp) {
        Dafny.ISequence<Dafny.Rune> _1910___mcc_h28 = _source58.dtor_op2;
        RAST._IExpr _1911___mcc_h29 = _source58.dtor_left;
        RAST._IExpr _1912___mcc_h30 = _source58.dtor_right;
        DAST.Format._IBinaryOpFormat _1913___mcc_h31 = _source58.dtor_format2;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_TypeAscription) {
        RAST._IExpr _1914___mcc_h36 = _source58.dtor_left;
        RAST._IType _1915___mcc_h37 = _source58.dtor_tpe;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_LiteralInt) {
        Dafny.ISequence<Dafny.Rune> _1916___mcc_h40 = _source58.dtor_value;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_LiteralBool) {
        bool _1917___mcc_h42 = _source58.dtor_bvalue;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_LiteralString) {
        Dafny.ISequence<Dafny.Rune> _1918___mcc_h44 = _source58.dtor_value;
        bool _1919___mcc_h45 = _source58.dtor_binary;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_DeclareVar) {
        RAST._IDeclareType _1920___mcc_h48 = _source58.dtor_declareType;
        Dafny.ISequence<Dafny.Rune> _1921___mcc_h49 = _source58.dtor_name;
        Std.Wrappers._IOption<RAST._IType> _1922___mcc_h50 = _source58.dtor_optType;
        Std.Wrappers._IOption<RAST._IExpr> _1923___mcc_h51 = _source58.dtor_optRhs;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Assign) {
        Std.Wrappers._IOption<RAST._IAssignLhs> _1924___mcc_h56 = _source58.dtor_names;
        RAST._IExpr _1925___mcc_h57 = _source58.dtor_rhs;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_IfExpr) {
        RAST._IExpr _1926___mcc_h60 = _source58.dtor_cond;
        RAST._IExpr _1927___mcc_h61 = _source58.dtor_thn;
        RAST._IExpr _1928___mcc_h62 = _source58.dtor_els;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Loop) {
        Std.Wrappers._IOption<RAST._IExpr> _1929___mcc_h66 = _source58.dtor_optCond;
        RAST._IExpr _1930___mcc_h67 = _source58.dtor_underlying;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_For) {
        Dafny.ISequence<Dafny.Rune> _1931___mcc_h70 = _source58.dtor_name;
        RAST._IExpr _1932___mcc_h71 = _source58.dtor_range;
        RAST._IExpr _1933___mcc_h72 = _source58.dtor_body;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Labelled) {
        Dafny.ISequence<Dafny.Rune> _1934___mcc_h76 = _source58.dtor_lbl;
        RAST._IExpr _1935___mcc_h77 = _source58.dtor_underlying;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Break) {
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1936___mcc_h80 = _source58.dtor_optLbl;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Continue) {
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1937___mcc_h82 = _source58.dtor_optLbl;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Return) {
        Std.Wrappers._IOption<RAST._IExpr> _1938___mcc_h84 = _source58.dtor_optExpr;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_CallType) {
        RAST._IExpr _1939___mcc_h86 = _source58.dtor_obj;
        Dafny.ISequence<RAST._IType> _1940___mcc_h87 = _source58.dtor_typeParameters;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Call) {
        RAST._IExpr _1941___mcc_h90 = _source58.dtor_obj;
        Dafny.ISequence<RAST._IExpr> _1942___mcc_h91 = _source58.dtor_arguments;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_Select) {
        RAST._IExpr _1943___mcc_h94 = _source58.dtor_obj;
        Dafny.ISequence<Dafny.Rune> _1944___mcc_h95 = _source58.dtor_name;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      } else if (_source58.is_MemberSelect) {
        RAST._IExpr _1945___mcc_h98 = _source58.dtor_obj;
        Dafny.ISequence<Dafny.Rune> _1946___mcc_h99 = _source58.dtor_name;
        Dafny.ISequence<Dafny.Rune> _1947_id = _1946___mcc_h99;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_Some(_1947_id);
      } else {
        Dafny.ISequence<RAST._IFormal> _1948___mcc_h102 = _source58.dtor_params;
        Std.Wrappers._IOption<RAST._IType> _1949___mcc_h103 = _source58.dtor_retType;
        RAST._IExpr _1950___mcc_h104 = _source58.dtor_body;
        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      var _pat_let_tv4 = ind;
      var _pat_let_tv5 = ind;
      var _pat_let_tv6 = ind;
      var _pat_let_tv7 = ind;
      RAST._IExpr _source59 = (this).Optimize();
      if (_source59.is_RawExpr) {
        Dafny.ISequence<Dafny.Rune> _1951___mcc_h0 = _source59.dtor_content;
        RAST._IExpr _1952_r = (this).Optimize();
        return RAST.__default.AddIndent((_1952_r).dtor_content, ind);
      } else if (_source59.is_ExprFromType) {
        RAST._IType _1953___mcc_h2 = _source59.dtor_tpe;
        RAST._IType _1954_t = _1953___mcc_h2;
        return (_1954_t)._ToString(ind);
      } else if (_source59.is_Identifier) {
        Dafny.ISequence<Dafny.Rune> _1955___mcc_h4 = _source59.dtor_name;
        Dafny.ISequence<Dafny.Rune> _1956_name = _1955___mcc_h4;
        return _1956_name;
      } else if (_source59.is_Match) {
        RAST._IExpr _1957___mcc_h6 = _source59.dtor_matchee;
        Dafny.ISequence<RAST._IMatchCase> _1958___mcc_h7 = _source59.dtor_cases;
        Dafny.ISequence<RAST._IMatchCase> _1959_cases = _1958___mcc_h7;
        RAST._IExpr _1960_matchee = _1957___mcc_h6;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match "), (_1960_matchee)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {")), RAST.__default.SeqToString<RAST._IMatchCase>(_1959_cases, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IMatchCase, Dafny.ISequence<Dafny.Rune>>>>((_1961_ind) => ((System.Func<RAST._IMatchCase, Dafny.ISequence<Dafny.Rune>>)((_1962_c) => {
          return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), _1961_ind), RAST.__default.IND), (_1962_c)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1961_ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
        })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
      } else if (_source59.is_StmtExpr) {
        RAST._IExpr _1963___mcc_h10 = _source59.dtor_stmt;
        RAST._IExpr _1964___mcc_h11 = _source59.dtor_rhs;
        RAST._IExpr _1965_rhs = _1964___mcc_h11;
        RAST._IExpr _1966_stmt = _1963___mcc_h10;
        if (((_1966_stmt).is_RawExpr) && (((_1966_stmt).dtor_content).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))) {
          return (_1965_rhs)._ToString(ind);
        } else {
          return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((_1966_stmt)._ToString(ind), (((_1966_stmt).NoExtraSemicolonAfter()) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), ind), (_1965_rhs)._ToString(ind));
        }
      } else if (_source59.is_Block) {
        RAST._IExpr _1967___mcc_h14 = _source59.dtor_underlying;
        RAST._IExpr _1968_underlying = _1967___mcc_h14;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n"), ind), RAST.__default.IND), (_1968_underlying)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
      } else if (_source59.is_StructBuild) {
        RAST._IExpr _1969___mcc_h16 = _source59.dtor_underlying;
        Dafny.ISequence<RAST._IAssignIdentifier> _1970___mcc_h17 = _source59.dtor_assignments;
        Dafny.ISequence<RAST._IAssignIdentifier> _1971_assignments = _1970___mcc_h17;
        RAST._IExpr _1972_name = _1969___mcc_h16;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((_1972_name)._ToString(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {")), RAST.__default.SeqToString<RAST._IAssignIdentifier>(_1971_assignments, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IAssignIdentifier, Dafny.ISequence<Dafny.Rune>>>>((_1973_ind) => ((System.Func<RAST._IAssignIdentifier, Dafny.ISequence<Dafny.Rune>>)((_1974_assignment) => {
          return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), _1973_ind), RAST.__default.IND), (_1974_assignment)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1973_ind, RAST.__default.IND)));
        })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","))), (((new BigInteger((_1971_assignments).Count)).Sign == 1) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
      } else if (_source59.is_Tuple) {
        Dafny.ISequence<RAST._IExpr> _1975___mcc_h20 = _source59.dtor_arguments;
        Dafny.ISequence<RAST._IExpr> _1976_arguments = _1975___mcc_h20;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), RAST.__default.SeqToString<RAST._IExpr>(_1976_arguments, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IExpr, Dafny.ISequence<Dafny.Rune>>>>((_1977_ind) => ((System.Func<RAST._IExpr, Dafny.ISequence<Dafny.Rune>>)((_1978_arg) => {
          return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), _1977_ind), RAST.__default.IND), (_1978_arg)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1977_ind, RAST.__default.IND)));
        })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","))), (((new BigInteger((_1976_arguments).Count)).Sign == 1) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      } else if (_source59.is_UnaryOp) {
        Dafny.ISequence<Dafny.Rune> _1979___mcc_h22 = _source59.dtor_op1;
        RAST._IExpr _1980___mcc_h23 = _source59.dtor_underlying;
        DAST.Format._IUnaryOpFormat _1981___mcc_h24 = _source59.dtor_format;
        DAST.Format._IUnaryOpFormat _1982_format = _1981___mcc_h24;
        RAST._IExpr _1983_underlying = _1980___mcc_h23;
        Dafny.ISequence<Dafny.Rune> _1984_op = _1979___mcc_h22;
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs41 = ((((this).printingInfo).NeedParenthesesFor((_1983_underlying).printingInfo)) ? (_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"))) : (_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))));
        Dafny.ISequence<Dafny.Rune> _1985_leftP = _let_tmp_rhs41.dtor__0;
        Dafny.ISequence<Dafny.Rune> _1986_rightP = _let_tmp_rhs41.dtor__1;
        Dafny.ISequence<Dafny.Rune> _1987_leftOp = ((((_1984_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&mut"))) && (!(_1985_leftP).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_1984_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "))) : ((((_1984_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("?"))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (_1984_op))));
        Dafny.ISequence<Dafny.Rune> _1988_rightOp = (((_1984_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("?"))) ? (_1984_op) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")));
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1987_leftOp, _1985_leftP), (_1983_underlying)._ToString(ind)), _1986_rightP), _1988_rightOp);
      } else if (_source59.is_BinaryOp) {
        Dafny.ISequence<Dafny.Rune> _1989___mcc_h28 = _source59.dtor_op2;
        RAST._IExpr _1990___mcc_h29 = _source59.dtor_left;
        RAST._IExpr _1991___mcc_h30 = _source59.dtor_right;
        DAST.Format._IBinaryOpFormat _1992___mcc_h31 = _source59.dtor_format2;
        DAST.Format._IBinaryOpFormat _1993_format = _1992___mcc_h31;
        RAST._IExpr _1994_right = _1991___mcc_h30;
        RAST._IExpr _1995_left = _1990___mcc_h29;
        Dafny.ISequence<Dafny.Rune> _1996_op2 = _1989___mcc_h28;
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs42 = (this).LeftParentheses(_1995_left);
        Dafny.ISequence<Dafny.Rune> _1997_leftLeftP = _let_tmp_rhs42.dtor__0;
        Dafny.ISequence<Dafny.Rune> _1998_leftRighP = _let_tmp_rhs42.dtor__1;
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs43 = (this).RightParentheses(_1994_right);
        Dafny.ISequence<Dafny.Rune> _1999_rightLeftP = _let_tmp_rhs43.dtor__0;
        Dafny.ISequence<Dafny.Rune> _2000_rightRightP = _let_tmp_rhs43.dtor__1;
        Dafny.ISequence<Dafny.Rune> _2001_opRendered = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "), _1996_op2), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
        Dafny.ISequence<Dafny.Rune> _2002_indLeft = (((_1997_leftLeftP).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("))) ? (Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)) : (ind));
        Dafny.ISequence<Dafny.Rune> _2003_indRight = (((_1999_rightLeftP).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("))) ? (Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)) : (ind));
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1997_leftLeftP, (_1995_left)._ToString(_2002_indLeft)), _1998_leftRighP), _2001_opRendered), _1999_rightLeftP), (_1994_right)._ToString(_2003_indRight)), _2000_rightRightP);
      } else if (_source59.is_TypeAscription) {
        RAST._IExpr _2004___mcc_h36 = _source59.dtor_left;
        RAST._IType _2005___mcc_h37 = _source59.dtor_tpe;
        RAST._IType _2006_tpe = _2005___mcc_h37;
        RAST._IExpr _2007_left = _2004___mcc_h36;
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs44 = (this).LeftParentheses(_2007_left);
        Dafny.ISequence<Dafny.Rune> _2008_leftLeftP = _let_tmp_rhs44.dtor__0;
        Dafny.ISequence<Dafny.Rune> _2009_leftRightP = _let_tmp_rhs44.dtor__1;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2008_leftLeftP, (_2007_left)._ToString(RAST.__default.IND)), _2009_leftRightP), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ")), (_2006_tpe)._ToString(RAST.__default.IND));
      } else if (_source59.is_LiteralInt) {
        Dafny.ISequence<Dafny.Rune> _2010___mcc_h40 = _source59.dtor_value;
        Dafny.ISequence<Dafny.Rune> _2011_number = _2010___mcc_h40;
        return _2011_number;
      } else if (_source59.is_LiteralBool) {
        bool _2012___mcc_h42 = _source59.dtor_bvalue;
        bool _2013_b = _2012___mcc_h42;
        if (_2013_b) {
          return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("true");
        } else {
          return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("false");
        }
      } else if (_source59.is_LiteralString) {
        Dafny.ISequence<Dafny.Rune> _2014___mcc_h44 = _source59.dtor_value;
        bool _2015___mcc_h45 = _source59.dtor_binary;
        bool _2016_binary = _2015___mcc_h45;
        Dafny.ISequence<Dafny.Rune> _2017_characters = _2014___mcc_h44;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((_2016_binary) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("b")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\"")), _2017_characters), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""));
      } else if (_source59.is_DeclareVar) {
        RAST._IDeclareType _2018___mcc_h48 = _source59.dtor_declareType;
        Dafny.ISequence<Dafny.Rune> _2019___mcc_h49 = _source59.dtor_name;
        Std.Wrappers._IOption<RAST._IType> _2020___mcc_h50 = _source59.dtor_optType;
        Std.Wrappers._IOption<RAST._IExpr> _2021___mcc_h51 = _source59.dtor_optRhs;
        Std.Wrappers._IOption<RAST._IExpr> _2022_optExpr = _2021___mcc_h51;
        Std.Wrappers._IOption<RAST._IType> _2023_optType = _2020___mcc_h50;
        Dafny.ISequence<Dafny.Rune> _2024_name = _2019___mcc_h49;
        RAST._IDeclareType _2025_declareType = _2018___mcc_h48;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let "), ((object.Equals(_2025_declareType, RAST.DeclareType.create_MUT())) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("mut ")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _2024_name), (((_2023_optType).is_Some) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": "), ((_2023_optType).dtor_value)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), (((_2022_optExpr).is_Some) ? (Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(((_2022_optExpr).dtor_value)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)), _pat_let6_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let6_0, _2026_optExprString => (((_2026_optExprString).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("= /*issue with empty RHS*/"), ((((_2022_optExpr).dtor_value).is_RawExpr) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Empty Raw expr")) : (((((_2022_optExpr).dtor_value).is_LiteralString) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Empty string literal")) : (((((_2022_optExpr).dtor_value).is_LiteralInt) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Empty int literal")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Another case"))))))))) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "), _2026_optExprString)))))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
      } else if (_source59.is_Assign) {
        Std.Wrappers._IOption<RAST._IAssignLhs> _2027___mcc_h56 = _source59.dtor_names;
        RAST._IExpr _2028___mcc_h57 = _source59.dtor_rhs;
        RAST._IExpr _2029_expr = _2028___mcc_h57;
        Std.Wrappers._IOption<RAST._IAssignLhs> _2030_names = _2027___mcc_h56;
        Dafny.ISequence<Dafny.Rune> _2031_lhs = ((System.Func<Std.Wrappers._IOption<RAST._IAssignLhs>, Dafny.ISequence<Dafny.Rune>>)((_source60) => {
          if (_source60.is_None) {
            return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_ = ");
          } else {
            RAST._IAssignLhs _2032___mcc_h108 = _source60.dtor_value;
            RAST._IAssignLhs _source61 = _2032___mcc_h108;
            if (_source61.is_LocalVar) {
              Dafny.ISequence<Dafny.Rune> _2033___mcc_h109 = _source61.dtor_name;
              Dafny.ISequence<Dafny.Rune> _2034_name = _2033___mcc_h109;
              return Dafny.Sequence<Dafny.Rune>.Concat(_2034_name, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "));
            } else if (_source61.is_SelectMember) {
              RAST._IExpr _2035___mcc_h110 = _source61.dtor_on;
              Dafny.ISequence<Dafny.Rune> _2036___mcc_h111 = _source61.dtor_field;
              Dafny.ISequence<Dafny.Rune> _2037_field = _2036___mcc_h111;
              RAST._IExpr _2038_member = _2035___mcc_h110;
              _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs45 = (RAST.Expr.create_Select(_2038_member, _2037_field)).LeftParentheses(_2038_member);
              Dafny.ISequence<Dafny.Rune> _2039_leftP = _let_tmp_rhs45.dtor__0;
              Dafny.ISequence<Dafny.Rune> _2040_rightP = _let_tmp_rhs45.dtor__1;
              return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2039_leftP, (_2038_member)._ToString(_pat_let_tv4)), _2040_rightP), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _2037_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "));
            } else if (_source61.is_ExtractTuple) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2041___mcc_h112 = _source61.dtor_names;
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2042_names = _2041___mcc_h112;
              return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), RAST.__default.SeqToString<Dafny.ISequence<Dafny.Rune>>(_2042_names, ((System.Func<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>)((_2043_name) => {
                return _2043_name;
              })), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") = "));
            } else {
              RAST._IExpr _2044___mcc_h113 = _source61.dtor_expr;
              Dafny.ISequence<RAST._IExpr> _2045___mcc_h114 = _source61.dtor_indices;
              Dafny.ISequence<RAST._IExpr> _2046_indices = _2045___mcc_h114;
              RAST._IExpr _2047_e = _2044___mcc_h113;
              _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs46 = (RAST.Expr.create_Call(_2047_e, _2046_indices)).LeftParentheses(_2047_e);
              Dafny.ISequence<Dafny.Rune> _2048_leftP = _let_tmp_rhs46.dtor__0;
              Dafny.ISequence<Dafny.Rune> _2049_rightP = _let_tmp_rhs46.dtor__1;
              return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2048_leftP, (_2047_e)._ToString(_pat_let_tv5)), _2049_rightP), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[")), RAST.__default.SeqToString<RAST._IExpr>(_2046_indices, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IExpr, Dafny.ISequence<Dafny.Rune>>>>((_2050_ind) => ((System.Func<RAST._IExpr, Dafny.ISequence<Dafny.Rune>>)((_2051_index) => {
                return (_2051_index)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_2050_ind, RAST.__default.IND));
              })))(_pat_let_tv6), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]["))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("] = "));
            }
          }
        }))(_2030_names);
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2031_lhs, (_2029_expr)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
      } else if (_source59.is_IfExpr) {
        RAST._IExpr _2052___mcc_h60 = _source59.dtor_cond;
        RAST._IExpr _2053___mcc_h61 = _source59.dtor_thn;
        RAST._IExpr _2054___mcc_h62 = _source59.dtor_els;
        RAST._IExpr _2055_els = _2054___mcc_h62;
        RAST._IExpr _2056_thn = _2053___mcc_h61;
        RAST._IExpr _2057_cond = _2052___mcc_h60;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), (_2057_cond)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), ind), RAST.__default.IND), (_2056_thn)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}")), ((object.Equals(_2055_els, RAST.Expr.create_RawExpr(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" else {\n"), ind), RAST.__default.IND), (_2055_els)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}")))));
      } else if (_source59.is_Loop) {
        Std.Wrappers._IOption<RAST._IExpr> _2058___mcc_h66 = _source59.dtor_optCond;
        RAST._IExpr _2059___mcc_h67 = _source59.dtor_underlying;
        RAST._IExpr _2060_underlying = _2059___mcc_h67;
        Std.Wrappers._IOption<RAST._IExpr> _2061_optCond = _2058___mcc_h66;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((System.Func<Std.Wrappers._IOption<RAST._IExpr>, Dafny.ISequence<Dafny.Rune>>)((_source62) => {
          if (_source62.is_None) {
            return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("loop");
          } else {
            RAST._IExpr _2062___mcc_h115 = _source62.dtor_value;
            RAST._IExpr _2063_c = _2062___mcc_h115;
            return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), (_2063_c)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_pat_let_tv7, RAST.__default.IND)));
          }
        }))(_2061_optCond), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), ind), RAST.__default.IND), (_2060_underlying)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
      } else if (_source59.is_For) {
        Dafny.ISequence<Dafny.Rune> _2064___mcc_h70 = _source59.dtor_name;
        RAST._IExpr _2065___mcc_h71 = _source59.dtor_range;
        RAST._IExpr _2066___mcc_h72 = _source59.dtor_body;
        RAST._IExpr _2067_body = _2066___mcc_h72;
        RAST._IExpr _2068_range = _2065___mcc_h71;
        Dafny.ISequence<Dafny.Rune> _2069_name = _2064___mcc_h70;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("for "), _2069_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" in ")), (_2068_range)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), ind), RAST.__default.IND), (_2067_body)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
      } else if (_source59.is_Labelled) {
        Dafny.ISequence<Dafny.Rune> _2070___mcc_h76 = _source59.dtor_lbl;
        RAST._IExpr _2071___mcc_h77 = _source59.dtor_underlying;
        RAST._IExpr _2072_underlying = _2071___mcc_h77;
        Dafny.ISequence<Dafny.Rune> _2073_name = _2070___mcc_h76;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'"), _2073_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), (_2072_underlying)._ToString(ind));
      } else if (_source59.is_Break) {
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _2074___mcc_h80 = _source59.dtor_optLbl;
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _2075_optLbl = _2074___mcc_h80;
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _source63 = _2075_optLbl;
        if (_source63.is_None) {
          return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break;");
        } else {
          Dafny.ISequence<Dafny.Rune> _2076___mcc_h116 = _source63.dtor_value;
          Dafny.ISequence<Dafny.Rune> _2077_lbl = _2076___mcc_h116;
          return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break '"), _2077_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
        }
      } else if (_source59.is_Continue) {
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _2078___mcc_h82 = _source59.dtor_optLbl;
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _2079_optLbl = _2078___mcc_h82;
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _source64 = _2079_optLbl;
        if (_source64.is_None) {
          return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("continue;");
        } else {
          Dafny.ISequence<Dafny.Rune> _2080___mcc_h117 = _source64.dtor_value;
          Dafny.ISequence<Dafny.Rune> _2081_lbl = _2080___mcc_h117;
          return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("continue '"), _2081_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
        }
      } else if (_source59.is_Return) {
        Std.Wrappers._IOption<RAST._IExpr> _2082___mcc_h84 = _source59.dtor_optExpr;
        Std.Wrappers._IOption<RAST._IExpr> _2083_optExpr = _2082___mcc_h84;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return"), (((_2083_optExpr).is_Some) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "), ((_2083_optExpr).dtor_value)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
      } else if (_source59.is_CallType) {
        RAST._IExpr _2084___mcc_h86 = _source59.dtor_obj;
        Dafny.ISequence<RAST._IType> _2085___mcc_h87 = _source59.dtor_typeParameters;
        Dafny.ISequence<RAST._IType> _2086_tpes = _2085___mcc_h87;
        RAST._IExpr _2087_expr = _2084___mcc_h86;
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs47 = (this).LeftParentheses(_2087_expr);
        Dafny.ISequence<Dafny.Rune> _2088_leftP = _let_tmp_rhs47.dtor__0;
        Dafny.ISequence<Dafny.Rune> _2089_rightP = _let_tmp_rhs47.dtor__1;
        if ((_2086_tpes).Equals(Dafny.Sequence<RAST._IType>.FromElements())) {
          return (_2087_expr)._ToString(ind);
        } else {
          return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2088_leftP, (_2087_expr)._ToString(ind)), _2089_rightP), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<")), RAST.__default.SeqToString<RAST._IType>(_2086_tpes, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>>>((_2090_ind) => ((System.Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>)((_2091_tpe) => {
            return (_2091_tpe)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_2090_ind, RAST.__default.IND));
          })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source59.is_Call) {
        RAST._IExpr _2092___mcc_h90 = _source59.dtor_obj;
        Dafny.ISequence<RAST._IExpr> _2093___mcc_h91 = _source59.dtor_arguments;
        Dafny.ISequence<RAST._IExpr> _2094_args = _2093___mcc_h91;
        RAST._IExpr _2095_expr = _2092___mcc_h90;
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs48 = (this).LeftParentheses(_2095_expr);
        Dafny.ISequence<Dafny.Rune> _2096_leftP = _let_tmp_rhs48.dtor__0;
        Dafny.ISequence<Dafny.Rune> _2097_rightP = _let_tmp_rhs48.dtor__1;
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs49 = ((System.Func<Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>>, _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>>)((_source65) => {
          if (_source65.is_None) {
            return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            Dafny.ISequence<Dafny.Rune> _2098___mcc_h118 = _source65.dtor_value;
            if (object.Equals(_2098___mcc_h118, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("seq!"))) {
              return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("["), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
            } else if (object.Equals(_2098___mcc_h118, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("map!"))) {
              return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("["), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
            } else if (object.Equals(_2098___mcc_h118, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("set!"))) {
              return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
            } else if (object.Equals(_2098___mcc_h118, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("multiset!"))) {
              return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
            } else {
              return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
        }))((_2095_expr).RightMostIdentifier());
        Dafny.ISequence<Dafny.Rune> _2099_leftCallP = _let_tmp_rhs49.dtor__0;
        Dafny.ISequence<Dafny.Rune> _2100_rightCallP = _let_tmp_rhs49.dtor__1;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2096_leftP, (_2095_expr)._ToString(ind)), _2097_rightP), _2099_leftCallP), RAST.__default.SeqToString<RAST._IExpr>(_2094_args, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IExpr, Dafny.ISequence<Dafny.Rune>>>>((_2101_ind) => ((System.Func<RAST._IExpr, Dafny.ISequence<Dafny.Rune>>)((_2102_arg) => {
          return (_2102_arg)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_2101_ind, RAST.__default.IND));
        })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "))), _2100_rightCallP);
      } else if (_source59.is_Select) {
        RAST._IExpr _2103___mcc_h94 = _source59.dtor_obj;
        Dafny.ISequence<Dafny.Rune> _2104___mcc_h95 = _source59.dtor_name;
        Dafny.ISequence<Dafny.Rune> _2105_name = _2104___mcc_h95;
        RAST._IExpr _2106_expression = _2103___mcc_h94;
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs50 = (this).LeftParentheses(_2106_expression);
        Dafny.ISequence<Dafny.Rune> _2107_leftP = _let_tmp_rhs50.dtor__0;
        Dafny.ISequence<Dafny.Rune> _2108_rightP = _let_tmp_rhs50.dtor__1;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2107_leftP, (_2106_expression)._ToString(ind)), _2108_rightP), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _2105_name);
      } else if (_source59.is_MemberSelect) {
        RAST._IExpr _2109___mcc_h98 = _source59.dtor_obj;
        Dafny.ISequence<Dafny.Rune> _2110___mcc_h99 = _source59.dtor_name;
        Dafny.ISequence<Dafny.Rune> _2111_name = _2110___mcc_h99;
        RAST._IExpr _2112_expression = _2109___mcc_h98;
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs51 = (this).LeftParentheses(_2112_expression);
        Dafny.ISequence<Dafny.Rune> _2113_leftP = _let_tmp_rhs51.dtor__0;
        Dafny.ISequence<Dafny.Rune> _2114_rightP = _let_tmp_rhs51.dtor__1;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2113_leftP, (_2112_expression)._ToString(ind)), _2114_rightP), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2111_name);
      } else {
        Dafny.ISequence<RAST._IFormal> _2115___mcc_h102 = _source59.dtor_params;
        Std.Wrappers._IOption<RAST._IType> _2116___mcc_h103 = _source59.dtor_retType;
        RAST._IExpr _2117___mcc_h104 = _source59.dtor_body;
        RAST._IExpr _2118_body = _2117___mcc_h104;
        Std.Wrappers._IOption<RAST._IType> _2119_retType = _2116___mcc_h103;
        Dafny.ISequence<RAST._IFormal> _2120_params = _2115___mcc_h102;
        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |"), RAST.__default.SeqToString<RAST._IFormal>(_2120_params, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IFormal, Dafny.ISequence<Dafny.Rune>>>>((_2121_ind) => ((System.Func<RAST._IFormal, Dafny.ISequence<Dafny.Rune>>)((_2122_arg) => {
          return (_2122_arg)._ToString(_2121_ind);
        })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| ")), (((_2119_retType).is_Some) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("-> "), ((_2119_retType).dtor_value)._ToString(ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), (_2118_body)._ToString(ind));
      }
    }
    public RAST._IExpr Then(RAST._IExpr rhs2) {
      if ((this).is_StmtExpr) {
        return RAST.Expr.create_StmtExpr((this).dtor_stmt, ((this).dtor_rhs).Then(rhs2));
      } else if (object.Equals(this, RAST.Expr.create_RawExpr(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))) {
        return rhs2;
      } else {
        return RAST.Expr.create_StmtExpr(this, rhs2);
      }
    }
    public RAST._IExpr Sel(Dafny.ISequence<Dafny.Rune> name) {
      return RAST.Expr.create_Select(this, name);
    }
    public RAST._IExpr MSel(Dafny.ISequence<Dafny.Rune> name) {
      return RAST.Expr.create_MemberSelect(this, name);
    }
    public RAST._IExpr ApplyType(Dafny.ISequence<RAST._IType> typeParameters) {
      return RAST.Expr.create_CallType(this, typeParameters);
    }
    public RAST._IExpr ApplyType1(RAST._IType typeParameter) {
      return RAST.Expr.create_CallType(this, Dafny.Sequence<RAST._IType>.FromElements(typeParameter));
    }
    public RAST._IExpr Apply(Dafny.ISequence<RAST._IExpr> arguments) {
      return RAST.Expr.create_Call(this, arguments);
    }
    public RAST._IExpr Apply1(RAST._IExpr argument) {
      return RAST.Expr.create_Call(this, Dafny.Sequence<RAST._IExpr>.FromElements(argument));
    }
    public bool IsLhsIdentifier() {
      return ((this).is_Identifier) || (((((this).is_Call) && (object.Equals((this).dtor_obj, RAST.__default.modify__macro))) && ((new BigInteger(((this).dtor_arguments).Count)) == (BigInteger.One))) && ((((this).dtor_arguments).Select(BigInteger.Zero)).is_Identifier));
    }
    public Dafny.ISequence<Dafny.Rune> LhsIdentifierName() {
      if ((this).is_Identifier) {
        return (this).dtor_name;
      } else {
        return (((this).dtor_arguments).Select(BigInteger.Zero)).dtor_name;
      }
    }
    public RAST._IPrintingInfo printingInfo { get {
      RAST._IExpr _source66 = this;
      if (_source66.is_RawExpr) {
        Dafny.ISequence<Dafny.Rune> _2123___mcc_h0 = _source66.dtor_content;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_ExprFromType) {
        RAST._IType _2124___mcc_h2 = _source66.dtor_tpe;
        return RAST.PrintingInfo.create_Precedence(BigInteger.One);
      } else if (_source66.is_Identifier) {
        Dafny.ISequence<Dafny.Rune> _2125___mcc_h4 = _source66.dtor_name;
        return RAST.PrintingInfo.create_Precedence(BigInteger.One);
      } else if (_source66.is_Match) {
        RAST._IExpr _2126___mcc_h6 = _source66.dtor_matchee;
        Dafny.ISequence<RAST._IMatchCase> _2127___mcc_h7 = _source66.dtor_cases;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_StmtExpr) {
        RAST._IExpr _2128___mcc_h10 = _source66.dtor_stmt;
        RAST._IExpr _2129___mcc_h11 = _source66.dtor_rhs;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_Block) {
        RAST._IExpr _2130___mcc_h14 = _source66.dtor_underlying;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_StructBuild) {
        RAST._IExpr _2131___mcc_h16 = _source66.dtor_underlying;
        Dafny.ISequence<RAST._IAssignIdentifier> _2132___mcc_h17 = _source66.dtor_assignments;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_Tuple) {
        Dafny.ISequence<RAST._IExpr> _2133___mcc_h20 = _source66.dtor_arguments;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_UnaryOp) {
        Dafny.ISequence<Dafny.Rune> _2134___mcc_h22 = _source66.dtor_op1;
        RAST._IExpr _2135___mcc_h23 = _source66.dtor_underlying;
        DAST.Format._IUnaryOpFormat _2136___mcc_h24 = _source66.dtor_format;
        DAST.Format._IUnaryOpFormat _2137_format = _2136___mcc_h24;
        RAST._IExpr _2138_underlying = _2135___mcc_h23;
        Dafny.ISequence<Dafny.Rune> _2139_op = _2134___mcc_h22;
        if (object.Equals(_2139_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("?"))) {
          return RAST.PrintingInfo.create_SuffixPrecedence(new BigInteger(5));
        } else if (object.Equals(_2139_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("-"))) {
          return RAST.PrintingInfo.create_Precedence(new BigInteger(6));
        } else if (object.Equals(_2139_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*"))) {
          return RAST.PrintingInfo.create_Precedence(new BigInteger(6));
        } else if (object.Equals(_2139_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!"))) {
          return RAST.PrintingInfo.create_Precedence(new BigInteger(6));
        } else if (object.Equals(_2139_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"))) {
          return RAST.PrintingInfo.create_Precedence(new BigInteger(6));
        } else if (object.Equals(_2139_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&mut"))) {
          return RAST.PrintingInfo.create_Precedence(new BigInteger(6));
        } else {
          return RAST.PrintingInfo.create_UnknownPrecedence();
        }
      } else if (_source66.is_BinaryOp) {
        Dafny.ISequence<Dafny.Rune> _2140___mcc_h28 = _source66.dtor_op2;
        RAST._IExpr _2141___mcc_h29 = _source66.dtor_left;
        RAST._IExpr _2142___mcc_h30 = _source66.dtor_right;
        DAST.Format._IBinaryOpFormat _2143___mcc_h31 = _source66.dtor_format2;
        DAST.Format._IBinaryOpFormat _2144_format = _2143___mcc_h31;
        RAST._IExpr _2145_right = _2142___mcc_h30;
        RAST._IExpr _2146_left = _2141___mcc_h29;
        Dafny.ISequence<Dafny.Rune> _2147_op2 = _2140___mcc_h28;
        if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(20), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(20), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(20), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("+"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(30), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("-"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(30), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<<"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(40), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(40), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(50), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("^"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(60), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("|"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(70), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("=="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(80), RAST.Associativity.create_RequiresParentheses());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(80), RAST.Associativity.create_RequiresParentheses());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(80), RAST.Associativity.create_RequiresParentheses());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(80), RAST.Associativity.create_RequiresParentheses());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(80), RAST.Associativity.create_RequiresParentheses());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(80), RAST.Associativity.create_RequiresParentheses());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&&"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(90), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("||"))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(100), RAST.Associativity.create_LeftToRight());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".."))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RequiresParentheses());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("..="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RequiresParentheses());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("+="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("-="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("|="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("^="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<<="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else if (object.Equals(_2147_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>="))) {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(110), RAST.Associativity.create_RightToLeft());
        } else {
          return RAST.PrintingInfo.create_PrecedenceAssociativity(BigInteger.Zero, RAST.Associativity.create_RequiresParentheses());
        }
      } else if (_source66.is_TypeAscription) {
        RAST._IExpr _2148___mcc_h36 = _source66.dtor_left;
        RAST._IType _2149___mcc_h37 = _source66.dtor_tpe;
        RAST._IType _2150_tpe = _2149___mcc_h37;
        RAST._IExpr _2151_left = _2148___mcc_h36;
        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(10), RAST.Associativity.create_LeftToRight());
      } else if (_source66.is_LiteralInt) {
        Dafny.ISequence<Dafny.Rune> _2152___mcc_h40 = _source66.dtor_value;
        return RAST.PrintingInfo.create_Precedence(BigInteger.One);
      } else if (_source66.is_LiteralBool) {
        bool _2153___mcc_h42 = _source66.dtor_bvalue;
        return RAST.PrintingInfo.create_Precedence(BigInteger.One);
      } else if (_source66.is_LiteralString) {
        Dafny.ISequence<Dafny.Rune> _2154___mcc_h44 = _source66.dtor_value;
        bool _2155___mcc_h45 = _source66.dtor_binary;
        return RAST.PrintingInfo.create_Precedence(BigInteger.One);
      } else if (_source66.is_DeclareVar) {
        RAST._IDeclareType _2156___mcc_h48 = _source66.dtor_declareType;
        Dafny.ISequence<Dafny.Rune> _2157___mcc_h49 = _source66.dtor_name;
        Std.Wrappers._IOption<RAST._IType> _2158___mcc_h50 = _source66.dtor_optType;
        Std.Wrappers._IOption<RAST._IExpr> _2159___mcc_h51 = _source66.dtor_optRhs;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_Assign) {
        Std.Wrappers._IOption<RAST._IAssignLhs> _2160___mcc_h56 = _source66.dtor_names;
        RAST._IExpr _2161___mcc_h57 = _source66.dtor_rhs;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_IfExpr) {
        RAST._IExpr _2162___mcc_h60 = _source66.dtor_cond;
        RAST._IExpr _2163___mcc_h61 = _source66.dtor_thn;
        RAST._IExpr _2164___mcc_h62 = _source66.dtor_els;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_Loop) {
        Std.Wrappers._IOption<RAST._IExpr> _2165___mcc_h66 = _source66.dtor_optCond;
        RAST._IExpr _2166___mcc_h67 = _source66.dtor_underlying;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_For) {
        Dafny.ISequence<Dafny.Rune> _2167___mcc_h70 = _source66.dtor_name;
        RAST._IExpr _2168___mcc_h71 = _source66.dtor_range;
        RAST._IExpr _2169___mcc_h72 = _source66.dtor_body;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_Labelled) {
        Dafny.ISequence<Dafny.Rune> _2170___mcc_h76 = _source66.dtor_lbl;
        RAST._IExpr _2171___mcc_h77 = _source66.dtor_underlying;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_Break) {
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _2172___mcc_h80 = _source66.dtor_optLbl;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_Continue) {
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _2173___mcc_h82 = _source66.dtor_optLbl;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_Return) {
        Std.Wrappers._IOption<RAST._IExpr> _2174___mcc_h84 = _source66.dtor_optExpr;
        return RAST.PrintingInfo.create_UnknownPrecedence();
      } else if (_source66.is_CallType) {
        RAST._IExpr _2175___mcc_h86 = _source66.dtor_obj;
        Dafny.ISequence<RAST._IType> _2176___mcc_h87 = _source66.dtor_typeParameters;
        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(2), RAST.Associativity.create_LeftToRight());
      } else if (_source66.is_Call) {
        RAST._IExpr _2177___mcc_h90 = _source66.dtor_obj;
        Dafny.ISequence<RAST._IExpr> _2178___mcc_h91 = _source66.dtor_arguments;
        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(2), RAST.Associativity.create_LeftToRight());
      } else if (_source66.is_Select) {
        RAST._IExpr _2179___mcc_h94 = _source66.dtor_obj;
        Dafny.ISequence<Dafny.Rune> _2180___mcc_h95 = _source66.dtor_name;
        Dafny.ISequence<Dafny.Rune> _2181_name = _2180___mcc_h95;
        RAST._IExpr _2182_underlying = _2179___mcc_h94;
        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(2), RAST.Associativity.create_LeftToRight());
      } else if (_source66.is_MemberSelect) {
        RAST._IExpr _2183___mcc_h98 = _source66.dtor_obj;
        Dafny.ISequence<Dafny.Rune> _2184___mcc_h99 = _source66.dtor_name;
        Dafny.ISequence<Dafny.Rune> _2185_name = _2184___mcc_h99;
        RAST._IExpr _2186_underlying = _2183___mcc_h98;
        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(2), RAST.Associativity.create_LeftToRight());
      } else {
        Dafny.ISequence<RAST._IFormal> _2187___mcc_h102 = _source66.dtor_params;
        Std.Wrappers._IOption<RAST._IType> _2188___mcc_h103 = _source66.dtor_retType;
        RAST._IExpr _2189___mcc_h104 = _source66.dtor_body;
        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(300), RAST.Associativity.create_LeftToRight());
      }
    } }
  }
  public class Expr_RawExpr : Expr {
    public readonly Dafny.ISequence<Dafny.Rune> _content;
    public Expr_RawExpr(Dafny.ISequence<Dafny.Rune> content) : base() {
      this._content = content;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_RawExpr(_content);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_RawExpr;
      return oth != null && object.Equals(this._content, oth._content);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._content));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.RawExpr";
      s += "(";
      s += this._content.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Expr_ExprFromType : Expr {
    public readonly RAST._IType _tpe;
    public Expr_ExprFromType(RAST._IType tpe) : base() {
      this._tpe = tpe;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_ExprFromType(_tpe);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_ExprFromType;
      return oth != null && object.Equals(this._tpe, oth._tpe);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tpe));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.ExprFromType";
      s += "(";
      s += Dafny.Helpers.ToString(this._tpe);
      s += ")";
      return s;
    }
  }
  public class Expr_Identifier : Expr {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public Expr_Identifier(Dafny.ISequence<Dafny.Rune> name) : base() {
      this._name = name;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Identifier(_name);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Identifier;
      return oth != null && object.Equals(this._name, oth._name);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Identifier";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Expr_Match : Expr {
    public readonly RAST._IExpr _matchee;
    public readonly Dafny.ISequence<RAST._IMatchCase> _cases;
    public Expr_Match(RAST._IExpr matchee, Dafny.ISequence<RAST._IMatchCase> cases) : base() {
      this._matchee = matchee;
      this._cases = cases;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Match(_matchee, _cases);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Match;
      return oth != null && object.Equals(this._matchee, oth._matchee) && object.Equals(this._cases, oth._cases);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._matchee));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._cases));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Match";
      s += "(";
      s += Dafny.Helpers.ToString(this._matchee);
      s += ", ";
      s += Dafny.Helpers.ToString(this._cases);
      s += ")";
      return s;
    }
  }
  public class Expr_StmtExpr : Expr {
    public readonly RAST._IExpr _stmt;
    public readonly RAST._IExpr _rhs;
    public Expr_StmtExpr(RAST._IExpr stmt, RAST._IExpr rhs) : base() {
      this._stmt = stmt;
      this._rhs = rhs;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_StmtExpr(_stmt, _rhs);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_StmtExpr;
      return oth != null && object.Equals(this._stmt, oth._stmt) && object.Equals(this._rhs, oth._rhs);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 4;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._stmt));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._rhs));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.StmtExpr";
      s += "(";
      s += Dafny.Helpers.ToString(this._stmt);
      s += ", ";
      s += Dafny.Helpers.ToString(this._rhs);
      s += ")";
      return s;
    }
  }
  public class Expr_Block : Expr {
    public readonly RAST._IExpr _underlying;
    public Expr_Block(RAST._IExpr underlying) : base() {
      this._underlying = underlying;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Block(_underlying);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Block;
      return oth != null && object.Equals(this._underlying, oth._underlying);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 5;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._underlying));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Block";
      s += "(";
      s += Dafny.Helpers.ToString(this._underlying);
      s += ")";
      return s;
    }
  }
  public class Expr_StructBuild : Expr {
    public readonly RAST._IExpr _underlying;
    public readonly Dafny.ISequence<RAST._IAssignIdentifier> _assignments;
    public Expr_StructBuild(RAST._IExpr underlying, Dafny.ISequence<RAST._IAssignIdentifier> assignments) : base() {
      this._underlying = underlying;
      this._assignments = assignments;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_StructBuild(_underlying, _assignments);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_StructBuild;
      return oth != null && object.Equals(this._underlying, oth._underlying) && object.Equals(this._assignments, oth._assignments);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 6;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._underlying));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._assignments));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.StructBuild";
      s += "(";
      s += Dafny.Helpers.ToString(this._underlying);
      s += ", ";
      s += Dafny.Helpers.ToString(this._assignments);
      s += ")";
      return s;
    }
  }
  public class Expr_Tuple : Expr {
    public readonly Dafny.ISequence<RAST._IExpr> _arguments;
    public Expr_Tuple(Dafny.ISequence<RAST._IExpr> arguments) : base() {
      this._arguments = arguments;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Tuple(_arguments);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Tuple;
      return oth != null && object.Equals(this._arguments, oth._arguments);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 7;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._arguments));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Tuple";
      s += "(";
      s += Dafny.Helpers.ToString(this._arguments);
      s += ")";
      return s;
    }
  }
  public class Expr_UnaryOp : Expr {
    public readonly Dafny.ISequence<Dafny.Rune> _op1;
    public readonly RAST._IExpr _underlying;
    public readonly DAST.Format._IUnaryOpFormat _format;
    public Expr_UnaryOp(Dafny.ISequence<Dafny.Rune> op1, RAST._IExpr underlying, DAST.Format._IUnaryOpFormat format) : base() {
      this._op1 = op1;
      this._underlying = underlying;
      this._format = format;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_UnaryOp(_op1, _underlying, _format);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_UnaryOp;
      return oth != null && object.Equals(this._op1, oth._op1) && object.Equals(this._underlying, oth._underlying) && object.Equals(this._format, oth._format);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 8;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._op1));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._underlying));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._format));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.UnaryOp";
      s += "(";
      s += this._op1.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._underlying);
      s += ", ";
      s += Dafny.Helpers.ToString(this._format);
      s += ")";
      return s;
    }
  }
  public class Expr_BinaryOp : Expr {
    public readonly Dafny.ISequence<Dafny.Rune> _op2;
    public readonly RAST._IExpr _left;
    public readonly RAST._IExpr _right;
    public readonly DAST.Format._IBinaryOpFormat _format2;
    public Expr_BinaryOp(Dafny.ISequence<Dafny.Rune> op2, RAST._IExpr left, RAST._IExpr right, DAST.Format._IBinaryOpFormat format2) : base() {
      this._op2 = op2;
      this._left = left;
      this._right = right;
      this._format2 = format2;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_BinaryOp(_op2, _left, _right, _format2);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_BinaryOp;
      return oth != null && object.Equals(this._op2, oth._op2) && object.Equals(this._left, oth._left) && object.Equals(this._right, oth._right) && object.Equals(this._format2, oth._format2);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 9;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._op2));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._left));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._right));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._format2));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.BinaryOp";
      s += "(";
      s += this._op2.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._left);
      s += ", ";
      s += Dafny.Helpers.ToString(this._right);
      s += ", ";
      s += Dafny.Helpers.ToString(this._format2);
      s += ")";
      return s;
    }
  }
  public class Expr_TypeAscription : Expr {
    public readonly RAST._IExpr _left;
    public readonly RAST._IType _tpe;
    public Expr_TypeAscription(RAST._IExpr left, RAST._IType tpe) : base() {
      this._left = left;
      this._tpe = tpe;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_TypeAscription(_left, _tpe);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_TypeAscription;
      return oth != null && object.Equals(this._left, oth._left) && object.Equals(this._tpe, oth._tpe);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 10;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._left));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tpe));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.TypeAscription";
      s += "(";
      s += Dafny.Helpers.ToString(this._left);
      s += ", ";
      s += Dafny.Helpers.ToString(this._tpe);
      s += ")";
      return s;
    }
  }
  public class Expr_LiteralInt : Expr {
    public readonly Dafny.ISequence<Dafny.Rune> _value;
    public Expr_LiteralInt(Dafny.ISequence<Dafny.Rune> @value) : base() {
      this._value = @value;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_LiteralInt(_value);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_LiteralInt;
      return oth != null && object.Equals(this._value, oth._value);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 11;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._value));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.LiteralInt";
      s += "(";
      s += this._value.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Expr_LiteralBool : Expr {
    public readonly bool _bvalue;
    public Expr_LiteralBool(bool bvalue) : base() {
      this._bvalue = bvalue;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_LiteralBool(_bvalue);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_LiteralBool;
      return oth != null && this._bvalue == oth._bvalue;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 12;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._bvalue));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.LiteralBool";
      s += "(";
      s += Dafny.Helpers.ToString(this._bvalue);
      s += ")";
      return s;
    }
  }
  public class Expr_LiteralString : Expr {
    public readonly Dafny.ISequence<Dafny.Rune> _value;
    public readonly bool _binary;
    public Expr_LiteralString(Dafny.ISequence<Dafny.Rune> @value, bool binary) : base() {
      this._value = @value;
      this._binary = binary;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_LiteralString(_value, _binary);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_LiteralString;
      return oth != null && object.Equals(this._value, oth._value) && this._binary == oth._binary;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 13;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._value));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._binary));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.LiteralString";
      s += "(";
      s += this._value.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._binary);
      s += ")";
      return s;
    }
  }
  public class Expr_DeclareVar : Expr {
    public readonly RAST._IDeclareType _declareType;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Std.Wrappers._IOption<RAST._IType> _optType;
    public readonly Std.Wrappers._IOption<RAST._IExpr> _optRhs;
    public Expr_DeclareVar(RAST._IDeclareType declareType, Dafny.ISequence<Dafny.Rune> name, Std.Wrappers._IOption<RAST._IType> optType, Std.Wrappers._IOption<RAST._IExpr> optRhs) : base() {
      this._declareType = declareType;
      this._name = name;
      this._optType = optType;
      this._optRhs = optRhs;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_DeclareVar(_declareType, _name, _optType, _optRhs);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_DeclareVar;
      return oth != null && object.Equals(this._declareType, oth._declareType) && object.Equals(this._name, oth._name) && object.Equals(this._optType, oth._optType) && object.Equals(this._optRhs, oth._optRhs);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 14;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._declareType));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._optType));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._optRhs));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.DeclareVar";
      s += "(";
      s += Dafny.Helpers.ToString(this._declareType);
      s += ", ";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._optType);
      s += ", ";
      s += Dafny.Helpers.ToString(this._optRhs);
      s += ")";
      return s;
    }
  }
  public class Expr_Assign : Expr {
    public readonly Std.Wrappers._IOption<RAST._IAssignLhs> _names;
    public readonly RAST._IExpr _rhs;
    public Expr_Assign(Std.Wrappers._IOption<RAST._IAssignLhs> names, RAST._IExpr rhs) : base() {
      this._names = names;
      this._rhs = rhs;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Assign(_names, _rhs);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Assign;
      return oth != null && object.Equals(this._names, oth._names) && object.Equals(this._rhs, oth._rhs);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 15;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._names));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._rhs));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Assign";
      s += "(";
      s += Dafny.Helpers.ToString(this._names);
      s += ", ";
      s += Dafny.Helpers.ToString(this._rhs);
      s += ")";
      return s;
    }
  }
  public class Expr_IfExpr : Expr {
    public readonly RAST._IExpr _cond;
    public readonly RAST._IExpr _thn;
    public readonly RAST._IExpr _els;
    public Expr_IfExpr(RAST._IExpr cond, RAST._IExpr thn, RAST._IExpr els) : base() {
      this._cond = cond;
      this._thn = thn;
      this._els = els;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_IfExpr(_cond, _thn, _els);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_IfExpr;
      return oth != null && object.Equals(this._cond, oth._cond) && object.Equals(this._thn, oth._thn) && object.Equals(this._els, oth._els);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 16;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._cond));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._thn));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._els));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.IfExpr";
      s += "(";
      s += Dafny.Helpers.ToString(this._cond);
      s += ", ";
      s += Dafny.Helpers.ToString(this._thn);
      s += ", ";
      s += Dafny.Helpers.ToString(this._els);
      s += ")";
      return s;
    }
  }
  public class Expr_Loop : Expr {
    public readonly Std.Wrappers._IOption<RAST._IExpr> _optCond;
    public readonly RAST._IExpr _underlying;
    public Expr_Loop(Std.Wrappers._IOption<RAST._IExpr> optCond, RAST._IExpr underlying) : base() {
      this._optCond = optCond;
      this._underlying = underlying;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Loop(_optCond, _underlying);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Loop;
      return oth != null && object.Equals(this._optCond, oth._optCond) && object.Equals(this._underlying, oth._underlying);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 17;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._optCond));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._underlying));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Loop";
      s += "(";
      s += Dafny.Helpers.ToString(this._optCond);
      s += ", ";
      s += Dafny.Helpers.ToString(this._underlying);
      s += ")";
      return s;
    }
  }
  public class Expr_For : Expr {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly RAST._IExpr _range;
    public readonly RAST._IExpr _body;
    public Expr_For(Dafny.ISequence<Dafny.Rune> name, RAST._IExpr range, RAST._IExpr body) : base() {
      this._name = name;
      this._range = range;
      this._body = body;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_For(_name, _range, _body);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_For;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._range, oth._range) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 18;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._range));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.For";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._range);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
  }
  public class Expr_Labelled : Expr {
    public readonly Dafny.ISequence<Dafny.Rune> _lbl;
    public readonly RAST._IExpr _underlying;
    public Expr_Labelled(Dafny.ISequence<Dafny.Rune> lbl, RAST._IExpr underlying) : base() {
      this._lbl = lbl;
      this._underlying = underlying;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Labelled(_lbl, _underlying);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Labelled;
      return oth != null && object.Equals(this._lbl, oth._lbl) && object.Equals(this._underlying, oth._underlying);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 19;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._lbl));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._underlying));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Labelled";
      s += "(";
      s += this._lbl.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._underlying);
      s += ")";
      return s;
    }
  }
  public class Expr_Break : Expr {
    public readonly Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _optLbl;
    public Expr_Break(Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> optLbl) : base() {
      this._optLbl = optLbl;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Break(_optLbl);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Break;
      return oth != null && object.Equals(this._optLbl, oth._optLbl);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 20;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._optLbl));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Break";
      s += "(";
      s += Dafny.Helpers.ToString(this._optLbl);
      s += ")";
      return s;
    }
  }
  public class Expr_Continue : Expr {
    public readonly Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _optLbl;
    public Expr_Continue(Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> optLbl) : base() {
      this._optLbl = optLbl;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Continue(_optLbl);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Continue;
      return oth != null && object.Equals(this._optLbl, oth._optLbl);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 21;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._optLbl));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Continue";
      s += "(";
      s += Dafny.Helpers.ToString(this._optLbl);
      s += ")";
      return s;
    }
  }
  public class Expr_Return : Expr {
    public readonly Std.Wrappers._IOption<RAST._IExpr> _optExpr;
    public Expr_Return(Std.Wrappers._IOption<RAST._IExpr> optExpr) : base() {
      this._optExpr = optExpr;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Return(_optExpr);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Return;
      return oth != null && object.Equals(this._optExpr, oth._optExpr);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 22;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._optExpr));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Return";
      s += "(";
      s += Dafny.Helpers.ToString(this._optExpr);
      s += ")";
      return s;
    }
  }
  public class Expr_CallType : Expr {
    public readonly RAST._IExpr _obj;
    public readonly Dafny.ISequence<RAST._IType> _typeParameters;
    public Expr_CallType(RAST._IExpr obj, Dafny.ISequence<RAST._IType> typeParameters) : base() {
      this._obj = obj;
      this._typeParameters = typeParameters;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_CallType(_obj, _typeParameters);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_CallType;
      return oth != null && object.Equals(this._obj, oth._obj) && object.Equals(this._typeParameters, oth._typeParameters);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 23;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._obj));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParameters));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.CallType";
      s += "(";
      s += Dafny.Helpers.ToString(this._obj);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeParameters);
      s += ")";
      return s;
    }
  }
  public class Expr_Call : Expr {
    public readonly RAST._IExpr _obj;
    public readonly Dafny.ISequence<RAST._IExpr> _arguments;
    public Expr_Call(RAST._IExpr obj, Dafny.ISequence<RAST._IExpr> arguments) : base() {
      this._obj = obj;
      this._arguments = arguments;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Call(_obj, _arguments);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Call;
      return oth != null && object.Equals(this._obj, oth._obj) && object.Equals(this._arguments, oth._arguments);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 24;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._obj));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._arguments));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Call";
      s += "(";
      s += Dafny.Helpers.ToString(this._obj);
      s += ", ";
      s += Dafny.Helpers.ToString(this._arguments);
      s += ")";
      return s;
    }
  }
  public class Expr_Select : Expr {
    public readonly RAST._IExpr _obj;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public Expr_Select(RAST._IExpr obj, Dafny.ISequence<Dafny.Rune> name) : base() {
      this._obj = obj;
      this._name = name;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Select(_obj, _name);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Select;
      return oth != null && object.Equals(this._obj, oth._obj) && object.Equals(this._name, oth._name);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 25;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._obj));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Select";
      s += "(";
      s += Dafny.Helpers.ToString(this._obj);
      s += ", ";
      s += this._name.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Expr_MemberSelect : Expr {
    public readonly RAST._IExpr _obj;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public Expr_MemberSelect(RAST._IExpr obj, Dafny.ISequence<Dafny.Rune> name) : base() {
      this._obj = obj;
      this._name = name;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_MemberSelect(_obj, _name);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_MemberSelect;
      return oth != null && object.Equals(this._obj, oth._obj) && object.Equals(this._name, oth._name);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 26;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._obj));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.MemberSelect";
      s += "(";
      s += Dafny.Helpers.ToString(this._obj);
      s += ", ";
      s += this._name.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Expr_Lambda : Expr {
    public readonly Dafny.ISequence<RAST._IFormal> _params;
    public readonly Std.Wrappers._IOption<RAST._IType> _retType;
    public readonly RAST._IExpr _body;
    public Expr_Lambda(Dafny.ISequence<RAST._IFormal> @params, Std.Wrappers._IOption<RAST._IType> retType, RAST._IExpr body) : base() {
      this._params = @params;
      this._retType = retType;
      this._body = body;
    }
    public override _IExpr DowncastClone() {
      if (this is _IExpr dt) { return dt; }
      return new Expr_Lambda(_params, _retType, _body);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Expr_Lambda;
      return oth != null && object.Equals(this._params, oth._params) && object.Equals(this._retType, oth._retType) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 27;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._params));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._retType));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Expr.Lambda";
      s += "(";
      s += Dafny.Helpers.ToString(this._params);
      s += ", ";
      s += Dafny.Helpers.ToString(this._retType);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
  }

  public interface _IFn {
    bool is_Fn { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams { get; }
    Dafny.ISequence<RAST._IFormal> dtor_formals { get; }
    Std.Wrappers._IOption<RAST._IType> dtor_returnType { get; }
    Dafny.ISequence<Dafny.Rune> dtor_where { get; }
    Std.Wrappers._IOption<RAST._IExpr> dtor_body { get; }
    _IFn DowncastClone();
    Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
  }
  public class Fn : _IFn {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<RAST._ITypeParamDecl> _typeParams;
    public readonly Dafny.ISequence<RAST._IFormal> _formals;
    public readonly Std.Wrappers._IOption<RAST._IType> _returnType;
    public readonly Dafny.ISequence<Dafny.Rune> _where;
    public readonly Std.Wrappers._IOption<RAST._IExpr> _body;
    public Fn(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, Dafny.ISequence<RAST._IFormal> formals, Std.Wrappers._IOption<RAST._IType> returnType, Dafny.ISequence<Dafny.Rune> @where, Std.Wrappers._IOption<RAST._IExpr> body) {
      this._name = name;
      this._typeParams = typeParams;
      this._formals = formals;
      this._returnType = returnType;
      this._where = @where;
      this._body = body;
    }
    public _IFn DowncastClone() {
      if (this is _IFn dt) { return dt; }
      return new Fn(_name, _typeParams, _formals, _returnType, _where, _body);
    }
    public override bool Equals(object other) {
      var oth = other as RAST.Fn;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._formals, oth._formals) && object.Equals(this._returnType, oth._returnType) && object.Equals(this._where, oth._where) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._formals));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._returnType));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._where));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int) hash;
    }
    public override string ToString() {
      string s = "RAST.Fn.Fn";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._formals);
      s += ", ";
      s += Dafny.Helpers.ToString(this._returnType);
      s += ", ";
      s += this._where.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
    private static readonly RAST._IFn theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._ITypeParamDecl>.Empty, Dafny.Sequence<RAST._IFormal>.Empty, Std.Wrappers.Option<RAST._IType>.Default(), Dafny.Sequence<Dafny.Rune>.Empty, Std.Wrappers.Option<RAST._IExpr>.Default());
    public static RAST._IFn Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<RAST._IFn> _TYPE = new Dafny.TypeDescriptor<RAST._IFn>(RAST.Fn.Default());
    public static Dafny.TypeDescriptor<RAST._IFn> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IFn create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, Dafny.ISequence<RAST._IFormal> formals, Std.Wrappers._IOption<RAST._IType> returnType, Dafny.ISequence<Dafny.Rune> @where, Std.Wrappers._IOption<RAST._IExpr> body) {
      return new Fn(name, typeParams, formals, returnType, @where, body);
    }
    public static _IFn create_Fn(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParamDecl> typeParams, Dafny.ISequence<RAST._IFormal> formals, Std.Wrappers._IOption<RAST._IType> returnType, Dafny.ISequence<Dafny.Rune> @where, Std.Wrappers._IOption<RAST._IExpr> body) {
      return create(name, typeParams, formals, returnType, @where, body);
    }
    public bool is_Fn { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public Dafny.ISequence<RAST._ITypeParamDecl> dtor_typeParams {
      get {
        return this._typeParams;
      }
    }
    public Dafny.ISequence<RAST._IFormal> dtor_formals {
      get {
        return this._formals;
      }
    }
    public Std.Wrappers._IOption<RAST._IType> dtor_returnType {
      get {
        return this._returnType;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_where {
      get {
        return this._where;
      }
    }
    public Std.Wrappers._IOption<RAST._IExpr> dtor_body {
      get {
        return this._body;
      }
    }
    public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind) {
      var _pat_let_tv8 = ind;
      var _pat_let_tv9 = ind;
      var _pat_let_tv10 = ind;
      var _pat_let_tv11 = ind;
      return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn "), (this).dtor_name), RAST.TypeParamDecl.ToStringMultiple((this).dtor_typeParams, ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), RAST.__default.SeqToString<RAST._IFormal>((this).dtor_formals, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IFormal, Dafny.ISequence<Dafny.Rune>>>>((_2190_ind) => ((System.Func<RAST._IFormal, Dafny.ISequence<Dafny.Rune>>)((_2191_formal) => {
        return (_2191_formal)._ToString(_2190_ind);
      })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), ((System.Func<Std.Wrappers._IOption<RAST._IType>, Dafny.ISequence<Dafny.Rune>>)((_source67) => {
        if (_source67.is_None) {
          return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
        } else {
          RAST._IType _2192___mcc_h0 = _source67.dtor_value;
          RAST._IType _2193_t = _2192___mcc_h0;
          return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" -> "), (_2193_t)._ToString(_pat_let_tv8));
        }
      }))((this).dtor_returnType)), ((((this).dtor_where).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"), ind), RAST.__default.IND), (this).dtor_where)))), ((System.Func<Std.Wrappers._IOption<RAST._IExpr>, Dafny.ISequence<Dafny.Rune>>)((_source68) => {
        if (_source68.is_None) {
          return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";");
        } else {
          RAST._IExpr _2194___mcc_h2 = _source68.dtor_value;
          RAST._IExpr _2195_body = _2194___mcc_h2;
          return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"), _pat_let_tv9), RAST.__default.IND), (_2195_body)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_pat_let_tv10, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _pat_let_tv11), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        }
      }))((this).dtor_body));
    }
  }
} // end of namespace RAST