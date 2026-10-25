# DogBreedsApp - ASP.NET Core Уеб Приложение

**DogBreedsApp** е динамично уеб приложение, изградено с **ASP.NET Core MVC (.NET 9.0)**, чиято цел е да улесни бъдещите собственици на кучета в избора на техния нов най-добър приятел.

---

## Основна цел на проекта
Изборът на куче е важно решение. Приложението предоставя каталог с детайлна информация за различни породи — произход, продължителност на живот, ниво на енергия и специфични изисквания за грижа. Тъй като породите по света са стотици, платформата позволява на потребителите динамично да добавят нови породи и да ги управляват.

---

## Функционалности

- **🏠 Начална страница (Landing Page):** Модерен Bootstrap интерфейс с бързи бутони към каталога и добавянето на нови породи.
- **🐾 Каталог с породи (Index):** Преглед на всички налични породи във вид на стилни карти с изображения и ключови характеристики.
- **🔍 Търсене и филтриране:** 
  - Търсене по име или кратко описание.
  - Филтриране по група на породата (*Sporting*, *Herding*, *Companion/Toy* и др.).
- **📋 Детайлен преглед (Details):** Пълна информация за породата, включително групата и специфичните нужди от грижа (разходка, обучение, хранене, поддръжка).
- **➕ Добавяне на порода (Create):** Форма с валидация на данните (Name, Description, Energy Level, Image URL и падащи менюта за релациите).
- **✏️ Редакция (Edit):** Възможност за актуализация на съществуваща порода.
- **🗑️ Изтриване (Delete):** Страница за потвърждение преди премахване на порода от базата данни.
- **ℹ️ Страница "За нас":** Информация за мисията на сайта и разработчика.

---

## Използвани технологии

- **Framework:** .NET 9.0 / ASP.NET Core MVC
- **ORM:** Entity Framework Core 9.0
- **Database:** SQL Server (LocalDB)
- **Frontend Framework:** Bootstrap 5 & Razor Views
- **Architecture:** 
  - **Service Layer Pattern** (`IDogBreedService` / `DogBreedService`)
  - **ViewModels** с пълна Data Annotation валидация (`DogBreedFormViewModel`, `DogBreedDetailsViewModel`)
- **Version Control:** Git & GitHub

---

## Структура на базата данни (Entities)

1. **`DogBreed`**: `Id`, `Name`, `ShortDescription`, `Origin`, `AverageLifespanYears`, `EnergyLevel`, `ImageUrl`, `BreedGroupId`, `CareRequirementId`
2. **`BreedGroup`**: `Id`, `Name`, `Description`
3. **`CareRequirement`**: `Id`, `GroomingNeeds`, `DailyExercise`, `TrainingEase`, `SpecialDietNotes`

---

## Инструкции за стартиране

1. **Клонирайте хранилището:**
   ```bash
   git clone [https://github.com/vestonosec/DogBreedsApp.git](https://github.com/vestonosec/DogBreedsApp.git)