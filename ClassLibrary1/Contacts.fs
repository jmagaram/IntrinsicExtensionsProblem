namespace Contacts

module AddressBookTypes =

    type Person = { FirstName: string; LastName: string }

module AddressBookFunctions =

    open AddressBookTypes

    let fullName (p: Person) = p.FirstName + " " + p.LastName

    type Person with
        member public me.FullName = me |> fullName

    // This works as expected
    let getFullName1 (p: Person) = p.FullName

module SomeOtherModule =

    open AddressBookTypes
    open AddressBookFunctions

    // This works too but only if I also "open AddressBookFunctions"
    // Seems to behave like an extension method
    let getFullName2 (p: Person) = p.FullName
