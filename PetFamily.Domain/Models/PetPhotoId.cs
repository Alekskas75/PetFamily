public record PetPhotoId
{
    public PetPhotoId(Guid value)
    {
        this.Value = value;
    }
    public Guid Value { get; }
    public static PetPhotoId NewVolunteerId() => new(Guid.NewGuid());
    public static PetPhotoId Empty() => new(Guid.Empty);
}