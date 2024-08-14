public record PetId
{        
    public PetId(Guid value)
    {
        this.Value = value;
    }
    public Guid Value { get; }
    public static PetId NewVolunteerId() => new(Guid.NewGuid());
    public static PetId Empty() => new(Guid.Empty);
}