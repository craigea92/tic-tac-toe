string[] grid = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
bool isPlayer1Turn = true;

while (true) {
  PrintGrid();

  if (isPlayer1Turn)
    Console.WriteLine("Player 1 turn!");
    else
    Console.WriteLine("Player 2 turn!");
  
  string choice = Console.ReadLine();

  if(grid.Contains(choice) && choice != "X" && choice !="O") {
    int gridIndex = Convert.ToInt32(choice) -1;

    if (isPlayer1Turn)
      grid[gridIndex] = "X";
    else
      grid[gridIndex] ="O";
  }

  isPlayer1Turn = !isPlayer1Turn;
}

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