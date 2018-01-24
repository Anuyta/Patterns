using System.Collections.Generic;
using System.Drawing;

namespace Flyweight
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> _chars = new Dictionary<char, Character>();

        public Character GetCharacter(char key, Bitmap image = null)
        {
            if (!_chars.ContainsKey(key))
            {
                if (key == ' ')
                {
                    _chars.Add(key, new Whitespace());
                }
                else
                {
                    _chars.Add(key, new LatinCharacter { Symbol = key, Image = image });
                }
            }
            return _chars[key];
        }
    }
}
