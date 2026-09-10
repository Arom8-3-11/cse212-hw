/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    // Index 0 is the front of the queue. New people added at the end.
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        // Appending puts new arrivals behind everyone already waiting.
        _queue.Add(person);
    }

    public Person Dequeue()
    {
        // Remove the person who has waited the longest (the front item).
        var person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}