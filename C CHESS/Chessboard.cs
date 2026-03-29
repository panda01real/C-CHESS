namespace ChessGUI;

public class Chessboard
{
    private Piece?[,] _squares; // array de piezas para poder acceder a cada pieza más facil
    // SI AGREGO "?" LUEGO DE EL TIPO EN UN ARRAY ESTOY INDICANDO QUE QUIERO QUE HAYAN VALORES NULL.

    public Chessboard()
    {
        _squares = new Piece[8, 8];
    }

    public void SetPiece(int row, int column, Piece piece)
    {
        //Chequear si el input es valido
        if ((row >= 8|| column >= 8) || (row < 0 || column < 0))
        {
            Console.WriteLine("Invalid row or column");
            return;
        }
        //Chequear si la posicion esta ocupada, para ocuparla
        if (_squares[row, column] == null)
        {
            //Colocar pieza
            _squares[row, column] = piece;
        }
        else
        {
            Console.WriteLine("There's already a piece in this square!");
        }
    }

    public void GetPiece(int row, int column)
    {
        // imprimir que pieza esta en la posicion indicada
    }

    public void DrawBoard()
    {
        //Dibuja una preview del gamestate
    }

}