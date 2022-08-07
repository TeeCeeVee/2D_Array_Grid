

Console.WriteLine("How tall will the 2d array be? (rows)");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("How wide will the 2d array be? (cols)");
int cols = int.Parse(Console.ReadLine());

int[,] grid = new int[rows, cols];
Console.WriteLine("Time to fill in the 2d array.");

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.WriteLine("grid[{0}, {1}]", row, col);
        grid[row, col] = int.Parse(Console.ReadLine());
        
    }
}
Console.WriteLine();
//print the grid

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(grid[row, col] + " ");
    }
    Console.WriteLine();
}