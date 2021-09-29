using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            TestCustomerDetailsUsingReflection();
            Console.ReadLine();
        }
        public static void TestCustomerDetailsUsingReflection()
        {
            Type type = Type.GetType("Exception058.Customer");
            Console.WriteLine("FullName :" + type.FullName);
            Console.WriteLine("Name :" + type.Name);
            PropertyInfo[] propertyInfos = type.GetProperties();
            Console.WriteLine("Fetching Customer property details");
            foreach (PropertyInfo property in propertyInfos)
            {
                Console.WriteLine("ReturnType" + property.PropertyType + "PropertyName" + property.Name);
            }
            Console.WriteLine("Fetching Customer Method Details");
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (MethodInfo method in methodInfos)
            {
                Console.WriteLine("ReturnType" + method.DeclaringType + "MethodyName" + method.Name);
            }
            Console.WriteLine("Fetching Customer Method Details");
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            foreach (ConstructorInfo info in constructorInfos)
            {
                Console.WriteLine(info.ToString());
            }
        }
    }
}
