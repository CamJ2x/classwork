package Pet;
// Every class in Java is part of a package
// First thing your to do is create a new class is create a new package

//Data: Name of the Pet
//      Type of Pet
//      Gender
//      Weight
//      Is it spayed or neutered?
public class Pet {
    private String  petName;
    private String  petType;
    private char    petGender;
    private int     petWeight;
    private boolean isSpayed;

    public Pet(String petName, String petType, char petGender, int petWeight, boolean isSpayed){
        this.petName = petName;
        this.petType = petType;
        this.petGender = petGender;
        this.petWeight = petWeight;
        this.isSpayed = isSpayed;
    }

    public String getPetName() {
        return petName;
    }

    public void setPetName(String petName) {
        this.petName = petName;
    }

    public char getPetGender() {
        return petGender;
    }

    public void setPetGender(char petGender) {
        this.petGender = petGender;
    }

    public String getPetType() {
        return petType;
    }

    public void setPetType(String petType) {
        this.petType = petType;
    }

    public int getPetWeight() {
        return petWeight;
    }

    public void setPetWeight(int petWeight) {
        this.petWeight = petWeight;
    }

    public boolean isSpayed() {
        return isSpayed;
    }

    public void setSpayed(boolean spayed) {
        isSpayed = spayed;
    }
}

