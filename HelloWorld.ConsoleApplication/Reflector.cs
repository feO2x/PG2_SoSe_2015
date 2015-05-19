using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class Reflector
    {
        public void ReflectOn(object @object)
        {
            Type type = @object.GetType();
            ReflectOn(type, @object);
        }

        public void ReflectOn<T>()
        {
            Type type = typeof(T);
            ReflectOn(type, null);
        }

        private void ReflectOn(Type type, object @object)
        {
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {

                Console.WriteLine(propertyInfo.Name);
                if (propertyInfo.Name == "Vorname")
                {
                    propertyInfo.GetSetMethod().Invoke(@object, new object[] { "Hodor" });
                }

                var value = propertyInfo.GetGetMethod().Invoke(@object, null);
                Console.WriteLine(value);



                Console.WriteLine();
            }


        }
    }
}
