namespace ExpressionSolver
{
    public class ExpressionSolver
    {
        public static double Evaluate(IEnumerator<char> e)
        {
            List<string> characters = new List<string>();

            do
            {
                char c = e.Current;

                if (char.IsDigit(c))
                {
                    characters.Add(c.ToString());
                }
                else if (c == '(')
                {
                    e.MoveNext();
                    characters.Add(Evaluate(e).ToString());
                }
                else if (c == ')')
                {
                    break;
                }
                else if ("+-*/".Contains(c))
                {
                    characters.Add(c.ToString());
                }
            }
            while (e.MoveNext());

            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i] == "*" || characters[i] == "/")
                {
                    double left = double.Parse(characters[i - 1]);
                    double right = double.Parse(characters[i + 1]);
                    double result = characters[i] == "*" ? left * right : left / right;
                    characters[i - 1] = result.ToString();
                    characters.RemoveAt(i);
                    characters.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i] == "+" || characters[i] == "-")
                {
                    double left = double.Parse(characters[i - 1]);
                    double right = double.Parse(characters[i + 1]);
                    double result = characters[i] == "+" ? left + right : left - right;
                    characters[i - 1] = result.ToString();
                    characters.RemoveAt(i);
                    characters.RemoveAt(i);
                    i--;
                }
            }

            return double.Parse(characters[0]);
        }
    }
}
