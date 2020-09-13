public class MyCircularDeque
{

    private readonly int _capacity;
    private readonly int[] _arr;
    private int _head = 0;
    private int _tail = 0;

    /** Initialize your data structure here. Set the size of the deque to be k. */
    public MyCircularDeque(int k)
    {
        _capacity = k + 1;
        _arr = new int[k + 1];
    }

    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value)
    {
        if (IsFull()) return false;
        _head = (_head - 1 + _capacity) % _capacity;
        _arr[_head] = value;
        return true;
    }

    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value)
    {
        if (IsFull()) return false;
        _arr[_tail] = value;
        _tail = (_tail + 1) % _capacity;
        return true;
    }

    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront()
    {
        if (IsEmpty()) return false;
        _head = (_head + 1) % _capacity;
        return true;
    }

    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast()
    {
        if (IsEmpty()) return false;
        _tail = (_tail - 1 + _capacity) % _capacity;
        return true;
    }

    /** Get the front item from the deque. */
    public int GetFront()
    {
        if (IsEmpty()) return -1;
        return _arr[_head];
    }

    /** Get the last item from the deque. */
    public int GetRear()
    {
        if (IsEmpty()) return -1;
        return _arr[(_tail - 1 + _capacity) % _capacity];
    }

    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty()
    {
        return _head == _tail;
    }

    /** Checks whether the circular deque is full or not. */
    public bool IsFull()
    {
        return (_tail + 1) % _capacity == _head;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */
