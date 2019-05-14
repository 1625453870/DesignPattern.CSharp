using DesignPattern.Builder.ActorController;
using DesignPattern.Builder.ConcreteBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var role = new RoleController().Construct(new HuaShanBuilder());
            Console.WriteLine("---------------创建华山人物----------");
            Console.WriteLine($"{role.Name}--{role.Sex}");


            role = new RoleController().Construct(new ShaoLinBuilder());
            Console.WriteLine("---------------创建少林人物----------");
            Console.WriteLine($"{role.Name}--{role.Sex}");
            Console.ReadKey();
        }
    }
}
