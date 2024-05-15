namespace NDatastore.Common.Domain.Exceptions;

public class EntityAlreadyExistsException : Exception
{
    public EntityAlreadyExistsException()
    {
    }

    public EntityAlreadyExistsException(string? message) : base(message)
    {
    }

    public EntityAlreadyExistsException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public static EntityAlreadyExistsException FromTypeAndName(string type, string identifier)
    {
        return new EntityAlreadyExistsException(
            $"Entity of type '{type}' with identifier '{identifier}' already exists");
    }
}