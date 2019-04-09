namespace Arrays
{
    public class NumberOfIslands
    {

        public static void Main(string[] args)
        {
            NumberOfIslands ns = new NumberOfIslands();
            char[,] M = new char[,] {{'1', '1', '0', '0', '0'},
                                    {'1', '1', '0', '0', '0'},
                                    {'0', '0', '1', '0', '0'},
                                    {'0', '0', '0', '1', '1'}};

            int result = ns.NumIslands(M);
        }
        // These arrays are used to  
        // get row and column numbers 
        // of 8 neighbors of a given cell 
        readonly public int[] rowNbr = new int[] { -1, 0, 0, 1 };
        readonly public int[] colNbr = new int[] { 0, -1, 1, 0 };


        bool isSafe(char[,] grid, int row,
                       int col, bool[,] visited)
        {
            // row number is in range,  
            // column number is in range 
            // and value is 1 and not  
            // yet visited 
            int ROW = grid.GetLength(0);
            int COLUMN = grid.GetLength(1);
            return (row >= 0) && (row < ROW) &&
                   (col >= 0) && (col < COLUMN) &&
                   (grid[row, col] == '1' &&
                   !visited[row, col]);
        }

        void DFS(char[,] grid, int row,
                    int col, bool[,] visited)
        {

            // Mark this cell 
            // as visited 
            visited[row, col] = true;
            

            // Recur for all  
            // connected neighbours 
            for (int a = 0; a < 4; a++)
            {
                if (isSafe(grid, row + rowNbr[a], col +
                               colNbr[a], visited))
                {
                    DFS(grid, row + rowNbr[a], col + colNbr[a], visited);
                }
            }
        }
        public int NumIslands(char[,] grid)
        {
            int ROW = grid.GetLength(0);
            int COLUMN = grid.GetLength(1);

            bool[,] visited = new bool[ROW, COLUMN];

            int count = 0;

            for (int i = 0; i < ROW; ++i)
            {
                for (int j = 0; j < COLUMN; ++j)
                {
                    if (grid[i, j] == '1' && !visited[i, j])
                    {
                        DFS(grid, i, j, visited);
                        ++count;
                    }
                }
            }

            return count;
        }

    }
}
