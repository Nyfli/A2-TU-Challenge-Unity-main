using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class Pathfinding
    {
        public Pathfinding(string map1)
        {
            string[] lines = map1.Split('\n');

            Grid = new char[lines.Length, lines[0].Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Replace("\r", "");
                for (int j = 0; j < line.Length; j++)
                {
                    Grid[i, j] = line[j];
                }
            }
        }

        public char[,] Grid { get; internal set; }

        internal bool IsOutOfBound(Vector2 vector2)
        {
            return vector2.X < 0
                   || vector2.X >= Grid.GetLength(0)
                   || vector2.Y < 0
                   || vector2.Y >= Grid.GetLength(1);
        }

        internal List<char> GetNeighboors(Vector2 vector2)
        {
            List<char> neighbors = new List<char>();

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0)
                        continue;

                    int nx = vector2.X + dx;
                    int ny = vector2.Y + dy;
                    Vector2 newPos = new Vector2(nx, ny);

                    if (!IsOutOfBound(newPos) && Grid[nx, ny] != 'X')
                    {
                        neighbors.Add(Grid[nx, ny]);
                    }
                }
            }

            return neighbors;
        }

        internal List<char> GetNeighboors(Vector2 vector2, List<Vector2> exclude)
        {
            throw new NotImplementedException();
        }

        internal Path BreadthFirstSearch(Vector2 start, Vector2 destination)
        {
            throw new NotImplementedException();
        }

        internal char GetCoord(Vector2 el)
        {
            throw new NotImplementedException();
        }
    }
}
