
using Workshop1.Entities;

Category category1 = new Category(1, "Programlama");

Instruction ınstruction1 = new Instruction(1, "Yazılım Geliştirici Yetiştirme Kampı (JAVA & REACT).", "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", "Engin Demiroğ", "Ücretsiz");

Console.WriteLine(category1.Id + " " + category1.Name + " ");
Console.WriteLine(ınstruction1.Id + " " + ınstruction1.Name + " " + ınstruction1.Description + " " + ınstruction1.Price);

Instruction ınstruction2 = new Instruction(2, "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA).", "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", "Engin Demiroğ", "Ücretsiz");

Console.WriteLine(category1.Id + " " + category1.Name + " ");
Console.WriteLine(ınstruction2.Id + " " + ınstruction2.Name + " " + ınstruction1.Description + " " + ınstruction2.Price);

Instruction ınstruction3 = new Instruction(3, "Yazılım Geliştirici Yetiştirme Kampı (JavaScript).", "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", "Engin Demiroğ", "Ücretsiz");

Console.WriteLine(category1.Id + " " + category1.Name + " ");
Console.WriteLine(ınstruction3.Id + " " + ınstruction3.Name + " " + ınstruction3.Description + " " + ınstruction3.Price);

Instruction ınstruction4 = new Instruction(4, "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR).", "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", "Engin Demiroğ", "Ücretsiz");

Console.WriteLine(category1.Id + " " + category1.Name + " ");
Console.WriteLine(ınstruction4.Id + " " + ınstruction4.Name + " " + ınstruction4.Description + " " + ınstruction4.Price);

Instruction ınstruction5 = new Instruction(5, "2024 Yazılım Geliştirici Yetiştirme Kampı (C#).", "Ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", "Engin Demiroğ", "Ücretsiz");

Console.WriteLine(category1.Id + " " + category1.Name + " ");
Console.WriteLine(ınstruction5.Id + " " + ınstruction5.Name + " " + ınstruction5.Description + " " + ınstruction5.Price);

Instruction ınstruction6 = new Instruction(6, "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET).", "Ücretsiz ve profesyonel bir programla, ileri seviye yazılım geliştirme öğreniyoruz.", "Engin Demiroğ", "Ücretsiz");

Console.WriteLine(category1.Id + " " + category1.Name + " ");
Console.WriteLine(ınstruction6.Id + " " + ınstruction6.Name + " " + ınstruction6.Description + " " + ınstruction6.Price);

Instruction ınstruction7 = new Instruction(7, "Programlamaya Giriş için Temel Kurs.", "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.", "Engin Demiroğ", "Ücretsiz");

Console.WriteLine(category1.Id + " " + category1.Name + " ");
Console.WriteLine(ınstruction7.Id + " " + ınstruction7.Name + " " + ınstruction7.Description + " " + ınstruction7.Price);

Instruction ınstruction8 = new Instruction(8, "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium).", "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", "Halit Enes Kalaycı", "Ücretsiz");

Console.WriteLine(category1.Id + " " + category1.Name + " ");
Console.WriteLine(ınstruction8.Id + " " + ınstruction8.Name + " " + ınstruction8.Description + " " + ınstruction8.Price);
