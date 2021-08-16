using Departament.Data.Entitys.Departament;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Departament.Data.Migrations
{
    public partial class FillData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var person = @"Семенов М. А.
Панов П. М.
Кудрявцева П. А.
Литвинов М. М.
Степанова Д. З.
Чернов В. А.
Белоусов А. Е.
Лебедев А. Ю.
Громова Я. Д.
Смирнова А. Р.
Громова А. Н.
Шевелев В. С.
Кузнецова П. С.
Игнатьева Е. Ф.";
            var position = @"Биоинженер
Верстальщик
Горнострелок
Дизайнер рекламы
Диджей
Пожарный
Авиатехник
Штурман
Профпатолог
Тракторист
Специалист по стрижке овец
Агроном-почвовед
Таксист
Актёр";
            var birthday = @"20.12.2005
02.10.2012
23.06.2003
19.08.2011
04.08.2008
21.02.2001
23.07.2004
13.07.2006
13.03.2014
04.06.1999
03.12.2002
10.09.2007
11.08.2004
08.10.2010";

            var listPerson = person.Split("\r\n");
            var listPosition = position.Split("\r\n");
            var listBirthday = birthday.Split("\r\n");
            var message = "Perpetual sincerity out suspected necessary one but provision satisfied." +
                " Respect nothing use set waiting pursuit nay you looking." +
                " If on prevailed concluded ye abilities. Address say you new but minuter greater." +
                " Do denied agreed in innate. Can and middletons thoroughly themselves him. " +
                "Tolerably sportsmen belonging in september no am immediate newspaper. " +
                "Theirs expect dinner it pretty indeed having no of. Principle september she conveying did eat may extensive. ";
            var random = new Random();

            for (int i = 0; i < listBirthday.Length; i++)
            {
                var decret = random.NextDouble() > 0.5;
                migrationBuilder.InsertData(table: "Staffs",
                    columns: new string[] { "Id", "FullName", "Position", "Birthday", "Message", "Decret" },
                    columnTypes: new string[] { "int", "nvarchar(max)", "nvarchar(max)", "datetime2", "nvarchar(max)", "bit" },
                    values: new object[] { i + 1, listPerson[i], listPosition[i], DateTime.Parse(listBirthday[i]),
                        message.Substring(random.Next(message.Length - 10), 10), decret });
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
