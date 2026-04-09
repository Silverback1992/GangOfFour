using Strategy;

// 1. Setup our "Document" data
var myParagraph = new List<Component>
{
    new() { Content = "The", NaturalSize = 10, StretchAbility = 2, ShrinkAbility = 1 },
    new() { Content = "Strategy", NaturalSize = 25, StretchAbility = 5, ShrinkAbility = 2 },
    new() { Content = "Pattern", NaturalSize = 20, StretchAbility = 4, ShrinkAbility = 1 },
    new() { Content = "is", NaturalSize = 5, StretchAbility = 1, ShrinkAbility = 0 },
    new() { Content = "really", NaturalSize = 15, StretchAbility = 3, ShrinkAbility = 1 },
    new() { Content = "quite", NaturalSize = 15, StretchAbility = 3, ShrinkAbility = 1 },
    new() { Content = "powerful!", NaturalSize = 25, StretchAbility = 5, ShrinkAbility = 2 }
};

// 2. Try the Simple (Greedy) Strategy
// It will break lines whenever the NaturalSize exceeds the width (e.g., 50)
Console.WriteLine("SCENARIO 1: QUICK DRAFT");
var draftDoc = new Composition(new SimpleCompositor(), myParagraph, 50);
draftDoc.Repair();

// 3. Try the Array Strategy
// It ignores sizes and just breaks every 3 words
Console.WriteLine("\nSCENARIO 2: GRID LAYOUT");
var gridDoc = new Composition(new ArrayCompositor(3), myParagraph, 100);
gridDoc.Repair();

// 4. Try the TeX Strategy
// (Uses our dummy logic that pretends to be smart)
Console.WriteLine("\nSCENARIO 3: HIGH-QUALITY PRINT");
var printDoc = new Composition(new TeXCompositor(), myParagraph, 100);
printDoc.Repair();
