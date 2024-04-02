string[] grid = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
PrintGrid();

// Void is an effective tool, it enables us to design a method to carry out operations without returning data
void PrintGrid(){
  for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
      Console.Write(grid[i * 3 + j] + "|");
    }
    Console.WriteLine();
    Console.WriteLine("------");
  }
}