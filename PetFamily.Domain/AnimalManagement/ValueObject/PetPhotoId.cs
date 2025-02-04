﻿public record PetPhotoId
{
    public Guid Id { get; }
    private PetPhotoId(Guid id) => Id = id;

    public static PetPhotoId NewId() => new PetPhotoId(Guid.NewGuid());
    public static PetPhotoId Empty() => new PetPhotoId(Guid.Empty);
    public static PetPhotoId Create(Guid id) => new(id);
}