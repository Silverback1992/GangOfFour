namespace Facade;

public class LexicalAnalysis
{
    public List<Token> Analyze(string input)
    {
        var tokens = new List<Token>();

        foreach (var split in input.Split(' '))
        {
            if (int.TryParse(split, out var number))
            {
                tokens.Add(new Token { Value = $"NUMBER({split})" });
            }

            if (split == "+")
            {
                tokens.Add(new Token { Value = "PLUS" });
            }
        }

        return tokens;
    }
}
