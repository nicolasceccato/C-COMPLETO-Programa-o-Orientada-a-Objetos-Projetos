namespace Exceptions.Entities.ProgramExceptions;

public class DomainException : ApplicationException
{
    public DomainException(string? message) : base(message)
    {
    }
}