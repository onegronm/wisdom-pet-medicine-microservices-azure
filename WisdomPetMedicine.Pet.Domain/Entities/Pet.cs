using System;
using WisdomPetMedicine.Pet.Domain.ValueObjects;

namespace WisdomPetMedicine.Pet.Domain.Entities
{
    public class Pet {
        public Guid Id { get; init; }
        // public PetName Name { get; private set; }
        public PetBreed Breed { get; private set; }
        // public SexOfPet SexOfPet { get; private set; }
        // public PetColor Color { get; private set; }
        // public PetDateOfBirth DateOfBirth { get; private set; }
        // public PetSpecies Species { get; private set; }
    }
}