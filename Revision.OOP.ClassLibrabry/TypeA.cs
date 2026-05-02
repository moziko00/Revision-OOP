using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Common
{
    /// What you can write inside the NameSpace
    /// 1. Class
    /// 2. Interface
    /// 3. Struct
    /// 4. Enum
    /// 5. Delegate
    /// 6. Record
    /// 7. Nested Namespace

    /// Allowed Access Modifiers inside the Namespace
    /// 1. public
    /// 2. internal [Default Access Modifier]
    /// file


    public class TypeA
    {
        /// What you can write inside the Class
        /// 1.  Field ( Attributes , Member Variables )
        /// 2.  Property (Full property, Auto Property)
        /// 3.  Indexer  (Special Property)
        /// 4.  Method ( Function )
        /// 5.  Constructor 
        /// 6.  Destructor
        /// 7.  Operators
        /// 8.  Event
        /// 9.  nested Type ( Class, Interface, Struct, Enum, Delegate, Record )
        /// 10. Static Members ( Static Field, Static Property, Static Method, Static Constructor, Static Destructor, Static Nested Type )

        /// What is Allowed Access Modifiers inside the Class
        /// 1. public
        /// 2. private [Default Access Modifier]
        /// 3. protected
        /// 4. internal
        /// 5. protected internal
        /// 6. private protected



    }

    public struct TypeZ
    {
        /// What you can write inside the Struct
        /// 1.  Field(Attributes , Member Variables)
        /// 2.  Property (Full property, Auto Property)
        /// 3.  Indexer  (Special Property)
        /// 4.  Method ( Function )
        /// 5.  Constructor 
        /// 6.  Operators
        /// 7.  Event
        /// 8.  nested Type ( Class, Interface, Struct, Enum, Delegate, Record )

        /// What is Allowed Access Modifiers inside the struct
        /// 1. public
        /// 2. private [Default Access Modifier]
        /// 3. internal


    }

    public interface IBehaviour
    {
        /// What you can write inside the Interface
        /// 1. Signature of Method ( Function )
        /// 2. Signature of Property (Full property, Auto Property)
        /// 3. Default Implementation of Method ( Function )
        /// 4. Static Members ( Static Method, Static Property, Static Constructor, Static Destructor, Static Nested Type )

        /// What is Allowed Access Modifiers inside the Interface
        /// 1. public [Default Access Modifier]
        /// 2. internal 
        /// 3. protected internal
        /// 4. private protected
        /// 5. Protected


    }
}

