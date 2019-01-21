using System;

namespace _04___Fourth_Event_Example
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BoxTrainer boxtrainer = new BoxTrainer();
            boxtrainer.TrainerName = "Krasimir Ivanov";

            Trainee junior = new Trainee();
            junior.Name = "Ivan";
            junior.ParticipateInBoxingClass(boxtrainer);

            Trainee juniorTwo = new Trainee();
            juniorTwo.Name = "Georgi";
            juniorTwo.ParticipateInBoxingClass(boxtrainer);

            Trainee juniorThree = new Trainee();
            juniorThree.Name = "Evgeni";
            juniorThree.ParticipateInBoxingClass(boxtrainer);

            DateEventArguments dateOfTraining = new DateEventArguments();
            dateOfTraining.Date = DateTime.Now;
            boxtrainer.StartTraining(boxtrainer.TrainerName, dateOfTraining);
        }
    }
    public class BoxTrainer
    {
        public string TrainerName { get; set; }

        public event EventHandler BoxTraining;
        public void StartTraining(string name, DateEventArguments date)
        {
            this.BoxTraining(new BoxTrainer { TrainerName = name}, new DateEventArguments{ Date = date.Date });
        }
    }
    public class Trainee
    {
        public string Name { get; set; }

        public void ParticipateInBoxingClass(BoxTrainer trainer)
        {
            trainer.BoxTraining += Trainer_BoxTraining;
        }

        private void Trainer_BoxTraining(object sender, EventArgs e)
        {
            BoxTrainer trainer = sender as BoxTrainer;
            DateEventArguments boxDetails = e as DateEventArguments;

            Console.WriteLine($"{this.Name} will go to have a boxing workout to mr. {trainer.TrainerName} at {boxDetails.Date}");
        }
    }

    public class DateEventArguments : EventArgs
    {
        public DateTime Date { get; set; }
    }
}
