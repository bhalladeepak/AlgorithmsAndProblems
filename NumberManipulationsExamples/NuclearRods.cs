using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    public static class NuclearRods
    {
        //1. Find connected rods using union
        //2/ Determing the cost 
        public static int minimalCost(int n, string[] pairs)
        {
            try
            {
                if (n == 0) throw new ArgumentNullException(nameof(n));
                if (pairs.Length == 0) throw new ArgumentNullException(nameof(pairs));
                    

                int[] rank, parent, count;
                rank = new int[n + 1];
                parent = new int[n + 1];
                count = new int[n + 1];

                for (int i = 1; i <= n; i++)
                {
                    parent[i] = i;
                    count[i] = 1;
                }

                foreach (var pair in pairs)
                {
                    String[] xy = pair.Split(' ');
                    int x = int.Parse(xy[0]);
                    int y = int.Parse(xy[1]);
                    union(x, y, parent, rank, count);
                }

                int res = 0;
                for (int z = 0; z < count.Length; z++)
                {
                    if (count[z] > 1)
                    {
                        res += (int) Math.Ceiling(Math.Sqrt(count[z]));
                    }
                    else
                    {
                        res += count[z];
                    }
                }

                return res;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int find(int x, int[] parent)
        {
            if (parent[x] != x)
            {
                parent[x] = find(parent[x], parent);
            }
            return parent[x];
        }

        public static void union(int x, int y, int[] parent, int[] rank, int[] count)
        {
            int xRoot = find(x, parent);
            int yRoot = find(y, parent);
            if (xRoot == yRoot)
                return;
            if (rank[xRoot] < rank[yRoot])
            {
                parent[xRoot] = yRoot;
                count[yRoot] += count[xRoot];
                count[xRoot] = 0;
            }
            else if (rank[yRoot] < rank[xRoot])
            {
                parent[yRoot] = xRoot;
                count[xRoot] += count[yRoot];
                count[yRoot] = 0;
            }
            else
            {
                parent[yRoot] = xRoot;
                count[xRoot] += count[yRoot];
                count[yRoot] = 0;
                rank[xRoot] = rank[xRoot] + 1;
            }
        }
    }
}
