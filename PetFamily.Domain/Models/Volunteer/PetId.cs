using CSharpFunctionalExtensions;

using PetFamily.Domain.Models;

public record PetId
{
    public Guid Value { get; }
    private PetId(Guid value) => Value = value;
    public static PetId NewId() => new PetId(Guid.NewGuid());
    public static PetId Empty() => new PetId(Guid.Empty);
    public static PetId Create(Guid value) => new(value);
}