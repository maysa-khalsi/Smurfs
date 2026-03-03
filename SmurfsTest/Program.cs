using System;
using System.Linq;
using SmurfsGame.Data;
using Smurfs.SmurfsBL.entities;

// ── 1. Création de la DB ─────────────────────────────────────
using var context = new SmurfsDbContext();
context.Database.EnsureCreated();
Console.WriteLine("✔ Base de données prête.\n");

// ── 2. Créer une Forêt ───────────────────────────────────────
var forest = new Forest
{
    MinX = 0,
    MaxX = 100,
    MinY = 0,
    MaxY = 100
};
context.Forests.Add(forest);
context.SaveChanges();
Console.WriteLine($"✔ Forest ajoutée → Idf: {forest.Idf}");  // ← Idf

// ── 3. Créer un Schtroumpf ───────────────────────────────────
var smurf = new Schtroumpf
{
    Name = "Schtroumpf Costaud",
    Health = 100,
    PositionX = 5,
    PositionY = 3,
    Forest = forest
};
context.Schtroumpfs.Add(smurf);
context.SaveChanges();
Console.WriteLine($"✔ Schtroumpf ajouté → Idc:{smurf.Idc}  HP:{smurf.Health}");  // ← Idc

// ── 4. Créer une Spider ──────────────────────────────────────
var spider = new Spider
{
    Name = "Araignée Géante",
    Health = 60,
    PositionX = 8,
    PositionY = 2,
    Forest = forest
};
context.Spiders.Add(spider);
context.SaveChanges();
Console.WriteLine($"✔ Spider ajoutée → Idc:{spider.Idc}  HP:{spider.Health}");

// ── 5. Créer une RedPotion ───────────────────────────────────
var potion = new RedPotion
{
    PositionX = 10,
    PositionY = 10,
    Forest = forest
};
context.RedPotions.Add(potion);
context.SaveChanges();
Console.WriteLine($"✔ RedPotion ajoutée → Idi:{potion.Idi}\n");  // ← Idi

// ── 6. Lire et vérifier ──────────────────────────────────────
var creatures = context.Creatures
    .Where(c => c.Forest.Idf == forest.Idf)   // ← Idf
    .ToList();

Console.WriteLine($"── Créatures dans Forest #{forest.Idf} ──");
foreach (var c in creatures)
    Console.WriteLine($"   [{c.GetType().Name,-12}] {c.Name}  HP:{c.Health}  Pos:({c.PositionX},{c.PositionY})");

var items = context.Items
    .Where(i => i.Forest.Idf == forest.Idf)   // ← Idf
    .ToList();

Console.WriteLine($"\n── Items dans Forest #{forest.Idf} ──");
foreach (var i in items)
    Console.WriteLine($"   [{i.GetType().Name,-12}] Idi:{i.Idi}  Pos:({i.PositionX},{i.PositionY})");  // ← Idi

// ── 7. Résultat final ────────────────────────────────────────
bool ok = creatures.Count == 2 && items.Count == 1;
Console.WriteLine(ok
    ? "\n✅ DB OK — Stockage et lecture fonctionnent correctement !"
    : "\n❌ Résultat inattendu — vérifiez vos entités.");

Console.ReadKey();