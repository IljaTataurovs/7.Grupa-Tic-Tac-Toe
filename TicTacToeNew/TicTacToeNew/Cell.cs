namespace TicTacToeNew
{
    public class Cell
    {
        FIELD fieldState = FIELD.Blank;

        public Cell()
        {
            fieldState = FIELD.Blank;
        }
        public FIELD GetFieldState()
        {
            return fieldState;
        }
        public bool isEmpty()
        {
            if (fieldState != FIELD.Blank)
                return false;
            return true;
        }

        public void markField(Player player)
        {
            if (isEmpty())
            {
                if (player.GetSign() == 'X')
                    fieldState = FIELD.PlayerX;
                else
                    fieldState = FIELD.PlayerO;

            }


        }

    }
}