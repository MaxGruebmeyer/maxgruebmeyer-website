namespace Website.Interfaces;

public enum ProblemClassification
{
    // Leave some space in between these numbers so we can easily add some in between in the future.
    // And use powers of two so we can do some bitwise tricks with them.
    Unknown = 0,
    RealAnalysis = 1 << 0,
    ComplexAnalysis = 1 << 1,
    LinearAlgebra = 1 << 5,
    DiscreteMath = 1 << 10,
    Combinatorics = 1 << 11,
    GraphTheoryy = 1 << 12,
    DSA = 1 << 15,
};
