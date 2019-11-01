# Required

- .NET Core 3.0
- Heroku CLI 7.33.3

# Getting Started

## Build

```bash
dotnet publish -c Release -r linux-musl-x64 /p:PublishSingleFile=true /p:PublishTrimmed=true
```

## Login Heroku

```bash
heroku login
heroku container:login
```

## Create Heroku App

```bash
heroku create
```

## Deploy App to Heroku

```bash
heroku container:push web
heroku container:release web
```

## Browse App

```bash
heroku open
```