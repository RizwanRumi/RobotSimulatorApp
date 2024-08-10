public class RobotSimulator {
    private IMove selectedMove;
    private IRotation rotation;

    public RobotSimulator() {
        this.selectedMove = null;
        this.rotation = null;
    }

    // Dependency injection implemented in both move and selectedRotation methods
    public void move(DataBlock block) {
        if (block.getCurrentDirection() == Direction.N) {
            selectedMove = new MoveUp();
            block.setCurrentRow(selectedMove.move(block.getCurrentRow(), 0));
        } 
        else if (block.getCurrentDirection() == Direction.E) {
            selectedMove = new MoveRight();
            block.setCurrentColumn(selectedMove.move(block.getCurrentColumn(), block.getColumns()));
        } 
        else if (block.getCurrentDirection() == Direction.S) {
            selectedMove = new MoveDown();
            block.setCurrentRow(selectedMove.move(block.getCurrentRow(), block.getRows()));
        } 
        else if (block.getCurrentDirection() == Direction.W) {
            selectedMove = new MoveLeft();
            block.setCurrentColumn(selectedMove.move(block.getCurrentColumn(), 0));
        }
    }

    public Direction selectedRotation(IRotation rotation, Direction currentDirection) {
        this.rotation = rotation;
        return this.rotation.rotate(currentDirection);
    }
}
