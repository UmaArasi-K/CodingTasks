namespace ExpressionSolver
{
    public class ExpressionValidator
    {
        public static bool IsValidExpression(string expr)
        {
            if (string.IsNullOrWhiteSpace(expr))
                return false;

            if (!(char.IsDigit(expr[0]) || expr[0] == '('))
                return false;
            if (!(char.IsDigit(expr[^1]) || expr[^1] == ')'))
                return false;

            char prev = ' ';
            int bracketCount = 0;

            foreach (char c in expr)
            {
                switch (c)
                {
                    case char ch when char.IsDigit(ch) || ch == '.':
                        break;

                    case '+' or '-' or '*' or '/' :
                        if (prev == '+' || prev == '-' || prev == '*' || prev == '/')
                            return false;
                        break;

                    case '(':
                        bracketCount++;
                        break;

                    case ')':
                        bracketCount--;
                        if (bracketCount < 0) 
                            return false;
                        break;

                    default:
                        return false; 
                }
                prev = c;
            }

            return bracketCount == 0;
        }
    }
}
