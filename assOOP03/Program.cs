namespace assOOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Q1_part1
            //a) A University has Departments. If the university is closed, the departments no longer exist.
            //Composition
            //b) A Driver uses a Car. The driver does not own the car.
            // Association
            //c) A Dog is an Animal.
            //Inheritance
            //d) A Team has Players. If the team is deleted, the players still exist.
            //Aggregation
            //e) A method receives a Logger as a parameter and calls it inside the method only.
            //Dependency
            #endregion
            #region Q2_Part1
            //a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?
            //yes / can't access
            //b) What is the difference between protected internal and private protected?
            //protected internal -> can access inside and outside assembly/private protected-> can access inside only assembly 
            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            //we can't inhert from this class /we can't override the method
            //d) Can you create an object from a sealed class using new? Why or why not?
            //yes we can but we can't inhert from it 
            #endregion
        }
    }
}
