import java.util.ArrayList;
import java.util.List;

enum Direction {
    N, E, S, W;
}

class DataBlock {
    private int rows;
    private int columns;
    private int currentRow;
    private int currentColumn;
    private Direction currentDirection;
    private String commands;

    // Getter for rows
    public int getRows() {
        return rows;
    }

    // Getter for columns
    public int getColumns() {
        return columns;
    }

    // Getter for currentRow
    public int getCurrentRow() {
        return currentRow;
    }

    // Setter for currentRow
    public void setCurrentRow(int currentRow) {
        this.currentRow = currentRow;
    }

    // Getter for currentColumn
    public int getCurrentColumn() {
        return currentColumn;
    }

    // Setter for currentColumn
    public void setCurrentColumn(int currentColumn) {
        this.currentColumn = currentColumn;
    }

    // Getter for currentDirection
    public Direction getCurrentDirection() {
        return currentDirection;
    }

    // Setter for currentDirection
    public void setCurrentDirection(Direction currentDirection) {
        this.currentDirection = currentDirection;
    }

    // Getter for commands
    public String getCommands() {
        return commands;
    }

    // Setter for commands
    public void setCommands(String commands) {
        this.commands = commands;
    }


    public DataBlock(int rows, int columns, int currentRow, int currentColumn, Direction currentDirection, String commands) {
        this.rows = rows;
        this.columns = columns;
        this.currentRow = currentRow;
        this.currentColumn = currentColumn;
        this.currentDirection = currentDirection;
        this.commands = commands;
    }

}

