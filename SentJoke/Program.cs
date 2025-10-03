namespace SentJoke
{

    public class Joke(string jokeMessage)
    {
        public string JokeMessage = jokeMessage;

        public string SetJoke()
        {
            return this.JokeMessage;


        }

        public static string GetAnswer(string answer)
        {

            return answer;
        }


    }

    public class Program
    {
        public static void Main(string[] args)
        {

            if (args.Length.Equals(0))
            {

                string jokeOne = "1: Why Did the Chicken Cross The Road";
                string jokeTwo = "2: What is Wrong with me";
                Joke joke = new(jokeOne);
                Joke joke2 = new(jokeTwo);


                if (joke.JokeMessage.Equals(jokeOne))
                {
                    string answer = Joke.GetAnswer("Answer is: To Get to the other side");

                    Console.WriteLine(joke.SetJoke() + " " +  answer);

                }


                if (joke2.JokeMessage.Equals(jokeTwo))
                {

                    string answer = Joke.GetAnswer("Answer is: I Currently Been asking my self that Everyday");

                    Console.WriteLine(joke2.SetJoke() + " " + answer);

                }

                Console.ReadLine();
            }

        }


    }

}