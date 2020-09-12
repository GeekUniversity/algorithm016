public class MinStack
{

    /** initialize your data structure here. */

    private Stack<int> _stack = new Stack<int>();
    private Stack<int[]> _minStack = new Stack<int[]>();

    public MinStack()
    {

    }

    public void Push(int x)
    {
        _stack.Push(x);

        if (!_minStack.Any() || _minStack.Peek()[0] > x)
        {
            _minStack.Push(new int[] { x, 1 });
        }
        else if (_minStack.Peek()[0] == x)
        {
            ++_minStack.Peek()[1];
        }
    }

    public void Pop()
    {
        var p = _stack.Pop();

        if (_minStack.Peek()[0] == p)
        {
            --_minStack.Peek()[1];
            if (_minStack.Peek()[1] == 0)
            {
                _minStack.Pop();
            }
        }
    }

    public int Top()
    {
        return _stack.Peek();
    }

    public int GetMin()
    {
        return _minStack.Peek()[0];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
