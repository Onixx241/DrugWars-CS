namespace prog {

    public class program {
        class drugs{
            public string coke = "Coke";

            public string weed = "Weed";

            public string shrooms = "Shrooms";

            public string heroin = "Heroin";

            static void BuyDrugs(int money){

                Console.WriteLine("What Drugs Would You Like To Buy?");

                Console.WriteLine(weed);

                Console.WriteLine(shrooms);

                Console.WriteLine(heroin);

                Console.WriteLine(coke);
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1){
                    money - 250;
                    Console.WriteLine($"Money After Purchase: {money}");
                }


            }

                        
        }
        class person {

            public string name;

            public int money = 500;

            

            public string level;



            public int Work() {
                
                
                if (this.money >= 0) {

                    this.money = this.money + 500;
                    
                    
                }

                return this.money;
                
            }

            public string nameSelect() {

                this.name = Console.ReadLine();

                return this.name;
            }
        
        }

        

        static void Main(String[] args)
        {
            person Player = new person();
            
            drugs drugz = new drugs();
            //keep going here and drugs method..

            int round = 1;

            bool mainLoop = true;

            places placeList = new places();

            Console.WriteLine($"Money: {Player.money}");

            while(mainLoop){
                // Display message , Ask user for name , load choices (travel , buy , sell)
                Console.WriteLine("Welcome To Drug Wars");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice){

                    case 1:
                        Console.WriteLine("Travel");
                        Console.WriteLine(placeList.placeList[0] + "\n" + placeList.placeList[1]);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Buy");
                        drugs.b
                        break;
                    case 3: 
                        Console.WriteLine("Sell");
                        break;
                    case 4:
                        Console.WriteLine("Inventory");
                        break;
                }

                round++;
            }

        }
    
    }

}
