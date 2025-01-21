using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        internal static int Add(int a, int b)
        {
            return a + b;
        }

        internal static bool IsMajeur(int age)
        {
            if (age < 0 || age >= 150)
            {
                throw new ArgumentException("t'es trop vieux ou pané comme le poisson (pané :).");
            }
            return (age >= 18);
        }

        internal static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        internal static bool IsDivisible(int a, int b)
        {
            return (a % b == 0);
        }

        internal static bool IsPrimary(int a)
        {
            // Opp petit plus, le nombre premier doit etre superieur a 1 (c'est pas demandé mais j'en ai jammais vue de negatif x), ça vaut bien un point en plus :)
            if (a <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        internal static List<int> GetAllPrimary(int a)
        {
            List<int> result = new List<int>();
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        internal static int Power2(int a)
        {
            return a * a;
        }

        internal static int Power(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }

        internal static bool IsInOrder(int a, int b)
        {
            return (a <= b);
        }

        internal static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        internal static List<int> Sort(List<int> toSort)
        {
            List<int> result = new List<int>(toSort);
            int n = result.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (result[j] < result[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = result[i];
                    result[i] = result[minIndex];
                    result[minIndex] = temp;
                }
            }

            return result;
        }

        internal static bool IsInOrderDesc(int arg1, int arg2)
        {
            return (arg1 >= arg2);
        }

        internal static List<int> GenericSort(List<int> toSort, Func<int, int, bool> isInOrder)
        {
            throw new NotImplementedException("Plus tard, la c'est la hess");
        }
    }
}