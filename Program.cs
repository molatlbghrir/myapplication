using System;

namespace robot
{
   /*
    1) Application (Console)
    2) class contains all operators (+ - * / %)
    3
   */
    class test {
        public string myvariable { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x");
            int x = int.Parse(Console.ReadLine());
             Console.WriteLine("enter y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter operator");
            char _operator = char.Parse(Console.ReadLine());

            if(_operator == '/') {
              
            }
            if (_operator == '+')
            {
                Console.WriteLine("this is + operation");
            }

           Console.ReadKey();
        }

       /*
          N: y + 1
          S: y - 1
          E: x + 1,
          O: x - 1
          Command: AAARAALAA (A => Avancer, R => right, L => left)
       */
        static void RobotMakeMoove(int MaxX, int MaxY, 
                int RobotCurrentPosX,
                 int RobotCurrentPosY = 0,
                 char RobotOrientation = 'S', string COMMAND = "AARLAAAARA") {
            //loop 
           Plus(5, 6);
            foreach(char character in COMMAND) {
                switch(character){
                    case 'A':
                    /* code */
                    switch(RobotOrientation){
                        case 'N':
                        RobotCurrentPosX = RobotCurrentPosX - 1;
                        break;

                        case 'S':
                        RobotCurrentPosX = RobotCurrentPosX + 1;
                        break;

                        case 'O':
                        RobotCurrentPosY = RobotCurrentPosY - 1;
                        break;

                        case 'E':
                        RobotCurrentPosY = RobotCurrentPosY + 1;
                        break;
                    }
                    break;



                    case 'R':
                                    /* code */
                    switch(RobotOrientation){
                        case 'N':
                        RobotOrientation = 'E';
                        break;

                        case 'S':
                        RobotOrientation = 'O';
                        break;

                        case 'O':
                        RobotOrientation = 'N';
                        break;

                        case 'E':
                        RobotOrientation = 'S';
                        break;
                    }
                    break;


                    case 'L':
                                            /* code */
                    switch(RobotOrientation){
                        case 'N':
                        RobotOrientation = 'O';
                        break;

                        case 'S':
                        RobotOrientation = 'E';
                        break;

                        case 'O':
                        RobotOrientation = 'S';
                        break;

                        case 'E':
                        RobotOrientation = 'N';
                        break;
                    }
                    break;
                }
            }


          /*
          Lambda expressions 
          */
          string Result = (RobotCurrentPosX > MaxX || RobotCurrentPosY > MaxY || 
                                  RobotCurrentPosX < 0 || RobotCurrentPosY < 0) 
                                       ? "Operation successful" : "Operation not successful";
          Console.WriteLine(Result);
          Console.WriteLine("[" + RobotCurrentPosX + "," + RobotCurrentPosY + "]");
        Console.WriteLine(RobotOrientation);
        }

  

        static int Plus(int x, int y){
           var a =  x + y;
          
           return a;
        }
    }

}
