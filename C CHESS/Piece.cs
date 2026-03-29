namespace ChessGUI;

public abstract class Piece
{
    private string _pieceName; //nombre de la pieza (caballo, torre, etc...)
    private int _piecePos; //posicion de la pieza (e5, d7, una cosa asi xd)
    
    public Piece(string name, int pos)
    {
        name = _pieceName;
        pos = _piecePos;
    }
}