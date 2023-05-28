namespace prog {

    public class program {
        class places{

            public string[] placeList = {"New York", "Miami"};

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
            int round = 1;
            bool mainLoop = true;
            places placeList = new places();
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
