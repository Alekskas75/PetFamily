namespace PetFamily.Domain
{
    public class Pet
    {
        public Pet() { }
        public int Id { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public string PetDescription { get; set; }
        public string PetBreed { get; set; }
        public string PetColor { get; set; }
        public string PetHealthInformation { get; set; } = string.Empty;
        public string PetAddress { get; set; } = string.Empty;
        public decimal Weight { get; set; }
        public decimal Breed { get; set; }        
        public string TelephoneNumberForContacting{ get; set; }
        public bool Neutered { get; set; }     // Кастрирован?
        public DateTime DateOfBirth { get; set; }
        public bool Vaccinated { get; set; }  //Вакцинирован?
        public string Status { get; set; }  //Статус помощи - Нуждается в помощи/Ищет дом/Нашел дом
        public string HelpDetails { get; set; }  //Реквизиты для помощи (у каждого реквизита будет название и описание, как сделать перевод), поэтому нужно сделать отдельный класс для реквизита
        public DateTime CreationDate { get; set; }
        public List<PetPhoto> PetPhotos { get; set; }
    }

}
