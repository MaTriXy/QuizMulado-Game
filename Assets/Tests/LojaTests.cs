using NUnit.Framework;
using UnityEngine;
using System.Reflection;
using System.Collections.Generic;

public class LojaTests
{
    [Test]
    public void AtivarRecompensa_ShouldGenerateAllPoderIds()
    {
        var gameObject = new GameObject();
        var loja = gameObject.AddComponent<Loja>();

        MethodInfo method = typeof(Loja).GetMethod("AtivarRecompensa", BindingFlags.NonPublic | BindingFlags.Instance);
        FieldInfo field = typeof(Loja).GetField("poderid", BindingFlags.NonPublic | BindingFlags.Instance);

        Assert.IsNotNull(method);
        Assert.IsNotNull(field);

        HashSet<int> valores = new HashSet<int>();
        for (int i = 0; i < 1000 && valores.Count < 4; i++)
        {
            method.Invoke(loja, null);
            int valor = (int)field.GetValue(loja);
            valores.Add(valor);
        }

        CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4 }, valores);
    }
}
