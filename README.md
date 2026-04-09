# Employees App

Минималистичное fullstack-приложение, демонстрирующее поток данных:

**PostgreSQL → .NET API → Angular UI**

Список сотрудников загружается из базы данных и отображается в таблице на фронтенде.

---

## Запуск

```bash
git clone https://github.com/litasfvck/fullstack-employees.git
cd <repo>
docker-compose up --build
```

После запуска:

* Frontend: http://localhost:4200
* Backend (Swagger): http://localhost:8080/swagger
* PostgreSQL: localhost:5432

---

## Проверка обновления данных

Можно добавить запись напрямую в базу и обновить таблицу в интерфейсе.

```sql
INSERT INTO "Employees" ("Id","FullName","Position","Department","Salary","HiredAt")
VALUES (gen_random_uuid(), 'Test User', 'QA', 'Testing', 12345, NOW());
```

После этого нажмите **«Обновить»** на странице.

---

## Стек

* PostgreSQL
* ASP.NET Web API
* Entity Framework
* Angular
* Docker

---

## Описание

Приложение реализует базовый сценарий:

* получение данных из БД
* обработка на backend
* отображение в UI
* ручное обновление списка

Код структурирован с упором на простоту и расширяемость.
