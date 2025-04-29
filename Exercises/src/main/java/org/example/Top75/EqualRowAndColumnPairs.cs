public class EqualRowAndColumnPairs {
    public int EqualPairs(int[][] grid) {
        Dictionary<string, int> rows = new Dictionary<string,int>();
        Dictionary<string, int> cols = new Dictionary<string,int>();

        for(int i =0;i<grid.Length;i++)
        {
            StringBuilder sb = new StringBuilder();
            for(int j=0;j<grid[0].Length;j++)
            {
                sb.Append(grid[i][j]+"_");
            }
            var kek = sb.ToString();
            if(rows.TryGetValue(kek, out int value))
            {
                rows[kek]++;
            } else{
                rows[kek] = 1;;
            }
            sb.Clear();
        }
        int count = 0;
        for(int i =0;i<grid.Length;i++)
        {
            StringBuilder sb = new StringBuilder();
            for(int j=0;j<grid[0].Length;j++)
            {
                sb.Append(grid[j][i]+"_");
            }
            var kek = sb.ToString();
            if(rows.TryGetValue(kek,out int value))
            {
                count += value;
            }
            sb.Clear();
        }
        return count;
    }
}

/* 
 */