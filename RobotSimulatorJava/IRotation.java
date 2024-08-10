// Design pattern: Factory method
public interface IRotation {
    Direction rotate(Direction direction);
}

class RotateRight implements IRotation {
    @Override
    public Direction rotate(Direction direction) {
        return Direction.values()[(direction.ordinal() + 1) % 4];
    }
}

class RotateLeft implements IRotation {
    @Override
    public Direction rotate(Direction direction) {
        return Direction.values()[(direction.ordinal() + 3) % 4];
    }
}
