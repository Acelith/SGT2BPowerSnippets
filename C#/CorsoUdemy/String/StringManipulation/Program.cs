namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0. define some variable
            int age = 37;
            string name = "Simone";
            string country = "Switzerland";

            // 1. string concatenation
            Console.WriteLine("string concatenation");
            Console.WriteLine("Hello my name is " + name 
                + ", I am " + age + " years old");

            // 2. string formatting (uses indext {0} or {1} or {2} ecc)
            Console.WriteLine("\nstring formatting");
            Console.WriteLine("Hello my name is {0}," +
                " I am {1} years old and i live in {2}",name, age, country);

            // 3. string interpolation (uses $ at the start wich will 
            //    allow us to write our variable like this {varName}
            Console.WriteLine("\nstring interpolation");
            Console.WriteLine($"Hello my name is {name}," +
                $" I am {age} years old and i live in {country}");

            // 4. verbatim strings (start with @ and tells the compiler to
            //    take the string literally and ignore any space and escape
            //    characters like \n)
            Console.WriteLine("\nstring verbatim");
            Console.WriteLine(@"            Lorem ipsum dolor sit, amet consectetur adipisicing elit. 

                Aperiam odit nisi doloribus nihil nostrum accusamus unde velit nulla, atque magnam inventore, 
            perferendis quidem voluptatem nam at beatae tempore consectetur ipsam eum amet eius, facilis ad. 

                Nostrum vitae quo ullam nihil saepe voluptas eum, totam ex perspiciatis in quis pariatur quaerat 
            hic error mollitia modi fugit neque explicabo alias nam illum, eius provident vero maiores. 

                Est dolor reiciendis esse architecto, fugiat praesentium laboriosam odit totam vel asperiores amet 
            ex enim ab illum incidunt expedita aut dicta, ducimus nemo repudiandae, obcaecati officia eaque et! 

                Cupiditate neque architecto est sapiente iste consequatur earum?");
            // intead of using \\ to write file path we can use verbation string
            // to make it easier if you remove @ you'll get an error becouse
            // \U, \A and \D ar not valid escape char
            Console.WriteLine("C:\\Documenti\\Scuola\\Progetti\\udemy\\C#");
            Console.WriteLine(@"C:\Documenti\Scuola\Progetti\udemy\C#");
            // all the special characters do not work in the verbation string
            Console.WriteLine(@"they don't work anymore! \n\t");
        }
    }
}