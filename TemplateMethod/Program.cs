using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Save();
            Post post = new Post();
            post.Save();
            Console.ReadKey();
        }
    }
}
