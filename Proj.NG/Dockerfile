FROM node:18.17.1 AS build-env

WORKDIR /app

COPY . .
RUN npm install
RUN npm run build

FROM nginx:alpine
COPY --from=build-env /app/dist /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf