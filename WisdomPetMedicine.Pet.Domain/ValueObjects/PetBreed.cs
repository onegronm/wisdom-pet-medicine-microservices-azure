namespace WisdomPetMedicine.Pet.Domain.ValueObjects 
{
    public record PetBreed
    {
        public string Value { get; init; }

        internal PetBreed(string value) {
            Value = value;
        }

        public static PetBreed Create(string value, IBreedService breedService)
        {
            //Validate(value, breedService);
            return new PetBreed(value);
        }
    }

    public interface IBreedService{
        
    }
}