public class DB
{
    public int X;
    public int Y;
    public bool finished = false;

    public int parentX;
    public int parentY;

    public int angle;
    public bool isGrey = false;

    public bool isSmoothened = false;

    public DB()
    {
    }

    public DB(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public override bool Equals(object obj)
    {
        DB db = (DB)obj;

        return this.X == db.X && this.Y == db.Y;
    }

    public override int GetHashCode()
    {
        // unchecked
        // {
        //     var result = 0;
        //     result = (result * 397) ^ this.X;
        //     result = (result * 397) ^ this.Y;
        //     return result;
        // }

        return 0;
    }
}