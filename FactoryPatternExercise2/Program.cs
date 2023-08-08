namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use: a List, SQL, or Mongo?");
            var answer = Console.ReadLine();

            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(answer);

            dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}
