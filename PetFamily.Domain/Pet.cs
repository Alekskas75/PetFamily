﻿namespace PetFamily.Domain
{
    public class Pet
    {
        public Pet() { }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Species { get; private set; }
        public string Description { get; private set; }
        public string Breed { get; private set; }
        public string Color { get; private set; }
        public string HealthInformation { get; private set; } = string.Empty;
        public string Address { get; private set; } = string.Empty;
        public decimal Weight { get; private set; }
        public string PhoneNumber { get; private set; }
        public bool IsNeutered { get; private set; }     // Кастрирован?
        public DateTime DateOfBirth { get; private set; }
        public bool IsVaccinated { get; private set; }  //Вакцинирован?
        public enum Status { NeedsHelp, LookingHome, FoundHome }  //Статус помощи - Нуждается в помощи/Ищет дом/Нашел дом
        public List<Requisites> Requisites;  //Реквизиты для помощи (у каждого реквизита будет название и описание, как сделать перевод), поэтому нужно сделать отдельный класс для реквизита
        public DateTime CreationDate { get; private set; }
    }
}