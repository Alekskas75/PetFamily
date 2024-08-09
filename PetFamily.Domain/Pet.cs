namespace PetFamily.Domain
{
    public class Pet
    {
        public Pet() { }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string HealthInformation { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public decimal Weight { get; set; }
        public string TelephoneNumberForContacting { get; set; }
        public bool Neutered { get; set; }     // Кастрирован?
        public DateTime DateOfBirth { get; set; }
        public bool Vaccinated { get; set; }  //Вакцинирован?
        public enum Status { NeedsHelp, LookingHome, FoundHome }  //Статус помощи - Нуждается в помощи/Ищет дом/Нашел дом
        public List<HelpDetails> DetailsForHelp { get; set; }  //Реквизиты для помощи (у каждого реквизита будет название и описание, как сделать перевод), поэтому нужно сделать отдельный класс для реквизита
        public DateTime CreationDate { get; set; }
    }
}