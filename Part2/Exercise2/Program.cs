using System;

namespace Exercise2
{
    class Graph
    {
        int[,] adj = new int[6, 6]
        {
            { 0, 1, 0, 1, 0, 0 },
            { 1, 0, 1, 1, 0, 0 },
            { 1, 0, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 1, 0 },
            { 0, 0, 0, 1, 0, 1 },
            { 0, 0, 0, 0, 1, 0 },
        };

        List<int>[] adj2 = new List<int>[]
        {
            new List<int>(){ 1, 3},
            new List<int>(){ 0, 2, 3},
            new List<int>(){ 1 },
            new List<int>(){ 0, 1, 4},
            new List<int>(){ 3, 5},
            new List<int>(){ 4 },
        };

        bool[] visted = new bool[6];

        public void DFS(int now)
        {
            Console.WriteLine(now);
            visted[now] = true;

            for (int next = 0; next < 6; next++)
            {
                if (adj[now, next] == 0) // 미연결 패스
                    continue;

                if (visted[next])  // 이미 방문한곳이면 패스
                    continue;

                DFS(next);

            }
        }

        public void DFS2(int now)
        {
            Console.WriteLine(now);
            visted[now] = true;

            foreach (int next in adj2[now])
            {
                if (visted[next])  // 이미 방문한곳이면 패스
                    continue;

                DFS2(next);
            }
        }

        public void SearchAll()
        {
            visted = new bool[6];
            for (int now = 0; now < 6; now++)
            {
                if (visted[now] == false)
                    DFS(now);
            }
        }

        
        public void BFS(int start)
        {
            bool[] found = new bool[6];
            int[] parent = new int[6];
            int[] distance = new int[6];

            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            found[start] = true;
            parent[start] = start;
            distance[start] = 0;

            while(q.Count > 0)
            {
                int now = q.Dequeue();
                Console.WriteLine(now);

                for (int next = 0; next < 6; next++)
                {
                    if (adj[now, next] == 0) // 인접하지 않으면 스킵
                        continue;
                    if (found[next]) // 이미 발견한애라면 스킵
                        continue;

                    q.Enqueue(next);
                    found[next] = true;
                    parent[next] = now;
                    distance[next] = distance[now] + 1;
                }
            }
        }
    }

   

    class Program
    {
        static void Main(string[] args)
        {
            //DFS (깊이 우선 탐색)
            //BFS (너비 우선 탐색)

            Graph graph = new Graph();
            graph.BFS(0);
        }
    }
}