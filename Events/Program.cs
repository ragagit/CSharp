using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Event
They provide notification to clients of a change.
Declaring an Event
	First we define the delegate
		public delegate void ChangeEventHandler(object sender, EventArgs e);
	Then we declare the event itself
		public event ChangeEventHandler Changed;

Subscribers
	Declare a method that matches the delegate 
	private void ListChange(object sender, EventArgs e){
    }

Add this method to the event delegate
	List.Changed += new ChangeEventHandler(ListChanged);

Invoke the Event
	if(Changed != null)
	Change(this, e)

Standard Event Patterns
	It must have a void return type
	It must accept two arguments the first the object and the second a subclass of EventsArgs
	Its name must end with EventHandler

Not invokable if class extended

Lambda expressions
    delegate int f(int x, inty) = (x,y) => x * y

    Func<int, int, int> func1 = (x,y) => x * y + y;
    func1(2, 5);

Outer variables
    int i = 0;
    Func<int> count = () => i;
 */
 
namespace ConsoleApplication5_2
{
    public delegate void GameListener(object sender, EventArgs e);
    class GameEvent
    {
        public event GameListener gameChanged;
        int homeScore, vistorScore;

        public GameEvent()
        {
            homeScore = vistorScore = 0;
        }

        protected void OnChange(EventArgs e)
        {
            if (gameChanged != null)
                gameChanged(this, e);
        }

        public void addHome()
        {
            homeScore++;
            OnChange(EventArgs.Empty);
        }
        public void addVisitor()
        {
            vistorScore++;
            OnChange(EventArgs.Empty);
        }
    }

    class ScoreBoard
    {
        private GameEvent gameEvent;

        public ScoreBoard(GameEvent ge){
            gameEvent = ge;
            //gameEvent.gameChanged += ScoreChanged;
            gameEvent.gameChanged += (object s, EventArgs e) => Console.WriteLine("Score Changed Lambda") ;
        }
        private void ScoreChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Score Changed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GameEvent ge = new GameEvent();
            ScoreBoard sb = new ScoreBoard(ge);

            ge.addHome();
            ge.addVisitor();
        }
    }
}
