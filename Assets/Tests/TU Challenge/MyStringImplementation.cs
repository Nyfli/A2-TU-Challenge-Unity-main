using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        internal static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null) return true;

            if (input.Length == 0) return true;

            foreach (char c in input)
            {
                if (c != ' ')
                    return false;
            }
            return true;
        }

        internal static string MixString(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                throw new ArgumentException("non nulle et non vides");
            }

            StringBuilder sb = new StringBuilder();

            int minLength = (a.Length < b.Length) ? a.Length : b.Length;
            for (int i = 0; i < minLength; i++)
            {
                sb.Append(a[i]);
                sb.Append(b[i]);
            }

            if (a.Length > minLength)
            {
                sb.Append(a.Substring(minLength));
            }
            else if (b.Length > minLength)
            {
                sb.Append(b.Substring(minLength));
            }

            return sb.ToString();
        }

        internal static string ToLowerCase(string a)
        {
            if (a == null) return null;

            StringBuilder sb = new StringBuilder(a.Length);
            foreach (char c in a)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    char lower = (char)(c + 32);
                    sb.Append(lower);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        internal static string Voyelles(string a)
        {
            if (string.IsNullOrEmpty(a)) return "";

            string voyels = "aeiou";
            StringBuilder result = new StringBuilder();
            HashSet<char> usedVowels = new HashSet<char>();

            foreach (char c in a)
            {
                char lower = c;
                if (c >= 'A' && c <= 'Z')
                {
                    lower = (char)(c + 32);
                }

                if (voyels.Contains(lower))
                {
                    if (!usedVowels.Contains(lower))
                    {
                        usedVowels.Add(lower);
                        result.Append(lower);
                    }
                }
            }
            return result.ToString();
        }

        public static string Reverse(string s)
        {
            if (s == null) return null;

            StringBuilder sb = new StringBuilder(s.Length);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }

        internal static string BazardString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            StringBuilder sb = new StringBuilder(input.Length);

            for (int i = 0; i < input.Length; i += 2)
            {
                sb.Append(input[i]);
            }

            for (int i = 1; i < input.Length; i += 2)
            {
                sb.Append(input[i]);
            }

            return sb.ToString();
        }

        internal static string UnBazardString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            int length = input.Length;
            int chunkEvenLength = (length + 1) / 2;

            string chunkEven = input.Substring(0, chunkEvenLength);
            string chunkOdd = input.Substring(chunkEvenLength);

            StringBuilder sb = new StringBuilder(length);

            int min = (chunkEven.Length < chunkOdd.Length) ? chunkEven.Length : chunkOdd.Length;
            for (int i = 0; i < min; i++)
            {
                sb.Append(chunkEven[i]);
                sb.Append(chunkOdd[i]);
            }

            if (chunkEven.Length > chunkOdd.Length)
            {
                sb.Append(chunkEven[chunkEven.Length - 1]);
            }

            return sb.ToString();
        }

        internal static string ToCesarCode(string input, int offset)
        {
            if (string.IsNullOrEmpty(input)) return input;

            offset = offset % 26;
            if (offset < 0) offset += 26;

            StringBuilder sb = new StringBuilder(input.Length);
            foreach (char c in input)
            {
                if (c >= 'a' && c <= 'z')
                {
                    int basePos = c - 'a';
                    int newPos = (basePos + offset) % 26;
                    char newChar = (char)('a' + newPos);
                    sb.Append(newChar);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}