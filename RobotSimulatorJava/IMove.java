// Interface declaration
public interface IMove {
    int move(int position, int boundary);
}

// Class that implements IMove to move up
class MoveUp implements IMove {
    @Override
    public int move(int position, int boundary) {
        int row = position;
        if (row > 0) row--;
        return row;
    }
}

// Class that implements IMove to move down
class MoveDown implements IMove {
    @Override
    public int move(int position, int boundary) {
        int row = position;
        int maxRows = boundary;

        if (row < maxRows - 1) row++;
        return row;
    }
}

// Class that implements IMove to move right
class MoveRight implements IMove {
    @Override
    public int move(int position, int boundary) {
        int col = position;
        int maxCols = boundary;

        if (col < maxCols - 1) col++;
        return col;
    }
}

// Class that implements IMove to move left
class MoveLeft implements IMove {
    @Override
    public int move(int position, int boundary) {
        int col = position;
        if (col > 0) col--;
        return col;
    }
}
