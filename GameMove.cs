namespace rockpaperscissors 
{
	class GameMove 
    {
        string MoveValue;

        public void SetMove(string Move)
        {
            this.MoveValue = Move;
        }

        public string GetMove()
        {
            return this.MoveValue;
        }

        public string WinningMove(GameMove OpponentMove) 
        {
            if (this.MoveValue == "rock") 
            {
                switch (OpponentMove.GetMove())
                {
                    case "rock":
                        return "tied";
                    case "paper":
                        return "lost";
                    case "scissors":
                        return "won";
                }
            }
            if (this.MoveValue == "paper") 
            {
                switch (OpponentMove.GetMove())
                {
                    case "rock":
                        return "won";
                    case "paper":
                        return "tied";
                    case "scissors":
                        return "lost";
                }
            }
            if (this.MoveValue == "scissors") 
            {
                switch (OpponentMove.GetMove())
                {
                    case "rock":
                        return "lost";
                    case "paper":
                        return "won";
                    case "scissors":
                        return "tied";
                }
            }
            return "bruh";
        }
    }
}