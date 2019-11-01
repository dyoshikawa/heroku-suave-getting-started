FROM alpine:3.10
MAINTAINER dyoshikawa

RUN apk update && \
    apk add gcc libintl icu

ADD ./bin/Release/netcoreapp3.0/linux-musl-x64/publish /app

CMD /app/heroku-suave-getting-started
