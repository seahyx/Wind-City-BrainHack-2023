

public class Tile {
    private int x;
    private int y;
    private string type;

    public Tile(int x, int y, string type) {
        this.x = x;
        this.y = y;
        this.type = type;
    }

    public int GetX() {
        return x;
    }

    public int GetY() {
        return y;
    }

    public string GetType() {
        return type;
    }
}
