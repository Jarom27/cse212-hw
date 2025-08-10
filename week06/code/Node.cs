public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value == Data)
        {
            return;
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }

    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            if (Left is null)
            {
                return false;
            }
            return Left.Contains(value);
        }
        else
        {
            if (Right is null)
            {
                return false;
            }
            return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int counter = 1;
        int leftCounter = 0;
        int rightCounter = 0;
        if (Left is not null)
        {
            leftCounter += Left.GetHeight();
        }
        if (Right is not null) {
            rightCounter += Right.GetHeight();
        }
        counter += leftCounter < rightCounter ? rightCounter : leftCounter;
        return counter;

    }
}