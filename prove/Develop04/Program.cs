using System;

class Program
{
    static void Main(string[] args)
    {

        int on = 1;
        while(on == 1){
            Console.Clear();
            Console.WriteLine("Menu Options:\n  1.Start breathing activity\n  2.Start reflecting activity\n  3.Start listing activity\n  4.Quit.\nSelect a choice from the menu: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1){
                startBreathing();

            }
            if(choice == 2){
                startReflecting();

            }
            if(choice == 3){
                startListing();


            }

            if(choice == 4){
                on = 0;
            }

        }


        void startReflecting(){

                string name = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                ReflectingActivity reflect1 = new ReflectingActivity(name, description );
                Console.Clear();
                reflect1.displayStart();
                reflect1.makeDuration();
                Console.Clear();
                reflect1.displayRelfection();
                reflect1.endMessage();
                reflect1.spinner();
        }

        void startBreathing(){


        string name = "Breathing Activity";
        string description = "This activity will help you relax by walking through your breathing.";
        BreathingActivity breath1 = new BreathingActivity(name, description);
        Console.Clear();
        breath1.displayStart();
        breath1.makeDuration();
        Console.Clear();
        breath1.displayBreath();
        Console.Clear();
        breath1.endMessage();
        breath1.spinner();
        }
        void startListing(){
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity list1 = new ListingActivity(name, description);
                Console.Clear();
                list1.displayStart();
                list1.makeDuration();
                Console.Clear();
                list1.displayListingActivity();
                list1.endMessage();
                list1.spinner();
        }

    }
}