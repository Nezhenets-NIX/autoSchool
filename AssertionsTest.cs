using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace QA
{
    public class Tests
    {
      
        //создать две одинаковые строки и проверить что они равны;
        [Test]
        public void TwoString()
        {
            string firstStr =  "Інтернет-магазин ROZETKA™: офіційний сайт найпопулярнішого онлайн-гіпермаркету в Україні";
            string secondStr = "Інтернет-магазин ROZETKA™: офіційний сайт найпопулярнішого онлайн-гіпермаркету в Україні";
            Assert.AreEqual(firstStr, secondStr, "Увы, строки неодинаковы");
        }
        
        
        //создать два одинаковых списка строк и проверить что они равны;
          [Test]
        public void TwoStringList()
        {
            List <string> firstStr = new List<string>
                { 
                "Інтернет-магазин ROZETKA™:", 
                "офіційний сайт" ,
                "найпопулярнішого онлайн-гіпермаркету в Україні" 
                 };

            List<string> secondStr = new List<string>
                {
                "Інтернет-магазин ROZETKA™:",
                "офіційний сайт" ,
                "найпопулярнішого онлайн-гіпермаркету в Україні"
                 };
                 
            CollectionAssert.AreEqual(firstStr, secondStr, "Увы, списки строк неодинаковы");
        }
        
        
        //создать список строк и одну отдельную строку значение которой есть и в списке. Проверить что созданная строка присутствует в списке;
        [Test]
        public void StringInList()
        {
            List <string> firstStr = new List<string>
                { 
                "Інтернет-магазин ROZETKA™:", 
                "офіційний сайт" ,
                "найпопулярнішого онлайн-гіпермаркету в Україні" 
                 };
            string separate = "офіційний сайт";

            Assert.Contains(separate, firstStr, $"Увы, в списке {firstStr} строки {separate} нет");
        }
        
        //создать переменную a=10 и переменную b=5, проверить что выражение a>b возвращает true;
        [Test]
        public void CheckTrue()
        {
            int a = 10;
            int b = 5;

            bool checkResult = a > b;
            Assert.IsTrue(checkResult, "Увы, переменная a не больше переменной b");
        }
     }
