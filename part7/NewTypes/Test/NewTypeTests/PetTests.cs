using System;
using NUnit.Framework;
using Pets;


public class PetTests
{
    [Test]
    public void DogTalkToOwnerReturnWoof()
    {
        string expected = "Woof!";
        string actual = new Dog().TalkToOwner();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CatTalkToOwnerReturnMeow()
    {
        string expected = "Meow!";
        string actual = new Cat().TalkToOwner();

        Assert.AreEqual(expected, actual);   
    }
}
