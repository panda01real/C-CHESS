namespace ChessGUI;

public class Chessboard
{
    private Piece[,] _squares; // array de piezas para poder acceder a cada pieza más facil

    public Chessboard()
    {
        _squares = new Piece[8, 8];
    }

    public void SetPiece(int x, int y, Piece piece)
    {
        //metodo para spawnear una pieza en la posicion indicada
        //chequear si ya hay una pieza en la posicion indicada
        //_squares[x, y] = new Int32;
    }

    public void GetPiece(int x, int y)
    {
        // imprimir que pieza esta en la posicion indicada
    }

    public void DrawBoard()
    {
        //Dibuja una preview del gamestate
    }

}