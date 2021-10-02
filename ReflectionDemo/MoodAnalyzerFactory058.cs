using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class MoodAnalyzerFactory058
    {
        /// <summary>
        /// Creats the mood analyzer object.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructor">The constructor.</param>
        /// <returns></returns>
        /// <exception cref="ReflectionDemo.CustomMoodAnalyzerException">
        /// class not found
        /// or
        /// constructor not found
        /// </exception>
        public object CreatMoodAnalyzerObject(string className, string constructor)
        {
            string pattern = "." + constructor + "$";
            Match result = System.Text.RegularExpressions.Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyzerType = assembly.GetType(className);
                    var res = Activator.CreateInstance(moodAnalyzerType);
                    return res;
                }
                catch (Exception)
                {
                    throw new CustomMoodAnalyzerException(CustomMoodAnalyzerException.ExceptionType.CLASS_NOT_FOUND, "class not found");
                }
            }
            else
            {
                throw new CustomMoodAnalyzerException(CustomMoodAnalyzerException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor not found");
            }
        }
        /// <summary>
        /// Creates the mood analyzer parametarized object.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructor">The constructor.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        /// <exception cref="ReflectionDemo.CustomMoodAnalyzerException">
        /// constructor not found
        /// or
        /// class not found
        /// </exception>
        /// <exception cref="System.Exception"></exception>
        public object CreateMoodAnalyzerParametarizedObject(string className, string constructor, string message)
        {
            try
            {
                Type type = typeof(MoodAnalyzer);
                if (type.Name.Equals(className) || type.FullName.Equals(className))
                {
                    if (type.Name.Equals(constructor))
                    {
                        ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                        var obj = constructorInfo.Invoke(new object[] { message });
                        return obj;
                    }
                    else
                        throw new CustomMoodAnalyzerException(CustomMoodAnalyzerException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor not found");
                }
                else
                {
                    throw new CustomMoodAnalyzerException(CustomMoodAnalyzerException.ExceptionType.CLASS_NOT_FOUND, "class not found");
                }
            }
            catch(CustomMoodAnalyzerException ex)
            {
                throw new CustomMoodAnalyzerException(CustomMoodAnalyzerException.ExceptionType.CONSTRUCTOR_NOT_FOUND, ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Invokes the analyzer method.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <returns></returns>
        /// <exception cref="ReflectionDemo.CustomMoodAnalyzerException">method not found</exception>
        public string InvokeAnalyzerMethod(string message, string methodName)
        {
            try
            {
                Type type = typeof(MoodAnalyzer);
                MethodInfo methodInfo = type.GetMethod(methodName);
                MoodAnalyzerFactory058 factory058 = new MoodAnalyzerFactory058();
                object moodAnalyzerObject = factory058.CreateMoodAnalyzerParametarizedObject("ReflectionDemo.MoodAnalyzer", "MoodAnalyzer", message);
                object info = methodInfo.Invoke(moodAnalyzerObject, null);
                return info.ToString();
            }
            catch (CustomMoodAnalyzerException ex)
            {
                throw new CustomMoodAnalyzerException(CustomMoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, ex.Message);
            }
        }
        
    }
}
    
