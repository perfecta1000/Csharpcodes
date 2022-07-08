// See https://aka.ms/new-console-template for more information
namespace Animal_Categories
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalFarm> ANIMAL = new List<AnimalFarm>()
            {
            new AnimalFarm("snake", "snake habitat is snakery", "snake is canivorus animal", true, "snake are categorized as wild animals", "snake are oviviparus"),
            new AnimalFarm("frog", "Frogs can both live as aquatic and terrestrial ", "frog is a canivorus", true, "Amphibians", "man are oviviparus"),
            new AnimalFarm("Man", "Terrestrial", "ominivorus", true, "higher animals", "oviviparus"),
            new AnimalFarm("Sheep", "terrestrial ", "Herbivorous", true, "sheep are macro  animal and are also which are domestic animals", "oviviparus"),
            new AnimalFarm("Mosquito", "aboreal", "canivorous (priecing and sucking with mandibles)", true, "categorized as insecta", "Mosquito are viviparus"),
            };

            Console.WriteLine();
            foreach (var animals in ANIMAL)
            {
                Console.WriteLine(animals.Name);
                Console.WriteLine(animals.habitat);
            }
        }

            //{
            //    List<AnimalFarm> ANIMA = new List<AnimalFarm>();
            //    ANIMA.Add(new AnimalFarm() { Name = "snake", habitat = "snake habitat is snakery", Feeding = "snake is canivorus animal", Movement = true, category = "snake are categorized as wild animals", Reproduction = "snake are oviviparus" });
            //    ANIMA.Add(new AnimalFarm() { Name = "frog", habitat = "Frogs can both live as aquatic and terrestrial ", Feeding = "frog is a canivorus", Movement = true, category = "Amphibians", Reproduction = "man are oviviparus" });
            //    ANIMA.Add(new AnimalFarm() { Name = "Man", habitat = "Terrestrial", Feeding = "ominivorus", Movement = true, category = "higher animals", Reproduction = "oviviparus" });
            //    ANIMA.Add(new AnimalFarm() { Name = "Sheep", habitat = "terrestrial ", Feeding = "Herbivorous", Movement = true, category = "sheep are macro  animal and are also which are domestic animals", Reproduction = "oviviparus" });
            //    ANIMAL.Add(new AnimalFarm() { Name = "Mosquito", habitat = "aboreal", Feeding = "canivorous (priecing and sucking with mandibles)", Movement = true, category = "categorized as insecta", Reproduction = "Mosquito are viviparus" });
            //}
            //foreach(AnimalFarm animals in ANIMAL)
            //{
            //    Console.WriteLine(animals.Name);
            //}

        
        //Console.WriteLine();
        //foreach (AnimalFarm animals in ANIMAL)
        //{
        //    Console.WriteLine(animals);
        //}

        //AnimalFarm Animal1 = new AnimalFarm();
        //Animal1.Name = "snake";
        //Animal1.habitat = " Snake habitat is snakery";
        //Animal1.Feeding = " snake is a canivorus animal";
        //Animal1.Movement = true;
        //Animal1.category = "Snake are categories as wild animals";
        //Animal1.Reproduction = "snake are oviviparus";


        //AnimalFarm Animal2 = new AnimalFarm();
        //Animal2.Name = "frog";
        //Animal2.habitat = "Frogs can both live as aquatic and terrestrial ";
        //Animal2.Feeding = "frog is a canivorus";
        //Animal2.Movement = true;
        //Animal2.category = "Amphibians";
        //Animal2.Reproduction = "Frogs are Viviparus";

        //AnimalFarm Animal3 = new AnimalFarm();
        //Animal3.Name = "Man";
        //Animal3.habitat = "Terrestrial";
        //Animal3.Feeding = "Ominivorous";
        //Animal3.Movement = true;
        //Animal3.category = "Man are categorized as hgiger animal";
        //Animal3.Reproduction = "man are oviviparus";

        //AnimalFarm Animal4 = new AnimalFarm();
        //Animal4.Name = "Sheep";
        //Animal4.habitat = "Terrestrial";
        //Animal4.Feeding = "Herbivorous";
        //Animal4.Movement = true;
        //Animal4.category = "sheep are macro  animal and are also which are domestic animals ";
        //Animal4.Reproduction = "Sheep are oviviparus";

        //AnimalFarm Animal5 = new AnimalFarm();
        //Animal5.Name = "Mosquito";
        //Animal5.habitat = "aboreal";
        //Animal5.Feeding = "canivorous (priecing and sucking with mandibles)";
        //Animal5.Movement = true;
        //Animal5.category = "categorized as insecta";
        //Animal4.Reproduction = "Mosquito are viviparus.";

        //AnimalFarm Animal6 = new AnimalFarm("fish", "aquatic", "carnivorus", true, "categorized as cold blooded animals", "fishes are oviparous");
        //Console.WriteLine(Animal4.Name);
    }
}


