using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    // enum - an enum is a value type defined by a set of named constants of the underlying integral numberic type.
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
    // This particular enum is accessible from anywhere within this class - that is the SCOPE of this enum

    // 1 - Access modifier (public)     
    // 2 - keyword/type (enum)   
    // 3 - keyword identifier/name (GenreType)
    // Standard convention: name should be PascalCase

    // 1    //2   //3
    public enum GenreType
    {
        // 1 - constant name (the value you want to display/use)
        // 2 - integral numeric type
        // The numeric type starts, by default, at 0. Here we have "re-indexed" it to start at 1
          //1    //2
        Horror = 1,
        RomCom,
        SciFi,
        Documentary,
        Bromance,
        Drama,
        Action
    }

    // Class - this is the "blueprint" used for creating objects of this type.
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes
    // 

    // 1 - Access modifier (public)     
    // 2 - keyword/type (enum)   
    // 3 - keyword identifier/name (GenreType)
    // Standard convention: name should be PascalCase
      //1    //2       //3
    public class StreamingContent
    {
        // This is considered to be a POCO which stands for: Plain Old C# Object
        // It is also, sometimes referred to as a Plain Old Class Object or several other variations

        // prop [tab][tab] is a shortcut that can be used for creating a property 
        // Properties are members that provide a flexible mechanism to read, write, or compute the value of a private field
        // Properties - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGenre { get; set; }

        // ctor [tab][tab] is a shortcut that can be used for creating a constructor for a class that you are working in
        // Constructors are a special kind of method that creates a new instance of a class
        // Constructors are designated by a "public" access modifier and the name of the class

        // 1 - Access modifier (public)
        // 2 - class name (a constructor is always named the same as the class - this is the nature of a constructor
        // 3 - parameters for the constructor. Parameters define the arguments that can be passed in to this particular constructor
        //     These parameters are used to set property values during the construction portion of the object creation
        //     Empty () designates a "blank" constructor. This is created by default when a class is coded, but, as soon as another constructor is created,
        //          the empty constructor is no longer available and must be defined separately (as shown here)

         // 1       // 2       //3
        public StreamingContent() { }
        public StreamingContent(string title, string description, string marturityRating, double starRating, bool isFamilyFriendly, GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = marturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = genre;
        }
    }
}
