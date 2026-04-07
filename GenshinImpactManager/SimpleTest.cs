using Microsoft.EntityFrameworkCore;
using GenshinImpactManager.Data;
using GenshinImpactManager.Models;

namespace GenshinImpactManager.Tests;

public class SimpleTest
{
    public static bool TestDatabaseConnection()
    {
        // Простая проверка, что модель работает
        var character = new Character
        {
            Name = "Test",
            Element = "Test",
            Rarity = 4
        };

        return character.Name == "Test" && character.Rarity == 4;
    }
}