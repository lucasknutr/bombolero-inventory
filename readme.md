## Bombolero (Cake Store) Inventory

#### Summary
-> This is just a small project I made some years ago to control the inventory of my own business (a cake store). I'm making a more general public focused and clean version of it, paying attention to EFL and clean/vertical slice architecture principles.

##### How to test it
1. Local Development (Docker Compose)
--> You can test it easily with my postgres configuration using my docker-compose.yml
`` docker compose up -d ``
    --> Side note: Do not panic about that "fail:" log at the very top. Entity Framework always tries to read the __EFMigrationsHistory table first. Because this was your very first migration, the table didn't exist yet, so it threw a harmless exception, created the history table, and then applied your schema
