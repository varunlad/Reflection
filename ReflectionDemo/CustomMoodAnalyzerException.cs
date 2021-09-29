using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class CustomMoodAnalyzerException : Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            EMPTY_TYPE_EXCEPTION,
            INVALID_MOOD_EXCEPTION,
            CLASS_NOT_FOUND,
            CONSTRUCTOR_NOT_FOUND
        }
        public CustomMoodAnalyzerException(ExceptionType type, string massage) : base(massage)
        {
            this.type = type;
        }
    }
}
