dev:
	docker compose up -d
	dotnet watch run --project AB12

migrate:
	dotnet ef database update --project AB12