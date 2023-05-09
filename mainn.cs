namespace prog {

    public class program {

        class person {

            public string name;

            public int money = 500;

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
            
            bool mainLoop = true;

            while(mainLoop){

            }

        }
    
    }

}
