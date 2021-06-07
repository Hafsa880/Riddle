
using System;
using System.Text;
using System.Threading.Tasks;
 
namespace Assignment.riddle_assignment
{
    enum Nationality { British, Danish, German, Swedish, Norwegian };
 
    enum Drink { Water, Tea, Beer, Milk, Coffee };
 
    enum Pet { Horse, Dog, Cat, Bird, Fish };
 
    enum Cigarette { Dunhill, Blends, Pall Mall,Prince, Blue Master };
 
    enum Color { White, Blue, Green, Red, Yellow };
 
    class Inhabitant
    {
        Cigarette cigBrand;
        Drink drink;
        Pet pet;
        Nationality nationality;
 
        public Inhabitant()
        {
 
        }
    }
 
    class House
    {
        public Color color;
        public int index;
        public Cigarette cigBrand;
        public Drink drink;
        public Pet pet;
        public Nationality nationality;
 
        public House()
        {
 
        }
    }
    class RiddleAssignment
    {
        House A;
        House B;
        House C;
        House D;
        House E;
 
        public RiddleAssignment()
        {
            
            this.A = new House();
            this.B = new House();
            this.C = new House();
            this.D = new House();
            this.E = new House();
 
            
            A.nationality = Nationality.English;
            A.color = Color.Red;
 
           
            B.pet = Pet.Horse;
            B.nationality = Nationality.Danish;
 
           
            C.nationality = Nationality.German;
            C.drink = Drink.Coffee;
 
          
            D.nationality = Nationality.Norwegian;
            D.index = 0;
 
            
            E.nationality = Nationality.Swedish;
            E.cigBrand = Cigarette.Blue Master;
 
            
        }
    }
}