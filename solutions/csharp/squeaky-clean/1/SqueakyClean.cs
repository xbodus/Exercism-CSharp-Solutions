using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var cleanBuilder = new StringBuilder();
        bool uppercaseNext = false;
        
        foreach (char c in identifier)
        {
            if (Char.IsWhiteSpace(c))
            {
                cleanBuilder.Append("_");
            } 
            else if (Char.IsControl(c))
            {
                cleanBuilder.Append("CTRL");
            }
            else if (c.Equals('-'))
            {
                uppercaseNext = true;
                continue;
            }
            else if ((Char.IsLower(c) && c >= '\u03B1' && c <= '\u03C9') || !Char.IsLetter(c))
            {
                continue;
            }
            else
            {
                cleanBuilder.Append(uppercaseNext ? Char.ToUpper(c) : c);
                uppercaseNext = false;
            }
        }

        return cleanBuilder.ToString();
    }
}
